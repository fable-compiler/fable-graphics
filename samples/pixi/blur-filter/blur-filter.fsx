(**
 - title: Blur Filter sample
 - tagline: Basic sample implemented with fable-pixi
 - app-style: width:800px; margin:20px auto 50px auto;
 - external-script: `"https://cdnjs.cloudflare.com/ajax/libs/pixi.js/3.0.11/pixi.min.js"`
 - intro: This is a port from [blur filter sample](http://pixijs.github.io/examples/#/filters/blur-filter.js)
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
  Globals.autoDetectRenderer(800., 600.)
  |> unbox<SystemRenderer>

let gameDiv = document.getElementById("game")
gameDiv.appendChild( renderer.view )

// create the root of the scene graph
let stage = Container()

let bg = Sprite.fromImage("./public/assets/depth_blur_BG.jpg")
bg.width <- renderer.width
bg.height <- renderer.height
stage.addChild(bg)

let littleDudes = Sprite.fromImage("./public/assets/depth_blur_dudes.jpg")
littleDudes.position.x <- (renderer.width / 2.) - 315.
littleDudes.position.y <- 200.
stage.addChild(littleDudes)

let littleRobot = Sprite.fromImage("./public/assets/depth_blur_moby.jpg")
littleRobot.position.x <- (renderer.width / 2.) - 200.
littleRobot.position.y <- 100.
stage.addChild(littleRobot)

let blurFilter1 = filters.BlurFilter()
let blurFilter2 = filters.BlurFilter()

littleDudes.filters <- Some(ResizeArray[|blurFilter1 :> AbstractFilter|])
littleRobot.filters <- Some(ResizeArray[|blurFilter2 :> AbstractFilter|])

let rec animate =
  let mutable count = 0.
  let rec animate (dt:float) =
    count <- count + 0.005
    let blurAmount = Math.cos(count)
    let blurAmount2 = Math.sin(count)
    blurFilter1.blur <- 20. * (blurAmount)
    blurFilter2.blur <- 20. * (blurAmount2)
    window.requestAnimationFrame(FrameRequestCallback animate) |> ignore
    renderer.render(stage)
  animate

// start animating
animate 0.
