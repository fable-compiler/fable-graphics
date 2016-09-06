(**
 - title: Text sample
 - tagline: Basic sample implemented with fable-pixi
 - app-style: width:800px; margin:20px auto 50px auto;
 - require-paths: `'PIXI':'https://cdnjs.cloudflare.com/ajax/libs/pixi.js/3.0.11/pixi.min'`
 - intro: This is a port from [text sample](http://pixijs.github.io/examples/#/demos/text-demo.js)
*)

#r "../../node_modules/fable-core/Fable.Core.dll"
#load "../../node_modules/fable-import-pixi/Fable.Import.Pixi.fs"

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.PIXI
open Fable.Import.Browser
open Fable.Import.JS

[<AutoOpen>]
module Fable =
  module Architecture =
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
        View: 'TModel -> unit
        Update: 'TModel -> 'TMessage -> ('TModel * Action<'TMessage> list)
        InitMessage : (('TMessage -> unit) -> unit) option
        Actions: Action<'TMessage> list
        Producers: Producer<'TMessage> list
        NodeSelector: string option
        RenderState: RenderState
        Node: Node option
      }

    type ScheduleMessage = 
      | PingIn of float*(unit -> unit)

    type AppMessage<'TMessage> =
      | Message of 'TMessage
      | Draw

    let createApp model view update =
      {
        Model = model
        View = view
        Update = update
        NodeSelector = None
        InitMessage = None
        Producers = []
        RenderState = NoRequest
        Actions = []
        Node = None
      }

    let withProducer p app =
      { app with Producers = p::app.Producers }
    
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

    let createFirstLoopState renderTree (startElem:Node) post renderer state =
      let tree = renderTree state.View post state.Model
      match state.InitMessage with
      | None -> ()
      | Some init -> init post
      state






module App =

  let renderer =
    Globals.autoDetectRenderer( 620., 400. )
    |> unbox<SystemRenderer>

  renderer.view.style.display <- "block"
  renderer.view.style.margin <- "0 auto"

  let gameDiv = document.getElementById("game")
  gameDiv.appendChild( renderer.view )

  // create the root of the scene graph
  let stage = Container()

