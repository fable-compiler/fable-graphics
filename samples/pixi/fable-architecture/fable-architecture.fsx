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
      | DrawStarted
      
    type Subscriber<'TMessage, 'TModel> = AppEvents<'TMessage, 'TModel> -> unit

    type RenderState = 
      | InProgress
      | NoRequest
          
    type App<'TModel, 'TMessage> =
      {
        Model: 'TModel
        View: 'TModel -> Dictionary<string, Container> -> ('TMessage -> unit) -> Container -> unit
        Objects: Dictionary<string, Container>
        Stage: Container
        Update: 'TModel -> 'TMessage -> ('TModel * Action<'TMessage> list)
        InitMessage : (('TMessage -> unit) -> unit) option
        Actions: Action<'TMessage> list
        Producers: Producer<'TMessage> list
        Subscribers: Map<string, Subscriber<'TMessage, 'TModel>>
        NodeSelector: string option
        RenderState: RenderState
        Renderer: SystemRenderer option
        Canvas: HTMLCanvasElement option
      }

    type ScheduleMessage = 
      | PingIn of float*(unit -> unit)

    type AppMessage<'TMessage> =
      | AddSubscriber of string*Subscriber<'TMessage, 'TMessage>
      | RemoveSubscriber of string
      | Message of 'TMessage
      | Draw

    let createApp model view update =
      {
        Model = model
        View = view
        Objects = Dictionary<string, Container>()
        Stage = new Container()
        Update = update
        NodeSelector = None
        InitMessage = None
        Producers = []
        Subscribers = Map.empty
        RenderState = NoRequest
        Actions = []
        Renderer = None
        Canvas = None
      }

    let withStartNodeSelector selector app =
      { app with NodeSelector = Some selector }

    let withStartRenderer renderer app =
      { app with Renderer = Some renderer }

    let withProducer p app =
      { app with Producers = p::app.Producers }

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
            | PingIn (milliseconds, cb) ->
              window.setTimeout(cb, milliseconds) |> ignore
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

    let handleMessage msg notify schedule state =
      ActionReceived msg |> (notify state.Subscribers)
      let (model', actions') = state.Update state.Model msg
      // Determine the renderState
      let renderState = 
        match state.RenderState with
        | NoRequest ->
          schedule()
          InProgress
        | InProgress -> InProgress

      // Return the new state
      { state with
          RenderState = renderState
          Model = model'
          Actions = state.Actions @ actions'
      }

    let handleDraw post notify state : App<'TModel, 'TMessage> =
      match state.RenderState with
      | InProgress ->
        // Notify the subscribers about the start of drawing process
        DrawStarted |> notify state.Subscribers
        let model = state.Model
        // Update the objects used by the view
        state.View model state.Objects post state.Stage
        // Render the view
        state.Renderer.Value.render(state.Stage)
        // Trigger the actions
        state.Actions |> List.iter (fun i -> i post)
        // Notify the subscribers
        (ModelChanged (model, state.Model)) |> notify state.Subscribers
        { state with RenderState = NoRequest; Actions = [] }
      | NoRequest -> raise (exn "Shouldn't happen")

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
        let schedule() = scheduler.Post(PingIn(1000./60., (fun() -> inbox.Post(Draw))))

        let rec loop state = 
          async {
            match state.Canvas with
            /// If this is the first loop
            | None ->
              let state' = createFirstLoopState startElem post state
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
              /// If the message if of type Draw handle it (use of View here)
              | Draw ->
                let state' = handleDraw post notifySubscribers state
                return! loop state'
              | _ -> return! loop state
          }
        loop app // Kick start the Mailbox
      )

