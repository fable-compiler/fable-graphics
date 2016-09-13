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

let renderer =
  Globals.autoDetectRenderer( 800., 600., options )
  |> unbox<SystemRenderer>

let gameDiv = document.getElementById("game")
gameDiv.appendChild( renderer.view )

// create the root of the scene graph
let stage = Container()
let rectangle1 = Graphics()
let rectangle2 = Graphics()
let rectangle3 = Graphics()

type Rectangle = 
  { X: float
    Y: float
    Width: float
    Height: float
  }

  static member X_ =
    (fun rect-> rect.X), (fun x rect -> rect?X <- x; rect)

  static member Y_ =
    (fun rect-> rect.Y), (fun y rect -> rect?Y <- y; rect)

  static member Width_ =
    (fun rect-> rect.Width), (fun width rect -> rect?Width <- width; rect)

  static member Height_ =
    (fun rect-> rect.Height), (fun height rect -> rect?Height <- height; rect)

  static member Create(x, y, w, h) =
    { X = x
      Y = y
      Width = w
      Height = h
    }

type Game =
  { Rect1: Rectangle
    Rect2: Rectangle
    Rect3: Rectangle
  }

  static member Rect1_ =
    (fun game -> game.Rect1), (fun rect (game: Game) -> game?Rect1 <- rect; game)

  static member Rect2_ =
    (fun game -> game.Rect2), (fun rect (game: Game) -> game?Rect2 <- rect; game)

  static member Rect3_ =
    (fun game -> game.Rect3), (fun rect (game: Game) -> game?Rect3 <- rect; game)

let game =
  { Rect1 = Rectangle.Create(20., 100., 100., 20.)
    Rect2 = Rectangle.Create(20., 200., 100., 40.)
    Rect3 = Rectangle.Create(20., 300., 100., 120.)
  }  

let rec animate (dt:float) =
  window.requestAnimationFrame(FrameRequestCallback animate) |> ignore
  
  Optic.set (Game.Rect1_ >-> Rectangle.X_) (game.Rect1.X + 1.) game |> ignore
  
  // render the container
  renderer.render(stage)

// start animating
animate 0.
