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

[<CustomEquality; NoComparison>]
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

  member x.ToXY() =
    (x.X, x.Y)

  /// Custom equality method
  override x.Equals(yobj) =
    match yobj with
    | :? Point as y -> x.X = y.X && x.Y = y.Y
    | _ -> false

  /// Implemented because needed when overriding Equals
  override x.GetHashCode() = failwith "Not supported"

/// Structure used to store a Vector2
type Vector2D =
  { X: float
    Y: float
  }

  /// Create a Vector2D
  static member Create(x, y) =
    { X = x
      Y = y
    }

  /// Create a Vector2D from two points. (direction is p1 to p2)
  static member CreateFrom2Point((p1: Point), (p2: Point)) =
    { X = p2.X - p1.X
      Y = p2.Y - p1.Y
    }

  /// Calculate the Length of a Vector2D
  member x.Length() =
    let square x : float = x * x 
    Math.Sqrt( (square x.X) + (square x.Y) )

  /// Normalize a Vector. Force X and Y to be between -1 and 1.
  member x.Normalize() =
    { X = x.X / x.Length()
      Y = x.Y / x.Length()
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

  /// Render the rectangle
  member x.Render() =
    x.Graphic
      .clear()
      .beginFill(float 0x451245)
      .drawRect(x.Origin.X, x.Origin.Y, x.Width, x.Height)
      .endFill()
    |> ignore

  /// Update the Origin coordinate to move at destination point. Based on time update
  member x.Move(dest: Point, dt) =
    let dir = Vector2D.CreateFrom2Point(x.Origin, dest).Normalize()
    let x' = Math.Ceiling(x.Origin.X + dir.X * 2. * dt)
    let y' = Math.Ceiling(x.Origin.Y + dir.Y * 2. * dt)
    Optic.set (Rectangle.Origin_ >-> Point.XY_) (x', y') x
    |> ignore

type GameState =
  { FollowRect: Rectangle
    Stage: Container
    mutable Destination: Point option
  }

  static member FollowRect_ =
    (fun game -> game.FollowRect), (fun rect (game: GameState) -> game?FollowRect <- rect; game)

  static member Destination_ =
    (fun game -> game.Destination.Value), (fun destination game -> game?Destination <- destination; game)

  static member Create() = 
    { FollowRect = Rectangle.Create(20., 20., 50., 50.)
      Stage = Container()
      Destination = None
    }

  member x.Render() =
    x.FollowRect.Render()

  /// Method used to initialize the Stage. Add listener, enable interactivity
  member x.InitStage() = 
    /// Instruction text
    let txt = Fable.Import.PIXI.Text("Click and watch the rectangle going to clicked place")
    txt.x <- 70.
    txt.y <- 500.
    
    /// Add graphics
    x.Stage.addChild(x.FollowRect.Graphic) |> ignore
    x.Stage.addChild(txt) |> ignore

    /// Enable interactivity
    x.Stage.hitArea <- Rectangle(0., 0., width, height)
    x.Stage.interactive <- true 
    
    // Handle mouse button
    x.Stage.on_mousedown(Func<_,_>(fun ev ->
      let event = unbox<MouseEvent> ev.data?originalEvent
      if event.button = 0. then
        x.Destination <- Some (Point.Create(event.offsetX, event.offsetY))
    )) |> ignore

    x

/// Memorize lastUpdate time
let mutable lastUpdate = 0.

/// Calculate delta interval for time based updated
let delta dt =
  let r = dt - lastUpdate
  lastUpdate <- dt
  r / 10.

let gameState = 
  GameState.Create().InitStage()
  
let rec animate (dt:float) =
  window.requestAnimationFrame(FrameRequestCallback animate) |> ignore
  let delta = delta dt

  if gameState.Destination.IsSome then
    gameState.FollowRect.Move(gameState.Destination.Value, delta)
    // If one of the coordinate is NaN then the Rectangle is at Destination
    if Fable.Import.JS.Number.isNaN(gameState.FollowRect.Origin.X) || Fable.Import.JS.Number.isNaN(gameState.FollowRect.Origin.Y) then
      // For the Origin to be at Destination

      (*
        The next line is using Aether Lenses to support updates of Origin point

        The equivalent code, if we were using purely functionnal and immutable state here would have been:
        
          { gameState with
              FollowRect = {
                gameState.FollowRect with
                  Origin = {
                    gameState.FollowRect.Origin with
                      X = newX
                      Y = newY
                  }
              }
          }
          
          Here thanks to the combinaison of Fable and Ather we can hide the implementation. 
          Here we looks like using purely functionnal and immutable state but we are in fact using only dynamicProgramming.
      *)
      Optic.set (GameState.FollowRect_ >-> Rectangle.Origin_ >-> Point.XY_) (gameState.Destination.Value.ToXY()) gameState |> ignore
      // Remove Destination information
      gameState.Destination <- None
        
  
  gameState.Render()
  // render the container
  renderer.render(gameState.Stage)

// start animating
animate 0.
