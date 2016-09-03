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
open Fable.Import.PIXI
open Fable.Import.PIXI.extras
open Fable.Import.Browser
open Fable.Import.JS

let renderer =
  Globals.autoDetectRenderer( 800., 600. )
  |> unbox<SystemRenderer>

let gameDiv = document.getElementById("game")
gameDiv.appendChild( renderer.view )

// create the root of the scene graph
let stage = new Container()

let onAssetsLoad resources =
  let fontStyle = [
    Font (U2.Case1 "35px Desyrel")
    Align "right"
  ]
  let mutable bitmapFontText = new extras.BitmapText("bitmap fonts are\n now supported", fontStyle)
  bitmapFontText.position.x <- 600. - bitmapFontText.textWidth
  bitmapFontText.position.y <- 20.
  stage.addChild(bitmapFontText)

// add a shiny background...
let background = Sprite.fromImage("./public/assets/textDemoBG.jpg")
stage.addChild( background)

// create some white text using the Snippet webfont
type TS = TextStyle
let style = [
  TS.Font "35px Arial"
  TS.Fill (U2.Case1 "white")
  TS.Align "left"
]
let mutable textSample : Fable.Import.PIXI.Text = Fable.Import.PIXI.Text("Pixi.js can have\n multiline text!", style)
textSample.position.set(20.)


// create a text object with a nice stroke
let funStyle = [
  TS.Font "bold 60px Arial"
  TS.Fill (U2.Case1 "#cc00ff")
  TS.Align "center"
  TS.Stroke (U2.Case1 "#FFFFFF")
  TS.StrokeThickness 6.
]
let mutable spinningText : Fable.Import.PIXI.Text = Fable.Import.PIXI.Text("I\'m fun!", funStyle)
spinningText.anchor.set(0.5)
spinningText.position.x <- 310.
spinningText.position.y <- 200.


let countingStyle = [
  TS.Font "bold italic 60px Arial"
  TS.Fill (U2.Case1 "#3e1707")
  TS.Align "center"
  TS.Stroke (U2.Case1 "#a4410e")
  TS.StrokeThickness 7.
]
let mutable countingText : Fable.Import.PIXI.Text = Fable.Import.PIXI.Text("COUNT 4EVAR: 0", countingStyle)
countingText.position.x <- 310.
countingText.position.y <- 320.
countingText.anchor.x <- 0.5

stage.addChild(textSample)
stage.addChild(spinningText)
stage.addChild(countingText)

Globals.loader
  .add("desyrel","./public/assets/desyrel.xml")
  .load(System.Func<_,_,_>(fun loader resources ->
    onAssetsLoad(resources) |> ignore
  ))

let mutable count = 0.

let rec animate (dt:float) =
  // render the container
  renderer.render(stage)
  count <- count + 0.5
  // update the text with a new string
  countingText.text <- sprintf "COUNT 4EVAR: %i" (Math.floor(count) |> int)

  // let's spin the spinning text
  spinningText.rotation <- spinningText.rotation + 0.03
  window.requestAnimationFrame(FrameRequestCallback animate) |> ignore


// start animating
animate 0.