module App =

  open System
  open Fable.Import.JS

  /// Model of the app
  type Model =
    { Count: float
      Level: int
      IsInit: bool
      IsGameOver: bool
    }

    /// Generate an initial model
    static member Initial =
      { Count = 0.
        Level = 0
        IsInit = false
        IsGameOver = false
      }

  /// List of the possible actions
  type Actions 
    = LevelUp
    | ResetGame
    | InitDone
    | GameOver
    | Tick of float

  /// Function supporting the updates logic of the app
  let update model action =
    console.log (sprintf "Model: %A" model)

    // Standard update of the model
    let model' = 
      match action with
      // On level up we add one level
      | LevelUp ->
        { model with Level = model.Level + 1 }
      // On reset the game we reset the model
      | ResetGame -> 
        Model.Initial
      // When the first init of the view is done
      | InitDone ->
        { model with IsInit = true }
      // On game over
      | GameOver ->
        { model with IsGameOver = true }
      // On tick we increment the count value
      | Tick value ->
        if not model.IsGameOver then
          let newCount = model.Count + value
          { model with Count = newCount }
        else 
          model

    /// Here we are handling the actions which tirgger others actions
    let delayedCall push =
      match action with
      // When we receive a tick
      | Tick _ -> 
        // Apply a pattern over the new value of count (note the usage of model' )
        match model'.Count with
        // If the value is over 20., we lose so push the action GameOver
        | x when x > 20. ->
          push(GameOver)
        // Else we check if we leveled up
        | value -> 
          let nextLevel = (Math.floor(value) |> int) % 2 = 0
          if nextLevel then
            push(LevelUp)
      | _ -> ()

    model', delayedCall |> toActionList
    
  /// Function used to generate the basic view (this is used for the first draw of the app
  let initView (model: Model) (objects: Dictionary<string, Container>) post (stage: Container) =
    let levelText = new Text(sprintf "Current level: %i" model.Level)
    levelText.x <- 50.
    levelText.y <- 50.
    objects.Add("levelText", levelText)
    stage.addChild(levelText) |> ignore

    let countText = new Text(sprintf "CountValue: %f" model.Count)
    countText.x <- 50.
    countText.y <- 100.
    objects.Add("countText", countText)
    stage.addChild(countText) |> ignore

    let gameOverText1 = new Text(sprintf "GAME OVER !")
    gameOverText1.x <- 200.
    gameOverText1.y <- 200.
    gameOverText1.visible <- false
    objects.Add("gameoverText1", gameOverText1)
    stage.addChild(gameOverText1) |> ignore

    let gameOverText2 = new Text("Click me to play again")
    gameOverText2.x <- 150.
    gameOverText2.y <- 250.
    gameOverText2.visible <- false
    objects.Add("gameoverText2", gameOverText2)
    stage.addChild(gameOverText2) |> ignore

    gameOverText2.interactive <- true
    /// When the player click on the text, push the action ResetGame in the App
    gameOverText2.on_click(Func<_,_> (fun _ ->
      post(ResetGame)
    )) |> ignore

    // Notify the app that we finished to init the view
    post(InitDone)

  /// Function used to handle the view updates
  let view (model: Model) (objects: Dictionary<string, Container>) post (stage: Container) =
    /// If the view has never been init
    if not model.IsInit then
      // Clear all the stage children (useful for support of ResetGame)
      stage.removeChildren(0., float stage.children.Count) |> ignore
      initView model objects post stage
    else
      /// Else update the object in the view
      (objects.["levelText"] :?> Text).text <- sprintf "Current level: %i" model.Level
      (objects.["countText"] :?> Text).text <- sprintf "CountValue: %f" model.Count

      objects.["gameoverText1"].visible <- model.IsGameOver
      objects.["gameoverText2"].visible <- model.IsGameOver

  // Push a tick in the GameApp every 1000/60 seconds
  let tickProducer push =
    window.setInterval((fun _ ->
        push(Tick 0.1)
        null
      )
    , 1000./60.) |> ignore
    ()

  let options = [
    BackgroundColor (float 0x1099bb)
    Resolution 1.
  ]

  let renderer =
    Globals.autoDetectRenderer( 620., 400., options )
    |> unbox<SystemRenderer>

  renderer.view.style.display <- "block"
  renderer.view.style.margin <- "0 auto"

  // Here we create the application for Fable Architecture
  createApp Model.Initial view update
  //|> withStartNodeSelector "#game" // Node on which to happen the Pixi view. If not given then we happend to body
  |> withStartRenderer renderer // For the moment the renderer need to be create by the user
  |> withProducer tickProducer // Register our producer
  |> start // Start the app