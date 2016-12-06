(**
 - title: Masking sample
 - tagline: Basic sample implemented with fable-pixi
 - app-style: width:800px; margin:20px auto 50px auto;
 - external-script: `"https://cdnjs.cloudflare.com/ajax/libs/pixi.js/3.0.11/pixi.min.js"`
 - intro: This is a port from [Masking sample](http://pixijs.github.io/examples/#/demos/masking.js)
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

importAll "core-js"

let renderer = WebGLRenderer( 800., 600. )

let gameDiv = document.getElementById("game")
gameDiv.appendChild( renderer.view )

// create the root of the scene graph
let stage = Container()
stage.interactive <- true

let bg = Sprite.fromImage("./public/assets/BGrotate.jpg")

bg.anchor.x <- 0.5
bg.anchor.y <- 0.5

bg.position.x <- renderer.width / 2.
bg.position.y <- renderer.height / 2.

stage.addChild(bg)

let container = Container()
container.position.x <- renderer.width / 2.
container.position.y <- renderer.height / 2.

// add a bunch of sprites
let bgFront = Sprite.fromImage("./public/assets/SceneRotate.jpg")
bgFront.anchor.x <- 0.5
bgFront.anchor.y <- 0.5

container.addChild(bgFront)

let light2 = Sprite.fromImage("./public/assets/LightRotate2.png")
light2.anchor.x <- 0.5
light2.anchor.y <- 0.5
container.addChild(light2)

let light1 = Sprite.fromImage("./public/assets/LightRotate1.png")
light1.anchor.x <- 0.5
light1.anchor.y <- 0.5
container.addChild(light1)

let panda = Sprite.fromImage("./public/assets/panda.png")
panda.anchor.x <- 0.5
panda.anchor.y <- 0.5

container.addChild(panda)

stage.addChild(container)

// let's create a moving shape
let thing = Graphics()
stage.addChild(thing)
thing.position.x <- renderer.width / 2.
thing.position.y <- renderer.height / 2.
thing.lineStyle(0.)

container.mask <- Some(U2.Case1 thing)

let onClick() =
  match container.mask with
  | None -> container.mask <- Some(U2.Case1 thing)
  | Some mask -> container.mask <- None

stage.on_click(fun _ -> onClick())
stage.on_tap(fun _ -> onClick())

let style = [
  Font "bold 12pt Arial"
  Fill (U2.Case1 "white")
]
let help = PIXI.Text("Click to turn masking on / off.", style)
help.position.y <- renderer.height - 26.
help.position.x <- 10.
stage.addChild(help)

let animate =
  let mutable count = 0.
  let rec animate (dt:float) =
    bg.rotation <- bg.rotation +  0.01
    bgFront.rotation <- bgFront.rotation - 0.01

    light1.rotation <- light1.rotation + 0.02
    light2.rotation <- light2.rotation + 0.01

    panda.scale.x <- 1. + Math.sin(count) * 0.04
    panda.scale.y <- 1. + Math.cos(count) * 0.04

    count <- count + 0.1

    thing.clear() |> ignore

    (*
      Version specifics:
      v3: clipping (you should see some edges blinking)
      v4: no clipping
    *)
    thing.beginFill(float 0x8bc5ff, 0.4)  |> ignore
    let myangle = 20.
    let mysin = Math.sin(count) * myangle
    let mycos = Math.cos(count) * myangle
    thing.moveTo(-120. + mysin, -100. + mycos) |> ignore
    thing.lineTo(-320. + mycos, 100. + mysin) |> ignore
    thing.lineTo(120. + mycos, -100. + mysin) |> ignore
    thing.lineTo(120. + mysin, 100. + mycos) |> ignore
    thing.lineTo(-120. + mycos, 100. + mysin) |> ignore
    thing.lineTo(-120. + mysin, -300. + mycos) |> ignore
    thing.lineTo(-320. + mysin, -100. + mycos) |> ignore
    thing.rotation <- count * 0.1

    window.requestAnimationFrame(FrameRequestCallback animate) |> ignore
    renderer.render(stage)

  animate // Return `animate` function with `count` trapped in a closure

// start animating
animate 0.
