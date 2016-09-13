(**
 - title: Basic sample
 - tagline: Basic sample implemented with fable-pixi
 - app-style: width:800px; margin:20px auto 50px auto;
 - require-paths: `'PIXI':'https://cdnjs.cloudflare.com/ajax/libs/pixi.js/3.0.11/pixi.min'`
 - intro: This is a port from [basic sample](http://pixijs.github.io/examples/#/basics/basic.js)
*)

#r "../../node_modules/fable-core/Fable.Core.dll"
#load "../../node_modules/fable-import-pixi/Fable.Import.Pixi.fs"
#load "./libs/Aether.fs"

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import.PIXI
open Fable.Import.Browser

open Aether
open Aether.Operators

let options = [
  BackgroundColor (float 0x1099bb)
  Resolution 1.
]

let width = 800.
let height = 600.

let renderer =
  Globals.autoDetectRenderer( width, height, options )
  |> unbox<SystemRenderer>

let gameDiv = document.getElementById("game")
gameDiv.appendChild( renderer.view )

// create the root of the scene graph
let stage = Container()
let rectangle1 = Graphics()
let rectangle2 = Graphics()
let rectangle3 = Graphics()

type Point = 
  { X: float
    Y: float
  }

  static member X_ = 
    (fun point -> point.X), (fun x point -> point?X <- x; point)

  static member Y_ = 
    (fun point -> point.Y), (fun y point -> point?Y <- y; point)

  static member XY_ =
    (fun point -> (point.X, point.Y)), (fun (x, y) point -> 
                                                            point?X <- x
                                                            point?Y <- y
                                                            point)

  static member Create(x,y) =
    { X = x
      Y = y
    }

type Rectangle = 
  { Origin: Point
    Width: float
    Height: float
    Graphic: Graphics
  }

  static member Origin_ =
    (fun rect-> rect.Origin), (fun origin rect -> rect?Origin <- origin; rect)

  static member Width_ =
    (fun rect-> rect.Width), (fun width rect -> rect?Width <- width; rect)

  static member Height_ =
    (fun rect-> rect.Height), (fun height rect -> rect?Height <- height; rect)

  static member Create(x, y, w, h) =
    { Origin = Point.Create(x, y)
      Width = w
      Height = h
      Graphic = Graphics()
    }

  member x.Render() =
    x.Graphic
      .beginFill(float 0x451245)
      .drawRect(x.Origin.X, x.Origin.Y, x.Width, x.Height)
      .endFill()
    |> ignore

type Mouse =
  { ButtonLeft: bool
    ButtonRight: bool
    Position: Point
  }

  static member ButtonLeft_ =
    (fun x -> x.ButtonLeft), (fun btn mouse-> { mouse with ButtonLeft = btn } )

  static member ButtonRight_ =
    (fun x -> x.ButtonRight), (fun btn mouse -> { mouse with ButtonRight = btn } )

  static member Position_ =
    (fun x -> x.Position), (fun pos mouse -> { mouse with Position = pos })

  static member Create() =
    { ButtonLeft = false
      ButtonRight = false
      Position = Point.Create(0., 0.)
    }

type GameState =
  { FollowRect: Rectangle
    Stage: Container
    Mouse: Mouse
  }

  static member FollowRect_ =
    (fun game -> game.FollowRect), (fun rect (game: GameState) -> game?FollowRect <- rect; game)

  static member Mouse_ =
    (fun game -> game.Mouse), (fun mouse game -> game?Mouse <- mouse; game)     

  static member Create() = 
    { FollowRect = Rectangle.Create(20., 20., 50., 50.)
      Stage = Container()
      Mouse = Mouse.Create()
    }

  member x.Render() =
    x.FollowRect.Render()

  member x.UpdateMouseRightBtn (newState: bool) =
    Optic.set (GameState.Mouse_ >-> Mouse.ButtonRight_) newState x |> ignore

  member x.UpdateMouseLeftBtn (newState: bool) =
    Optic.set (GameState.Mouse_ >-> Mouse.ButtonLeft_) newState x |> ignore

  member x.UpdateMousePosition pos =
    Optic.set (GameState.Mouse_ >-> Mouse.Position_ >-> Point.XY_) pos x |> ignore

  member x.InitStage() = 
    x.Stage.addChild(x.FollowRect.Graphic) |> ignore
    x.Stage.hitArea <- Rectangle(0., 0., width, height)
    x.Stage.interactive <- true 
    
    // Handle mouse right button
    x.Stage.on_rightdown(Func<_,_>(fun _ ->
      x.UpdateMouseRightBtn(true)
    )) |> ignore

    x.Stage.on_rightup(Func<_,_>(fun _ ->
      x.UpdateMouseRightBtn(false)
    )) |> ignore


    // Handle mouse button
    x.Stage.on_mousedown(Func<_,_>(fun ev ->
      let event = unbox<MouseEvent> ev.data?originalEvent
      if event.button = 0. then
        x.UpdateMouseLeftBtn(true)
    )) |> ignore

    x.Stage.on_mouseup(Func<_,_>(fun ev ->
      let event = unbox<MouseEvent> ev.data?originalEvent
      if event.button = 0. then
        x.UpdateMouseLeftBtn(false)
    )) |> ignore


    x

let mutable lastUpdate = 0.

let delta dt =
  let r = dt - lastUpdate
  lastUpdate <- dt
  r / 10.

let gameState = 
  GameState.Create().InitStage()

/// Disable context menu when right clicking the canvas
renderer.view.addEventListener_contextmenu(Func<_,_>(fun ev ->
  ev.stopPropagation()
  ev.preventDefault()
  null
))

renderer.view.addEventListener_mousemove(Func<_,_>(fun ev -> 
//  x.Stage.on(
//      "mousemove", 
//      unbox (fun ev -> 
//        let event = unbox<MouseEvent> ev?data?originalEvent
//        x.UpdateMousePosition(event.offsetX, event.offsetY)
//      )
//    ) |> ignore
  null
))

let rec animate (dt:float) =
  window.requestAnimationFrame(FrameRequestCallback animate) |> ignore
  let delta = delta dt

  //Optic.set (Game.Rect1_ >-> Rectangle.Width_) (game.Rect1.Width - 1. * delta) game |> ignore

  gameState.Render()
  // render the container
  renderer.render(gameState.Stage)

  console.log gameState.Mouse.Position

// start animating
animate 0.
