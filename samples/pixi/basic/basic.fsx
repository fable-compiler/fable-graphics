(**
 - title: Basic sample
 - tagline: Basic sample implemented with fable-pixi
 - app-style: width:800px; margin:20px auto 50px auto;
 - external-script: `"https://cdnjs.cloudflare.com/ajax/libs/pixi.js/3.0.11/pixi.min.js"`
 - intro: This is a port from [basic sample](http://pixijs.github.io/examples/#/basics/basic.js)
*)

#r "../../node_modules/fable-core/Fable.Core.dll"
#load "../../node_modules/fable-import-pixi/Fable.Import.Pixi.fs"

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import.PIXI
open Fable.Import.Browser

importAll "core-js"

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

// create a texture from an image path
let texture = Texture.fromImage("public/assets/bunny.png")

// create a new Sprite using the texture
let bunny = Sprite(texture)

// center the sprite's anchor point
bunny.anchor.x <- 0.5
bunny.anchor.y <- 0.5

// move the sprite
bunny.position.x <- 200.
bunny.position.y <- 150.

// Add the bunny to the scene we are building.
stage.addChild(bunny) |> ignore

let rec animate (dt:float) =
  window.requestAnimationFrame(FrameRequestCallback animate) |> ignore

  // just for fun, let's rotate mr rabbit a little
  bunny.rotation <- bunny.rotation + 0.1

  // render the container
  renderer.render(stage)

// start animating
animate 0.
