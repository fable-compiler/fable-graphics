(**
 - title: Graphics sample
 - tagline: Basic sample implemented with fable-pixi
 - app-style: width:800px; margin:20px auto 50px auto;
 - external-script: `"https://cdnjs.cloudflare.com/ajax/libs/pixi.js/3.0.11/pixi.min.js"`
 - intro: This is a port from [graphics sample](http://pixijs.github.io/examples/#/demos/graphics-demo.js)
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

let options = [
  Antialias true
]

let renderer =
  Globals.autoDetectRenderer(800., 600., options)
  |> unbox<SystemRenderer>

let gameDiv = document.getElementById("game")
gameDiv.appendChild( renderer.view )

// create the root of the scene graph
let stage = Container()

let graphics = Graphics()

// set a fill and line style
graphics.beginFill(float 0xFF3300)
graphics.lineStyle(4., float 0xffd900, 1.)

// draw a shape
graphics.moveTo(50.,50.)
graphics.lineTo(250., 50.)
graphics.lineTo(100., 100.)
graphics.lineTo(50., 50.)
graphics.endFill()

// set a fill and line style again
graphics.lineStyle(10., float 0xFF0000, 0.8)
graphics.beginFill(float 0xFF700B, 1.)

// draw a second shape
graphics.moveTo(210.,300.)
graphics.lineTo(450.,320.)
graphics.lineTo(570.,350.)
graphics.quadraticCurveTo(600., 0., 480.,100.)
graphics.lineTo(330.,120.)
graphics.lineTo(410.,200.)
graphics.lineTo(210.,300.)
graphics.endFill()

// draw a rectangle
graphics.lineStyle(2., float 0x0000FF, 1.)
graphics.drawRect(50., 250., 100., 100.)

// draw a circle
graphics.lineStyle(0.)
graphics.beginFill(float 0xFFFF0B, 0.5)
graphics.drawCircle(470., 200.,100.)
graphics.endFill()

graphics.lineStyle(20., float 0x33FF00)
graphics.moveTo(30.,30.)
graphics.lineTo(600., 300.)

stage.addChild(graphics)

// let's create a moving shape
let thing = Graphics()
stage.addChild(thing)
thing.position.x <- 620. / 2.
thing.position.y <- 380. / 2.

let onClick() =
  graphics.lineStyle(
    Math.random() * 30., Math.random() * float 0xFFFFFF, 1.) |>ignore
  graphics.moveTo(
    Math.random() * 620., Math.random() * 380.) |>ignore
  graphics.bezierCurveTo(
    Math.random() * 620., Math.random() * 380.,
    Math.random() * 620., Math.random() * 380.,
    Math.random() * 620., Math.random() * 380.) |> ignore

stage.interactive <- true
// Just click on the stage to draw random lines
stage.on_click(fun _ -> onClick())
stage.on_tap(fun _ -> onClick())

let animate =
  let mutable count = 0.
  let rec animate (dt:float) =
    thing.clear() |> ignore
    count <- count + 0.1
    thing.clear() |> ignore
    thing.lineStyle(10., float 0xff0000, 1.) |> ignore
    thing.beginFill(float 0xffFF00, 0.5) |> ignore
    thing.moveTo(
      -120. + Math.sin(count) * 20.,
      -100. + Math.cos(count)* 20.) |> ignore
    thing.lineTo(
      120. + Math.cos(count) * 20.,
      -100. + Math.sin(count)* 20.) |> ignore
    thing.lineTo(
      120. + Math.sin(count) * 20.,
      100. + Math.cos(count)* 20.) |> ignore
    thing.lineTo(
      -120. + Math.cos(count)* 20.,
      100. + Math.sin(count)* 20.) |> ignore
    thing.lineTo(
      -120. + Math.sin(count) * 20.,
      -100. + Math.cos(count)* 20.) |> ignore
    thing.rotation <- count * 0.1
    window.requestAnimationFrame(FrameRequestCallback animate) |> ignore
    renderer.render(stage)
  animate

// start animating
animate 0.
