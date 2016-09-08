(**
 - title: Fable architecture sample
 - tagline: Just a try to implement the Fable architecture over Pixi
 - app-style: width:800px; margin:20px auto 50px auto;
 - require-paths: `'PIXI':'https://cdnjs.cloudflare.com/ajax/libs/pixi.js/3.0.11/pixi.min'`
 - intro: Just a try to implement the Fable architecture over Pixi. This is an experimentation for the moment
*)

#r "../../node_modules/fable-core/Fable.Core.dll"
#load "../../node_modules/fable-import-pixi/Fable.Import.Pixi.fs"

open Fable.Core
open Fable.Import.Browser
open Fable.Import.PIXI
open System.Collections.Generic
open System

[<AutoOpen>]
module Fable =
  [<AutoOpen>]
  module Architecture =

    let toActionList x = [x]

    type Action<'TMessage> = ('TMessage -> unit) -> unit
    type Producer<'TMessage> = ('TMessage -> unit) -> unit

    type AppEvents<'TMessage, 'TModel> =
      | ModelChanged of 'TModel*'TModel
      | ActionReceived of 'TMessage
      | Ticked
      | DrawStarted

    type Subscriber<'TMessage, 'TModel> = AppEvents<'TMessage, 'TModel> -> unit

    type RenderState = 
        | InProgress
        | NoRequest

    type App<'TModel, 'TMessage, 'TDisplayAction> =
      {
        Model: 'TModel
        Display: 'TModel -> 'TDisplayAction list -> ResizeArray<obj> -> ('TMessage -> unit) -> Container -> unit
        Objects: ResizeArray<obj>
        Stage: Container
        Update: 'TModel -> 'TMessage option -> ('TModel * Action<'TMessage> list * 'TDisplayAction list)
        InitMessage : (('TMessage -> unit) -> unit) option
        Actions: Action<'TMessage> list
        DisplayActions: 'TDisplayAction list
        Producers: Producer<'TMessage> list
        Subscribers: Map<string, Subscriber<'TMessage, 'TModel>>
        NodeSelector: string option
        Renderer: SystemRenderer option
        Canvas: HTMLCanvasElement option
        RenderState: RenderState
      }

    type ScheduleMessage =
      | PingIn of (float -> unit)

    type AppMessage<'TMessage> =
      | AddSubscriber of string*Subscriber<'TMessage, 'TMessage>
      | RemoveSubscriber of string
      | Message of 'TMessage
      | Tick
      | Draw

    let createApp model view update =
      {
        Model = model
        Display = view
        Objects = ResizeArray<obj>()
        Stage = new Container()
        Update = update
        NodeSelector = None
        InitMessage = None
        Producers = []
        Subscribers = Map.empty
        Actions = []
        DisplayActions = []
        Renderer = None
        Canvas = None
        RenderState = NoRequest
      }

    let withStartNodeSelector selector app =
      { app with NodeSelector = Some selector }

    let withStartRenderer renderer app =
      { app with Renderer = Some renderer }

    let withProducer p app =
      { app with Producers = p::app.Producers }

    let withInitMessage msg app =
      { app with InitMessage = Some msg }

    let withSubscriber subscriberId subscriber app =
        let subsribers = app.Subscribers |> Map.add subscriberId subscriber
        { app with Subscribers = subsribers }

    /// Scheduler helper
    /// This scheduler allow us to send a PingIn message to delay the call of a callback
    let createScheduler() =
      MailboxProcessor.Start(fun inbox ->
        let rec loop() =
          async {
            let! message = inbox.Receive()
            match message with
            | PingIn cb ->
              window.requestAnimationFrame(new FrameRequestCallback(cb)) |> ignore
              return! loop()
          }
        loop()
      )

    /// Function used on the first loop
    /// This function init the page by adding the view in the DOM and the app
    let createFirstLoopState (startElem:Node) post state =
      // We check that we have a pixi renderer
      let canvas =
        match state.Renderer with
        | None ->
          console.error "You need to provide a renderer. See function withStartRenderer"
          raise (exn "You need to provide a renderer. See function withStartRenderer")
        | Some renderer -> renderer.view
      // Append the view of the renderer to the startElem
      startElem.appendChild(canvas) |> ignore
      state.Renderer.Value.render(state.Stage)
      // If we have some init message trigger them
      match state.InitMessage with
      | None -> ()
      | Some init -> init post
      { state with Canvas = Some canvas }

    let handleRenderState schedule state =
      match state.RenderState with
      | NoRequest ->
        schedule(Draw)
        InProgress
      | InProgress -> InProgress

    let handleMessage msg notify schedule state =
      ActionReceived msg |> (notify state.Subscribers)
      let (model', actions', displayAction') = state.Update state.Model (Some msg)
      let renderState' = handleRenderState schedule state
      // Return the new state
      { state with
          RenderState = renderState'
          Model = model'
          Actions = state.Actions @ actions'
          DisplayActions = state.DisplayActions @ displayAction'
      }

    let handleTick notify schedule state =
      Ticked |> (notify state.Subscribers)
      let (model', actions', displayAction') = state.Update state.Model None
      let renderState' = handleRenderState schedule state
      // Return the new state
      { state with
          RenderState = renderState'
          Model = model'
          Actions = state.Actions @ actions'
          DisplayActions = state.DisplayActions @ displayAction'
      }

    let handleDraw post notify state : App<'TModel, 'TMessage, 'TDisplayActions> =
      // Notify the subscribers about the start of drawing process
      DrawStarted |> notify state.Subscribers
      let model = state.Model
      // Update the objects used by the view
      state.Display model state.DisplayActions state.Objects post state.Stage
      // Render the view
      state.Renderer.Value.render(state.Stage)
      // Trigger the actions
      state.Actions |> List.iter (fun i -> i post)
      // Notify the subscribers
      (ModelChanged (model, state.Model)) |> notify state.Subscribers
      { state with Actions = []; DisplayActions = []; RenderState = NoRequest }

    let start app =
      // Deduce the startElement
      let startElem =
        match app.NodeSelector with
        | None -> document.body
        | Some sel -> document.body.querySelector(sel) :?> HTMLElement

      let scheduler = createScheduler()
      // Here is the core of the architecture
      MailboxProcessor.Start(fun inbox ->
        ///  Helpers to post a message in the app
        let post message =
          inbox.Post (Message message)

        /// Helper to notify the subscribers
        let notifySubscribers subs model =
          subs |> Map.iter (fun key handler -> handler model)

        /// Init the producers
        app.Producers |> List.iter (fun p -> p post)

        /// Function used to delay the Draw action (60fps based)
        let schedule(msg) = scheduler.Post(PingIn((fun _ -> inbox.Post(msg))))

        let rec loop state =
          async {
            match state.Canvas with
            /// If this is the first loop
            | None ->
              let state' = createFirstLoopState startElem post state
              // Trigger the first draw
              schedule (Draw)
              return! loop state'
            /// Else the app is already init
            | Some node ->
              /// Wait for a message
              let! message = inbox.Receive()
              match message with
              /// If the message if of type Message handle it (use of Update here)
              | Message msg ->
                let state' = handleMessage msg notifySubscribers schedule state
                return! loop state'
              | Tick ->
                let state' = handleTick notifySubscribers schedule state
                return! loop state'
              /// If the message if of type Draw handle it (use of View here)
              | Draw ->
                let state' = handleDraw post notifySubscribers state
                // Trigger the next draw
                schedule (Tick)
                return! loop state'
              | _ -> return! loop state
          }
        loop app // Kick start the Mailbox
      )

  // Helper to use in the Update function
  // This help handling Message calls over the Tick
  let handleAction (model: 'TModel) (action: 'TMessage option) (x: Func<'TMessage, ('TModel * 'TDisplayAction list)>)  =
    if action.IsSome then
      x.Invoke(action.Value)
    else
      model, []

module App =

  open Fable.Import.JS

  /// Model of the app
  type Model =
    { StageBox: Rectangle
      MousePressed: bool
    }

    /// Generate an initial model
    static member Initial =
      { StageBox = Rectangle(0.,0.,0.,0.)
        MousePressed = false
      }

  /// List of the possible actions
  type Actions
    = ResetGame
    | InitDone of float * float
    | AddBunnies of bool
    
  type DisplayActions
    = AddBunnies
    | InitView
    
  /// Function supporting the updates logic of the app
  let update model action =

    // Handle update with message
    let model', displayAction' = 
      let t = 
        Func<_,_>(fun act ->
          match act with
          // On reset the game we reset the model
          | ResetGame ->
            Model.Initial, DisplayActions.InitView |> toActionList
          // When the first init of the view is done
          | InitDone(stageWidth, stageHeight) ->
            { model with StageBox=Rectangle(0.,0., stageWidth, stageHeight) }, []
          // Add bunnies
          | Actions.AddBunnies shouldAdd ->
            { model with MousePressed = shouldAdd }, []
        )
      handleAction model action t

    // Handle tick part of the update
    // This should be executed even without message informations
    let bunniesAction = 
      if model'.MousePressed then 
        DisplayActions.AddBunnies |> toActionList 
      else []

    model', [], bunniesAction @ displayAction'

  let options = [
    BackgroundColor (float 0x1099bb)
    Resolution 1.
  ]

  let renderer =
    Globals.autoDetectRenderer( 620., 400., options )
    |> unbox<SystemRenderer>

  renderer.view.style.display <- "block"
  renderer.view.style.margin <- "0 auto"

  /// Function used to generate the basic view (this is used for the first draw of the app
  let initView (post: Actions -> unit) =
    renderer.view.onmousedown <- fun _ -> post(Actions.AddBunnies true); null
    renderer.view.onmouseup <- fun _ -> post(Actions.AddBunnies false); null
      
    // Notify the app that we finished to init the view
    post(InitDone(renderer.view.width, renderer.view.height))


  let wabbitTexture = Texture.fromImage("./public/bunny.png")

  /// Function used to handle the view updates
  let updateDisplay (model: Model) (displayActions: DisplayActions list) (objects: ResizeArray<obj>) (post: Actions -> unit) (stage: Container) =
    // Update all the bunnies rotation
    let count : int = objects.Count - 1
    for i in 0..count do
      let bunny = unbox<Sprite> objects.[i]
      bunny.rotation <- bunny.rotation + 0.1

    // Process the displayActions
    let rec processActions actions =
      match actions with
      | x::xs ->
        match x with
        // Add the bunnies
        | DisplayActions.AddBunnies ->
          for i in 0..10 do
            let bunny = Sprite(wabbitTexture)
            stage.addChild( bunny) |> ignore
            objects.Add(bunny)
            bunny.tint <- Math.random() * (float 0xFFFFFF)
            bunny.position <- Point(Math.random() * model.StageBox.width, Math.random() * model.StageBox.height)
            bunny.rotation <- Math.random() * 1.
            bunny.anchor <- Point(0.5,0.5)
        // User ask to reset the view
        | DisplayActions.InitView ->
          // Clear all the stage children (useful for support of ResetGame)
          stage.removeChildren(0., float stage.children.Count) |> ignore
          initView post
        | a -> console.error (sprintf "Unknow DisplaysAction: %A" a)
        processActions xs
      | [] -> ()

    processActions displayActions
    
  // Reset the game when user press R
  let resetGameProducer push =
    document.addEventListener_keypress(Func<_,_>(fun ev -> 
      if ev.keyCode = 114. || ev.which = 114. then
        push ResetGame     
      null
    ))
        
  // Here we create the application for Fable Architecture
  createApp Model.Initial updateDisplay update
  //|> withStartNodeSelector "#game" // Node on which to happen the Pixi view. If not given then we happend to body
  |> withStartRenderer renderer // For the moment the renderer need to be create by the user
  |> withProducer resetGameProducer
  |> withInitMessage (fun h -> h(Actions.ResetGame))
  |> start // Start the app
