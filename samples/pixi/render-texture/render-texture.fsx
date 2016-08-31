(**
 - title: Render Texture sample
 - tagline: Basic sample implemented with fable-pixi
 - app-style: width:800px; margin:20px auto 50px auto;
 - require-paths: `'PIXI':'https://cdnjs.cloudflare.com/ajax/libs/pixi.js/3.0.11/pixi.min'`
 - intro: This is a port from [Render texture sample](http://pixijs.github.io/examples/#/demos/render-texture-demo.js)
*)

#r "node_modules/fable-core/Fable.Core.dll"
#load "../../../bindings/fable-import-pixi/Fable.Import.Pixi.fs"

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import.PIXI
open Fable.Import.PIXI.extras
open Fable.Import.Browser
open Fable.Import.JS

let renderer = WebGLRenderer( 800., 600. )

let gameDiv = document.getElementById("game")
gameDiv.appendChild( renderer.view )

// create the root of the scene graph
let stage = new Container()

let mutable renderTexture = RenderTexture( U2.Case2 renderer, renderer.width, renderer.height)
let mutable renderTexture2 = RenderTexture( U2.Case2 renderer, renderer.width, renderer.height)
let mutable currentTexture = renderTexture

// create a new sprite that uses the render texture we created above
let mutable outputSprite = new Sprite(currentTexture)

// align the sprite
outputSprite.position.x <- 400.
outputSprite.position.y <- 300.
outputSprite.anchor.set(0.5)

// add to stage
stage.addChild(outputSprite)

let stuffContainer = new Container()
stuffContainer.position.x <- 400.
stuffContainer.position.y <- 300.
stage.addChild(stuffContainer)

// create an array of image ids..
let fruits = ResizeArray [|"./public/assets/spinObj_01.png";
  "./public/assets/spinObj_02.png";
  "./public/assets/spinObj_03.png";
  "./public/assets/spinObj_04.png";
  "./public/assets/spinObj_05.png";
  "./public/assets/spinObj_06.png";
  "./public/assets/spinObj_07.png";
  "./public/assets/spinObj_08.png"
|]
let fl = fruits.Count

// create an array of items
let items = new ResizeArray<Sprite>()

// now create some items and randomly position them in the stuff container
for i in 0..19 do
  let mutable item = Sprite.fromImage(fruits.[i % fl])
  item.position.x <- Math.random() * 400. - 200.
  item.position.y <- Math.random() * 400. - 200.
  item.anchor.set(0.5)
  stuffContainer.addChild(item) |> ignore
  items.Add(item)

let mutable count = 0.

let rec animate (dt:float) =
  window.requestAnimationFrame(FrameRequestCallback animate) |> ignore

  let il = items.Count - 1
  console.log(il)
  for i in 0..il do
    let mutable item = items.[i]
    item.rotation <- item.rotation + 0.1

  count <- count + 0.01

  // swap the buffers ...
  let temp = renderTexture
  renderTexture <- renderTexture2
  renderTexture2 <- temp

  // set the new texture
  outputSprite.texture <- renderTexture

  // twist this up!
  stuffContainer.rotation <- stuffContainer.rotation - 0.01
  outputSprite.scale.set(1. + Math.sin(float count) * 0.2)

  // render the stage to the texture
  // the 'true' clears the texture before the content is rendered
  renderTexture2.render(displayObject=stage, clear=false)

  // render the container
  renderer.render(stage)

animate 0.
