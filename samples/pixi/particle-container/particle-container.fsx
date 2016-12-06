(**
 - title: Particle Container sample
 - tagline: Basic sample implemented with fable-pixi
 - app-style: width:800px; margin:20px auto 50px auto;
 - external-script: `"https://cdnjs.cloudflare.com/ajax/libs/pixi.js/3.0.11/pixi.min.js"`
 - intro: This is a port from [Particle Container sample](http://pixijs.github.io/examples/#/demos/batch-v3.js)
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

let isWebGL, renderer =
  match Globals.autoDetectRenderer(800., 600.) with
  | U2.Case1 webgl -> true, webgl :> SystemRenderer
  | U2.Case2 canvas -> false, canvas :> SystemRenderer

let gameDiv = document.getElementById("game")
gameDiv.appendChild( renderer.view )

// create the root of the scene graph
let stage = Container()

type PCP = ParticleContainerProperties
let options = [
    PCP.Scale true
    PCP.Position true
    PCP.Rotation true
    PCP.Uvs true
    PCP.Alpha true
  ]
let sprites = ParticleContainer(10000., options)
stage.addChild(sprites)

// create an array to store a reference to the dudes
let maggots = ResizeArray<Sprite>()
let totalSprites = if isWebGL then 10000 else 100

for i in 0..totalSprites-1 do
    // create a new Sprite that uses the image name
    // we just generated as its source
    let dude = Sprite.fromImage("./public/assets/tinyMaggot.png")

    // Exists in code but is not used in actual demo
    // http://pixijs.github.io/examples/#/demos/batch-v3.js
    //dude.tint <- Math.random() * (float 0xE8D4CD)

    dude.anchor.set(0.5)

    // set a random scale for the dude
    dude.scale.set(0.8 + Math.random() * 0.3)

    // finally let"s set the dude to be at a random position...
    dude.position.x <- Math.floor(Math.random() * renderer.width)
    dude.position.y <- Math.floor(Math.random() * renderer.height)

    // Exists in code but is not used in actual demo
    // http://pixijs.github.io/examples/#/demos/batch-v3.js
    //dude.tint <- Math.random() * (float 0x808080)

    // create some extra properties that will control movement
    // create a random direction in radians. This is a number
    // between 0 and PI*2 which is the equivalent of 0 - 360 degrees
    dude?direction <- Math.random() * Math.PI * 2.

    // this number will be used to modify the direction of the dude over time
    dude?turningSpeed <- Math.random() - 0.8

    // create a random speed between 0 - 2, and these maggots are slooww
    dude?speed <- 2. + Math.random() * 2. * 0.2

    dude?offset <- Math.random() * 100.

    // push the dude into the maggots so it can be easily accessed later
    maggots.Add(dude)

    stage.addChild(dude) |> ignore


// create a bounding box box for the little dudes
let dudeBoundsPadding = 100.

let dudeBounds = Rectangle(-dudeBoundsPadding,
                           -dudeBoundsPadding,
                           renderer.width + dudeBoundsPadding * 2.,
                           renderer.height + dudeBoundsPadding * 2.)

let animate =
  let mutable tick = 0.
  let rec animate (dt:float) =
    // iterate through the dudes and update the positions
    let dc = maggots.Count - 1
    for i in 0..dc do
      let dude = maggots.[i]
      dude.scale.y <-
        0.95 + Math.sin(tick + unbox dude?offset) * 0.05

      dude?direction <-
        (unbox dude?direction) + (unbox dude?turningSpeed) * 0.01

      dude.position.x <-
        dude.position.x + Math.sin(unbox dude?direction)
        * (unbox dude?speed) * dude.scale.y

      dude.position.y <-
        dude.position.y + Math.cos(unbox dude?direction)
        * (unbox dude?speed) * dude.scale.y

      dude.rotation <-
        -(unbox dude?direction) - Math.PI

      // wrap the dudes by testing their bounds...
      if (dude.position.x < dudeBounds.x)
      then dude.position.x <- dude.position.x + dudeBounds.width
      elif (dude.position.x > dudeBounds.x + dudeBounds.width)
      then dude.position.x <- dude.position.x - dudeBounds.width

      if (dude.position.y < dudeBounds.y)
      then dude.position.y <- dude.position.y + dudeBounds.height
      elif (dude.position.y > dudeBounds.y + dudeBounds.height)
      then dude.position.y <- dude.position.y - dudeBounds.height

    // increment the ticker
    tick <- tick + 0.1
    window.requestAnimationFrame(FrameRequestCallback animate) |> ignore
    renderer.render(stage)

  animate // Return `animate` function with `tick` trapped in a closure

// start animating
animate 0.
