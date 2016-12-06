(**
 - title: Dragging sample
 - tagline: Basic sample implemented with fable-pixi
 - app-style: width:800px; margin:20px auto 50px auto;
 - external-script: `"https://cdnjs.cloudflare.com/ajax/libs/pixi.js/3.0.11/pixi.min.js"`
 - intro: This is a port from [dragging sample](http://pixijs.github.io/examples/#/demos/dragging.js)
*)

#r "../../node_modules/fable-core/Fable.Core.dll"
#load "../../node_modules/fable-import-pixi/Fable.Import.Pixi.fs"

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import.PIXI
open Fable.Import.Browser
open Fable.Import.JS

importAll "core-js"

let renderer =
  Globals.autoDetectRenderer( 800., 600. )
  |> unbox<SystemRenderer>

let gameDiv = document.getElementById("game")
gameDiv.appendChild( renderer.view )

// create the root of the scene graph
let stage = Container()

let texture = Texture.fromImage("./public/assets/bunny.png")

type MyBunny(texture) =
    inherit Sprite(texture)

    member this.noop() = console.log("click")
    member this.tap = this.noop
    member this.click = this.noop

    member this.mousedown(event) =
      this?data <- event?data
      this?alpha <- 0.5
      this?dragging <- true

    member this.mouseup() =
      this?data <- None
      this?alpha <- 1.
      this?dragging <- false

    member this.mousemove() =
      if unbox this?dragging then
        let newPosition = this?data?getLocalPosition(this?parent)
        this.position.x <- unbox newPosition?x
        this.position.y <- unbox newPosition?y

    member this.touchstart = this.mousedown
    member this.touchend = this.mouseup
    member this.touchendoutside = this.mouseup
    member this.mouseupoutside = this.mouseup
    member this.touchmove = this.mousemove

let createBunny x y =
  let bunny = MyBunny(texture)
  bunny.interactive <- true
  bunny.buttonMode <- true
  bunny.anchor.set(0.5)
  bunny.scale.set(3.)
  bunny.position.x <- x
  bunny.position.y <- y
  stage.addChild(bunny)

for i in 0..9 do
  let x = Math.floor(Math.random() * 800.)
  let y = Math.floor(Math.random() * 600.)
  createBunny x y |> ignore

let rec animate (dt:float) =
  window.requestAnimationFrame(FrameRequestCallback animate) |> ignore
  // render the container
  renderer.render(stage)

animate 0.
