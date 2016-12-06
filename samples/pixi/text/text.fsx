(**
 - title: Text sample
 - tagline: Basic sample implemented with fable-pixi
 - app-style: width:800px; margin:20px auto 50px auto;
 - external-script: `"https://cdnjs.cloudflare.com/ajax/libs/pixi.js/3.0.11/pixi.min.js"`
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

importAll "core-js"

let renderer =
  Globals.autoDetectRenderer( 620., 400. )
  |> unbox<SystemRenderer>

renderer.view.style.display <- "block"
renderer.view.style.margin <- "0 auto"

let gameDiv = document.getElementById("game")
gameDiv.appendChild( renderer.view )

// create the root of the scene graph
let stage = Container()

let onAssetsLoad resources =
  let fontStyle = [
    extras.Font (U2.Case1 "35px Desyrel")
    extras.Align "right"
  ]
  let bitmapFontText =
    extras.BitmapText("bitmap fonts are\n now supported", fontStyle)
  bitmapFontText.position.x <- 600. - bitmapFontText.textWidth
  bitmapFontText.position.y <- 20.
  stage.addChild(bitmapFontText)
  |> ignore

// add a shiny background...
let background = Sprite.fromImage("./public/assets/textDemoBG.jpg")
stage.addChild( background)

// create some white text using the Snippet webfont
let style = [
  TextStyle.Font "35px Arial"
  TextStyle.Fill (U2.Case1 "white")
  TextStyle.Align "left"
]
let textSample = PIXI.Text("Pixi.js can have\n multiline text!", style)
textSample.position.set(20.)

// create a text object with a nice stroke
let funStyle = [
  TextStyle.Font "bold 60px Arial"
  TextStyle.Fill (U2.Case1 "#cc00ff")
  TextStyle.Align "center"
  TextStyle.Stroke (U2.Case1 "#FFFFFF")
  TextStyle.StrokeThickness 6.
]
let spinningText = PIXI.Text("I\'m fun!", funStyle)
spinningText.anchor.set(0.5)
spinningText.position.x <- 310.
spinningText.position.y <- 200.

let countingStyle = [
  TextStyle.Font "bold italic 60px Arial"
  TextStyle.Fill (U2.Case1 "#3e1707")
  TextStyle.Align "center"
  TextStyle.Stroke (U2.Case1 "#a4410e")
  TextStyle.StrokeThickness 7.
]
let countingText = PIXI.Text("COUNT 4EVAR: 0", countingStyle)
countingText.position.x <- 310.
countingText.position.y <- 320.
countingText.anchor.x <- 0.5

stage.addChild(textSample)
stage.addChild(spinningText)
stage.addChild(countingText)

Globals.loader
  .add("desyrel","./public/assets/desyrel.xml")
  .load(Func<_,_,_>(fun _ resources ->
    onAssetsLoad(resources)))

let animate =
  let mutable count = 0.
  let rec animate (dt:float) =
    // render the container
    renderer.render(stage)
    count <- count + 0.5
    // update the text with a new string
    countingText.text <- sprintf "COUNT 4EVAR: %.0f" (Math.floor(count))
    // let's spin the spinning text
    spinningText.rotation <- spinningText.rotation + 0.03
    window.requestAnimationFrame(FrameRequestCallback animate) |> ignore
  animate

// start animating
animate 0.
