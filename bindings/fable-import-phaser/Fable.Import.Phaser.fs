namespace rec Fable.Import
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Import.Browser

type [<AllowNullLiteral>] [<Import("*","Phaser")>] Phaser() =
    member __.VERSION with get(): string = jsNative and set(v: string): unit = jsNative
    member __.DEV_VERSION with get(): string = jsNative and set(v: string): unit = jsNative
    member __.GAMES with get(): ResizeArray<Phaser.Game> = jsNative and set(v: ResizeArray<Phaser.Game>): unit = jsNative
    member __.AUTO with get(): float = jsNative and set(v: float): unit = jsNative
    member __.CANVAS with get(): float = jsNative and set(v: float): unit = jsNative
    member __.WEBGL with get(): float = jsNative and set(v: float): unit = jsNative
    member __.HEADLESS with get(): float = jsNative and set(v: float): unit = jsNative
    member __.BITMAPDATA with get(): float = jsNative and set(v: float): unit = jsNative
    member __.BITMAPTEXT with get(): float = jsNative and set(v: float): unit = jsNative
    member __.BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
    member __.CANVAS_FILTER with get(): float = jsNative and set(v: float): unit = jsNative
    member __.CIRCLE with get(): float = jsNative and set(v: float): unit = jsNative
    member __.ELLIPSE with get(): float = jsNative and set(v: float): unit = jsNative
    member __.EMITTER with get(): float = jsNative and set(v: float): unit = jsNative
    member __.GRAPHICS with get(): float = jsNative and set(v: float): unit = jsNative
    member __.GROUP with get(): float = jsNative and set(v: float): unit = jsNative
    member __.IMAGE with get(): float = jsNative and set(v: float): unit = jsNative
    member __.LINE with get(): float = jsNative and set(v: float): unit = jsNative
    member __.MATRIX with get(): float = jsNative and set(v: float): unit = jsNative
    member __.POINT with get(): float = jsNative and set(v: float): unit = jsNative
    member __.POINTER with get(): float = jsNative and set(v: float): unit = jsNative
    member __.POLYGON with get(): float = jsNative and set(v: float): unit = jsNative
    member __.RECTANGLE with get(): float = jsNative and set(v: float): unit = jsNative
    member __.ROUNDEDRECTANGLE with get(): float = jsNative and set(v: float): unit = jsNative
    member __.RENDERTEXTURE with get(): float = jsNative and set(v: float): unit = jsNative
    member __.RETROFONT with get(): float = jsNative and set(v: float): unit = jsNative
    member __.SPRITE with get(): float = jsNative and set(v: float): unit = jsNative
    member __.SPRITEBATCH with get(): float = jsNative and set(v: float): unit = jsNative
    member __.TEXT with get(): float = jsNative and set(v: float): unit = jsNative
    member __.TILEMAP with get(): float = jsNative and set(v: float): unit = jsNative
    member __.TILEMAPLAYER with get(): float = jsNative and set(v: float): unit = jsNative
    member __.TILESPRITE with get(): float = jsNative and set(v: float): unit = jsNative
    member __.WEBGL_FILTER with get(): float = jsNative and set(v: float): unit = jsNative
    member __.ROPE with get(): float = jsNative and set(v: float): unit = jsNative
    member __.CREATURE with get(): float = jsNative and set(v: float): unit = jsNative
    member __.VIDEO with get(): float = jsNative and set(v: float): unit = jsNative
    member __.NONE with get(): float = jsNative and set(v: float): unit = jsNative
    member __.LEFT with get(): float = jsNative and set(v: float): unit = jsNative
    member __.RIGHT with get(): float = jsNative and set(v: float): unit = jsNative
    member __.UP with get(): float = jsNative and set(v: float): unit = jsNative
    member __.DOWN with get(): float = jsNative and set(v: float): unit = jsNative
    member __.HORIZONTAL with get(): float = jsNative and set(v: float): unit = jsNative
    member __.VERTICAL with get(): float = jsNative and set(v: float): unit = jsNative
    member __.LANDSCAPE with get(): float = jsNative and set(v: float): unit = jsNative
    member __.PORTRAIT with get(): float = jsNative and set(v: float): unit = jsNative
    member __.ANGLE_UP with get(): float = jsNative and set(v: float): unit = jsNative
    member __.ANGLE_DOWN with get(): float = jsNative and set(v: float): unit = jsNative
    member __.ANGLE_LEFT with get(): float = jsNative and set(v: float): unit = jsNative
    member __.ANGLE_RIGHT with get(): float = jsNative and set(v: float): unit = jsNative
    member __.ANGLE_NORTH_EAST with get(): float = jsNative and set(v: float): unit = jsNative
    member __.ANGLE_NORTH_WEST with get(): float = jsNative and set(v: float): unit = jsNative
    member __.ANGLE_SOUTH_EAST with get(): float = jsNative and set(v: float): unit = jsNative
    member __.ANGLE_SOUTH_WEST with get(): float = jsNative and set(v: float): unit = jsNative
    member __.TOP_LEFT with get(): float = jsNative and set(v: float): unit = jsNative
    member __.TOP_CENTER with get(): float = jsNative and set(v: float): unit = jsNative
    member __.TOP_RIGHT with get(): float = jsNative and set(v: float): unit = jsNative
    member __.LEFT_TOP with get(): float = jsNative and set(v: float): unit = jsNative
    member __.LEFT_CENTER with get(): float = jsNative and set(v: float): unit = jsNative
    member __.LEFT_BOTTOM with get(): float = jsNative and set(v: float): unit = jsNative
    member __.CENTER with get(): float = jsNative and set(v: float): unit = jsNative
    member __.RIGHT_TOP with get(): float = jsNative and set(v: float): unit = jsNative
    member __.RIGHT_CENTER with get(): float = jsNative and set(v: float): unit = jsNative
    member __.RIGHT_BOTTOM with get(): float = jsNative and set(v: float): unit = jsNative
    member __.BOTTOM_LEFT with get(): float = jsNative and set(v: float): unit = jsNative
    member __.BOTTOM_CENTER with get(): float = jsNative and set(v: float): unit = jsNative
    member __.BOTTOM_RIGHT with get(): float = jsNative and set(v: float): unit = jsNative

module Phaser =
    type [<AllowNullLiteral>] [<Import("Animation","Phaser")>] Animation(game: Phaser.Game, parent: Phaser.Sprite, name: string, frameData: Phaser.FrameData, frames: U2<ResizeArray<float>, ResizeArray<string>>, ?frameRate: float, ?loop: bool) =
        member __.currentFrame with get(): Phaser.Frame = jsNative and set(v: Phaser.Frame): unit = jsNative
        member __.delay with get(): float = jsNative and set(v: float): unit = jsNative
        member __.enableUpdate with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.frame with get(): float = jsNative and set(v: float): unit = jsNative
        member __.frameTotal with get(): float = jsNative and set(v: float): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.isFinished with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isPaused with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isPlaying with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.killOnComplete with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.loop with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.loopCount with get(): float = jsNative and set(v: float): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.onComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onLoop with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onStart with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onUpdate with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.paused with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.reversed with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
        member __.complete(): unit = jsNative
        member __.destroy(): unit = jsNative
        static member generateFrameNames(prefix: string, start: float, stop: float, ?suffix: string, ?zeroPad: float): ResizeArray<string> = jsNative
        member __.next(?quantity: float): unit = jsNative
        member __.onPause(): unit = jsNative
        member __.onResume(): unit = jsNative
        member __.play(?frameRate: float, ?loop: bool, ?killOnComplete: bool): Phaser.Animation = jsNative
        member __.previous(?quantity: float): unit = jsNative
        member __.restart(): unit = jsNative
        member __.reverse(): Animation = jsNative
        member __.reverseOnce(): Animation = jsNative
        member __.setFrame(?frameId: U2<string, float>, ?useLocalFrameIndex: bool): unit = jsNative
        member __.stop(?resetFrame: bool, ?dispatchComplete: bool): unit = jsNative
        member __.update(): bool = jsNative
        member __.updateCurrentFrame(signalUpdate: bool, ?fromPlay: bool): bool = jsNative
        member __.updateFrameData(frameData: FrameData): unit = jsNative

    and [<AllowNullLiteral>] [<Import("AnimationManager","Phaser")>] AnimationManager(sprite: Phaser.Sprite) =
        member __.currentAnim with get(): Phaser.Animation = jsNative and set(v: Phaser.Animation): unit = jsNative
        member __.currentFrame with get(): Phaser.Frame = jsNative and set(v: Phaser.Frame): unit = jsNative
        member __.frame with get(): float = jsNative and set(v: float): unit = jsNative
        member __.frameData with get(): Phaser.FrameData = jsNative and set(v: Phaser.FrameData): unit = jsNative
        member __.frameName with get(): string = jsNative and set(v: string): unit = jsNative
        member __.frameTotal with get(): float = jsNative and set(v: float): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.isLoaded with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.paused with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.sprite with get(): Phaser.Sprite = jsNative and set(v: Phaser.Sprite): unit = jsNative
        member __.updateIfVisible with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.add(name: string, ?frames: U2<ResizeArray<float>, ResizeArray<string>>, ?frameRate: float, ?loop: bool, ?useNumericIndex: bool): Phaser.Animation = jsNative
        member __.copyFrameData(frameData: Phaser.FrameData, frame: U2<string, float>): bool = jsNative
        member __.destroy(): unit = jsNative
        member __.getAnimation(name: string): Phaser.Animation = jsNative
        member __.next(?quantity: float): unit = jsNative
        member __.play(name: string, ?frameRate: float, ?loop: bool, ?killOnComplete: bool): Phaser.Animation = jsNative
        member __.previous(?quantity: float): unit = jsNative
        member __.stop(?name: string, ?resetFrame: bool): unit = jsNative
        member __.update(): bool = jsNative
        member __.validateFrames(frames: ResizeArray<Phaser.Frame>, ?useNumericIndex: bool): bool = jsNative

    and [<AllowNullLiteral>] [<Import("AnimationParser","Phaser")>] AnimationParser() =
        static member JSONData(game: Phaser.Game, json: obj): Phaser.FrameData = jsNative
        static member JSONDataHash(game: Phaser.Game, json: obj): Phaser.FrameData = jsNative
        static member JSONDataPyxel(game: Phaser.Game, json: obj): Phaser.FrameData = jsNative
        static member spriteSheet(game: Phaser.Game, key: string, frameWidth: float, frameHeight: float, ?frameMax: float, ?margin: float, ?spacing: float): Phaser.FrameData = jsNative
        static member XMLData(game: Phaser.Game, xml: obj): Phaser.FrameData = jsNative

    and [<AllowNullLiteral>] [<Import("AudioSprite","Phaser")>] AudioSprite(game: Phaser.Game, key: string) =
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.key with get(): string = jsNative and set(v: string): unit = jsNative
        member __.config with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.autoplayKey with get(): string = jsNative and set(v: string): unit = jsNative
        member __.autoplay with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.sounds with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.get(marker: string): Phaser.Sound = jsNative
        member __.play(marker: string, ?volume: float): Phaser.Sound = jsNative
        member __.stop(marker: string): Phaser.Sound = jsNative

    and [<AllowNullLiteral>] [<Import("ArraySet","Phaser")>] ArraySet(list: ResizeArray<obj>) =
        member __.position with get(): float = jsNative and set(v: float): unit = jsNative
        member __.list with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
        member __.total with get(): float = jsNative and set(v: float): unit = jsNative
        member __.first with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.next with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.add(item: obj): obj = jsNative
        member __.getByKey(property: string, value: obj): obj = jsNative
        member __.getIndex(item: obj): float = jsNative
        member __.exists(item: obj): bool = jsNative
        member __.reset(): unit = jsNative
        member __.remove(item: obj): obj = jsNative
        member __.removeAll(?destoy: bool): unit = jsNative
        member __.setAll(key: obj, value: obj): unit = jsNative
        member __.callAll(key: string, [<ParamArray>] parameter: obj[]): unit = jsNative

    and [<AllowNullLiteral>] [<Import("ArrayUtils","Phaser")>] ArrayUtils() =
        static member getRandomItem(objects: ResizeArray<'T>, ?startIndex: float, ?length: float): 'T = jsNative
        static member removeRandomItem(objects: ResizeArray<'T>, ?startIndex: float, ?length: float): 'T = jsNative
        static member shuffle(array: ResizeArray<'T>): ResizeArray<'T> = jsNative
        static member transposeMatrix(array: ResizeArray<'T>): 'T = jsNative
        static member rotateMatrix(matrix: obj, direction: U2<float, string>): obj = jsNative
        static member findClosest(value: float, arr: ResizeArray<float>): float = jsNative
        static member rotate(array: ResizeArray<obj>): obj = jsNative
        static member rotateLeft(array: ResizeArray<obj>): obj = jsNative
        static member rotateRight(array: ResizeArray<obj>): obj = jsNative
        static member numberArray(start: float, ``end``: float): ResizeArray<float> = jsNative
        static member numberArrayStep(start: float, ?``end``: float, ?step: float): ResizeArray<float> = jsNative

    and [<AllowNullLiteral>] BitmapFont =
        abstract ``base``: PIXI.BaseTexture with get, set
        abstract data: HTMLImageElement with get, set
        abstract font: Phaser.BMFont with get, set
        abstract url: string with get, set

    and [<AllowNullLiteral>] BMFont =
        abstract chars: ResizeArray<Phaser.BMFontChar> with get, set
        abstract font: string with get, set
        abstract lineHeight: float with get, set
        abstract size: float with get, set

    and [<AllowNullLiteral>] BMFontChar =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract width: float with get, set
        abstract height: float with get, set
        abstract xOffset: float with get, set
        abstract yOffset: float with get, set
        abstract xAdvance: float with get, set
        abstract kerning: ResizeArray<float> with get, set
        abstract texture: PIXI.BaseTexture with get, set

    and [<AllowNullLiteral>] [<Import("BitmapData","Phaser")>] BitmapData(game: Phaser.Game, key: string, ?width: float, ?height: float, ?skipPool: bool) =
        member __.baseTexture with get(): PIXI.BaseTexture = jsNative and set(v: PIXI.BaseTexture): unit = jsNative
        member __.buffer with get(): ArrayBuffer = jsNative and set(v: ArrayBuffer): unit = jsNative
        member __.canvas with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
        member __.context with get(): CanvasRenderingContext2D = jsNative and set(v: CanvasRenderingContext2D): unit = jsNative
        member __.ctx with get(): CanvasRenderingContext2D = jsNative and set(v: CanvasRenderingContext2D): unit = jsNative
        member __.data with get(): Uint8Array = jsNative and set(v: Uint8Array): unit = jsNative
        member __.dirty with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.disableTextureUpload with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.imageData with get(): ImageData = jsNative and set(v: ImageData): unit = jsNative
        member __.key with get(): string = jsNative and set(v: string): unit = jsNative
        member __.op with get(): string = jsNative and set(v: string): unit = jsNative
        member __.pixels with get(): Uint32Array = jsNative and set(v: Uint32Array): unit = jsNative
        member __.smoothed with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.smoothProperty with get(): string = jsNative and set(v: string): unit = jsNative
        member __.texture with get(): PIXI.Texture = jsNative and set(v: PIXI.Texture): unit = jsNative
        member __.textureFrame with get(): Phaser.Frame = jsNative and set(v: Phaser.Frame): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        static member getTransform(translateX: float, translateY: float, scaleX: float, scaleY: float, skewX: float, skewY: float): obj = jsNative
        member __.add(``object``: obj): Phaser.BitmapData = jsNative
        member __.addToWorld(?x: float, ?y: float, ?anchorX: float, ?anchorY: float, ?scaleX: float, ?scaleY: float): Phaser.Image = jsNative
        member __.alphaMask(source: obj, ?mask: obj, ?sourceRect: Phaser.Rectangle, ?maskRect: Phaser.Rectangle): Phaser.BitmapData = jsNative
        member __.blendAdd(): Phaser.BitmapData = jsNative
        member __.blendColor(): Phaser.BitmapData = jsNative
        member __.blendColorBurn(): Phaser.BitmapData = jsNative
        member __.blendColorDodge(): Phaser.BitmapData = jsNative
        member __.blendDarken(): Phaser.BitmapData = jsNative
        member __.blendDestinationAtop(): Phaser.BitmapData = jsNative
        member __.blendDestinationIn(): Phaser.BitmapData = jsNative
        member __.blendDestinationOut(): Phaser.BitmapData = jsNative
        member __.blendDestinationOver(): Phaser.BitmapData = jsNative
        member __.blendDifference(): Phaser.BitmapData = jsNative
        member __.blendExclusion(): Phaser.BitmapData = jsNative
        member __.blendHardLight(): Phaser.BitmapData = jsNative
        member __.blendHue(): Phaser.BitmapData = jsNative
        member __.blendLighten(): Phaser.BitmapData = jsNative
        member __.blendLuminosity(): Phaser.BitmapData = jsNative
        member __.blendMultiply(): Phaser.BitmapData = jsNative
        member __.blendOverlay(): Phaser.BitmapData = jsNative
        member __.blendReset(): Phaser.BitmapData = jsNative
        member __.blendSaturation(): Phaser.BitmapData = jsNative
        member __.blendScreen(): Phaser.BitmapData = jsNative
        member __.blendSoftLight(): Phaser.BitmapData = jsNative
        member __.blendSourceAtop(): Phaser.BitmapData = jsNative
        member __.blendSourceIn(): Phaser.BitmapData = jsNative
        member __.blendSourceOut(): Phaser.BitmapData = jsNative
        member __.blendSourceOver(): Phaser.BitmapData = jsNative
        member __.blendXor(): Phaser.BitmapData = jsNative
        member __.circle(x: float, y: float, radius: float, ?fillStyle: string): Phaser.BitmapData = jsNative
        member __.clear(?x: float, ?y: float, ?width: float, ?height: float): Phaser.BitmapData = jsNative
        member __.cls(): Phaser.BitmapData = jsNative
        member __.copy(?source: obj, ?x: float, ?y: float, ?width: float, ?height: float, ?tx: float, ?ty: float, ?newWidth: float, ?newHeight: float, ?rotate: float, ?anchorX: float, ?anchorY: float, ?scaleX: float, ?scaleY: float, ?alpha: float, ?blendMode: string, ?roundPx: bool): Phaser.BitmapData = jsNative
        member __.copyPixels(source: obj, area: Phaser.Rectangle, x: float, y: float, ?alpha: float): unit = jsNative
        member __.copyRect(source: obj, area: Phaser.Rectangle, ?x: float, ?y: float, ?alpha: float, ?blendMode: string, ?roundPx: bool): Phaser.BitmapData = jsNative
        member __.copyTransform(source: obj, ?blendMode: string, ?roundPx: bool): Phaser.BitmapData = jsNative
        member __.destroy(): unit = jsNative
        member __.draw(source: obj, ?x: float, ?y: float, ?width: float, ?height: float, ?blendMode: string, ?roundPx: bool): Phaser.BitmapData = jsNative
        member __.drawFull(parent: obj, ?blendMode: string, ?roundPx: bool): Phaser.BitmapData = jsNative
        member __.drawGroup(group: Phaser.Group, ?blendMode: string, ?roundPx: bool): Phaser.BitmapData = jsNative
        member __.extract(destination: Phaser.BitmapData, r: float, g: float, b: float, ?a: float, ?resize: bool, ?r2: float, ?g2: float, ?b2: float): Phaser.BitmapData = jsNative
        member __.fill(r: float, g: float, b: float, ?a: float): Phaser.BitmapData = jsNative
        member __.generateTexture(key: string): PIXI.Texture = jsNative
        member __.getBounds(?rect: Phaser.Rectangle): Phaser.Rectangle = jsNative
        member __.getFirstPixel(direction: float): obj = jsNative
        member __.getPixel(x: float, y: float, ?out: obj): float = jsNative
        member __.getPixelRGB(x: float, y: float, ?out: obj, ?hsl: bool, ?hsv: bool): obj = jsNative
        member __.getPixel32(x: float, y: float): float = jsNative
        member __.getPixels(rect: Phaser.Rectangle): ImageData = jsNative
        member __.line(x1: float, y1: float, x2: float, y2: float, ?color: string, ?width: float): Phaser.BitmapData = jsNative
        member __.load(source: obj): Phaser.BitmapData = jsNative
        member __.move(x: float, y: float, ?wrap: bool): Phaser.BitmapData = jsNative
        member __.moveH(distance: float, ?wrap: bool): Phaser.BitmapData = jsNative
        member __.moveV(distance: float, ?wrap: bool): Phaser.BitmapData = jsNative
        member __.processPixel(callback: Func<float, float, float, unit>, callbackContext: obj, ?x: float, ?y: float, ?width: float, ?height: float): Phaser.BitmapData = jsNative
        member __.processPixelRGB(callback: Func<ColorComponents, float, float, unit>, callbackContext: obj, ?x: float, ?y: float, ?width: float, ?height: float): Phaser.BitmapData = jsNative
        member __.rect(x: float, y: float, width: float, height: float, ?fillStyle: string): Phaser.BitmapData = jsNative
        member __.render(): Phaser.BitmapData = jsNative
        member __.replaceRGB(r1: float, g1: float, b1: float, a1: float, r2: float, g2: float, b2: float, a2: float, ?region: Phaser.Rectangle): Phaser.BitmapData = jsNative
        member __.resize(width: float, height: float): Phaser.BitmapData = jsNative
        member __.resizeFrame(parent: obj, width: float, height: float): unit = jsNative
        member __.setHSL(?h: float, ?s: float, ?l: float, ?region: Phaser.Rectangle): Phaser.BitmapData = jsNative
        member __.setPixel(x: float, y: float, red: float, green: float, blue: float, ?immediate: bool): Phaser.BitmapData = jsNative
        member __.setPixel32(x: float, y: float, red: float, green: float, blue: float, alpha: float, ?immediate: bool): Phaser.BitmapData = jsNative
        member __.shadow(color: string, ?blur: float, ?x: float, ?y: float): Phaser.BitmapData = jsNative
        member __.shiftHSL(?h: float, ?s: float, ?l: float, ?region: Phaser.Rectangle): Phaser.BitmapData = jsNative
        member __.text(text: string, ?x: float, ?y: float, ?font: string, ?color: string, ?shadow: bool): Phaser.BitmapData = jsNative
        member __.textureLine(line: Phaser.Line, key: string, ?repeat: string): Phaser.BitmapData = jsNative
        member __.update(?x: float, ?y: float, ?width: float, ?height: float): Phaser.BitmapData = jsNative

    and [<AllowNullLiteral>] [<Import("BitmapText","Phaser")>] BitmapText(game: Phaser.Game, x: float, y: float, font: string, ?text: string, ?size: float, ?align: string) =
        // interface PIXI.DisplayObjectContainer
        member __.align with get(): string = jsNative and set(v: string): unit = jsNative
        member __.alive with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.anchor with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.animations with get(): Phaser.AnimationManager = jsNative and set(v: Phaser.AnimationManager): unit = jsNative
        member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
        member __.autoCull with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.body with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
        member __.cameraOffset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.checkWorldBounds with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.data with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.destroyPhase with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.debug with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.dirty with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.events with get(): Phaser.Events = jsNative and set(v: Phaser.Events): unit = jsNative
        member __.exists with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.fixedToCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.font with get(): string = jsNative and set(v: string): unit = jsNative
        member __.fontSize with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fresh with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.input with get(): Phaser.InputHandler = jsNative and set(v: Phaser.InputHandler): unit = jsNative
        member __.inputEnabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.inCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.inWorld with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.key with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.left with get(): float = jsNative and set(v: float): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.components with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.lifespan with get(): float = jsNative and set(v: float): unit = jsNative
        member __.maxWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.offsetX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.offsetY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.outOfBoundsKill with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.pendingDestroy with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.physicsType with get(): float = jsNative and set(v: float): unit = jsNative
        member __.previousPosition with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.previousRotation with get(): float = jsNative and set(v: float): unit = jsNative
        member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.renderOrderID with get(): float = jsNative and set(v: float): unit = jsNative
        member __.right with get(): float = jsNative and set(v: float): unit = jsNative
        member __.text with get(): string = jsNative and set(v: string): unit = jsNative
        member __.smoothed with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.textWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.textHeight with get(): float = jsNative and set(v: float): unit = jsNative
        member __.tint with get(): float = jsNative and set(v: float): unit = jsNative
        member __.top with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.world with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.z with get(): float = jsNative and set(v: float): unit = jsNative
        member __.alignIn(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): obj = jsNative
        member __.alignTo(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): obj = jsNative
        member __.destroy(?destroyChildren: bool): unit = jsNative
        member __.kill(): unit = jsNative
        member __.postUpdate(): unit = jsNative
        member __.preUpdate(): unit = jsNative
        member __.purgeGlyphs(): float = jsNative
        member __.reset(x: float, y: float, ?health: float): Phaser.BitmapText = jsNative
        member __.revive(?health: float): Phaser.BitmapText = jsNative
        member __.scanLine(data: obj, scale: float, text: string): obj = jsNative
        member __.setText(text: string): unit = jsNative
        member __.update(): unit = jsNative
        member __.updateText(): unit = jsNative
        member __.updateTransform(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Bullet","Phaser")>] Bullet(game: Phaser.Game, x: float, y: float, ?key: obj, ?frame: obj) =
        inherit Phaser.Sprite()
        member __.kill(): Phaser.Bullet = jsNative
        member __.update(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Button","Phaser")>] Button(game: Phaser.Game, ?x: float, ?y: float, ?key: string, ?callback: Function, ?callbackContext: obj, ?overFrame: U2<string, float>, ?outFrame: U2<string, float>, ?downFrame: U2<string, float>, ?upFrame: U2<string, float>) =
        inherit Phaser.Image()
        member __.forceOut with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.freezeFrames with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.onDownSound with get(): U2<Phaser.Sound, Phaser.AudioSprite> = jsNative and set(v: U2<Phaser.Sound, Phaser.AudioSprite>): unit = jsNative
        member __.onDownSoundMarker with get(): string = jsNative and set(v: string): unit = jsNative
        member __.onInputDown with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onInputOut with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onInputOver with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onInputUp with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onOutSound with get(): U2<Phaser.Sound, Phaser.AudioSprite> = jsNative and set(v: U2<Phaser.Sound, Phaser.AudioSprite>): unit = jsNative
        member __.onOutSoundMarker with get(): string = jsNative and set(v: string): unit = jsNative
        member __.onOverSound with get(): U2<Phaser.Sound, Phaser.AudioSprite> = jsNative and set(v: U2<Phaser.Sound, Phaser.AudioSprite>): unit = jsNative
        member __.onOverSoundMarker with get(): string = jsNative and set(v: string): unit = jsNative
        member __.onOverMouseOnly with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.onUpSound with get(): U2<Phaser.Sound, Phaser.AudioSprite> = jsNative and set(v: U2<Phaser.Sound, Phaser.AudioSprite>): unit = jsNative
        member __.onUpSoundMaker with get(): string = jsNative and set(v: string): unit = jsNative
        member __.physicsType with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.clearFrames(): unit = jsNative
        member __.setDownSound(sound: U2<Phaser.Sound, Phaser.AudioSprite>, ?marker: string): unit = jsNative
        member __.setFrames(?overFrame: U2<string, float>, ?outFrame: U2<string, float>, ?downFrame: U2<string, float>, ?upFrame: U2<string, float>): unit = jsNative
        member __.onInputOverHandler(sprite: Phaser.Button, pointer: Phaser.Pointer): unit = jsNative
        member __.onInputOutHandler(sprite: Phaser.Button, pointer: Phaser.Pointer): unit = jsNative
        member __.onInputDownHandler(sprite: Phaser.Button, pointer: Phaser.Pointer): unit = jsNative
        member __.onInputUpHandler(sprite: Phaser.Button, pointer: Phaser.Pointer, isOver: bool): unit = jsNative
        member __.removedFromWorld(): unit = jsNative
        member __.setOutSound(sound: U2<Phaser.Sound, Phaser.AudioSprite>, ?marker: string): unit = jsNative
        member __.setOverSound(sound: U2<Phaser.Sound, Phaser.AudioSprite>, ?marker: string): unit = jsNative
        member __.setSounds(?overSound: U2<Phaser.Sound, Phaser.AudioSprite>, ?overMarker: string, ?downSound: U2<Phaser.Sound, Phaser.AudioSprite>, ?downMarker: string, ?outSound: U2<Phaser.Sound, Phaser.AudioSprite>, ?outMarker: string, ?upSound: U2<Phaser.Sound, Phaser.AudioSprite>, ?upMarker: string): unit = jsNative
        member __.setState(newState: float): unit = jsNative
        member __.setUpSound(sound: U2<Phaser.Sound, Phaser.AudioSprite>, ?marker: string): unit = jsNative

    and [<AllowNullLiteral>] [<Import("PointerMode","Phaser")>] PointerMode() =
        member __.CURSOR with get(): float = jsNative and set(v: float): unit = jsNative
        member __.CONTACT with get(): float = jsNative and set(v: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Cache","Phaser")>] Cache(game: Phaser.Game) =
        member __.BINARY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BITMAPDATA with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BITMAPFONT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.CANVAS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.IMAGE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.JSON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PHYSICS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.RENDER_TEXTURE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SHADER with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SOUND with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SPRITE_SHEET with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TEXT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TEXTURE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TEXTURE_ATLAS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TILEMAP with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XML with get(): float = jsNative and set(v: float): unit = jsNative
        member __.VIDEO with get(): float = jsNative and set(v: float): unit = jsNative
        member __.DEFAULT with get(): PIXI.Texture = jsNative and set(v: PIXI.Texture): unit = jsNative
        member __.MISSING with get(): PIXI.Texture = jsNative and set(v: PIXI.Texture): unit = jsNative
        member __.autoResolveURL with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.onSoundUnlock with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.addBinary(key: string, binaryData: obj): unit = jsNative
        member __.addBitmapData(key: string, bitmapData: Phaser.BitmapData, ?frameData: Phaser.FrameData): Phaser.BitmapData = jsNative
        member __.addBitmapFont(key: string, texture: Phaser.RetroFont): unit = jsNative
        member __.addBitmapFont(key: string, url: string, data: obj, atlasData: obj, atlasType: string, ?xSpacing: float, ?ySpacing: float): unit = jsNative
        member __.addCanvas(key: string, canvas: HTMLCanvasElement, ?context: CanvasRenderingContext2D): unit = jsNative
        member __.addDefaultImage(): unit = jsNative
        member __.addImage(key: string, url: string, data: obj): HTMLImageElement = jsNative
        member __.addJSON(key: string, urL: string, data: obj): unit = jsNative
        member __.addMissingImage(): unit = jsNative
        member __.addPhysicsData(key: string, url: string, JSONData: obj, format: float): unit = jsNative
        member __.addRenderTexture(key: string, texture: RenderTexture): unit = jsNative
        member __.addShader(key: string, url: string, data: obj): unit = jsNative
        member __.addSound(key: string, url: string, data: obj, webAudio: bool, audioTag: bool): unit = jsNative
        member __.addSpriteSheet(key: string, url: string, data: obj, frameWidth: float, frameHeight: float, ?frameMax: float, ?margin: float, ?spacing: float): unit = jsNative
        member __.addText(key: string, url: string, data: obj): unit = jsNative
        member __.addTextureAtlas(key: string, url: string, data: obj, atlasData: obj, format: float): unit = jsNative
        member __.addTilemap(key: string, url: string, mapData: obj, format: float): unit = jsNative
        member __.addVideo(key: string, url: string, data: obj, ?isBlob: bool): unit = jsNative
        member __.addXML(key: string, url: string, data: obj): unit = jsNative
        member __.checkBinaryKey(key: string): bool = jsNative
        member __.checkBitmapDataKey(key: string): bool = jsNative
        member __.checkBitmapFontKey(key: string): bool = jsNative
        member __.checkCanvasKey(key: string): bool = jsNative
        member __.checkImageKey(key: string): bool = jsNative
        member __.checkJSONKey(key: string): bool = jsNative
        member __.checkKey(cache: float, key: string): bool = jsNative
        member __.checkPhysicsKey(key: string): bool = jsNative
        member __.checkRenderTextureKey(key: string): bool = jsNative
        member __.checkShaderKey(key: string): bool = jsNative
        member __.checkSoundKey(key: string): bool = jsNative
        member __.checkTextKey(key: string): bool = jsNative
        member __.checkTextureKey(key: string): bool = jsNative
        member __.checkTilemapKey(key: string): bool = jsNative
        member __.checkURL(url: string): obj = jsNative
        member __.checkUrl(url: string): obj = jsNative
        member __.checkXMLKey(key: string): bool = jsNative
        member __.checkVideoKey(key: string): bool = jsNative
        member __.clearGLTextures(): unit = jsNative
        member __.decodedSound(key: string, data: obj): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.getBaseTexture(key: string, ?cache: float): PIXI.BaseTexture = jsNative
        member __.getBinary(key: string): obj = jsNative
        member __.getBitmapData(key: string): Phaser.BitmapData = jsNative
        member __.getBitmapFont(key: string): Phaser.BitmapFont = jsNative
        member __.getCanvas(key: string): HTMLCanvasElement = jsNative
        member __.getFrame(key: string, ?cache: float): Phaser.Frame = jsNative
        member __.getFrameByIndex(key: string, index: float, ?cache: float): Phaser.Frame = jsNative
        member __.getFrameByName(key: string, name: string, ?cache: float): Phaser.Frame = jsNative
        member __.getFrameCount(key: string, ?cache: float): float = jsNative
        member __.getFrameData(key: string, ?cache: float): Phaser.FrameData = jsNative
        member __.getImage(key: string, ?full: bool): HTMLImageElement = jsNative
        member __.getItem(key: string, cache: float, ?``method``: string, ?property: string): obj = jsNative
        member __.getJSON(key: string, ?clone: bool): obj = jsNative
        member __.getKeys(cache: float): ResizeArray<string> = jsNative
        member __.getPhysicsData(key: string, ?``object``: string, ?fixtureKey: string): ResizeArray<obj> = jsNative
        member __.getRenderTexture(key: string): Phaser.CachedRenderTexture = jsNative
        member __.getShader(key: string): string = jsNative
        member __.getSound(key: string): Phaser.Sound = jsNative
        member __.getSoundData(key: string): obj = jsNative
        member __.getSpriteSheetKey(key: string): bool = jsNative
        member __.getText(key: string): string = jsNative
        member __.getTextKeys(): ResizeArray<string> = jsNative
        member __.getTexture(key: string): Phaser.RenderTexture = jsNative
        member __.getTextureAtlasKey(key: string): bool = jsNative
        member __.getTextureFrame(key: string): Phaser.Frame = jsNative
        member __.getTilemap(key: string): obj = jsNative
        member __.getTilemapData(key: string): obj = jsNative
        member __.getURL(url: string): obj = jsNative
        member __.getXML(key: string): obj = jsNative
        member __.getVideo(key: string): Phaser.Video = jsNative
        member __.hasFrameData(key: string, ?cache: float): bool = jsNative
        member __.isSoundDecoded(key: string): bool = jsNative
        member __.isSoundReady(key: string): bool = jsNative
        member __.isSpriteSheet(key: string): bool = jsNative
        member __.reloadSound(key: string): unit = jsNative
        member __.reloadSoundComplete(key: string): unit = jsNative
        member __.removeBinary(key: string): unit = jsNative
        member __.removeBitmapData(key: string): unit = jsNative
        member __.removeBitmapFont(key: string): unit = jsNative
        member __.removeCanvas(key: string): unit = jsNative
        member __.removeImage(key: string, ?removeFromPixi: bool): unit = jsNative
        member __.removeJSON(key: string): unit = jsNative
        member __.removePhysics(key: string): unit = jsNative
        member __.removeRenderTexture(key: string): unit = jsNative
        member __.removeShader(key: string): unit = jsNative
        member __.removeSound(key: string): unit = jsNative
        member __.removeSpriteSheet(key: string): unit = jsNative
        member __.removeText(key: string): unit = jsNative
        member __.removeTextureAtlas(key: string): unit = jsNative
        member __.removeTilemap(key: string): unit = jsNative
        member __.removeXML(key: string): unit = jsNative
        member __.removeVideo(key: string): unit = jsNative
        member __.updateFrameData(key: string, frameData: obj, ?cache: float): unit = jsNative
        member __.updateSound(key: string, property: string, value: Phaser.Sound): unit = jsNative

    and [<AllowNullLiteral>] CachedRenderTexture =
        abstract frame: Phaser.Frame with get, set
        abstract texture: Phaser.RenderTexture with get, set

    and [<AllowNullLiteral>] [<Import("Camera","Phaser")>] Camera(game: Phaser.Game, id: float, x: float, y: float, width: float, height: float) =
        member __.FOLLOW_LOCKON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.FOLLOW_PLATFORMER with get(): float = jsNative and set(v: float): unit = jsNative
        member __.FOLLOW_TOPDOWN with get(): float = jsNative and set(v: float): unit = jsNative
        member __.FOLLOW_TOPDOWN_TIGHT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SHAKE_BOTH with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SHAKE_HORIZONTAL with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SHAKE_VERTICAL with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ENABLE_FX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.atLimit with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.bounds with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.deadzone with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.displayObject with get(): PIXI.DisplayObject = jsNative and set(v: PIXI.DisplayObject): unit = jsNative
        member __.id with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fx with get(): Phaser.Graphics = jsNative and set(v: Phaser.Graphics): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.lerp with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.roundPx with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.scale with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.shakeIntensity with get(): float = jsNative and set(v: float): unit = jsNative
        member __.onFadeComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onFlashComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onShakeComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.target with get(): Phaser.Sprite = jsNative and set(v: Phaser.Sprite): unit = jsNative
        member __.totalInView with get(): float = jsNative and set(v: float): unit = jsNative
        member __.view with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.visible with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.world with get(): Phaser.World = jsNative and set(v: Phaser.World): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.checkBounds(): unit = jsNative
        member __.fade(?color: float, ?duration: float, ?force: bool): bool = jsNative
        member __.flash(?color: float, ?duration: float, ?force: bool): bool = jsNative
        member __.focusOn(displayObject: PIXI.DisplayObject): unit = jsNative
        member __.focusOnXY(x: float, y: float): unit = jsNative
        member __.follow(target: Phaser.Sprite, ?style: float, ?lerpX: float, ?lerpY: float): unit = jsNative
        member __.reset(): unit = jsNative
        member __.resetFX(): unit = jsNative
        member __.setBoundsToWorld(): unit = jsNative
        member __.setPosition(x: float, y: float): unit = jsNative
        member __.setSize(width: float, height: float): unit = jsNative
        member __.shake(?intensity: float, ?duration: float, ?force: bool, ?direction: float, ?shakeBounds: bool): bool = jsNative
        member __.unfollow(): unit = jsNative
        member __.update(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Canvas","Phaser")>] Canvas() =
        static member addToDOM(canvas: HTMLCanvasElement, parent: HTMLElement, ?overflowHidden: bool): HTMLCanvasElement = jsNative
        static member create(parent: HTMLDivElement, ?width: float, ?height: float, ?id: string, ?skipPool: bool): HTMLCanvasElement = jsNative
        static member getSmoothingEnabled(context: CanvasRenderingContext2D): bool = jsNative
        static member getSmoothingPrefix(context: CanvasRenderingContext2D): string = jsNative
        static member removeFromDOM(canvas: HTMLCanvasElement): unit = jsNative
        static member setBackgroundColor(canvas: HTMLCanvasElement, color: string): HTMLCanvasElement = jsNative
        static member setImageRenderingBicubic(canvas: HTMLCanvasElement): HTMLCanvasElement = jsNative
        static member setImageRenderingCrisp(canvas: HTMLCanvasElement): HTMLCanvasElement = jsNative
        static member setSmoothingEnabled(context: CanvasRenderingContext2D, value: bool): CanvasRenderingContext2D = jsNative
        static member setTouchAction(canvas: HTMLCanvasElement, value: string): HTMLCanvasElement = jsNative
        static member setTransform(context: CanvasRenderingContext2D, translateX: float, translateY: float, scaleX: float, scaleY: float, skewX: float, skewY: float): CanvasRenderingContext2D = jsNative
        static member setUserSelect(canvas: HTMLCanvasElement, ?value: string): HTMLCanvasElement = jsNative

    and [<AllowNullLiteral>] [<Import("Circle","Phaser")>] Circle(?x: float, ?y: float, ?diameter: float) =
        member __.area with get(): float = jsNative and set(v: float): unit = jsNative
        member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
        member __.diameter with get(): float = jsNative and set(v: float): unit = jsNative
        member __.empty with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.left with get(): float = jsNative and set(v: float): unit = jsNative
        member __.radius with get(): float = jsNative and set(v: float): unit = jsNative
        member __.right with get(): float = jsNative and set(v: float): unit = jsNative
        member __.top with get(): float = jsNative and set(v: float): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        static member circumferencePoint(a: Phaser.Circle, angle: float, asDegrees: bool, ?out: Phaser.Point): Phaser.Point = jsNative
        static member contains(a: Phaser.Circle, x: float, y: float): bool = jsNative
        static member equals(a: Phaser.Circle, b: Phaser.Circle): bool = jsNative
        static member intersects(a: Phaser.Circle, b: Phaser.Circle): bool = jsNative
        static member intersectsRectangle(c: Phaser.Circle, r: Phaser.Rectangle): bool = jsNative
        member __.circumference(): float = jsNative
        member __.circumferencePoint(angle: float, ?asDegrees: bool, ?out: Phaser.Point): Phaser.Point = jsNative
        member __.clone(output: Phaser.Circle): Phaser.Circle = jsNative
        member __.contains(x: float, y: float): bool = jsNative
        member __.copyFrom(source: obj): Circle = jsNative
        member __.copyTo(dest: obj): obj = jsNative
        member __.distance(dest: obj, ?round: bool): float = jsNative
        member __.getBounds(): Phaser.Rectangle = jsNative
        member __.offset(dx: float, dy: float): Phaser.Circle = jsNative
        member __.offsetPoint(point: Phaser.Point): Phaser.Circle = jsNative
        member __.random(?out: Phaser.Point): Phaser.Point = jsNative
        member __.scale(x: float, ?y: float): Phaser.Rectangle = jsNative
        member __.setTo(x: float, y: float, diameter: float): Circle = jsNative
        member __.toString(): string = jsNative

    and [<AllowNullLiteral>] [<Import("Color","Phaser")>] Color() =
        static member componentToHex(color: float): string = jsNative
        static member createColor(?r: float, ?g: float, ?b: float, ?a: float, ?h: float, ?s: float, ?l: float, ?v: float): ColorComponents = jsNative
        static member fromRGBA(rgba: float, ?out: ColorComponents): ColorComponents = jsNative
        static member getAlpha(color: float): float = jsNative
        static member getAlphaFloat(color: float): float = jsNative
        static member getBlue(color: float): float = jsNative
        static member getColor(red: float, green: float, blue: float): float = jsNative
        static member getColor32(alpha: float, red: float, green: float, blue: float): float = jsNative
        static member getGreen(color: float): float = jsNative
        static member getRandomColor(?min: float, ?max: float, ?alpha: float): float = jsNative
        static member getRed(color: float): float = jsNative
        static member getRGB(color: float): RGBColor = jsNative
        static member getWebRGB(color: U2<float, RGBColor>): string = jsNative
        static member hexToRGB(h: string): float = jsNative
        static member hexToColor(hex: string, ?out: ColorComponents): ColorComponents = jsNative
        static member HSLtoRGB(h: float, s: float, l: float, ?out: ColorComponents): ColorComponents = jsNative
        static member HSLColorWheel(?s: float, ?l: float): ResizeArray<ColorComponents> = jsNative
        static member HSVtoRGB(h: float, s: float, v: float, ?out: ColorComponents): ColorComponents = jsNative
        static member HSVColorWheel(?s: float, ?v: float): ResizeArray<ColorComponents> = jsNative
        static member hueToColor(p: float, q: float, t: float): float = jsNative
        static member interpolateColor(color1: float, color2: float, steps: float, currentStep: float, ?alpha: float): float = jsNative
        static member interpolateColorWithRGB(color: float, r: float, g: float, b: float, steps: float, currentStep: float): float = jsNative
        static member interpolateRGB(r1: float, g1: float, b1: float, r2: float, g2: float, b2: float, steps: float, currentStep: float): float = jsNative
        static member packPixel(r: float, g: float, b: float, a: float): float = jsNative
        static member RGBtoHSL(r: float, g: float, b: float, ?out: ColorComponents): ColorComponents = jsNative
        static member RGBtoHSV(r: float, g: float, b: float, ?out: ColorComponents): ColorComponents = jsNative
        static member RGBtoString(r: float, g: float, b: float, ?a: float, ?prefix: string): string = jsNative
        static member toRGBA(r: float, g: float, b: float, a: float): float = jsNative
        static member toABGR(r: float, g: float, b: float, a: float): float = jsNative
        static member unpackPixel(rgba: float, ?out: ColorComponents, ?hsl: bool, ?hsv: bool): ColorComponents = jsNative
        static member updateColor(out: ColorComponents): ColorComponents = jsNative
        static member valueToColor(value: string, ?out: ColorComponents): ColorComponents = jsNative
        static member webToColor(web: string, ?out: ColorComponents): ColorComponents = jsNative
        static member blendNormal(a: float): float = jsNative
        static member blendLighten(a: float, b: float): float = jsNative
        static member blendDarken(a: float, b: float): float = jsNative
        static member blendMultiply(a: float, b: float): float = jsNative
        static member blendAverage(a: float, b: float): float = jsNative
        static member blendAdd(a: float, b: float): float = jsNative
        static member blendSubtract(a: float, b: float): float = jsNative
        static member blendDifference(a: float, b: float): float = jsNative
        static member blendNegation(a: float, b: float): float = jsNative
        static member blendScreen(a: float, b: float): float = jsNative
        static member blendExclusion(a: float, b: float): float = jsNative
        static member blendOverlay(a: float, b: float): float = jsNative
        static member blendSoftLight(a: float, b: float): float = jsNative
        static member blendHardLight(a: float, b: float): float = jsNative
        static member blendColorDodge(a: float, b: float): float = jsNative
        static member blendColorBurn(a: float, b: float): float = jsNative
        static member blendLinearDodge(a: float, b: float): float = jsNative
        static member blendLinearBurn(a: float, b: float): float = jsNative
        static member blendLinearLight(a: float, b: float): float = jsNative
        static member blendVividLight(a: float, b: float): float = jsNative
        static member blendPinLight(a: float, b: float): float = jsNative
        static member blendHardMix(a: float, b: float): float = jsNative
        static member blendReflect(a: float, b: float): float = jsNative
        static member blendGlow(a: float, b: float): float = jsNative
        static member blendPhoenix(a: float, b: float): float = jsNative

    and [<AllowNullLiteral>] RGBColor =
        abstract r: float with get, set
        abstract g: float with get, set
        abstract b: float with get, set
        abstract a: float with get, set

    and [<AllowNullLiteral>] ColorComponents =
        inherit RGBColor
        abstract h: float with get, set
        abstract s: float with get, set
        abstract v: float with get, set
        abstract l: float with get, set
        abstract color: float with get, set
        abstract color32: float with get, set
        abstract rgba: string with get, set

    and [<AllowNullLiteral>] [<Import("Create","Phaser")>] Create(game: Phaser.Game) =
        member __.PALETTE_ARNE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PALETTE_JMP with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PALETTE_CGA with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PALETTE_C64 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PALETTE_JAPANESE_MACHINE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.bmd with get(): Phaser.BitmapData = jsNative and set(v: Phaser.BitmapData): unit = jsNative
        member __.canvas with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
        member __.ctx with get(): CanvasRenderingContext2D = jsNative and set(v: CanvasRenderingContext2D): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.palettes with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.grid(key: string, width: float, height: float, cellWidth: float, cellHeight: float, color: string): PIXI.Texture = jsNative
        member __.texture(key: string, data: obj, ?pixelWidth: float, ?pixelHeight: float, ?palette: float): PIXI.Texture = jsNative

    and [<AllowNullLiteral>] CursorKeys =
        abstract up: Phaser.Key with get, set
        abstract down: Phaser.Key with get, set
        abstract left: Phaser.Key with get, set
        abstract right: Phaser.Key with get, set

    and [<AllowNullLiteral>] [<Import("Device","Phaser")>] Device() =
        member __.LITTLE_ENDIAN with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.onInitialized with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.whenReady with get(): Func<Function, obj, unit> = jsNative and set(v: Func<Function, obj, unit>): unit = jsNative
        member __.android with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.arora with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.audioData with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.cancelFullScreen with get(): string = jsNative and set(v: string): unit = jsNative
        member __.canvas with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.chrome with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.chromeOS with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.chromeVersion with get(): float = jsNative and set(v: float): unit = jsNative
        member __.cocoonJS with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.cocoonJSApp with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.cordova with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.crosswalk with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.css3D with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.desktop with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.deviceReadyAt with get(): float = jsNative and set(v: float): unit = jsNative
        member __.electron with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.ejecta with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.epiphany with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.file with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.fileSystem with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.firefox with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.firefoxVersion with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fullScreen with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.fullScreenKeyboard with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.getUserMedia with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.h264Video with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.hlsVideo with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.ie with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.ieVersion with get(): float = jsNative and set(v: float): unit = jsNative
        member __.iOS with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.iOSVersion with get(): float = jsNative and set(v: float): unit = jsNative
        member __.initialized with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.iPad with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.iPhone with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.iPhone4 with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.kindle with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.linux with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.littleEndian with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.localStorage with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.m4a with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.macOS with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.midori with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.mobileSafari with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.mp3 with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.mp4Video with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.mspointer with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.node with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.nodeWebkit with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.ogg with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.oggVideo with get(): float = jsNative and set(v: float): unit = jsNative
        member __.opera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.opus with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.pixelRatio with get(): float = jsNative and set(v: float): unit = jsNative
        member __.pointerLock with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.quirksMode with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.requestFullScreen with get(): string = jsNative and set(v: string): unit = jsNative
        member __.safari with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.silk with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.support32bit with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.touch with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.trident with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.tridentVersion with get(): float = jsNative and set(v: float): unit = jsNative
        member __.typedArray with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.vibration with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.vita with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.wav with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.webApp with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.webAudio with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.webGL with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.webm with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.webmVideo with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.windows with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.windowsPhone with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.wheelEvent with get(): string = jsNative and set(v: string): unit = jsNative
        member __.worker with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.wp9Video with get(): bool = jsNative and set(v: bool): unit = jsNative
        static member checkFullScreenSupport(): unit = jsNative
        static member canPlayAudio(``type``: string): bool = jsNative
        static member canPlayVideo(``type``: string): bool = jsNative
        static member isConsoleOpen(): bool = jsNative
        static member isAndroidStockBrowser(): string = jsNative

    and [<AllowNullLiteral>] [<Import("DeviceButton","Phaser")>] DeviceButton(parent: U2<Phaser.Pointer, Phaser.SinglePad>, butonCode: float) =
        member __.buttonCode with get(): float = jsNative and set(v: float): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.isDown with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isUp with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.onDown with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onFloat with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onUp with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.pad with get(): Phaser.Gamepad = jsNative and set(v: Phaser.Gamepad): unit = jsNative
        member __.repeats with get(): float = jsNative and set(v: float): unit = jsNative
        member __.timeDown with get(): float = jsNative and set(v: float): unit = jsNative
        member __.timeUp with get(): float = jsNative and set(v: float): unit = jsNative
        member __.value with get(): float = jsNative and set(v: float): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.justPressed(?duration: float): bool = jsNative
        member __.justReleased(?duration: float): bool = jsNative
        member __.processButtonDown(value: float): unit = jsNative
        member __.processButtonFloat(value: float): unit = jsNative
        member __.processButtonUp(value: float): unit = jsNative
        member __.reset(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Ellipse","Phaser")>] Ellipse(?x: float, ?y: float, ?width: float, ?height: float) =
        member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
        member __.empty with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.left with get(): float = jsNative and set(v: float): unit = jsNative
        member __.right with get(): float = jsNative and set(v: float): unit = jsNative
        member __.top with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        static member constains(a: Phaser.Ellipse, x: float, y: float): bool = jsNative
        member __.clone(output: Phaser.Ellipse): Phaser.Ellipse = jsNative
        member __.contains(x: float, y: float): bool = jsNative
        member __.copyFrom(source: obj): Phaser.Ellipse = jsNative
        member __.copyTo(dest: obj): obj = jsNative
        member __.getBounds(): Phaser.Rectangle = jsNative
        member __.random(?out: Phaser.Point): Phaser.Point = jsNative
        member __.setTo(x: float, y: float, width: float, height: float): Phaser.Ellipse = jsNative
        member __.toString(): string = jsNative

    and [<AllowNullLiteral>] [<Import("Events","Phaser")>] Events(sprite: Phaser.Sprite) =
        member __.parent with get(): Phaser.Sprite = jsNative and set(v: Phaser.Sprite): unit = jsNative
        member __.onAddedToGroup with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onRemovedFromGroup with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onRemovedFromWorld with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onKilled with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onRevived with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onOutOfBounds with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onEnterBounds with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onInputOver with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onInputOut with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onInputDown with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onInputUp with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onDestroy with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onDragStart with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onDragStop with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onDragUpdate with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onAnimationStart with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onAnimationComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onAnimationLoop with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.destroy(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Filter","Phaser")>] Filter(game: Phaser.Game, uniforms: obj, fragmentSrc: U2<string, ResizeArray<string>>) =
        // interface PIXI.AbstractFilter
        member __.dirty with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fragmentSrc with get(): U2<string, ResizeArray<string>> = jsNative and set(v: U2<string, ResizeArray<string>>): unit = jsNative
        member __.padding with get(): float = jsNative and set(v: float): unit = jsNative
        member __.prevPoint with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.uniforms with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.addToWorld(?x: float, ?y: float, ?width: float, ?height: float, ?anchorX: float, ?anchorY: float): Phaser.Image = jsNative
        member __.apply(frameBuffer: WebGLFramebuffer): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.init([<ParamArray>] args: obj[]): unit = jsNative
        member __.setResolution(width: float, height: float): unit = jsNative
        member __.syncUniforms(): unit = jsNative
        member __.update(?pointer: Phaser.Pointer): unit = jsNative

    and [<AllowNullLiteral>] [<Import("FlexGrid","Phaser")>] FlexGrid(manager: Phaser.ScaleManager, width: float, height: float) =
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.manager with get(): Phaser.ScaleManager = jsNative and set(v: Phaser.ScaleManager): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.boundsCustom with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.boundsFluid with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.boundsFull with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.boundsNone with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.customWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.customHeight with get(): float = jsNative and set(v: float): unit = jsNative
        member __.customOffsetX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.customOffsetY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.positionCustom with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.positionFluid with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.positionFull with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.positionNone with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.scaleCustom with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.scaleFluid with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.scaleFluidInversed with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.scaleFull with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.scaleNone with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.ratioH with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ratioV with get(): float = jsNative and set(v: float): unit = jsNative
        member __.multiplier with get(): float = jsNative and set(v: float): unit = jsNative
        member __.createCustomLayer(width: float, height: float, ?children: ResizeArray<PIXI.DisplayObject>, ?addToWorld: bool): Phaser.FlexLayer = jsNative
        member __.createFluidLayer(children: ResizeArray<PIXI.DisplayObject>): Phaser.FlexLayer = jsNative
        member __.createFullLayer(children: ResizeArray<PIXI.DisplayObject>): Phaser.FlexLayer = jsNative
        member __.createFixedLayer(children: ResizeArray<PIXI.DisplayObject>): Phaser.FlexLayer = jsNative
        member __.debug(): unit = jsNative
        member __.fitSprite(sprite: Phaser.Sprite): unit = jsNative
        member __.onResize(width: float, height: float): unit = jsNative
        member __.refresh(): unit = jsNative
        member __.reset(): unit = jsNative
        member __.setSize(width: float, height: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("FlexLayer","Phaser")>] FlexLayer(manager: Phaser.ScaleManager, position: Phaser.Point, bounds: Phaser.Rectangle, scale: Phaser.Point) =
        inherit Phaser.Group()
        member __.grid with get(): Phaser.FlexGrid = jsNative and set(v: Phaser.FlexGrid): unit = jsNative
        member __.manager with get(): Phaser.ScaleManager = jsNative and set(v: Phaser.ScaleManager): unit = jsNative
        member __.bottomLeft with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.bottomMiddle with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.bottomRight with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.bounds with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.persist with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.scale with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.topLeft with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.topMiddle with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.topRight with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.debug(): unit = jsNative
        member __.resize(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Frame","Phaser")>] Frame(index: float, x: float, y: float, width: float, height: float, name: string) =
        member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
        member __.centerX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.centerY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.distance with get(): float = jsNative and set(v: float): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.index with get(): float = jsNative and set(v: float): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.right with get(): float = jsNative and set(v: float): unit = jsNative
        member __.rotated with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.rotationDirection with get(): string = jsNative and set(v: string): unit = jsNative
        member __.sourceSizeH with get(): float = jsNative and set(v: float): unit = jsNative
        member __.sourceSizeW with get(): float = jsNative and set(v: float): unit = jsNative
        member __.spriteSourceSizeH with get(): float = jsNative and set(v: float): unit = jsNative
        member __.spriteSourceSizeW with get(): float = jsNative and set(v: float): unit = jsNative
        member __.spriteSourceSizeX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.spriteSourceSizeY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.trimmed with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.uuid with get(): string = jsNative and set(v: string): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.clone(): Phaser.Frame = jsNative
        member __.getRect(?out: Phaser.Rectangle): Phaser.Rectangle = jsNative
        member __.setTrim(trimmed: bool, actualWidth: float, actualHeight: float, destX: float, destY: float, destWidth: float, destHeight: float): unit = jsNative
        member __.resize(width: float, height: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("FrameData","Phaser")>] FrameData() =
        member __.total with get(): float = jsNative and set(v: float): unit = jsNative
        member __.addFrame(frame: Frame): Phaser.Frame = jsNative
        member __.checkFrameName(name: string): bool = jsNative
        member __.clone(): Phaser.FrameData = jsNative
        member __.getFrame(index: float): Phaser.Frame = jsNative
        member __.getFrameByName(name: string): Phaser.Frame = jsNative
        member __.getFrameIndexes(?frames: ResizeArray<float>, ?useNumericIndex: bool, ?output: ResizeArray<float>): ResizeArray<float> = jsNative
        member __.getFrameRange(start: float, ``end``: float, output: ResizeArray<Phaser.Frame>): ResizeArray<Phaser.Frame> = jsNative
        member __.getFrames(?frames: ResizeArray<float>, ?useNumericIndex: bool, ?output: ResizeArray<Phaser.Frame>): ResizeArray<Phaser.Frame> = jsNative

    and [<AllowNullLiteral>] IGameConfig =
        abstract enableDebug: bool option with get, set
        abstract width: float option with get, set
        abstract height: float option with get, set
        abstract renderer: float option with get, set
        abstract parent: obj option with get, set
        abstract transparent: bool option with get, set
        abstract antialias: bool option with get, set
        abstract resolution: float option with get, set
        abstract preserveDrawingBuffer: bool option with get, set
        abstract physicsConfig: obj option with get, set
        abstract seed: string option with get, set
        abstract state: Phaser.State option with get, set
        abstract forceSetTimeOut: bool with get, set

    and [<AllowNullLiteral>] [<Import("Game","Phaser")>] Game(config: IGameConfig) =
        member __.add with get(): Phaser.GameObjectFactory = jsNative and set(v: Phaser.GameObjectFactory): unit = jsNative
        member __.antialias with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.cache with get(): Phaser.Cache = jsNative and set(v: Phaser.Cache): unit = jsNative
        member __.camera with get(): Phaser.Camera = jsNative and set(v: Phaser.Camera): unit = jsNative
        member __.canvas with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
        member __.clearBeforeRender with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.config with get(): IGameConfig = jsNative and set(v: IGameConfig): unit = jsNative
        member __.context with get(): CanvasRenderingContext2D = jsNative and set(v: CanvasRenderingContext2D): unit = jsNative
        member __.count with get(): float = jsNative and set(v: float): unit = jsNative
        member __.create with get(): Phaser.Create = jsNative and set(v: Phaser.Create): unit = jsNative
        member __.debug with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.device with get(): Phaser.Device = jsNative and set(v: Phaser.Device): unit = jsNative
        member __.forceSingleUpdate with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.fpsProblemNotifier with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.id with get(): float = jsNative and set(v: float): unit = jsNative
        member __.input with get(): Phaser.Input = jsNative and set(v: Phaser.Input): unit = jsNative
        member __.isBooted with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isRunning with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.load with get(): Phaser.Loader = jsNative and set(v: Phaser.Loader): unit = jsNative
        member __.lockRender with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.make with get(): Phaser.GameObjectCreator = jsNative and set(v: Phaser.GameObjectCreator): unit = jsNative
        member __.math with get(): Phaser.Math = jsNative and set(v: Phaser.Math): unit = jsNative
        member __.net with get(): Phaser.Net = jsNative and set(v: Phaser.Net): unit = jsNative
        member __.onBlur with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onFocus with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onPause with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onResume with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.parent with get(): HTMLElement = jsNative and set(v: HTMLElement): unit = jsNative
        member __.particles with get(): Phaser.Particles = jsNative and set(v: Phaser.Particles): unit = jsNative
        member __.paused with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.pendingStep with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.physics with get(): Phaser.Physics = jsNative and set(v: Phaser.Physics): unit = jsNative
        member __.physicsConfig with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.plugins with get(): PluginManager = jsNative and set(v: PluginManager): unit = jsNative
        member __.preserveDrawingBuffer with get(): Boolean = jsNative and set(v: Boolean): unit = jsNative
        member __.raf with get(): Phaser.RequestAnimationFrame = jsNative and set(v: Phaser.RequestAnimationFrame): unit = jsNative
        member __.renderer with get(): U2<PIXI.CanvasRenderer, PIXI.WebGLRenderer> = jsNative and set(v: U2<PIXI.CanvasRenderer, PIXI.WebGLRenderer>): unit = jsNative
        member __.renderType with get(): float = jsNative and set(v: float): unit = jsNative
        member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
        member __.rnd with get(): Phaser.RandomDataGenerator = jsNative and set(v: Phaser.RandomDataGenerator): unit = jsNative
        member __.scale with get(): Phaser.ScaleManager = jsNative and set(v: Phaser.ScaleManager): unit = jsNative
        member __.scratch with get(): Phaser.BitmapData = jsNative and set(v: Phaser.BitmapData): unit = jsNative
        member __.sound with get(): Phaser.SoundManager = jsNative and set(v: Phaser.SoundManager): unit = jsNative
        member __.stage with get(): Phaser.Stage = jsNative and set(v: Phaser.Stage): unit = jsNative
        member __.state with get(): Phaser.StateManager = jsNative and set(v: Phaser.StateManager): unit = jsNative
        member __.stepCount with get(): float = jsNative and set(v: float): unit = jsNative
        member __.stepping with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.time with get(): Phaser.Time = jsNative and set(v: Phaser.Time): unit = jsNative
        member __.transparent with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.tweens with get(): Phaser.TweenManager = jsNative and set(v: Phaser.TweenManager): unit = jsNative
        member __.currentUpdateID with get(): float = jsNative and set(v: float): unit = jsNative
        member __.updatesThisFrame with get(): float = jsNative and set(v: float): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.world with get(): Phaser.World = jsNative and set(v: Phaser.World): unit = jsNative
        member __.boot(): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.disableStep(): unit = jsNative
        member __.enableStep(): unit = jsNative
        member __.focusGain(``event``: obj): unit = jsNative
        member __.focusLoss(``event``: obj): unit = jsNative
        member __.gamePaused(``event``: obj): unit = jsNative
        member __.gameResumed(``event``: obj): unit = jsNative
        member __.parseConfig(config: obj): unit = jsNative
        member __.removeFromDOM(canvas: HTMLCanvasElement): unit = jsNative
        member __.setUpRenderer(): unit = jsNative
        member __.showDebugHeader(): unit = jsNative
        member __.step(): unit = jsNative
        member __.update(time: float): unit = jsNative
        member __.updateLogic(timeStep: float): unit = jsNative
        member __.updateRender(timeStep: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("GameObjectCreator","Phaser")>] GameObjectCreator(game: Phaser.Game) =
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.world with get(): Phaser.World = jsNative and set(v: Phaser.World): unit = jsNative
        member __.audio(key: string, ?volume: float, ?loop: bool, ?connect: bool): Phaser.Sound = jsNative
        member __.audioSprite(key: string): Phaser.AudioSprite = jsNative
        member __.bitmapData(?width: float, ?height: float, ?key: string, ?addToCache: bool): Phaser.BitmapData = jsNative
        member __.bitmapText(x: float, y: float, font: string, ?text: string, ?size: float, ?align: string): Phaser.BitmapText = jsNative
        member __.button(?x: float, ?y: float, ?key: string, ?callback: Function, ?callbackContext: obj, ?overFrame: obj, ?outFrame: obj, ?downFrame: obj, ?upFrame: obj): Phaser.Button = jsNative
        member __.emitter(?x: float, ?y: float, ?maxParticles: float): obj = jsNative
        member __.filter(filter: obj, [<ParamArray>] args: obj[]): Phaser.Filter = jsNative
        member __.graphics(?x: float, ?y: float): Phaser.Graphics = jsNative
        member __.group(?parent: obj, ?name: string, ?addToStage: bool, ?enableBody: bool, ?physicsBodyType: float): Phaser.Group = jsNative
        member __.image(x: float, y: float, ?key: obj, ?frame: obj): Phaser.Image = jsNative
        member __.renderTexture(?width: float, ?height: float, ?key: obj, ?addToCache: bool): Phaser.RenderTexture = jsNative
        member __.retroFont(font: string, characterWidth: float, characterHeight: float, chars: string, charsPerRow: float, ?xSpacing: float, ?ySpacing: float, ?xOffset: float, ?yOffset: float): Phaser.RetroFont = jsNative
        member __.rope(x: float, y: float, key: obj, ?frame: obj, ?points: ResizeArray<Phaser.Point>): Phaser.Rope = jsNative
        member __.sound(key: string, ?volume: float, ?loop: bool, ?connect: bool): Phaser.Sound = jsNative
        member __.sprite(x: float, y: float, ?key: obj, ?frame: obj): Phaser.Sprite = jsNative
        member __.spriteBatch(parent: obj, ?name: string, ?addToStage: bool): Phaser.SpriteBatch = jsNative
        member __.text(x: float, y: float, ?text: string, ?style: obj): Phaser.Text = jsNative
        member __.tilemap(key: string, ?tileWidth: float, ?tileHeight: float, ?width: float, ?height: float): Phaser.Tilemap = jsNative
        member __.tileSprite(x: float, y: float, width: float, height: float, key: obj, frame: obj): Phaser.TileSprite = jsNative
        member __.tween(obj: obj): Phaser.Tween = jsNative

    and [<AllowNullLiteral>] [<Import("GameObjectFactory","Phaser")>] GameObjectFactory(game: Phaser.Game) =
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.world with get(): Phaser.World = jsNative and set(v: Phaser.World): unit = jsNative
        member __.audio(key: string, ?volume: float, ?loop: bool, ?connect: bool): Phaser.Sound = jsNative
        member __.audioSprite(key: string): Phaser.AudioSprite = jsNative
        member __.bitmapData(?width: float, ?height: float, ?key: string, ?addToCache: bool): Phaser.BitmapData = jsNative
        member __.bitmapText(x: float, y: float, font: string, ?text: string, ?size: float, ?group: Phaser.Group): Phaser.BitmapText = jsNative
        member __.button(?x: float, ?y: float, ?key: string, ?callback: Function, ?callbackContext: obj, ?overFrame: obj, ?outFrame: obj, ?downFrame: obj, ?upFrame: obj, ?group: Phaser.Group): Phaser.Button = jsNative
        member __.emitter(?x: float, ?y: float, ?maxParticles: float): obj = jsNative
        member __.existing(``object``: obj): obj = jsNative
        member __.filter(filter: string, [<ParamArray>] args: obj[]): Phaser.Filter = jsNative
        member __.graphics(x: float, y: float, ?group: Phaser.Group): Phaser.Graphics = jsNative
        member __.group(?parent: obj, ?name: string, ?addToStage: bool, ?enableBody: bool, ?physicsBodyType: float): Phaser.Group = jsNative
        member __.image(x: float, y: float, ?key: obj, ?frame: obj, ?group: Phaser.Group): Phaser.Image = jsNative
        member __.physicsGroup(?physicsBodyType: float, ?parent: obj, ?name: string, ?addToStage: bool): Phaser.Group = jsNative
        member __.plugin(plugin: Phaser.Plugin, [<ParamArray>] parameter: obj[]): Phaser.Plugin = jsNative
        member __.renderTexture(?width: float, ?height: float, ?key: string, ?addToCache: bool): Phaser.RenderTexture = jsNative
        member __.retroFont(font: string, characterWidth: float, characterHeight: float, chars: string, charsPerRow: float, ?xSpacing: float, ?ySpacing: float, ?xOffset: float, ?yOffset: float): Phaser.RetroFont = jsNative
        member __.rope(x: float, y: float, key: obj, ?frame: obj, ?points: ResizeArray<Phaser.Point>): Phaser.Rope = jsNative
        member __.sound(key: string, ?volume: float, ?loop: bool, ?connect: bool): Phaser.Sound = jsNative
        member __.sprite(x: float, y: float, ?key: obj, ?frame: obj, ?group: Phaser.Group): Phaser.Sprite = jsNative
        member __.spriteBatch(parent: obj, ?name: string, ?addToStage: bool): Phaser.Group = jsNative
        member __.text(x: float, y: float, text: string, style: obj, ?group: Phaser.Group): Phaser.Text = jsNative
        member __.tilemap(?key: string, ?tileWidth: float, ?tileHeight: float, ?width: float, ?height: float): Phaser.Tilemap = jsNative
        member __.tileSprite(x: float, y: float, width: float, height: float, ?key: obj, ?frame: obj, ?group: Phaser.Group): Phaser.TileSprite = jsNative
        member __.tween(obj: obj): Phaser.Tween = jsNative
        member __.weapon(?quantity: float, ?key: obj, ?frame: obj, ?group: Phaser.Group): Phaser.Weapon = jsNative
        member __.video(?key: string, ?url: string): Phaser.Video = jsNative

    and [<AllowNullLiteral>] [<Import("Gamepad","Phaser")>] Gamepad(game: Phaser.Game) =
        member __.BUTTON_0 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_1 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_2 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_3 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_4 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_5 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_6 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_7 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_8 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_9 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_10 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_11 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_12 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_13 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_14 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BUTTON_15 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.AXIS_0 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.AXIS_1 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.AXIS_2 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.AXIS_3 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.AXIS_4 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.AXIS_5 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.AXIS_6 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.AXIS_7 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.AXIS_8 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.AXIS_9 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_A with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_B with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_X with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_Y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_LEFT_BUMPER with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_RIGHT_BUMPER with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_LEFT_TRIGGER with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_RIGHT_TRIGGER with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_BACK with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_START with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_STICK_LEFT_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_STICK_RIGHT_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_DPAD_LEFT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_DPAD_RIGHT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_DPAD_UP with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_DPAD_DOWN with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_STICK_LEFT_X with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_STICK_LEFT_Y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_STICK_RIGHT_X with get(): float = jsNative and set(v: float): unit = jsNative
        member __.XBOX360_STICK_RIGHT_Y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_X with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_CIRCLE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_SQUARE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_TRIANGLE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_L1 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_R1 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_L2 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_R2 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_SELECT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_START with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_STICK_LEFT_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_STICK_RIGHT_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_DPAD_UP with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_DPAD_DOWN with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_DPAD_LEFT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_DPAD_RIGHT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_STICK_LEFT_X with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_STICK_LEFT_Y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_STICK_RIGHT_X with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PS3XC_STICK_RIGHT_Y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.active with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.callbackContext with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.enabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.onAxisCallBack with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onConnectCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onDisconnectCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onDownCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onFloatCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onUpCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.pad1 with get(): Phaser.SinglePad = jsNative and set(v: Phaser.SinglePad): unit = jsNative
        member __.pad2 with get(): Phaser.SinglePad = jsNative and set(v: Phaser.SinglePad): unit = jsNative
        member __.pad3 with get(): Phaser.SinglePad = jsNative and set(v: Phaser.SinglePad): unit = jsNative
        member __.pad4 with get(): Phaser.SinglePad = jsNative and set(v: Phaser.SinglePad): unit = jsNative
        member __.padsConnected with get(): float = jsNative and set(v: float): unit = jsNative
        member __.supported with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.addCallbacks(context: obj, callbacks: obj): unit = jsNative
        member __.isDown(buttonCode: float): bool = jsNative
        member __.justPressed(buttonCode: float, ?duration: float): bool = jsNative
        member __.justReleased(buttonCode: float, ?duration: float): bool = jsNative
        member __.reset(): unit = jsNative
        member __.setDeadZones(value: obj): unit = jsNative
        member __.start(): unit = jsNative
        member __.stop(): unit = jsNative
        member __.update(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Graphics","Phaser")>] Graphics(game: Phaser.Game, ?x: float, ?y: float) =
        // interface PIXI.Graphics
        member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
        member __.alive with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.animations with get(): Phaser.AnimationManager = jsNative and set(v: Phaser.AnimationManager): unit = jsNative
        member __.autoCull with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.body with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
        member __.cameraOffset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.checkWorldBounds with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.components with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.data with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.debug with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.destroyPhase with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.exists with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.events with get(): Phaser.Events = jsNative and set(v: Phaser.Events): unit = jsNative
        member __.fixedToCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.key with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.fresh with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.input with get(): Phaser.InputHandler = jsNative and set(v: Phaser.InputHandler): unit = jsNative
        member __.inputEnabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.inCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.inWorld with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.left with get(): float = jsNative and set(v: float): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.lifespan with get(): float = jsNative and set(v: float): unit = jsNative
        member __.offsetX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.offsetY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.outOfBoundsKill with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.pendingDestroy with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.physicsType with get(): float = jsNative and set(v: float): unit = jsNative
        member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.previousPosition with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.previousRotation with get(): float = jsNative and set(v: float): unit = jsNative
        member __.renderOrderID with get(): float = jsNative and set(v: float): unit = jsNative
        member __.right with get(): float = jsNative and set(v: float): unit = jsNative
        member __.top with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.world with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.z with get(): float = jsNative and set(v: float): unit = jsNative
        member __.alignIn(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): obj = jsNative
        member __.alignTo(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): obj = jsNative
        member __.destroy(?destroyChildren: bool): unit = jsNative
        member __.drawTriangle(points: ResizeArray<Phaser.Point>, ?cull: bool): unit = jsNative
        member __.drawTriangles(vertices: U2<ResizeArray<Phaser.Point>, ResizeArray<float>>, ?indices: ResizeArray<float>, ?cull: bool): unit = jsNative
        member __.kill(): Phaser.Graphics = jsNative
        member __.postUpdate(): unit = jsNative
        member __.preUpdate(): unit = jsNative
        member __.reset(x: float, y: float, ?health: float): Phaser.Graphics = jsNative
        member __.revive(?health: float): Phaser.Graphics = jsNative
        member __.update(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Group","Phaser")>] Group(game: Phaser.Game, ?parent: obj, ?name: string, ?addToStage: bool, ?enableBody: bool, ?physicsBodyType: float) =
        // interface PIXI.DisplayObjectContainer
        member __.RETURN_CHILD with get(): float = jsNative and set(v: float): unit = jsNative
        member __.RETURN_NONE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.RETURN_TOTAL with get(): float = jsNative and set(v: float): unit = jsNative
        member __.RETURN_ALL with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SORT_ASCENDING with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SORT_DESCENDING with get(): float = jsNative and set(v: float): unit = jsNative
        member __.alpha with get(): float = jsNative and set(v: float): unit = jsNative
        member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
        member __.alive with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
        member __.cameraOffset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.centerX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.centerY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.classType with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.cursor with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.cursorIndex with get(): float = jsNative and set(v: float): unit = jsNative
        member __.enableBody with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.enableBodyDebug with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.exists with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.fixedToCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.hash with get(): ResizeArray<PIXI.DisplayObject> = jsNative and set(v: ResizeArray<PIXI.DisplayObject>): unit = jsNative
        member __.ignoreDestroy with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.inputEnableChildren with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.left with get(): float = jsNative and set(v: float): unit = jsNative
        member __.length with get(): float = jsNative and set(v: float): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.onChildInputDown with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onChildInputUp with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onChildInputOver with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onChildInputOut with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onDestroy with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.pendingDestroy with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.physicsBodyType with get(): float = jsNative and set(v: float): unit = jsNative
        member __.physicsType with get(): float = jsNative and set(v: float): unit = jsNative
        member __.physicsSortDirection with get(): float = jsNative and set(v: float): unit = jsNative
        member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.right with get(): float = jsNative and set(v: float): unit = jsNative
        member __.rotation with get(): float = jsNative and set(v: float): unit = jsNative
        member __.scale with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.top with get(): float = jsNative and set(v: float): unit = jsNative
        member __.total with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.visible with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.z with get(): float = jsNative and set(v: float): unit = jsNative
        member __.add(child: obj, ?silent: bool, ?index: float): obj = jsNative
        member __.addAll(property: string, amount: float, checkAlive: bool, checkVisible: bool): unit = jsNative
        member __.addAt(child: obj, index: float, ?silent: bool): obj = jsNative
        member __.addMultiple(children: ResizeArray<obj>, ?silent: bool): ResizeArray<obj> = jsNative
        member __.addToHash(child: PIXI.DisplayObject): bool = jsNative
        member __.align(width: float, height: float, cellWidth: float, cellHeight: float, ?position: float, ?offset: float): bool = jsNative
        member __.alignIn(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): Phaser.Group = jsNative
        member __.alignTo(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): Phaser.Group = jsNative
        member __.bringToTop(child: obj): obj = jsNative
        member __.callAll(``method``: string, context: obj, [<ParamArray>] parameters: obj[]): unit = jsNative
        member __.callAllExists(callback: string, existsValue: bool, [<ParamArray>] parameters: obj[]): unit = jsNative
        member __.callbackFromArray(child: obj, callback: Function, length: float): unit = jsNative
        member __.checkAll(key: ResizeArray<string>, value: obj, ?checkAlive: bool, ?checkVisible: bool, ?force: bool): bool = jsNative
        member __.checkProperty(child: obj, key: ResizeArray<string>, value: obj, ?force: bool): bool = jsNative
        member __.countDead(): float = jsNative
        member __.countLiving(): float = jsNative
        member __.create(x: float, y: float, ?key: obj, ?frame: U2<string, float>, ?exists: bool, ?index: float): obj = jsNative
        member __.createMultiple(quantity: float, key: U2<string, ResizeArray<string>>, ?frame: U2<obj, ResizeArray<obj>>, ?exists: bool): ResizeArray<obj> = jsNative
        member __.customSort(sortHandler: Function, ?context: obj): unit = jsNative
        member __.destroy(?destroyChildren: bool, ?soft: bool): unit = jsNative
        member __.divideAll(property: string, amount: float, ?checkAlive: bool, ?checkVisible: bool): unit = jsNative
        member __.forEach(callback: Function, callbackContext: obj, checkExists: bool, [<ParamArray>] args: obj[]): unit = jsNative
        member __.forEachAlive(callback: Function, callbackContext: obj, [<ParamArray>] args: obj[]): unit = jsNative
        member __.forEachDead(callback: Function, callbackContext: obj, [<ParamArray>] args: obj[]): unit = jsNative
        member __.forEachExists(callback: Function, callbackContext: obj): unit = jsNative
        member __.filter(predicate: Function, ?checkExists: bool): ArraySet = jsNative
        member __.getAt(index: float): U2<PIXI.DisplayObject, float> = jsNative
        member __.getBottom(): obj = jsNative
        member __.getByName(name: string): obj = jsNative
        member __.getClosestTo(``object``: obj, ?callback: Function, ?callbackContext: obj): obj = jsNative
        member __.getFirstAlive(?createIfNull: bool, ?x: float, ?y: float, ?key: obj, ?frame: U2<string, float>): obj = jsNative
        member __.getFirstDead(?createIfNull: bool, ?x: float, ?y: float, ?key: obj, ?frame: U2<string, float>): obj = jsNative
        member __.getFirstExists(exists: bool, ?createIfNull: bool, ?x: float, ?y: float, ?key: obj, ?frame: U2<string, float>): obj = jsNative
        member __.getFurthestFrom(``object``: obj, ?callback: Function, ?callbackContext: obj): obj = jsNative
        member __.getIndex(child: obj): float = jsNative
        member __.getRandom(?startIndex: float, ?length: float): obj = jsNative
        member __.getTop(): obj = jsNative
        member __.hasProperty(child: obj, key: ResizeArray<string>): bool = jsNative
        member __.iterate(key: string, value: obj, returnType: float, callback: Function, callbackContext: obj, [<ParamArray>] args: obj[]): obj = jsNative
        member __.moveAll(group: Phaser.Group, ?silent: bool): Phaser.Group = jsNative
        member __.moveDown(child: obj): obj = jsNative
        member __.moveUp(child: obj): obj = jsNative
        member __.multiplyAll(property: string, amount: float, checkAlive: bool, checkVisible: bool): unit = jsNative
        member __.next(): unit = jsNative
        member __.postUpdate(): unit = jsNative
        member __.preUpdate(): unit = jsNative
        member __.previous(): unit = jsNative
        member __.remove(child: obj, ?destroy: bool, ?silent: bool): bool = jsNative
        member __.removeAll(?destroy: bool, ?silent: bool, ?destroyTexture: bool): unit = jsNative
        member __.removeBetween(startIndex: float, ?endIndex: float, ?destroy: bool, ?silent: bool): unit = jsNative
        member __.removeFromHash(child: PIXI.DisplayObject): bool = jsNative
        member __.replace(oldChild: obj, newChild: obj): obj = jsNative
        member __.resetChild(child: obj, ?x: float, ?y: float, ?key: obj, ?frame: U2<string, float>): obj = jsNative
        member __.resetCursor(?index: float): obj = jsNative
        member __.reverse(): unit = jsNative
        member __.sendToBack(child: obj): obj = jsNative
        member __.set(child: obj, key: ResizeArray<string>, value: obj, ?operation: float, ?force: bool): bool = jsNative
        member __.setAll(key: string, value: obj, ?checkAlive: bool, ?checkVisible: bool, ?operation: float, ?force: bool): unit = jsNative
        member __.setAllChildren(key: string, value: obj, ?checkAlive: bool, ?checkVisible: bool, ?operation: float, ?force: bool): unit = jsNative
        member __.setProperty(child: obj, key: ResizeArray<string>, value: obj, ?operation: float, ?force: bool): bool = jsNative
        member __.sort(?key: string, ?order: float): unit = jsNative
        member __.subAll(property: string, amount: float, checkAlive: bool, checkVisible: bool): unit = jsNative
        member __.swap(child1: obj, child2: obj): bool = jsNative
        member __.update(): unit = jsNative
        member __.updateZ(): unit = jsNative
        member __.xy(index: float, x: float, y: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Image","Phaser")>] Image(game: Phaser.Game, x: float, y: float, key: U4<string, Phaser.RenderTexture, Phaser.BitmapData, PIXI.Texture>, ?frame: U2<string, float>) =
        // interface PIXI.Sprite
        member __.alive with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
        member __.anchor with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.animations with get(): Phaser.AnimationManager = jsNative and set(v: Phaser.AnimationManager): unit = jsNative
        member __.autoCull with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
        member __.cameraOffset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.centerX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.centerY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.components with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.cropRect with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.customRender with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.data with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.debug with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.deltaX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.deltaY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.deltaZ with get(): float = jsNative and set(v: float): unit = jsNative
        member __.destroyPhase with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.events with get(): Phaser.Events = jsNative and set(v: Phaser.Events): unit = jsNative
        member __.exists with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.fixedToCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.frame with get(): U2<string, float> = jsNative and set(v: U2<string, float>): unit = jsNative
        member __.frameName with get(): string = jsNative and set(v: string): unit = jsNative
        member __.fresh with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.inCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.input with get(): Phaser.InputHandler = jsNative and set(v: Phaser.InputHandler): unit = jsNative
        member __.inputEnabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.inWorld with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.key with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.lifespan with get(): float = jsNative and set(v: float): unit = jsNative
        member __.left with get(): float = jsNative and set(v: float): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.offsetX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.offsetY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.pendingDestroy with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.previousPosition with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.previousRotation with get(): float = jsNative and set(v: float): unit = jsNative
        member __.renderOrderID with get(): float = jsNative and set(v: float): unit = jsNative
        member __.right with get(): float = jsNative and set(v: float): unit = jsNative
        member __.scale with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.smoothed with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.top with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.world with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.z with get(): float = jsNative and set(v: float): unit = jsNative
        member __.alignIn(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): obj = jsNative
        member __.alignTo(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): obj = jsNative
        member __.bringToTop(): Phaser.Image = jsNative
        member __.crop(rect: Phaser.Rectangle, ?copy: bool): unit = jsNative
        member __.destroy(?destroyChildren: bool): unit = jsNative
        member __.kill(): Phaser.Image = jsNative
        member __.loadTexture(key: obj, ?frame: U2<string, float>, ?stopAnimation: bool): unit = jsNative
        member __.resizeFrame(parent: obj, width: float, height: float): unit = jsNative
        member __.moveDown(): Phaser.Image = jsNative
        member __.moveUp(): Phaser.Image = jsNative
        member __.overlap(displayObject: obj): bool = jsNative
        member __.play(name: string, ?frameRate: float, ?loop: bool, ?killOnComplete: bool): Phaser.Animation = jsNative
        member __.postUpdate(): unit = jsNative
        member __.preUpdate(): unit = jsNative
        member __.reset(x: float, y: float, ?health: float): Phaser.Image = jsNative
        member __.resetFrame(): unit = jsNative
        member __.revive(?health: float): Phaser.Image = jsNative
        member __.sendToBack(): Phaser.Image = jsNative
        member __.setFrame(frame: Phaser.Frame): unit = jsNative
        member __.update(): unit = jsNative
        member __.updateCrop(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("ImageCollection","Phaser")>] ImageCollection(name: string, firstgid: float, ?width: float, ?height: float, ?margin: float, ?spacing: float, ?properties: obj) =
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.firstgid with get(): float = jsNative and set(v: float): unit = jsNative
        member __.imageWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.imageHeight with get(): float = jsNative and set(v: float): unit = jsNative
        member __.imageMargin with get(): float = jsNative and set(v: float): unit = jsNative
        member __.imageSpacing with get(): float = jsNative and set(v: float): unit = jsNative
        member __.properties with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.images with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
        member __.total with get(): float = jsNative and set(v: float): unit = jsNative
        member __.addImage(gid: float, image: string): unit = jsNative
        member __.containsImageIndex(imageIndex: float): bool = jsNative

    and [<AllowNullLiteral>] [<Import("Input","Phaser")>] Input(game: Phaser.Game) =
        member __.MAX_POINTERS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.MOUSE_OVERRIDES_TOUCH with get(): float = jsNative and set(v: float): unit = jsNative
        member __.MOUSE_TOUCH_COMBINE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TOUCH_OVERRIDES_MOUSE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.activePointer with get(): Phaser.Pointer = jsNative and set(v: Phaser.Pointer): unit = jsNative
        member __.circle with get(): Phaser.Circle = jsNative and set(v: Phaser.Circle): unit = jsNative
        member __.enabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.doubleTapRate with get(): float = jsNative and set(v: float): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.gamepad with get(): Phaser.Gamepad = jsNative and set(v: Phaser.Gamepad): unit = jsNative
        member __.hitCanvas with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
        member __.hitContext with get(): CanvasRenderingContext2D = jsNative and set(v: CanvasRenderingContext2D): unit = jsNative
        member __.holdRate with get(): float = jsNative and set(v: float): unit = jsNative
        member __.interactiveItems with get(): Phaser.ArraySet = jsNative and set(v: Phaser.ArraySet): unit = jsNative
        member __.justPressedRate with get(): float = jsNative and set(v: float): unit = jsNative
        member __.justReleasedRate with get(): float = jsNative and set(v: float): unit = jsNative
        member __.keyboard with get(): Phaser.Keyboard = jsNative and set(v: Phaser.Keyboard): unit = jsNative
        member __.maxPointers with get(): float = jsNative and set(v: float): unit = jsNative
        member __.minPriorityID with get(): float = jsNative and set(v: float): unit = jsNative
        member __.mouse with get(): Phaser.Mouse = jsNative and set(v: Phaser.Mouse): unit = jsNative
        member __.mousePointer with get(): Phaser.Pointer = jsNative and set(v: Phaser.Pointer): unit = jsNative
        member __.moveCallbacks with get(): Func<Phaser.Pointer, float, float, ResizeArray<unit>> = jsNative and set(v: Func<Phaser.Pointer, float, float, ResizeArray<unit>>): unit = jsNative
        member __.mspointer with get(): Phaser.MSPointer = jsNative and set(v: Phaser.MSPointer): unit = jsNative
        member __.multiInputOverride with get(): float = jsNative and set(v: float): unit = jsNative
        member __.onDown with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onHold with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onTap with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onUp with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.pointer1 with get(): Phaser.Pointer = jsNative and set(v: Phaser.Pointer): unit = jsNative
        member __.pointer2 with get(): Phaser.Pointer = jsNative and set(v: Phaser.Pointer): unit = jsNative
        member __.pointer3 with get(): Phaser.Pointer = jsNative and set(v: Phaser.Pointer): unit = jsNative
        member __.pointer4 with get(): Phaser.Pointer = jsNative and set(v: Phaser.Pointer): unit = jsNative
        member __.pointer5 with get(): Phaser.Pointer = jsNative and set(v: Phaser.Pointer): unit = jsNative
        member __.pointer6 with get(): Phaser.Pointer = jsNative and set(v: Phaser.Pointer): unit = jsNative
        member __.pointer7 with get(): Phaser.Pointer = jsNative and set(v: Phaser.Pointer): unit = jsNative
        member __.pointer8 with get(): Phaser.Pointer = jsNative and set(v: Phaser.Pointer): unit = jsNative
        member __.pointer9 with get(): Phaser.Pointer = jsNative and set(v: Phaser.Pointer): unit = jsNative
        member __.pointer10 with get(): Phaser.Pointer = jsNative and set(v: Phaser.Pointer): unit = jsNative
        member __.pollLocked with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.pollRate with get(): float = jsNative and set(v: float): unit = jsNative
        member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.pointer with get(): ResizeArray<Phaser.Pointer> = jsNative and set(v: ResizeArray<Phaser.Pointer>): unit = jsNative
        member __.recordLimit with get(): float = jsNative and set(v: float): unit = jsNative
        member __.recordPointerHistory with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.recordRate with get(): float = jsNative and set(v: float): unit = jsNative
        member __.resetLocked with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.scale with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.speed with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.tapRate with get(): float = jsNative and set(v: float): unit = jsNative
        member __.totalActivePointers with get(): float = jsNative and set(v: float): unit = jsNative
        member __.totalInactivePointers with get(): float = jsNative and set(v: float): unit = jsNative
        member __.touch with get(): Phaser.Touch = jsNative and set(v: Phaser.Touch): unit = jsNative
        member __.worldX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.worldY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.addPointer(): Phaser.Pointer = jsNative
        member __.addMoveCallback(callback: Function, context: obj): float = jsNative
        member __.boot(): unit = jsNative
        member __.countActivePointers(?limit: float): float = jsNative
        member __.deleteMoveCallback(callback: Function, ?context: obj): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.getLocalPosition(displayObject: obj, pointer: Phaser.Pointer): Phaser.Point = jsNative
        member __.getPointer(?isActive: bool): Phaser.Pointer = jsNative
        member __.getPointerFromId(pointerID: float): Phaser.Pointer = jsNative
        member __.getPointerFromIdentifier(identifier: float): Phaser.Pointer = jsNative
        member __.hitTest(displayObject: PIXI.DisplayObject, pointer: Phaser.Pointer, localPoint: Phaser.Point): unit = jsNative
        member __.reset(?hard: bool): unit = jsNative
        member __.resetSpeed(x: float, y: float): unit = jsNative
        member __.setInteractiveCandidateHandler(callback: Function, ?context: obj): unit = jsNative
        member __.startPointer(``event``: obj): Phaser.Pointer = jsNative
        member __.stopPointer(``event``: obj): Phaser.Pointer = jsNative
        member __.update(): unit = jsNative
        member __.updatePointer(``event``: obj): Phaser.Pointer = jsNative

    and [<AllowNullLiteral>] [<Import("InputHandler","Phaser")>] InputHandler(sprite: Phaser.Sprite) =
        member __.allowHorizontalDrag with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.allowVerticalDrag with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.boundsRect with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.boundsSprite with get(): Phaser.Sprite = jsNative and set(v: Phaser.Sprite): unit = jsNative
        member __.bringToTop with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.downPoint with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.dragDistanceThreshold with get(): float = jsNative and set(v: float): unit = jsNative
        member __.dragOffset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.dragFromCenter with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.draggable with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.dragStartPoint with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.dragStopBlocksInputUp with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.dragTimeThreshold with get(): float = jsNative and set(v: float): unit = jsNative
        member __.enabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.isDragged with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.pixelPerfectAlpha with get(): float = jsNative and set(v: float): unit = jsNative
        member __.pixelPerfectClick with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.pixelPerfectOver with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.priorityID with get(): float = jsNative and set(v: float): unit = jsNative
        member __.scaleLayer with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.snapOffset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.snapOffsetX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.snapOffsetY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.snapOnDrag with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.snapOnRelease with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.snapPoint with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.snapX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.snapY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.sprite with get(): Phaser.Sprite = jsNative and set(v: Phaser.Sprite): unit = jsNative
        member __.useHandCursor with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.globalToLocalX(x: float): float = jsNative
        member __.globalToLocalY(y: float): float = jsNative
        member __.checkBoundsRect(): unit = jsNative
        member __.checkBoundsSprite(): unit = jsNative
        member __.checkPixel(x: float, y: float, ?pointer: Phaser.Pointer): bool = jsNative
        member __.checkPointerDown(pointer: Phaser.Pointer, ?fastTest: bool): bool = jsNative
        member __.checkPointerOver(pointer: Phaser.Pointer, ?fastTest: bool): bool = jsNative
        member __.destroy(): unit = jsNative
        member __.disableDrag(): unit = jsNative
        member __.disableSnap(): unit = jsNative
        member __.downDuration(?pointerId: float): float = jsNative
        member __.enableDrag(?lockCenter: bool, ?bringToTop: bool, ?pixelPerfect: bool, ?alphaThreshold: float, ?boundsRect: Phaser.Rectangle, ?boundsSprite: Phaser.Sprite): unit = jsNative
        member __.enableSnap(snapX: float, snapY: float, ?onDrag: bool, ?onRelease: bool, ?snapOffsetX: float, ?snapOffsetY: float): unit = jsNative
        member __.isPixelPerfect(): bool = jsNative
        member __.justOut(?pointerId: float, ?delay: float): bool = jsNative
        member __.justOver(?pointerId: float, ?delay: float): bool = jsNative
        member __.justPressed(?pointerId: float, ?delay: float): bool = jsNative
        member __.justReleased(?pointerId: float, ?delay: float): bool = jsNative
        member __.overDuration(?pointerId: float): float = jsNative
        member __.pointerDown(?pointerId: float): bool = jsNative
        member __.pointerDragged(?pointerId: float): bool = jsNative
        member __.pointerOut(?pointerId: float): bool = jsNative
        member __.pointerOver(?pointerId: float): bool = jsNative
        member __.pointerTimeDown(?pointerId: float): float = jsNative
        member __.pointerTimeOut(?pointerId: float): float = jsNative
        member __.pointerTimeOver(?pointerId: float): float = jsNative
        member __.pointerTimeUp(?pointerId: float): float = jsNative
        member __.pointerUp(?pointerId: float): bool = jsNative
        member __.pointerX(?pointerId: float): float = jsNative
        member __.pointerY(?pointerId: float): float = jsNative
        member __.reset(): unit = jsNative
        member __.setDragLock(?allowHorizontal: bool, ?allowVertical: bool): unit = jsNative
        member __.start(priority: float, useHandCursor: bool): Phaser.Sprite = jsNative
        member __.startDrag(pointer: Phaser.Pointer): unit = jsNative
        member __.stop(): unit = jsNative
        member __.stopDrag(pointer: Phaser.Pointer): unit = jsNative
        member __.update(pointer: Phaser.Pointer): unit = jsNative
        member __.updateDrag(pointer: Phaser.Pointer): bool = jsNative
        member __.validForInput(highestID: float, highestRenderID: float, ?includePixelPerfect: bool): bool = jsNative

    and [<AllowNullLiteral>] [<Import("Key","Phaser")>] Key(game: Phaser.Game, keycode: float) =
        member __.altKey with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.ctrlKey with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.duration with get(): float = jsNative and set(v: float): unit = jsNative
        member __.enabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.``event`` with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.isDown with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isUp with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __._justDown with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.justDown with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __._justUp with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.justUp with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.keyCode with get(): float = jsNative and set(v: float): unit = jsNative
        member __.onDown with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onHoldCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onHoldContext with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.onUp with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.repeats with get(): float = jsNative and set(v: float): unit = jsNative
        member __.shiftKey with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.timeDown with get(): float = jsNative and set(v: float): unit = jsNative
        member __.timeUp with get(): float = jsNative and set(v: float): unit = jsNative
        member __.downDuration(?duration: float): bool = jsNative
        member __.processKeyDown(``event``: KeyboardEvent): unit = jsNative
        member __.processKeyUp(``event``: KeyboardEvent): unit = jsNative
        member __.reset(?hard: bool): unit = jsNative
        member __.update(): unit = jsNative
        member __.upDuration(?duration: float): bool = jsNative

    and [<AllowNullLiteral>] [<Import("Keyboard","Phaser")>] Keyboard(game: Phaser.Game) =
        member __.A with get(): float = jsNative and set(v: float): unit = jsNative
        member __.B with get(): float = jsNative and set(v: float): unit = jsNative
        member __.C with get(): float = jsNative and set(v: float): unit = jsNative
        member __.D with get(): float = jsNative and set(v: float): unit = jsNative
        member __.E with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F with get(): float = jsNative and set(v: float): unit = jsNative
        member __.G with get(): float = jsNative and set(v: float): unit = jsNative
        member __.H with get(): float = jsNative and set(v: float): unit = jsNative
        member __.I with get(): float = jsNative and set(v: float): unit = jsNative
        member __.J with get(): float = jsNative and set(v: float): unit = jsNative
        member __.K with get(): float = jsNative and set(v: float): unit = jsNative
        member __.L with get(): float = jsNative and set(v: float): unit = jsNative
        member __.M with get(): float = jsNative and set(v: float): unit = jsNative
        member __.N with get(): float = jsNative and set(v: float): unit = jsNative
        member __.O with get(): float = jsNative and set(v: float): unit = jsNative
        member __.P with get(): float = jsNative and set(v: float): unit = jsNative
        member __.Q with get(): float = jsNative and set(v: float): unit = jsNative
        member __.R with get(): float = jsNative and set(v: float): unit = jsNative
        member __.S with get(): float = jsNative and set(v: float): unit = jsNative
        member __.T with get(): float = jsNative and set(v: float): unit = jsNative
        member __.U with get(): float = jsNative and set(v: float): unit = jsNative
        member __.V with get(): float = jsNative and set(v: float): unit = jsNative
        member __.W with get(): float = jsNative and set(v: float): unit = jsNative
        member __.X with get(): float = jsNative and set(v: float): unit = jsNative
        member __.Y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.Z with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ZERO with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ONE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TWO with get(): float = jsNative and set(v: float): unit = jsNative
        member __.THREE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.FOUR with get(): float = jsNative and set(v: float): unit = jsNative
        member __.FIVE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SIX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SEVEN with get(): float = jsNative and set(v: float): unit = jsNative
        member __.EIGHT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NINE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_0 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_1 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_2 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_3 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_4 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_5 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_6 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_7 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_8 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_9 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_MULTIPLY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_ADD with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_ENTER with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_SUBTRACT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_DECIMAL with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_DIVIDE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F1 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F2 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F3 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F4 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F5 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F6 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F7 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F8 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F9 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F10 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F11 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F12 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F13 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F14 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F15 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.COLON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.EQUALS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.COMMA with get(): float = jsNative and set(v: float): unit = jsNative
        member __.UNDERSCORE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PERIOD with get(): float = jsNative and set(v: float): unit = jsNative
        member __.QUESTION_MARK with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TILDE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.OPEN_BRACKET with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BACKWARD_SLASH with get(): float = jsNative and set(v: float): unit = jsNative
        member __.CLOSED_BRACKET with get(): float = jsNative and set(v: float): unit = jsNative
        member __.QUOTES with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BACKSPACE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TAB with get(): float = jsNative and set(v: float): unit = jsNative
        member __.CLEAR with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ENTER with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SHIFT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.CONTROL with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ALT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.CAPS_LOCK with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ESC with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SPACEBAR with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PAGE_UP with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PAGE_DOWN with get(): float = jsNative and set(v: float): unit = jsNative
        member __.END with get(): float = jsNative and set(v: float): unit = jsNative
        member __.HOME with get(): float = jsNative and set(v: float): unit = jsNative
        member __.LEFT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.UP with get(): float = jsNative and set(v: float): unit = jsNative
        member __.RIGHT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.DOWN with get(): float = jsNative and set(v: float): unit = jsNative
        member __.INSERT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.DELETE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.HELP with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUM_LOCK with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PLUS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.MINUS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.callbackContext with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.enabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.``event`` with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.lastChar with get(): string = jsNative and set(v: string): unit = jsNative
        member __.lastKey with get(): Phaser.Key = jsNative and set(v: Phaser.Key): unit = jsNative
        member __.onDownCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onPressCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onUpCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.pressEvent with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.addCallbacks(context: obj, ?onDown: Function, ?onUp: Function, ?onPress: Function): unit = jsNative
        member __.addKey(keycode: float): Phaser.Key = jsNative
        member __.addKeys(keys: obj): obj = jsNative
        member __.addKeyCapture(keycode: obj): unit = jsNative
        member __.createCursorKeys(): Phaser.CursorKeys = jsNative
        member __.clearCaptures(): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.downDuration(keycode: float, ?duration: float): bool = jsNative
        member __.isDown(keycode: float): bool = jsNative
        member __.processKeyDown(``event``: KeyboardEvent): unit = jsNative
        member __.processKeyPress(``event``: KeyboardEvent): unit = jsNative
        member __.processKeyUp(``event``: KeyboardEvent): unit = jsNative
        member __.removeKey(keycode: float): unit = jsNative
        member __.removeKeyCapture(keycode: float): unit = jsNative
        member __.reset(?hard: bool): unit = jsNative
        member __.start(): unit = jsNative
        member __.stop(): unit = jsNative
        member __.update(): unit = jsNative
        member __.upDuration(keycode: float, ?duration: float): bool = jsNative

    and [<AllowNullLiteral>] [<Import("KeyCode","Phaser")>] KeyCode() =
        member __.A with get(): float = jsNative and set(v: float): unit = jsNative
        member __.B with get(): float = jsNative and set(v: float): unit = jsNative
        member __.C with get(): float = jsNative and set(v: float): unit = jsNative
        member __.D with get(): float = jsNative and set(v: float): unit = jsNative
        member __.E with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F with get(): float = jsNative and set(v: float): unit = jsNative
        member __.G with get(): float = jsNative and set(v: float): unit = jsNative
        member __.H with get(): float = jsNative and set(v: float): unit = jsNative
        member __.I with get(): float = jsNative and set(v: float): unit = jsNative
        member __.J with get(): float = jsNative and set(v: float): unit = jsNative
        member __.K with get(): float = jsNative and set(v: float): unit = jsNative
        member __.L with get(): float = jsNative and set(v: float): unit = jsNative
        member __.M with get(): float = jsNative and set(v: float): unit = jsNative
        member __.N with get(): float = jsNative and set(v: float): unit = jsNative
        member __.O with get(): float = jsNative and set(v: float): unit = jsNative
        member __.P with get(): float = jsNative and set(v: float): unit = jsNative
        member __.Q with get(): float = jsNative and set(v: float): unit = jsNative
        member __.R with get(): float = jsNative and set(v: float): unit = jsNative
        member __.S with get(): float = jsNative and set(v: float): unit = jsNative
        member __.T with get(): float = jsNative and set(v: float): unit = jsNative
        member __.U with get(): float = jsNative and set(v: float): unit = jsNative
        member __.V with get(): float = jsNative and set(v: float): unit = jsNative
        member __.W with get(): float = jsNative and set(v: float): unit = jsNative
        member __.X with get(): float = jsNative and set(v: float): unit = jsNative
        member __.Y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.Z with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ZERO with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ONE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TWO with get(): float = jsNative and set(v: float): unit = jsNative
        member __.THREE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.FOUR with get(): float = jsNative and set(v: float): unit = jsNative
        member __.FIVE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SIX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SEVEN with get(): float = jsNative and set(v: float): unit = jsNative
        member __.EIGHT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NINE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_0 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_1 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_2 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_3 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_4 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_5 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_6 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_7 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_8 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_9 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_MULTIPLY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_ADD with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_ENTER with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_SUBTRACT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_DECIMAL with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUMPAD_DIVIDE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F1 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F2 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F3 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F4 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F5 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F6 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F7 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F8 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F9 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F10 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F11 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F12 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F13 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F14 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.F15 with get(): float = jsNative and set(v: float): unit = jsNative
        member __.COLON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.EQUALS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.COMMA with get(): float = jsNative and set(v: float): unit = jsNative
        member __.UNDERSCORE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PERIOD with get(): float = jsNative and set(v: float): unit = jsNative
        member __.QUESTION_MARK with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TILDE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.OPEN_BRACKET with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BACKWARD_SLASH with get(): float = jsNative and set(v: float): unit = jsNative
        member __.CLOSED_BRACKET with get(): float = jsNative and set(v: float): unit = jsNative
        member __.QUOTES with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BACKSPACE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TAB with get(): float = jsNative and set(v: float): unit = jsNative
        member __.CLEAR with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ENTER with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SHIFT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.CONTROL with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ALT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.CAPS_LOCK with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ESC with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SPACEBAR with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PAGE_UP with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PAGE_DOWN with get(): float = jsNative and set(v: float): unit = jsNative
        member __.END with get(): float = jsNative and set(v: float): unit = jsNative
        member __.HOME with get(): float = jsNative and set(v: float): unit = jsNative
        member __.LEFT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.UP with get(): float = jsNative and set(v: float): unit = jsNative
        member __.RIGHT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.DOWN with get(): float = jsNative and set(v: float): unit = jsNative
        member __.INSERT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.DELETE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.HELP with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NUM_LOCK with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PLUS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.MINUS with get(): float = jsNative and set(v: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Line","Phaser")>] Line(?x1: float, ?y1: float, ?x2: float, ?y2: float) =
        member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``end`` with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.left with get(): float = jsNative and set(v: float): unit = jsNative
        member __.length with get(): float = jsNative and set(v: float): unit = jsNative
        member __.normalAngle with get(): float = jsNative and set(v: float): unit = jsNative
        member __.normalX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.normalY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.perpSlope with get(): float = jsNative and set(v: float): unit = jsNative
        member __.right with get(): float = jsNative and set(v: float): unit = jsNative
        member __.slope with get(): float = jsNative and set(v: float): unit = jsNative
        member __.start with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.top with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        static member intersectsPoints(a: Phaser.Point, b: Phaser.Point, e: Phaser.Point, f: Phaser.Point, ?asSegment: bool, ?result: Phaser.Point): Phaser.Point = jsNative
        static member intersects(a: Phaser.Line, b: Phaser.Line, ?asSegment: bool, ?result: Phaser.Point): Phaser.Point = jsNative
        static member intersectsRectangle(line: Phaser.Line, rect: Phaser.Rectangle): bool = jsNative
        static member reflect(a: Phaser.Line, b: Phaser.Line): float = jsNative
        member __.centerOn(x: float, y: float): Phaser.Line = jsNative
        member __.clone(output: Phaser.Line): Phaser.Line = jsNative
        member __.coordinatesOnLine(stepRate: float, results: ResizeArray<obj>): ResizeArray<obj> = jsNative
        member __.fromAngle(x: float, y: float, angle: float, length: float): Phaser.Line = jsNative
        member __.fromSprite(startSprite: Phaser.Sprite, endSprite: Phaser.Sprite, ?useCenter: bool): Phaser.Line = jsNative
        member __.intersects(line: Phaser.Line, ?asSegment: bool, ?result: Phaser.Point): Phaser.Point = jsNative
        member __.midPoint(?out: Phaser.Point): Phaser.Point = jsNative
        member __.pointOnLine(x: float, y: float): bool = jsNative
        member __.pointOnSegment(x: float, y: float): bool = jsNative
        member __.random(?out: Phaser.Point): Phaser.Point = jsNative
        member __.reflect(line: Phaser.Line): float = jsNative
        member __.rotate(angle: float, ?asDegrees: bool): Phaser.Line = jsNative
        member __.rotateAround(x: float, y: float, angle: float, ?asDegrees: bool): Phaser.Line = jsNative
        member __.setTo(?x1: float, ?y1: float, ?x2: float, ?y2: float): Phaser.Line = jsNative

    and [<AllowNullLiteral>] [<Import("LinkedList","Phaser")>] LinkedList() =
        member __.first with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.last with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.next with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.prev with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.total with get(): float = jsNative and set(v: float): unit = jsNative
        member __.add(item: obj): obj = jsNative
        member __.callAll(callback: Function): unit = jsNative
        member __.remove(item: obj): unit = jsNative
        member __.reset(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Loader","Phaser")>] Loader(game: Phaser.Game) =
        member __.PHYSICS_LIME_CORONA_JSON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PHYSICS_PHASER_JSON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TEXTURE_ATLAS_JSON_ARRAY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TEXTURE_ATLAS_JSON_HASH with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TEXTURE_ATLAS_XML_STARLING with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TEXTURE_ATLAS_JSON_PYXEL with get(): float = jsNative and set(v: float): unit = jsNative
        member __.baseURL with get(): string = jsNative and set(v: string): unit = jsNative
        member __.cache with get(): Phaser.Cache = jsNative and set(v: Phaser.Cache): unit = jsNative
        member __.crossOrigin with get(): U2<bool, string> = jsNative and set(v: U2<bool, string>): unit = jsNative
        member __.enableParallel with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.hasLoaded with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isLoading with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.maxParallelDownloads with get(): float = jsNative and set(v: float): unit = jsNative
        member __.onFileStart with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onFileComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onFileError with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onLoadComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onLoadStart with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onPackComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.path with get(): string = jsNative and set(v: string): unit = jsNative
        member __.preloadSprite with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.progress with get(): float = jsNative and set(v: float): unit = jsNative
        member __.progressFloat with get(): float = jsNative and set(v: float): unit = jsNative
        member __.resetLocked with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.useXDomainRequest with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.asyncComplete(file: obj, ?errorMessage: string): unit = jsNative
        member __.addSyncPoint(``type``: string, key: string): Phaser.Loader = jsNative
        member __.addToFileList(``type``: string, key: string, ?url: string, ?properties: obj, ?overwrite: bool, ?extension: string): Phaser.Loader = jsNative
        member __.atlas(key: string, ?textureURL: string, ?atlasURL: string, ?atlasData: obj, ?format: float): Phaser.Loader = jsNative
        member __.atlasJSONArray(key: string, ?textureURL: string, ?atlasURL: string, ?atlasData: obj): Phaser.Loader = jsNative
        member __.atlasJSONHash(key: string, ?textureURL: string, ?atlasURL: string, ?atlasData: obj): Phaser.Loader = jsNative
        member __.atlasXML(key: string, ?textureURL: string, ?atlasURL: string, ?atlasData: obj): Phaser.Loader = jsNative
        member __.audio(key: string, urls: U3<string, ResizeArray<string>, obj>, ?autoDecode: bool): Phaser.Loader = jsNative
        member __.audiosprite(key: string, urls: ResizeArray<string>, ?jsonURL: string, ?jsonData: U2<string, obj>, ?autoDecode: bool): Phaser.Loader = jsNative
        member __.binary(key: string, ?url: string, ?callback: Function, ?callbackContext: obj): Phaser.Loader = jsNative
        member __.bitmapFont(key: string, ?textureURL: string, ?atlasURL: string, ?atlasData: obj, ?xSpacing: float, ?ySpacing: float): Phaser.Loader = jsNative
        member __.checkKeyExists(``type``: string, key: string): bool = jsNative
        member __.csvLoadComplete(file: obj, xhr: XMLHttpRequest): unit = jsNative
        member __.fileComplete(file: obj, xhr: XMLHttpRequest): unit = jsNative
        member __.fileError(file: obj, xhr: XMLHttpRequest, reason: string): unit = jsNative
        member __.finishedLoading(?abnormal: bool): unit = jsNative
        member __.getAsset(``type``: string, key: string): obj = jsNative
        member __.getAssetIndex(``type``: string, key: string): float = jsNative
        member __.getAudioURL(urls: ResizeArray<obj>): unit = jsNative
        member __.image(key: string, ?url: string, ?overwrite: bool): Phaser.Loader = jsNative
        member __.images(keys: ResizeArray<string>, ?urls: ResizeArray<string>): Phaser.Loader = jsNative
        member __.json(key: string, ?url: string, ?overwrite: bool): Phaser.Loader = jsNative
        member __.jsonLoadComplete(file: obj, xhr: XMLHttpRequest): unit = jsNative
        member __.loadAudioTag(file: obj): unit = jsNative
        member __.loadFile(file: obj): unit = jsNative
        member __.loadImageTag(file: obj): unit = jsNative
        member __.pack(key: string, ?url: string, ?data: obj, ?callbackContext: obj): Phaser.Loader = jsNative
        member __.parseXml(data: string): XMLDocument = jsNative
        member __.physics(key: string, ?url: string, ?data: obj, ?format: string): Phaser.Loader = jsNative
        member __.processLoadQueue(): unit = jsNative
        member __.processPack(pack: obj): unit = jsNative
        member __.removeAll(): unit = jsNative
        member __.removeFile(``type``: string, key: string): unit = jsNative
        member __.replaceInFileList(``type``: string, key: string, url: string, properties: obj): unit = jsNative
        member __.reset(?hard: bool, ?clearEvents: bool): unit = jsNative
        member __.resize(): unit = jsNative
        member __.script(key: string, ?url: string, ?callback: Function, ?callbackContext: obj): Phaser.Loader = jsNative
        member __.shader(key: string, ?url: string, ?overwrite: bool): Phaser.Loader = jsNative
        member __.setPreloadSprite(sprite: U2<Phaser.Sprite, Phaser.Image>, ?direction: float): unit = jsNative
        member __.spritesheet(key: string, url: string, frameWidth: float, frameHeight: float, ?frameMax: float, ?margin: float, ?spacing: float): Phaser.Loader = jsNative
        member __.start(): unit = jsNative
        member __.text(key: string, ?url: string, ?overwrite: bool): Phaser.Loader = jsNative
        member __.tilemap(key: string, ?url: string, ?data: obj, ?format: float): Phaser.Loader = jsNative
        member __.totalLoadedFiles(): float = jsNative
        member __.totalLoadedPacks(): float = jsNative
        member __.totalQueuedFiles(): float = jsNative
        member __.totalQueuedPacks(): float = jsNative
        member __.transformUrl(url: string, ?file: obj): string = jsNative
        member __.updateProgress(): unit = jsNative
        member __.video(key: string, urls: U3<string, ResizeArray<string>, obj>, ?loadEvent: string, ?asBlob: bool): Phaser.Loader = jsNative
        member __.withSyncPoint(callback: Function, ?callbackContext: obj): Phaser.Loader = jsNative
        member __.xml(key: string, ?url: string, ?overwrite: bool): Phaser.Loader = jsNative
        member __.xhrLoad(file: obj, url: string, ``type``: string, onload: Function, ?onerror: Function): unit = jsNative
        member __.xhrLoadWithXDR(file: obj, url: string, ``type``: string, onload: Function, ?onerror: Function): unit = jsNative
        member __.xmlLoadComplete(file: obj, xhr: XMLHttpRequest): unit = jsNative

    and [<AllowNullLiteral>] [<Import("LoaderParser","Phaser")>] LoaderParser() =
        static member bitmapFont(xml: obj, baseTexture: PIXI.BaseTexture, ?xSpacing: float, ?ySpacing: float): obj = jsNative
        static member xmlBitmapFont(xml: obj, baseTexture: PIXI.BaseTexture, ?xSpacing: float, ?ySpacing: float): obj = jsNative
        static member jsonBitmapFont(json: obj, baseTexture: PIXI.BaseTexture, ?xSpacing: float, ?ySpacing: float): obj = jsNative

    and [<AllowNullLiteral>] [<Import("Matrix","Phaser")>] Matrix(?a: float, ?b: float, ?c: float, ?d: float, ?tx: float, ?ty: float) =
        // interface PIXI.Matrix
        member __.a with get(): float = jsNative and set(v: float): unit = jsNative
        member __.b with get(): float = jsNative and set(v: float): unit = jsNative
        member __.c with get(): float = jsNative and set(v: float): unit = jsNative
        member __.d with get(): float = jsNative and set(v: float): unit = jsNative
        member __.tx with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ty with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.apply(pos: Phaser.Point, ?newPos: Phaser.Point): Phaser.Point = jsNative
        member __.applyInverse(pos: Phaser.Point, ?newPos: Phaser.Point): Phaser.Point = jsNative
        member __.clone(?output: Phaser.Matrix): Phaser.Matrix = jsNative
        member __.copyFrom(matrix: Phaser.Matrix): Phaser.Matrix = jsNative
        member __.copyTo(matrix: Phaser.Matrix): Phaser.Matrix = jsNative
        member __.fromArray(array: ResizeArray<float>): Phaser.Matrix = jsNative
        member __.setTo(a: float, b: float, c: float, d: float, tx: float, ty: float): Phaser.Matrix = jsNative
        member __.toArray(?transpose: bool, ?array: ResizeArray<float>): ResizeArray<float> = jsNative
        member __.translate(x: float, y: float): Phaser.Matrix = jsNative
        member __.scale(x: float, y: float): Phaser.Matrix = jsNative
        member __.rotate(angle: float): Phaser.Matrix = jsNative
        member __.append(matrix: Phaser.Matrix): Phaser.Matrix = jsNative
        member __.identity(): Phaser.Matrix = jsNative

    and [<AllowNullLiteral>] [<Import("Math","Phaser")>] Math() =
        member __.PI2 with get(): float = jsNative and set(v: float): unit = jsNative
        static member angleBetween(x1: float, y1: float, x2: float, y2: float): float = jsNative
        static member angleBetweenPoints(point1: Phaser.Point, point2: Phaser.Point): float = jsNative
        static member angleBetweenY(x1: float, y1: float, x2: float, y2: float): float = jsNative
        static member angleBetweenPointsY(point1: Phaser.Point, point2: Phaser.Point): float = jsNative
        static member average([<ParamArray>] numbers: float[]): float = jsNative
        static member bernstein(n: float, i: float): float = jsNative
        static member between(min: float, max: float): float = jsNative
        static member bezierInterpolation(v: ResizeArray<float>, k: float): float = jsNative
        static member catmullRom(p0: float, p1: float, p2: float, p3: float, t: float): float = jsNative
        static member catmullRomInterpolation(v: ResizeArray<float>, k: float): float = jsNative
        static member ceilTo(value: float, ?place: float, ?``base``: float): float = jsNative
        static member clamp(x: float, a: float, b: float): float = jsNative
        static member clampBottom(x: float, a: float): float = jsNative
        static member degToRad(degrees: float): float = jsNative
        static member difference(a: float, b: float): float = jsNative
        static member distance(x1: float, y1: float, x2: float, y2: float): float = jsNative
        static member distanceSq(x1: float, y1: float, x2: float, y2: float): float = jsNative
        static member distancePow(xy: float, y1: float, x2: float, y2: float, ?pow: float): float = jsNative
        static member factorial(value: float): float = jsNative
        static member floorTo(value: float, place: float, ``base``: float): float = jsNative
        static member fuzzyCeil(``val``: float, ?epsilon: float): bool = jsNative
        static member fuzzyEqual(a: float, b: float, ?epsilon: float): bool = jsNative
        static member fuzzyLessThan(a: float, b: float, ?epsilon: float): bool = jsNative
        static member fuzzyFloor(``val``: float, ?epsilon: float): bool = jsNative
        static member fuzzyGreaterThan(a: float, b: float, ?epsilon: float): bool = jsNative
        static member isEven(n: float): bool = jsNative
        static member isOdd(n: float): bool = jsNative
        static member linear(p0: float, p1: float, t: float): float = jsNative
        static member linearInterpolation(v: ResizeArray<float>, k: float): float = jsNative
        static member mapLinear(x: float, a1: float, a2: float, b1: float, b2: float): float = jsNative
        static member max([<ParamArray>] numbers: float[]): float = jsNative
        static member maxAdd(value: float, amount: float, max: float): float = jsNative
        static member maxProperty([<ParamArray>] numbers: float[]): float = jsNative
        static member min([<ParamArray>] numbers: float[]): float = jsNative
        static member minProperty([<ParamArray>] numbers: float[]): float = jsNative
        static member minSub(value: float, amount: float, min: float): float = jsNative
        static member normalizeAngle(angle: float, ?radians: bool): float = jsNative
        static member percent(a: float, b: float, ?``base``: float): float = jsNative
        static member p2px(v: float): float = jsNative
        static member radToDeg(radians: float): float = jsNative
        static member reverseAngle(angleRed: float): float = jsNative
        static member rotateToAngle(currentAngle: float, targetAngle: float, ?lerp: float): float = jsNative
        static member roundAwayFromZero(value: float): float = jsNative
        static member roundTo(value: float, ?place: float, ?``base``: float): float = jsNative
        static member shear(n: float): float = jsNative
        static member sign(x: float): float = jsNative
        static member sinCosGenerator(length: float, ?sinAmplitude: float, ?cosAmplitude: float, ?frequency: float): obj = jsNative
        static member smootherstep(x: float, min: float, max: float): float = jsNative
        static member smoothstep(x: float, min: float, max: float): float = jsNative
        static member snapTo(input: float, gap: float, ?start: float): float = jsNative
        static member snapToCeil(input: float, gap: float, ?start: float): float = jsNative
        static member snapToFloor(input: float, gap: float, ?start: float): float = jsNative
        static member within(a: float, b: float, tolerance: float): bool = jsNative
        static member wrap(value: float, min: float, max: float): float = jsNative
        static member wrapAngle(angle: float, ?radians: bool): float = jsNative
        static member wrapValue(value: float, amount: float, max: float): float = jsNative

    and [<AllowNullLiteral>] WheelEventProxy =
        abstract ``type``: string with get, set
        abstract deltaMode: float with get, set
        abstract deltaX: float with get, set
        abstract deltaY: float with get, set
        abstract deltaZ: float with get, set
        abstract bindEvent: ``event``: obj -> WheelEventProxy

    and [<AllowNullLiteral>] [<Import("Mouse","Phaser")>] Mouse(game: Phaser.Game) =
        member __.NO_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.LEFT_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.MIDDLE_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.RIGHT_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BACK_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.FORWARD_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.WHEEL_DOWN with get(): float = jsNative and set(v: float): unit = jsNative
        member __.WHEEL_UP with get(): float = jsNative and set(v: float): unit = jsNative
        member __.button with get(): float = jsNative and set(v: float): unit = jsNative
        member __.callbackContext with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.capture with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.enabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.``event`` with get(): MouseEvent = jsNative and set(v: MouseEvent): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.input with get(): Phaser.Input = jsNative and set(v: Phaser.Input): unit = jsNative
        member __.locked with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.mouseDownCallback with get(): Func<MouseEvent, unit> = jsNative and set(v: Func<MouseEvent, unit>): unit = jsNative
        member __.mouseOutCallback with get(): Func<MouseEvent, unit> = jsNative and set(v: Func<MouseEvent, unit>): unit = jsNative
        member __.mouseOverCallback with get(): Func<MouseEvent, unit> = jsNative and set(v: Func<MouseEvent, unit>): unit = jsNative
        member __.mouseUpCallback with get(): Func<MouseEvent, unit> = jsNative and set(v: Func<MouseEvent, unit>): unit = jsNative
        member __.mouseWheelCallback with get(): Func<MouseEvent, unit> = jsNative and set(v: Func<MouseEvent, unit>): unit = jsNative
        member __._onMouseDown with get(): Func<MouseEvent, unit> = jsNative and set(v: Func<MouseEvent, unit>): unit = jsNative
        member __._onMouseMove with get(): Func<MouseEvent, unit> = jsNative and set(v: Func<MouseEvent, unit>): unit = jsNative
        member __._onMouseUp with get(): Func<MouseEvent, unit> = jsNative and set(v: Func<MouseEvent, unit>): unit = jsNative
        member __._onMouseOut with get(): Func<MouseEvent, unit> = jsNative and set(v: Func<MouseEvent, unit>): unit = jsNative
        member __._onMouseOver with get(): Func<MouseEvent, unit> = jsNative and set(v: Func<MouseEvent, unit>): unit = jsNative
        member __._onMouseWheel with get(): Func<MouseEvent, unit> = jsNative and set(v: Func<MouseEvent, unit>): unit = jsNative
        member __._wheelEvent with get(): WheelEventProxy = jsNative and set(v: WheelEventProxy): unit = jsNative
        member __.pointerLock with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.stopOnGameOut with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.wheelDelta with get(): float = jsNative and set(v: float): unit = jsNative
        member __.onMouseDown(``event``: MouseEvent): unit = jsNative
        member __.onMouseMove(``event``: MouseEvent): unit = jsNative
        member __.onMouseOut(``event``: MouseEvent): unit = jsNative
        member __.onMouseOver(``event``: MouseEvent): unit = jsNative
        member __.onMouseUp(``event``: MouseEvent): unit = jsNative
        member __.onMouseUpGlobal(``event``: MouseEvent): unit = jsNative
        member __.onMouseWheel(``event``: MouseEvent): unit = jsNative
        member __.pointerLockChange(``event``: MouseEvent): unit = jsNative
        member __.releasePointerLock(): unit = jsNative
        member __.requestPointerLock(): unit = jsNative
        member __.start(): unit = jsNative
        member __.stop(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("MSPointer","Phaser")>] MSPointer(game: Phaser.Game) =
        member __.button with get(): float = jsNative and set(v: float): unit = jsNative
        member __.capture with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.callbackContext with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.``event`` with get(): MSPointerEvent = jsNative and set(v: MSPointerEvent): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.input with get(): Phaser.Input = jsNative and set(v: Phaser.Input): unit = jsNative
        member __.onPointerDown with get(): Func<MSPointerEvent, unit> = jsNative and set(v: Func<MSPointerEvent, unit>): unit = jsNative
        member __.onPointerMove with get(): Func<MSPointerEvent, unit> = jsNative and set(v: Func<MSPointerEvent, unit>): unit = jsNative
        member __.onPointerUp with get(): Func<MSPointerEvent, unit> = jsNative and set(v: Func<MSPointerEvent, unit>): unit = jsNative
        member __.mouseDownCallback with get(): Func<MSPointerEvent, unit> = jsNative and set(v: Func<MSPointerEvent, unit>): unit = jsNative
        member __.mouseMoveCallback with get(): Func<MSPointerEvent, unit> = jsNative and set(v: Func<MSPointerEvent, unit>): unit = jsNative
        member __.mouseUpCallback with get(): Func<MSPointerEvent, unit> = jsNative and set(v: Func<MSPointerEvent, unit>): unit = jsNative
        member __.pointerDownCallback with get(): Func<MSPointerEvent, unit> = jsNative and set(v: Func<MSPointerEvent, unit>): unit = jsNative
        member __.pointerMoveCallback with get(): Func<MSPointerEvent, unit> = jsNative and set(v: Func<MSPointerEvent, unit>): unit = jsNative
        member __.pointerUpCallback with get(): Func<MSPointerEvent, unit> = jsNative and set(v: Func<MSPointerEvent, unit>): unit = jsNative
        member __.start(): unit = jsNative
        member __.stop(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Net","Phaser")>] Net(game: Phaser.Game) =
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.checkDomainName(domain: string): bool = jsNative
        member __.decodeURI(value: string): string = jsNative
        member __.getHostName(): string = jsNative
        member __.getQueryString(?parameter: string): string = jsNative
        member __.updateQueryString(key: string, value: obj, ?redirect: bool, ?url: string): string = jsNative

    and [<AllowNullLiteral>] [<Import("Particle","Phaser")>] Particle(game: Phaser.Game, x: float, y: float, ?key: obj, ?frame: obj) =
        inherit Phaser.Sprite()
        member __.fresh with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.onEmit(): unit = jsNative
        member __.reset(x: float, y: float, ?health: float): Phaser.Particle = jsNative
        member __.setAlphaData(data: ResizeArray<obj>): unit = jsNative
        member __.setScaleData(data: ResizeArray<obj>): unit = jsNative
        member __.update(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Particles","Phaser")>] Particles(game: Phaser.Game) =
        member __.emitters with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.ID with get(): float = jsNative and set(v: float): unit = jsNative
        member __.add(emitter: obj): obj = jsNative
        member __.remove(emitter: obj): unit = jsNative
        member __.update(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Physics","Phaser")>] Physics(game: Phaser.Game, ?config: obj) =
        member __.ARCADE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.P2JS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NINJA with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BOX2D with get(): float = jsNative and set(v: float): unit = jsNative
        member __.CHIPMUNK with get(): float = jsNative and set(v: float): unit = jsNative
        member __.MATTERJS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.arcade with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.config with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.ninja with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.p2 with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.box2d with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.clear(): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.enable(``object``: obj, ?system: float, ?debug: bool): unit = jsNative
        member __.parseConfig(): unit = jsNative
        member __.preUpdate(): unit = jsNative
        member __.reset(): unit = jsNative
        member __.setBoundsToWorld(): unit = jsNative
        member __.startSystem(system: float): unit = jsNative
        member __.update(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Video","Phaser")>] Video(game: Phaser.Game, ?key: string, ?url: string) =
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.key with get(): string = jsNative and set(v: string): unit = jsNative
        member __.video with get(): HTMLVideoElement = jsNative and set(v: HTMLVideoElement): unit = jsNative
        member __.baseTexture with get(): PIXI.BaseTexture = jsNative and set(v: PIXI.BaseTexture): unit = jsNative
        member __.texture with get(): PIXI.Texture = jsNative and set(v: PIXI.Texture): unit = jsNative
        member __.textureFrame with get(): Phaser.Frame = jsNative and set(v: Phaser.Frame): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.disableTextureUpload with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.dirty with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.currentTime with get(): float = jsNative and set(v: float): unit = jsNative
        member __.duration with get(): float = jsNative and set(v: float): unit = jsNative
        member __.progress with get(): float = jsNative and set(v: float): unit = jsNative
        member __.mute with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.paused with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.volume with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.playbackRate with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.playing with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.loop with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.videoStream with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.isStreaming with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.snapshot with get(): Phaser.BitmapData = jsNative and set(v: Phaser.BitmapData): unit = jsNative
        member __.timeout with get(): float = jsNative and set(v: float): unit = jsNative
        member __.retryLimit with get(): float = jsNative and set(v: float): unit = jsNative
        member __.retry with get(): float = jsNative and set(v: float): unit = jsNative
        member __.retryInterval with get(): float = jsNative and set(v: float): unit = jsNative
        member __.onAccess with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onError with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onPlay with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onUpdate with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onTimeout with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.touchLocked with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.complete with get(): Func<unit, unit> = jsNative and set(v: Func<unit, unit>): unit = jsNative
        member __.add(``object``: U4<Phaser.Sprite, ResizeArray<Phaser.Sprite>, Phaser.Image, ResizeArray<Phaser.Image>>): Phaser.Video = jsNative
        member __.addToWorld(?x: float, ?y: float, ?anchorX: float, ?anchorY: float, ?scaleX: float, ?scaleY: float): Phaser.Image = jsNative
        member __.createVideoFromBlob(blob: Blob): Phaser.Video = jsNative
        member __.startMediaStream(?captureAudio: bool, ?width: float, ?height: float): Phaser.Video = jsNative
        member __.createVideoFromURL(url: string, ?autoplay: bool): Phaser.Video = jsNative
        member __.changeSource(src: string, ?autoplay: bool): Phaser.Video = jsNative
        member __.connectToMediaStram(video: obj, stream: obj): Phaser.Video = jsNative
        member __.destroy(): unit = jsNative
        member __.play(?loop: bool, ?playbackRate: float): Phaser.Video = jsNative
        member __.playHandler(): unit = jsNative
        member __.render(): unit = jsNative
        member __.removeVideoElement(): unit = jsNative
        member __.resizeFrame(parent: obj, width: float, height: float): unit = jsNative
        member __.setTouchLock(): unit = jsNative
        member __.grab(?clear: bool, ?alpha: float, ?blendMode: string): Phaser.BitmapData = jsNative
        member __.stop(): unit = jsNative
        member __.unlock(): bool = jsNative
        member __.updateTexture(?``event``: obj, ?width: float, ?height: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Plugin","Phaser")>] Plugin(game: Phaser.Game, parent: Phaser.PluginManager) =
        interface IStateCycle with
            member __.preUpdate(): unit = jsNative
            member __.update(): unit = jsNative
            member __.render(): unit = jsNative
            member __.postRender(): unit = jsNative
            member __.destroy(): unit = jsNative
        member __.active with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.hasPostRender with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.hasPostUpdate with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.hasPreUpdate with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.hasRender with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.hasUpdate with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.parent with get(): PIXI.DisplayObject = jsNative and set(v: PIXI.DisplayObject): unit = jsNative
        member __.visible with get(): bool = jsNative and set(v: bool): unit = jsNative

    and [<AllowNullLiteral>] PluginConstructorOf<'T> =
        [<Emit("new $0($1...)")>] abstract Create: [<ParamArray>] parameters: obj[] -> 'T

    and [<AllowNullLiteral>] [<Import("PluginManager","Phaser")>] PluginManager(game: Phaser.Game) =
        interface IStateCycle with
            member __.preUpdate(): unit = jsNative
            member __.update(): unit = jsNative
            member __.render(): unit = jsNative
            member __.postRender(): unit = jsNative
            member __.destroy(): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.plugins with get(): ResizeArray<Phaser.Plugin> = jsNative and set(v: ResizeArray<Phaser.Plugin>): unit = jsNative
        member __.add(plugin: PluginConstructorOf<'T>, [<ParamArray>] parameters: obj[]): 'T = jsNative
        member __.postUpdate(): unit = jsNative
        member __.remove(plugin: Phaser.Plugin, ?destroy: bool): unit = jsNative
        member __.removeAll(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Point","Phaser")>] Point(?x: float, ?y: float) =
        // interface PIXI.Point
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        static member add(a: Phaser.Point, b: Phaser.Point, ?out: Phaser.Point): Phaser.Point = jsNative
        static member subtract(a: Phaser.Point, b: Phaser.Point, ?out: Phaser.Point): Phaser.Point = jsNative
        static member multiply(a: Phaser.Point, b: Phaser.Point, ?out: Phaser.Point): Phaser.Point = jsNative
        static member divide(a: Phaser.Point, b: Phaser.Point, ?out: Phaser.Point): Phaser.Point = jsNative
        static member equals(a: Phaser.Point, b: Phaser.Point): bool = jsNative
        static member angle(a: Phaser.Point, b: Phaser.Point): float = jsNative
        static member angleSq(a: Phaser.Point, b: Phaser.Point): float = jsNative
        static member negative(a: Phaser.Point, ?out: Phaser.Point): Phaser.Point = jsNative
        static member multiplyAdd(a: Phaser.Point, b: Phaser.Point, scale: float, ?out: Phaser.Point): Phaser.Point = jsNative
        static member interpolate(a: Phaser.Point, b: Phaser.Point, alpha: float, ?out: Phaser.Point): Phaser.Point = jsNative
        static member parse(obj: obj, ?xProp: string, ?yProp: string): Phaser.Point = jsNative
        static member perp(a: Phaser.Point, ?out: Phaser.Point): Phaser.Point = jsNative
        static member rperp(a: Phaser.Point, ?out: Phaser.Point): Phaser.Point = jsNative
        static member distance(a: obj, b: obj, ?round: bool): float = jsNative
        static member project(a: Phaser.Point, b: Phaser.Point, ?out: Phaser.Point): Phaser.Point = jsNative
        static member projectUnit(a: Phaser.Point, b: Phaser.Point, ?out: Phaser.Point): Phaser.Point = jsNative
        static member normalRightHand(a: Phaser.Point, ?out: Phaser.Point): Phaser.Point = jsNative
        static member normalize(a: Phaser.Point, ?out: Phaser.Point): Phaser.Point = jsNative
        static member rotate(a: Phaser.Point, x: float, y: float, angle: float, ?asDegrees: bool, ?distance: float): Phaser.Point = jsNative
        static member centroid(points: ResizeArray<Phaser.Point>, ?out: Phaser.Point): Phaser.Point = jsNative
        member __.add(x: float, y: float): Phaser.Point = jsNative
        member __.angle(a: Phaser.Point, ?asDegrees: bool): float = jsNative
        member __.angleSq(a: Phaser.Point): float = jsNative
        member __.clamp(min: float, max: float): Phaser.Point = jsNative
        member __.clampX(min: float, max: float): Phaser.Point = jsNative
        member __.clampY(min: float, max: float): Phaser.Point = jsNative
        member __.clone(?output: Phaser.Point): Phaser.Point = jsNative
        member __.copyFrom(source: Phaser.Point): Phaser.Point = jsNative
        member __.copyTo(dest: 'T): 'T = jsNative
        member __.ceil(): Phaser.Point = jsNative
        member __.cross(a: Phaser.Point): float = jsNative
        member __.divide(x: float, y: float): Phaser.Point = jsNative
        member __.distance(dest: Phaser.Point, ?round: bool): float = jsNative
        member __.dot(a: Phaser.Point): float = jsNative
        member __.equals(a: Phaser.Point): bool = jsNative
        member __.floor(): Phaser.Point = jsNative
        member __.getMagnitude(): float = jsNative
        member __.getMagnitudeSq(): float = jsNative
        member __.invert(): Phaser.Point = jsNative
        member __.isZero(): bool = jsNative
        member __.multiply(x: float, y: float): Phaser.Point = jsNative
        member __.normalize(): Phaser.Point = jsNative
        member __.normalRightHand(): Phaser.Point = jsNative
        member __.perp(): Phaser.Point = jsNative
        member __.rperp(): Phaser.Point = jsNative
        member __.rotate(x: float, y: float, angle: float, ?asDegrees: bool, ?distance: float): Phaser.Point = jsNative
        member __.set(x: float, ?y: float): Phaser.Point = jsNative
        member __.setMagnitude(magnitude: float): Phaser.Point = jsNative
        member __.setTo(x: float, ?y: float): Phaser.Point = jsNative
        member __.subtract(x: float, y: float): Phaser.Point = jsNative
        member __.toString(): string = jsNative

    and [<AllowNullLiteral>] [<Import("Pointer","Phaser")>] Pointer(game: Phaser.Game, id: float, ?pointerMode: float) =
        member __.NO_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.LEFT_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.RIGHT_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.MIDDLE_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.BACK_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.FORWARD_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ERASER_BUTTON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.active with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.backButton with get(): Phaser.DeviceButton = jsNative and set(v: Phaser.DeviceButton): unit = jsNative
        member __.button with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.circle with get(): Phaser.Circle = jsNative and set(v: Phaser.Circle): unit = jsNative
        member __.clientX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.clientY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.dirty with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.duration with get(): float = jsNative and set(v: float): unit = jsNative
        member __.eraserButton with get(): Phaser.DeviceButton = jsNative and set(v: Phaser.DeviceButton): unit = jsNative
        member __.exists with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.forceOut with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.forwardButton with get(): Phaser.DeviceButton = jsNative and set(v: Phaser.DeviceButton): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.justReleasePreventsOver with get(): U2<bool, float> = jsNative and set(v: U2<bool, float>): unit = jsNative
        member __.id with get(): float = jsNative and set(v: float): unit = jsNative
        member __.identifier with get(): float = jsNative and set(v: float): unit = jsNative
        member __.interactiveCandidates with get(): ResizeArray<Phaser.InputHandler> = jsNative and set(v: ResizeArray<Phaser.InputHandler>): unit = jsNative
        member __.isDown with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isMouse with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isUp with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.leftButton with get(): Phaser.DeviceButton = jsNative and set(v: Phaser.DeviceButton): unit = jsNative
        member __.middleButton with get(): Phaser.DeviceButton = jsNative and set(v: Phaser.DeviceButton): unit = jsNative
        member __.movementX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.movementY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.msSinceLastClick with get(): float = jsNative and set(v: float): unit = jsNative
        member __.pageX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.pageY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.pointerId with get(): float = jsNative and set(v: float): unit = jsNative
        member __.pointerMode with get(): float = jsNative and set(v: float): unit = jsNative
        member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.positionDown with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.positionUp with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.previousTapTime with get(): float = jsNative and set(v: float): unit = jsNative
        member __.rawMovementX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.rawMovementY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.rightButton with get(): Phaser.DeviceButton = jsNative and set(v: Phaser.DeviceButton): unit = jsNative
        member __.screenX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.screenY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.target with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.targetObject with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.timeDown with get(): float = jsNative and set(v: float): unit = jsNative
        member __.timeUp with get(): float = jsNative and set(v: float): unit = jsNative
        member __.totalTouches with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.withinGame with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.worldX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.worldY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.addClickTrampoline(name: string, callback: Function, callbackContext: obj, [<ParamArray>] callbackArgs: obj[]): unit = jsNative
        member __.justPressed(?duration: float): bool = jsNative
        member __.justReleased(?duration: float): bool = jsNative
        member __.leave(``event``: obj): unit = jsNative
        member __.move(``event``: obj, ?fromClick: bool): unit = jsNative
        member __.reset(): unit = jsNative
        member __.resetButtons(): unit = jsNative
        member __.resetMovement(): unit = jsNative
        member __.start(``event``: obj): unit = jsNative
        member __.stop(``event``: obj): unit = jsNative
        member __.swapTarget(newTarget: Phaser.InputHandler, ?silent: bool): unit = jsNative
        member __.update(): unit = jsNative
        member __.updateButtons(``event``: MouseEvent): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Polygon","Phaser")>] Polygon([<ParamArray>] points: float[]) =
        member __.area with get(): float = jsNative and set(v: float): unit = jsNative
        member __.flattened with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.points with get(): U2<ResizeArray<float>, ResizeArray<Phaser.Point>> = jsNative and set(v: U2<ResizeArray<float>, ResizeArray<Phaser.Point>>): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.clone(output: Phaser.Polygon): Phaser.Polygon = jsNative
        member __.contains(x: float, y: float): bool = jsNative
        member __.flatten(): Phaser.Polygon = jsNative
        member __.setTo(points: U2<ResizeArray<Phaser.Point>, ResizeArray<float>>): unit = jsNative
        member __.setTo([<ParamArray>] points: Phaser.Point[]): unit = jsNative
        member __.setTo([<ParamArray>] points: float[]): unit = jsNative
        member __.toNumberArray(?output: ResizeArray<float>): ResizeArray<float> = jsNative

    and [<AllowNullLiteral>] [<Import("QuadTree","Phaser")>] QuadTree(x: float, y: float, width: float, height: float, ?maxObject: float, ?maxLevels: float, ?level: float) =
        member __.bounds with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.level with get(): float = jsNative and set(v: float): unit = jsNative
        member __.maxObjects with get(): float = jsNative and set(v: float): unit = jsNative
        member __.maxLevels with get(): float = jsNative and set(v: float): unit = jsNative
        member __.objects with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
        member __.nodes with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
        member __.clear(): unit = jsNative
        member __.getIndex(rect: obj): float = jsNative
        member __.insert(body: obj): unit = jsNative
        member __.populate(group: Phaser.Group): unit = jsNative
        member __.populateHandler(sprite: Phaser.Sprite): unit = jsNative
        member __.reset(x: float, y: float, width: float, height: float, ?maxObject: float, ?maxLevels: float, ?level: float): unit = jsNative
        member __.retrieve(source: obj): ResizeArray<obj> = jsNative
        member __.split(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("RandomDataGenerator","Phaser")>] RandomDataGenerator(?seeds: U2<ResizeArray<obj>, string>) =
        member __.angle(): float = jsNative
        member __.between(min: float, max: float): float = jsNative
        member __.frac(): float = jsNative
        member __.integer(): float = jsNative
        member __.integerInRange(min: float, max: float): float = jsNative
        member __.normal(): float = jsNative
        member __.pick(ary: ResizeArray<'T>): 'T = jsNative
        member __.real(): float = jsNative
        member __.realInRange(min: float, max: float): float = jsNative
        member __.sign(): float = jsNative
        member __.sow(seeds: ResizeArray<obj>): unit = jsNative
        member __.state(?state: string): string = jsNative
        member __.timestamp(min: float, max: float): float = jsNative
        member __.uuid(): float = jsNative
        member __.weightedPick(ary: ResizeArray<'T>): 'T = jsNative

    and [<AllowNullLiteral>] [<Import("Rectangle","Phaser")>] Rectangle(x: float, y: float, width: float, height: float) =
        member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
        member __.bottomRight with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.bottomLeft with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.centerX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.centerY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.empty with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.halfHeight with get(): float = jsNative and set(v: float): unit = jsNative
        member __.halfWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.left with get(): float = jsNative and set(v: float): unit = jsNative
        member __.perimeter with get(): float = jsNative and set(v: float): unit = jsNative
        member __.randomX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.randomY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.right with get(): float = jsNative and set(v: float): unit = jsNative
        member __.top with get(): float = jsNative and set(v: float): unit = jsNative
        member __.topLeft with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.topRight with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.volume with get(): float = jsNative and set(v: float): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        static member aabb(points: ResizeArray<Phaser.Point>, ?out: Phaser.Rectangle): Phaser.Rectangle = jsNative
        static member clone(a: Phaser.Rectangle, ?output: Phaser.Rectangle): Phaser.Rectangle = jsNative
        static member contains(a: Phaser.Rectangle, x: float, y: float): bool = jsNative
        static member containsPoint(a: Phaser.Rectangle, point: Phaser.Point): bool = jsNative
        static member containsRaw(rx: float, ry: float, rw: float, rh: float, x: float, y: float): bool = jsNative
        static member containsRect(a: Phaser.Rectangle, b: Phaser.Rectangle): bool = jsNative
        static member equals(a: Phaser.Rectangle, b: Phaser.Rectangle): bool = jsNative
        static member inflate(a: Phaser.Rectangle, dx: float, dy: float): Phaser.Rectangle = jsNative
        static member inflatePoint(a: Phaser.Rectangle, point: Phaser.Point): Phaser.Rectangle = jsNative
        static member intersection(a: Phaser.Rectangle, b: Phaser.Rectangle, ?out: Phaser.Rectangle): Phaser.Rectangle = jsNative
        static member intersects(a: Phaser.Rectangle, b: Phaser.Rectangle): bool = jsNative
        static member intersectsRaw(left: float, right: float, top: float, bottom: float, tolerance: float): bool = jsNative
        static member size(a: Phaser.Rectangle, ?output: Phaser.Point): Phaser.Point = jsNative
        static member union(a: Phaser.Rectangle, b: Phaser.Rectangle, ?out: Phaser.Rectangle): Phaser.Rectangle = jsNative
        member __.ceil(): unit = jsNative
        member __.ceilAll(): unit = jsNative
        member __.centerOn(x: float, y: float): Phaser.Rectangle = jsNative
        member __.clone(output: Phaser.Rectangle): Phaser.Rectangle = jsNative
        member __.contains(x: float, y: float): bool = jsNative
        member __.containsRect(b: Phaser.Rectangle): bool = jsNative
        member __.copyFrom(source: obj): Phaser.Rectangle = jsNative
        member __.copyTo(dest: obj): obj = jsNative
        member __.equals(b: Phaser.Rectangle): bool = jsNative
        member __.floor(): unit = jsNative
        member __.floorAll(): unit = jsNative
        member __.getPoint(position: float, out: Phaser.Point): Phaser.Point = jsNative
        member __.inflate(dx: float, dy: float): Phaser.Rectangle = jsNative
        member __.intersection(b: Phaser.Rectangle, out: Phaser.Rectangle): Phaser.Rectangle = jsNative
        member __.intersects(b: Phaser.Rectangle, tolerance: float): bool = jsNative
        member __.offset(dx: float, dy: float): Phaser.Rectangle = jsNative
        member __.offsetPoint(point: Phaser.Point): Phaser.Rectangle = jsNative
        member __.random(?out: Phaser.Point): Phaser.Point = jsNative
        member __.resize(width: float, height: float): Phaser.Rectangle = jsNative
        member __.setTo(x: float, y: float, width: float, height: float): Phaser.Rectangle = jsNative
        member __.scale(x: float, ?y: float): Phaser.Rectangle = jsNative
        member __.size(?output: Phaser.Point): Phaser.Point = jsNative
        member __.toString(): string = jsNative
        member __.union(b: Phaser.Rectangle, ?out: Phaser.Rectangle): Phaser.Rectangle = jsNative

    and [<AllowNullLiteral>] [<Import("RenderTexture","Phaser")>] RenderTexture(game: Phaser.Game, ?width: float, ?height: float, ?key: string, ?scaleMode: float, ?resolution: float) =
        // interface PIXI.RenderTexture
        member __.crop with get(): PIXI.Rectangle = jsNative and set(v: PIXI.Rectangle): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.key with get(): string = jsNative and set(v: string): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.render(displayObject: PIXI.DisplayObject, ?matrix: Phaser.Matrix, ?clear: bool): unit = jsNative
        member __.renderXY(displayObject: PIXI.DisplayObject, x: float, y: float, ?clear: bool): unit = jsNative
        member __.renderRawXY(displayObject: PIXI.DisplayObject, x: float, y: float, ?clear: bool): unit = jsNative

    and [<AllowNullLiteral>] [<Import("RequestAnimationFrame","Phaser")>] RequestAnimationFrame(game: Phaser.Game, ?forceSetTimeOut: bool) =
        member __.forceSetTimeOut with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.isRunning with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isRAF(): bool = jsNative
        member __.isSetTimeOut(): bool = jsNative
        member __.start(): bool = jsNative
        member __.stop(): unit = jsNative
        member __.updateRAF(rafTime: float): unit = jsNative
        member __.updateSetTimeout(time: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("RetroFont","Phaser")>] RetroFont(game: Phaser.Game, key: string, characterWidth: float, characterHeight: float, chars: string, ?charsPerRow: float, ?xSpacing: float, ?ySpacing: float, ?xOffset: float, ?yOffset: float) =
        inherit Phaser.RenderTexture()
        member __.ALIGN_CENTER with get(): string = jsNative and set(v: string): unit = jsNative
        member __.ALIGN_LEFT with get(): string = jsNative and set(v: string): unit = jsNative
        member __.ALIGN_RIGHT with get(): string = jsNative and set(v: string): unit = jsNative
        member __.TEXT_SET1 with get(): string = jsNative and set(v: string): unit = jsNative
        member __.TEXT_SET2 with get(): string = jsNative and set(v: string): unit = jsNative
        member __.TEXT_SET3 with get(): string = jsNative and set(v: string): unit = jsNative
        member __.TEXT_SET4 with get(): string = jsNative and set(v: string): unit = jsNative
        member __.TEXT_SET5 with get(): string = jsNative and set(v: string): unit = jsNative
        member __.TEXT_SET6 with get(): string = jsNative and set(v: string): unit = jsNative
        member __.TEXT_SET7 with get(): string = jsNative and set(v: string): unit = jsNative
        member __.TEXT_SET8 with get(): string = jsNative and set(v: string): unit = jsNative
        member __.TEXT_SET9 with get(): string = jsNative and set(v: string): unit = jsNative
        member __.TEXT_SET10 with get(): string = jsNative and set(v: string): unit = jsNative
        member __.TEXT_SET11 with get(): string = jsNative and set(v: string): unit = jsNative
        member __.align with get(): string = jsNative and set(v: string): unit = jsNative
        member __.autoUpperCase with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.characterHeight with get(): float = jsNative and set(v: float): unit = jsNative
        member __.characterPerRow with get(): float = jsNative and set(v: float): unit = jsNative
        member __.characterSpacingX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.characterSpacingY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.characterWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.customSpacingX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.customSpacingY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fixedWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fontSet with get(): Image = jsNative and set(v: Image): unit = jsNative
        member __.frameData with get(): Phaser.FrameData = jsNative and set(v: Phaser.FrameData): unit = jsNative
        member __.multiLine with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.offsetX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.offsetY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.smoothed with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.stamp with get(): Phaser.Image = jsNative and set(v: Phaser.Image): unit = jsNative
        member __.text with get(): string = jsNative and set(v: string): unit = jsNative
        member __.buildRetroFontText(): unit = jsNative
        member __.getLongestLine(): float = jsNative
        member __.pasteLine(line: string, x: float, y: float, customSpacingX: float): unit = jsNative
        member __.removeUnsupportedCharacters(?stripCR: bool): string = jsNative
        member __.setFixedWidth(width: float, ?lineAlignment: string): unit = jsNative
        member __.setText(content: string, ?multiLine: bool, ?characterSpacing: float, ?lineSpacing: float, ?lineAlignment: string, ?allowLowerCase: bool): unit = jsNative
        member __.updateOffset(?x: float, ?y: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Rope","Phaser")>] Rope(game: Phaser.Game, x: float, y: float, key: obj, ?frame: U2<string, float>, ?points: ResizeArray<Phaser.Point>) =
        // interface PIXI.Rope
        member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
        member __.animations with get(): Phaser.AnimationManager = jsNative and set(v: Phaser.AnimationManager): unit = jsNative
        member __.alive with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.autoCull with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.body with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
        member __.cameraOffset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.checkWorldBounds with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.cropRect with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.components with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.customRender with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.debug with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.deltaX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.deltaY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.deltaZ with get(): float = jsNative and set(v: float): unit = jsNative
        member __.destroyPhase with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.exists with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.events with get(): Phaser.Events = jsNative and set(v: Phaser.Events): unit = jsNative
        member __.fixedToCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.frame with get(): U2<string, float> = jsNative and set(v: U2<string, float>): unit = jsNative
        member __.frameName with get(): string = jsNative and set(v: string): unit = jsNative
        member __.fresh with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.inCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.input with get(): Phaser.InputHandler = jsNative and set(v: Phaser.InputHandler): unit = jsNative
        member __.inputEnabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.inWorld with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.left with get(): float = jsNative and set(v: float): unit = jsNative
        member __.lifespan with get(): float = jsNative and set(v: float): unit = jsNative
        member __.key with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.offsetX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.offsetY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.outOfBoundsKill with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.pendingDestroy with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.points with get(): ResizeArray<Phaser.Point> = jsNative and set(v: ResizeArray<Phaser.Point>): unit = jsNative
        member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.previousPosition with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.previousRotation with get(): float = jsNative and set(v: float): unit = jsNative
        member __.right with get(): float = jsNative and set(v: float): unit = jsNative
        member __.renderOrderID with get(): float = jsNative and set(v: float): unit = jsNative
        member __.segments with get(): ResizeArray<Phaser.Rectangle> = jsNative and set(v: ResizeArray<Phaser.Rectangle>): unit = jsNative
        member __.smoothed with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.top with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.transformCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.transformCallbackContext with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.scaleMin with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.scaleMax with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.updateAnimation with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.world with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.z with get(): float = jsNative and set(v: float): unit = jsNative
        member __.overlap(displayObject: obj): bool = jsNative
        member __.bringToTop(): Phaser.Rope = jsNative
        member __.checkTransform(wt: PIXI.Matrix): unit = jsNative
        member __.crop(rect: Phaser.Rectangle, ?copy: bool): unit = jsNative
        member __.destroy(?destroyChildren: bool): unit = jsNative
        member __.kill(): Phaser.Rope = jsNative
        member __.loadTexture(key: obj, ?frame: U2<string, float>, ?stopAnimation: bool): unit = jsNative
        member __.moveUp(): Phaser.Rope = jsNative
        member __.moveDown(): Phaser.Rope = jsNative
        member __.play(name: string, ?frameRate: float, ?loop: bool, ?killOnComplete: bool): Phaser.Animation = jsNative
        member __.preUpdate(): unit = jsNative
        member __.postUpdate(): unit = jsNative
        member __.reset(x: float, y: float, ?health: float): Phaser.Rope = jsNative
        member __.resizeFrame(parent: obj, width: float, height: float): unit = jsNative
        member __.resetFrame(): unit = jsNative
        member __.revive(?health: float): Phaser.Rope = jsNative
        member __.sendToBack(): Phaser.Rope = jsNative
        member __.setFrame(frame: Phaser.Frame): unit = jsNative
        member __.setScaleMinMax(?minX: float, ?minY: float, ?maxX: float, ?maxY: float): unit = jsNative
        member __.updateCrop(): unit = jsNative
        member __.update(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("RoundedRectangle","Phaser")>] RoundedRectangle() =
        // interface PIXI.RoundedRectangle
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.radius with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.clone(): RoundedRectangle = jsNative
        member __.contains(x: float, y: float): bool = jsNative

    and [<AllowNullLiteral>] [<Import("Signal","Phaser")>] Signal() =
        member __.active with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.boundDispatch with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.memorize with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.add(listener: Function, listenerContext: obj, priority: float, [<ParamArray>] args: obj[]): Phaser.SignalBinding = jsNative
        member __.addOnce(listener: Function, listenerContext: obj, priority: float, [<ParamArray>] args: obj[]): Phaser.SignalBinding = jsNative
        member __.dispatch([<ParamArray>] ``params``: obj[]): unit = jsNative
        member __.dispose(): unit = jsNative
        member __.forget(): unit = jsNative
        member __.getNumListeners(): float = jsNative
        member __.halt(): unit = jsNative
        member __.has(listener: Function, ?context: obj): bool = jsNative
        member __.remove(listener: Function, ?context: obj): Function = jsNative
        member __.removeAll(?context: obj): unit = jsNative
        member __.toString(): string = jsNative
        member __.validateListener(listener: Function, fnName: string): unit = jsNative

    and [<AllowNullLiteral>] [<Import("SignalBinding","Phaser")>] SignalBinding(signal: Phaser.Signal, listener: Function, isOnce: bool, listenerContext: obj, priority: float, [<ParamArray>] args: obj[]) =
        member __.active with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.callCount with get(): float = jsNative and set(v: float): unit = jsNative
        member __.context with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.``params`` with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
        member __.execute(?paramsArr: ResizeArray<obj>): unit = jsNative
        member __.detach(): Function = jsNative
        member __.isBound(): bool = jsNative
        member __.isOnce(): bool = jsNative
        member __.getListener(): Function = jsNative
        member __.getSignal(): Phaser.Signal = jsNative
        member __.toString(): string = jsNative

    and [<AllowNullLiteral>] [<Import("SinglePad","Phaser")>] SinglePad(game: Phaser.Game, padParent: obj) =
        member __.callbackContext with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.connected with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.deadZone with get(): float = jsNative and set(v: float): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.index with get(): float = jsNative and set(v: float): unit = jsNative
        member __.onAxisCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onConnectCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onDisconnectCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onDownCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onFloatCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onUpCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.axis(axisCode: float): float = jsNative
        member __.addCallbacks(context: obj, callbacks: obj): unit = jsNative
        member __.buttonValue(buttonCode: float): float = jsNative
        member __.connect(rawPad: obj): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.disconnect(): unit = jsNative
        member __.getButton(buttonCode: float): Phaser.DeviceButton = jsNative
        member __.isDown(buttonCode: float): bool = jsNative
        member __.isUp(buttonCode: float): bool = jsNative
        member __.justPressed(buttonCode: float, ?duration: float): bool = jsNative
        member __.justReleased(buttonCode: float, ?duration: float): bool = jsNative
        member __.pollStatus(): unit = jsNative
        member __.processAxisChange(axisState: obj): unit = jsNative
        member __.processButtonDown(buttonCode: float, value: obj): unit = jsNative
        member __.processButtonFloat(buttonCode: float, value: obj): unit = jsNative
        member __.processButtonUp(buttonCode: float, value: obj): unit = jsNative
        member __.reset(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Sound","Phaser")>] Sound(game: Phaser.Game, key: string, ?volume: float, ?loop: bool, ?connect: bool) =
        member __.autoplay with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.allowMultiple with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.context with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.currentMarker with get(): string = jsNative and set(v: string): unit = jsNative
        member __.currentTime with get(): float = jsNative and set(v: float): unit = jsNative
        member __.duration with get(): float = jsNative and set(v: float): unit = jsNative
        member __.durationMS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.externalNode with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.fadeTween with get(): Phaser.Tween = jsNative and set(v: Phaser.Tween): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.gainNode with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.isDecoded with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isDecoding with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isPlaying with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.key with get(): string = jsNative and set(v: string): unit = jsNative
        member __.loop with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.markers with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.masterGainNode with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.mute with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.onDecoded with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onEndedHandler with get(): Func<unit, unit> = jsNative and set(v: Func<unit, unit>): unit = jsNative
        member __.onFadeComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onLoop with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onMarkerComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onMute with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onPause with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onPlay with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onResume with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onStop with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.``override`` with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.paused with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.pausedPosition with get(): float = jsNative and set(v: float): unit = jsNative
        member __.pausedTime with get(): float = jsNative and set(v: float): unit = jsNative
        member __.pendingPlayback with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.position with get(): float = jsNative and set(v: float): unit = jsNative
        member __.startTime with get(): float = jsNative and set(v: float): unit = jsNative
        member __.stopTime with get(): float = jsNative and set(v: float): unit = jsNative
        member __.totalDuration with get(): float = jsNative and set(v: float): unit = jsNative
        member __.usingAudioTag with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.usingWebAudio with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.volume with get(): float = jsNative and set(v: float): unit = jsNative
        member __.destroy(?remove: bool): unit = jsNative
        member __.addMarker(name: string, start: float, duration: float, ?volume: float, ?loop: bool): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.fadeIn(?duration: float, ?loop: bool, ?marker: string): unit = jsNative
        member __.fadeOut(?duration: float): unit = jsNative
        member __.fadeTo(?duration: float, ?volume: float): unit = jsNative
        member __.loopFull(?volume: float): Phaser.Sound = jsNative
        member __.pause(): unit = jsNative
        member __.play(?marker: string, ?position: float, ?volume: float, ?loop: bool, ?forceRestart: bool): Phaser.Sound = jsNative
        member __.removeMarker(name: string): unit = jsNative
        member __.restart(marker: string, position: float, ?volume: float, ?loop: bool): unit = jsNative
        member __.resume(): unit = jsNative
        member __.soundHasUnlocked(key: string): unit = jsNative
        member __.stop(): unit = jsNative
        member __.update(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("SoundManager","Phaser")>] SoundManager(game: Phaser.Game) =
        member __.channels with get(): float = jsNative and set(v: float): unit = jsNative
        member __.connectToMaster with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.context with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.mute with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.muteOnPause with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.noAudio with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.onSoundDecode with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onVolumeChange with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onMute with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onUnMute with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.touchLocked with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.usingAudioTag with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.usingWebAudio with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.volume with get(): float = jsNative and set(v: float): unit = jsNative
        member __.add(key: string, ?volume: float, ?loop: bool, ?connect: bool): Phaser.Sound = jsNative
        member __.addSprite(key: string): Phaser.AudioSprite = jsNative
        member __.boot(): unit = jsNative
        member __.decode(key: string, ?sound: Phaser.Sound): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.pauseAll(): unit = jsNative
        member __.play(key: string, ?volume: float, ?loop: bool): Phaser.Sound = jsNative
        member __.remove(sound: Phaser.Sound): bool = jsNative
        member __.removeByKey(key: string): float = jsNative
        member __.resumeAll(): unit = jsNative
        member __.setDecodedCallback(files: U2<ResizeArray<string>, ResizeArray<Phaser.Sound>>, callback: Function, callbackContext: obj): unit = jsNative
        member __.setTouchLock(): unit = jsNative
        member __.stopAll(): unit = jsNative
        member __.unlock(): bool = jsNative
        member __.update(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Sprite","Phaser")>] Sprite(game: Phaser.Game, x: float, y: float, ?key: U4<string, Phaser.RenderTexture, Phaser.BitmapData, PIXI.Texture>, ?frame: U2<string, float>) =
        // interface PIXI.Sprite
        member __.alive with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.anchor with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
        member __.animations with get(): Phaser.AnimationManager = jsNative and set(v: Phaser.AnimationManager): unit = jsNative
        member __.autoCull with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.body with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
        member __.cameraOffset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.centerX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.centerY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.checkWorldBounds with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.components with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.cropRect with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.customRender with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.data with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.debug with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.deltaX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.deltaY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.deltaZ with get(): float = jsNative and set(v: float): unit = jsNative
        member __.destroyPhase with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.events with get(): Phaser.Events = jsNative and set(v: Phaser.Events): unit = jsNative
        member __.exists with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.fixedToCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.frame with get(): U2<string, float> = jsNative and set(v: U2<string, float>): unit = jsNative
        member __.frameName with get(): string = jsNative and set(v: string): unit = jsNative
        member __.fresh with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.health with get(): float = jsNative and set(v: float): unit = jsNative
        member __.inCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.input with get(): Phaser.InputHandler = jsNative and set(v: Phaser.InputHandler): unit = jsNative
        member __.inputEnabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.inWorld with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.key with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.left with get(): float = jsNative and set(v: float): unit = jsNative
        member __.lifespan with get(): float = jsNative and set(v: float): unit = jsNative
        member __.maxHealth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.offsetX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.offsetY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.outOfBoundsKill with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.pendingDestroy with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.previousPosition with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.previousRotation with get(): float = jsNative and set(v: float): unit = jsNative
        member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.physicsEnabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.physicsType with get(): float = jsNative and set(v: float): unit = jsNative
        member __.renderOrderID with get(): float = jsNative and set(v: float): unit = jsNative
        member __.right with get(): float = jsNative and set(v: float): unit = jsNative
        member __.scale with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.scaleMin with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.scaleMax with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.smoothed with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.top with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.tintedTexture with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
        member __.transformCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.transformCallbackContext with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.world with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.z with get(): float = jsNative and set(v: float): unit = jsNative
        member __.alignIn(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): obj = jsNative
        member __.alignTo(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): obj = jsNative
        member __.bringToTop(): Phaser.Sprite = jsNative
        member __.crop(rect: Phaser.Rectangle, copy: bool): unit = jsNative
        member __.checkTransform(wt: PIXI.Matrix): unit = jsNative
        member __.damage(amount: float): Phaser.Sprite = jsNative
        member __.destroy(?destroyChildren: bool): unit = jsNative
        member __.drawPolygon(): unit = jsNative
        member __.heal(amount: float): Phaser.Sprite = jsNative
        member __.kill(): Phaser.Sprite = jsNative
        member __.loadTexture(key: obj, ?frame: U2<string, float>, ?stopAnimation: bool): unit = jsNative
        member __.moveUp(): Phaser.Sprite = jsNative
        member __.moveDown(): Phaser.Sprite = jsNative
        member __.overlap(displayObject: obj): bool = jsNative
        member __.play(name: string, ?frameRate: float, ?loop: bool, ?killOnComplete: bool): Phaser.Animation = jsNative
        member __.postUpdate(): unit = jsNative
        member __.preUpdate(): unit = jsNative
        member __.reset(x: float, y: float, ?health: float): Phaser.Sprite = jsNative
        member __.resetFrame(): unit = jsNative
        member __.resizeFrame(parent: obj, width: float, height: float): unit = jsNative
        member __.revive(?health: float): Phaser.Sprite = jsNative
        member __.sendToBack(): Phaser.Sprite = jsNative
        member __.setFrame(frame: Phaser.Frame): unit = jsNative
        member __.setScaleMinMax(?minX: float, ?minY: float, ?maxX: float, ?maxY: float): unit = jsNative
        member __.update(): unit = jsNative
        member __.updateCrop(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("SpriteBatch","Phaser")>] SpriteBatch(game: Phaser.Game, parent: obj, ?name: string, ?addedToStage: bool) =
        inherit Phaser.Group()
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Stage","Phaser")>] Stage(game: Phaser.Game) =
        // interface PIXI.DisplayObjectContainer
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.disableVisibilityChange with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.exists with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.currentRenderOrderID with get(): float = jsNative and set(v: float): unit = jsNative
        member __.backgroundColor with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.smoothed with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.parseConfig(config: obj): unit = jsNative
        member __.preUpdate(): unit = jsNative
        member __.update(): unit = jsNative
        member __.postUpdate(): unit = jsNative
        member __.updateTransform(): unit = jsNative
        member __.checkVisibility(): unit = jsNative
        member __.visibilityChange(``event``: Event): unit = jsNative
        member __.setBackgroundColor(backgroundColor: U2<float, string>): unit = jsNative
        member __.destroy(): unit = jsNative

    and [<AllowNullLiteral>] ResizeCallback =
        [<Emit("$0($1...)")>] abstract Invoke: scale: ScaleManager * parentBounds: Rectangle -> obj

    and [<AllowNullLiteral>] [<Import("ScaleManager","Phaser")>] ScaleManager(game: Phaser.Game, width: U2<float, string>, height: U2<float, string>) =
        member __.EXACT_FIT with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NO_SCALE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SHOW_ALL with get(): float = jsNative and set(v: float): unit = jsNative
        member __.RESIZE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.USER_SCALE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.aspectRatio with get(): float = jsNative and set(v: float): unit = jsNative
        member __.bounds with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
        member __.boundingParent with get(): HTMLElement = jsNative and set(v: HTMLElement): unit = jsNative
        member __.compatibility with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.currentScaleMode with get(): float = jsNative and set(v: float): unit = jsNative
        member __.dom with get(): Phaser.DOM = jsNative and set(v: Phaser.DOM): unit = jsNative
        member __.enterIncorrectOrientation with get(): Signal = jsNative and set(v: Signal): unit = jsNative
        member __.``event`` with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.forceLandscape with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.forcePortrait with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.fullScreenScaleMode with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fullScreenTarget with get(): HTMLElement = jsNative and set(v: HTMLElement): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.grid with get(): Phaser.FlexGrid = jsNative and set(v: Phaser.FlexGrid): unit = jsNative
        member __.hasPhaserSetFullScreen with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.incorrectOrientation with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isFullScreen with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isGameLandscape with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isGamePortrait with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isPortrait with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isLandscape with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.leaveIncorrectOrientation with get(): Signal = jsNative and set(v: Signal): unit = jsNative
        member __.margin with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.maxHeight with get(): float = jsNative and set(v: float): unit = jsNative
        member __.maxWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.minHeight with get(): float = jsNative and set(v: float): unit = jsNative
        member __.minWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.offset with get(): Point = jsNative and set(v: Point): unit = jsNative
        member __.onFullScreenInit with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onFullScreenChange with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onFullScreenError with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onOrientationChange with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onSizeChange with get(): Signal = jsNative and set(v: Signal): unit = jsNative
        member __.pageAlignHorizontally with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.pageAlignVertically with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.parentNode with get(): HTMLElement = jsNative and set(v: HTMLElement): unit = jsNative
        member __.parentIsWindow with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.parentScaleFactor with get(): Point = jsNative and set(v: Point): unit = jsNative
        member __.scaleFactor with get(): Point = jsNative and set(v: Point): unit = jsNative
        member __.scaleFactorInversed with get(): Point = jsNative and set(v: Point): unit = jsNative
        member __.scaleMode with get(): float = jsNative and set(v: float): unit = jsNative
        member __.screenOrientation with get(): string = jsNative and set(v: string): unit = jsNative
        member __.sourceAspectRatio with get(): float = jsNative and set(v: float): unit = jsNative
        member __.trackParentInterval with get(): float = jsNative and set(v: float): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.windowConstraints with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.boot(): unit = jsNative
        member __.createFullScreenTarget(): HTMLDivElement = jsNative
        member __.destroy(): unit = jsNative
        member __.forceOrientation(forceLandscape: bool, ?forcePortrait: bool): unit = jsNative
        member __.getParentBounds(?target: Rectangle): Rectangle = jsNative
        member __.parseConfig(config: obj): unit = jsNative
        member __.preUpdate(): unit = jsNative
        member __.pauseUpdate(): unit = jsNative
        member __.refresh(): unit = jsNative
        member __.setGameSize(width: float, height: float): unit = jsNative
        member __.setResizeCallback(callback: ResizeCallback, context: obj): unit = jsNative
        member __.setUserScale(hScale: float, vScale: float, ?hTrim: float, ?vTrim: float): unit = jsNative
        member __.setMinMax(minWidth: float, minHeight: float, ?maxWidth: float, ?maxHeight: float): unit = jsNative
        member __.setupScale(width: float, height: float): unit = jsNative
        member __.setupScale(width: string, height: string): unit = jsNative
        member __.scaleSprite(sprite: Sprite, ?width: float, ?height: float, ?letterBox: bool): Sprite = jsNative
        member __.scaleSprite(sprite: Image, ?width: float, ?height: float, ?letterBox: bool): Sprite = jsNative
        member __.startFullScreen(?antialias: bool, ?allowTrampoline: bool): bool = jsNative
        member __.stopFullScreen(): bool = jsNative

    and [<AllowNullLiteral>] [<Import("DOM","Phaser")>] DOM() =
        member __.visualBounds with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.layoutBounds with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.documentBounds with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        static member calibrate(coords: obj, ?cushion: float): obj = jsNative
        static member getAspectRatio(``object``: obj): float = jsNative
        static member getScreenOrientation(?primaryFallback: string): string = jsNative
        static member getBounds(element: obj, ?cushion: float): obj = jsNative
        static member getOffset(element: obj, ?point: Point): Point = jsNative
        static member inLayoutViewport(element: obj, ?cushion: float): bool = jsNative

    and [<AllowNullLiteral>] [<Import("State","Phaser")>] State() =
        member __.add with get(): Phaser.GameObjectFactory = jsNative and set(v: Phaser.GameObjectFactory): unit = jsNative
        member __.cache with get(): Phaser.Cache = jsNative and set(v: Phaser.Cache): unit = jsNative
        member __.camera with get(): Phaser.Camera = jsNative and set(v: Phaser.Camera): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.input with get(): Phaser.Input = jsNative and set(v: Phaser.Input): unit = jsNative
        member __.key with get(): string = jsNative and set(v: string): unit = jsNative
        member __.load with get(): Phaser.Loader = jsNative and set(v: Phaser.Loader): unit = jsNative
        member __.make with get(): Phaser.GameObjectCreator = jsNative and set(v: Phaser.GameObjectCreator): unit = jsNative
        member __.particles with get(): Phaser.Particles = jsNative and set(v: Phaser.Particles): unit = jsNative
        member __.physics with get(): Phaser.Physics = jsNative and set(v: Phaser.Physics): unit = jsNative
        member __.rnd with get(): Phaser.RandomDataGenerator = jsNative and set(v: Phaser.RandomDataGenerator): unit = jsNative
        member __.scale with get(): Phaser.ScaleManager = jsNative and set(v: Phaser.ScaleManager): unit = jsNative
        member __.sound with get(): Phaser.SoundManager = jsNative and set(v: Phaser.SoundManager): unit = jsNative
        member __.stage with get(): Phaser.Stage = jsNative and set(v: Phaser.Stage): unit = jsNative
        member __.time with get(): Phaser.Time = jsNative and set(v: Phaser.Time): unit = jsNative
        member __.tweens with get(): Phaser.TweenManager = jsNative and set(v: Phaser.TweenManager): unit = jsNative
        member __.world with get(): Phaser.World = jsNative and set(v: Phaser.World): unit = jsNative
        member __.create(): unit = jsNative
        member __.init([<ParamArray>] args: obj[]): unit = jsNative
        member __.loadRender(): unit = jsNative
        member __.loadUpdate(): unit = jsNative
        member __.paused(): unit = jsNative
        member __.pauseUpdate(): unit = jsNative
        member __.preload(): unit = jsNative
        member __.preRender(): unit = jsNative
        member __.render(): unit = jsNative
        member __.resize(): unit = jsNative
        member __.resumed(): unit = jsNative
        member __.shutdown(): unit = jsNative
        member __.update(): unit = jsNative

    and [<AllowNullLiteral>] IStateCycle =
        abstract preUpdate: unit -> unit
        abstract update: unit -> unit
        abstract render: unit -> unit
        abstract postRender: unit -> unit
        abstract destroy: unit -> unit

    and [<AllowNullLiteral>] [<Import("StateManager","Phaser")>] StateManager(game: Phaser.Game, ?pendingState: Phaser.State) =
        member __.created with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.current with get(): string = jsNative and set(v: string): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.onCreateCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onInitCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onLoadRenderCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onLoadUpdateCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onPausedCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onPauseUpdateCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onPreloadCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onPreRenderCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onRenderCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onResumedCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onResizeCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onShutDownCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.onUpdateCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.states with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.onStateChange with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.add(key: string, state: obj, ?autoStart: bool): unit = jsNative
        member __.checkState(key: string): bool = jsNative
        member __.clearCurrentState(): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.getCurrentState(): Phaser.State = jsNative
        member __.link(key: string): unit = jsNative
        member __.loadComplete(): unit = jsNative
        member __.preRender(elapsedTime: float): unit = jsNative
        member __.preUpdate(): unit = jsNative
        member __.render(): unit = jsNative
        member __.remove(key: string): unit = jsNative
        member __.resume(): unit = jsNative
        member __.restart(clearWorld: bool, clearCache: bool, [<ParamArray>] args: obj[]): unit = jsNative
        member __.resize(width: float, height: float): unit = jsNative
        member __.start(key: string, clearWorld: bool, clearCache: bool, [<ParamArray>] args: obj[]): unit = jsNative
        member __.update(): unit = jsNative
        member __.unlink(key: string): unit = jsNative

    and [<AllowNullLiteral>] PhaserTextStyle =
        abstract font: string option with get, set
        abstract fill: obj option with get, set
        abstract align: string option with get, set
        abstract stroke: string option with get, set
        abstract strokeThickness: float option with get, set
        abstract wordWrap: bool option with get, set
        abstract wordWrapWidth: float option with get, set
        abstract maxLines: float option with get, set
        abstract shadowOffsetX: float option with get, set
        abstract shadowOffsetY: float option with get, set
        abstract shadowColor: string option with get, set
        abstract shadowBlur: float option with get, set
        abstract valign: string option with get, set
        abstract tab: float option with get, set
        abstract tabs: float option with get, set
        abstract fontSize: float option with get, set
        abstract fontStyle: string option with get, set
        abstract fontVariant: string option with get, set
        abstract fontWeight: U2<string, float> option with get, set
        abstract backgroundColor: string option with get, set
        abstract boundsAlignH: string option with get, set
        abstract boundsAlignV: string option with get, set

    and [<AllowNullLiteral>] [<Import("Text","Phaser")>] Text(game: Phaser.Game, x: float, y: float, text: string, ?style: PhaserTextStyle) =
        inherit Phaser.Sprite()
        member __.fontPropertiesCanvas with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.fontPropertiesContext with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.fontPropertiesCache with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.align with get(): string = jsNative and set(v: string): unit = jsNative
        member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
        member __.autoRound with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.boundsAlignH with get(): string = jsNative and set(v: string): unit = jsNative
        member __.boundsAlignV with get(): string = jsNative and set(v: string): unit = jsNative
        member __.cameraOffset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.canvas with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
        member __.colors with get(): ResizeArray<string> = jsNative and set(v: ResizeArray<string>): unit = jsNative
        member __.context with get(): CanvasRenderingContext2D = jsNative and set(v: CanvasRenderingContext2D): unit = jsNative
        member __.cssFont with get(): string = jsNative and set(v: string): unit = jsNative
        member __.destroyPhase with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.events with get(): Phaser.Events = jsNative and set(v: Phaser.Events): unit = jsNative
        member __.exists with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.fill with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.fixedToCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.font with get(): string = jsNative and set(v: string): unit = jsNative
        member __.fontSize with get(): U2<float, string> = jsNative and set(v: U2<float, string>): unit = jsNative
        member __.fontStyle with get(): string = jsNative and set(v: string): unit = jsNative
        member __.fontStyles with get(): ResizeArray<string> = jsNative and set(v: ResizeArray<string>): unit = jsNative
        member __.fontVariant with get(): string = jsNative and set(v: string): unit = jsNative
        member __.fontWeight with get(): U2<string, float> = jsNative and set(v: U2<string, float>): unit = jsNative
        member __.fontWeights with get(): ResizeArray<U2<string, float>> = jsNative and set(v: ResizeArray<U2<string, float>>): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.input with get(): Phaser.InputHandler = jsNative and set(v: Phaser.InputHandler): unit = jsNative
        member __.inputEnabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.lineSpacing with get(): float = jsNative and set(v: float): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.padding with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.pendingDestroy with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.physicsType with get(): float = jsNative and set(v: float): unit = jsNative
        member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.previousPosition with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.previousRotation with get(): float = jsNative and set(v: float): unit = jsNative
        member __.renderOrderID with get(): float = jsNative and set(v: float): unit = jsNative
        member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
        member __.shadowBlur with get(): float = jsNative and set(v: float): unit = jsNative
        member __.shadowColor with get(): string = jsNative and set(v: string): unit = jsNative
        member __.shadowFill with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.shadowOffsetX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.shadowOffsetY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.shadowStroke with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.stroke with get(): string = jsNative and set(v: string): unit = jsNative
        member __.strokeColors with get(): ResizeArray<string> = jsNative and set(v: ResizeArray<string>): unit = jsNative
        member __.strokeThickness with get(): float = jsNative and set(v: float): unit = jsNative
        member __.scale with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.tab with get(): float = jsNative and set(v: float): unit = jsNative
        member __.tabs with get(): U2<float, ResizeArray<float>> = jsNative and set(v: U2<float, ResizeArray<float>>): unit = jsNative
        member __.text with get(): string = jsNative and set(v: string): unit = jsNative
        member __.textBounds with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.useAdvancedWrap with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.world with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.wordWrap with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.wordWrapWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.z with get(): float = jsNative and set(v: float): unit = jsNative
        member __.addColor(color: string, position: float): Phaser.Text = jsNative
        member __.addFontStyle(style: string, position: float): Phaser.Text = jsNative
        member __.addFontWeight(weight: string, position: float): Phaser.Text = jsNative
        member __.addStrokeColor(color: string, position: float): Phaser.Text = jsNative
        member __.alignIn(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): obj = jsNative
        member __.alignTo(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): obj = jsNative
        member __.clearColors(): Phaser.Text = jsNative
        member __.clearFontValues(): Phaser.Text = jsNative
        member __.componentsToFont(components: obj): string = jsNative
        member __.destroy(?destroyChildren: bool): unit = jsNative
        member __.fontToComponents(font: string): obj = jsNative
        member __.postUpdate(): unit = jsNative
        member __.parseList(list: ResizeArray<obj>): Phaser.Text = jsNative
        member __.precalculateWordWrap(text: string): ResizeArray<string> = jsNative
        member __.preUpdate(): unit = jsNative
        member __.renderTabLine(line: string, x: float, y: float, ?fill: bool): unit = jsNative
        member __.setShadow(?x: float, ?y: float, ?color: obj, ?blur: float, ?shadowStroke: bool, ?shadowFill: bool): Phaser.Text = jsNative
        member __.setStyle(?style: PhaserTextStyle, ?update: bool): Phaser.Text = jsNative
        member __.setText(text: string, ?immediate: bool): Phaser.Text = jsNative
        member __.setTextBounds(?x: float, ?y: float, ?width: float, ?height: float): Phaser.Text = jsNative
        member __.update(): unit = jsNative
        member __.updateFont(components: obj): unit = jsNative
        member __.updateLine(text: string, ?x: float, ?y: float): unit = jsNative
        member __.updateShadow(?state: bool): unit = jsNative
        member __.updateTexture(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Tile","Phaser")>] Tile(layer: obj, index: float, x: float, y: float, width: float, height: float) =
        member __.alpha with get(): float = jsNative and set(v: float): unit = jsNative
        member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
        member __.callback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.callbackContext with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.centerX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.centerY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.canCollide with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.collideDown with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.collideLeft with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.collideNone with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.collideRight with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.collisionCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.collisionCallbackContext with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.collides with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.collideUp with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.faceBottom with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.faceLeft with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.faceRight with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.faceTop with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.index with get(): float = jsNative and set(v: float): unit = jsNative
        member __.layer with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.left with get(): float = jsNative and set(v: float): unit = jsNative
        member __.properties with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.right with get(): float = jsNative and set(v: float): unit = jsNative
        member __.scanned with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.top with get(): float = jsNative and set(v: float): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.worldX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.worldY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.copy(tile: Phaser.Tile): Phaser.Tile = jsNative
        member __.containsPoint(x: float, y: float): bool = jsNative
        member __.destroy(): unit = jsNative
        member __.intersects(x: float, y: float, right: float, bottom: float): bool = jsNative
        member __.isInterested(collides: bool, faces: bool): bool = jsNative
        member __.resetCollision(): unit = jsNative
        member __.setCollision(left: bool, right: bool, up: bool, down: bool): unit = jsNative
        member __.setCollisionCallback(callback: Function, context: obj): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Tilemap","Phaser")>] Tilemap(game: Phaser.Game, ?key: string, ?tileWidth: float, ?tileHeight: float, ?width: float, ?height: float) =
        member __.CSV with get(): float = jsNative and set(v: float): unit = jsNative
        member __.TILED_JSON with get(): float = jsNative and set(v: float): unit = jsNative
        member __.NORTH with get(): float = jsNative and set(v: float): unit = jsNative
        member __.EAST with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SOUTH with get(): float = jsNative and set(v: float): unit = jsNative
        member __.WEST with get(): float = jsNative and set(v: float): unit = jsNative
        member __.collision with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
        member __.collideIndexes with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
        member __.currentLayer with get(): float = jsNative and set(v: float): unit = jsNative
        member __.debugMap with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
        member __.enableDebug with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.format with get(): float = jsNative and set(v: float): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.heightInPixels with get(): float = jsNative and set(v: float): unit = jsNative
        member __.images with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
        member __.imagecollections with get(): ResizeArray<ImageCollection> = jsNative and set(v: ResizeArray<ImageCollection>): unit = jsNative
        member __.key with get(): string = jsNative and set(v: string): unit = jsNative
        member __.layer with get(): ResizeArray<Phaser.TilemapLayer> = jsNative and set(v: ResizeArray<Phaser.TilemapLayer>): unit = jsNative
        member __.layers with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
        member __.objects with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
        member __.orientation with get(): string = jsNative and set(v: string): unit = jsNative
        member __.properties with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.rayStepRate with get(): float = jsNative and set(v: float): unit = jsNative
        member __.tileHeight with get(): float = jsNative and set(v: float): unit = jsNative
        member __.tiles with get(): ResizeArray<Phaser.Tile> = jsNative and set(v: ResizeArray<Phaser.Tile>): unit = jsNative
        member __.tilesets with get(): ResizeArray<Phaser.Tileset> = jsNative and set(v: ResizeArray<Phaser.Tileset>): unit = jsNative
        member __.tileWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.version with get(): float = jsNative and set(v: float): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.widthInPixels with get(): float = jsNative and set(v: float): unit = jsNative
        member __.addTilesetImage(tileset: string, ?key: U2<string, Phaser.BitmapData>, ?tileWidth: float, ?tileHeight: float, ?tileMargin: float, ?tileSpacing: float, ?gid: float): Phaser.Tileset = jsNative
        member __.calculateFaces(layer: float): unit = jsNative
        member __.copy(x: float, y: float, width: float, height: float, ?layer: obj): ResizeArray<Phaser.Tile> = jsNative
        member __.create(name: string, width: float, height: float, tileWidth: float, tileHeight: float, ?group: Phaser.Group): Phaser.TilemapLayer = jsNative
        member __.createBlankLayer(name: string, width: float, height: float, tileWidth: float, tileHeight: float, ?group: Phaser.Group): Phaser.TilemapLayer = jsNative
        member __.createFromObjects(name: string, gid: float, key: string, ?frame: obj, ?exists: bool, ?autoCull: bool, ?group: Phaser.Group, ?CustomClass: obj, ?adjustY: bool): unit = jsNative
        member __.createFromTiles(tiles: obj, replacements: obj, key: string, ?layer: obj, ?group: Phaser.Group, ?properties: obj): float = jsNative
        member __.createLayer(layer: obj, ?width: float, ?height: float, ?group: Phaser.Group): Phaser.TilemapLayer = jsNative
        member __.destroy(): unit = jsNative
        member __.dump(): unit = jsNative
        member __.fill(index: float, x: float, y: float, width: float, height: float, ?layer: obj): unit = jsNative
        member __.forEach(callback: Function, context: obj, x: float, y: float, width: float, height: float, ?layer: obj): unit = jsNative
        member __.getImageIndex(name: string): float = jsNative
        member __.getIndex(location: ResizeArray<obj>, name: string): float = jsNative
        member __.getLayer(layer: obj): float = jsNative
        member __.getLayerIndex(name: string): float = jsNative
        member __.getObjectIndex(name: string): float = jsNative
        member __.getTile(x: float, y: float, ?layer: obj, ?nonNull: bool): Phaser.Tile = jsNative
        member __.getRayCastTiles(layer: U2<Phaser.TilemapLayer, Phaser.TilemapLayerGL>, line: Phaser.Line, ?stepRate: float, ?collides: bool, ?interestingFace: bool): ResizeArray<Phaser.Tile> = jsNative
        member __.getTiles(layer: U2<Phaser.TilemapLayer, Phaser.TilemapLayerGL>, x: float, y: float, width: float, height: float, ?collides: bool, ?interestingFace: bool): ResizeArray<Phaser.Tile> = jsNative
        member __.getTileX(layer: U2<Phaser.TilemapLayer, Phaser.TilemapLayerGL>, x: float): float = jsNative
        member __.getTileXY(layer: U2<Phaser.TilemapLayer, Phaser.TilemapLayerGL>, x: float, y: float, point: Phaser.Point): Phaser.Point = jsNative
        member __.getTileY(layer: U2<Phaser.TilemapLayer, Phaser.TilemapLayerGL>, y: float): float = jsNative
        member __.getTileAbove(layer: float, x: float, y: float): Phaser.Tile = jsNative
        member __.getTileBelow(layer: float, x: float, y: float): Phaser.Tile = jsNative
        member __.getTileLeft(layer: float, x: float, y: float): Phaser.Tile = jsNative
        member __.getTileRight(layer: float, x: float, y: float): Phaser.Tile = jsNative
        member __.getTilesetIndex(name: string): float = jsNative
        member __.getTileWorldXY(x: float, y: float, ?tileWidth: float, ?tileHeight: float, ?layer: U3<float, string, Phaser.TilemapLayer>, ?nonNull: bool): Phaser.Tile = jsNative
        member __.hasTile(x: float, y: float, layer: Phaser.TilemapLayer): bool = jsNative
        member __.paste(x: float, y: float, tileblock: ResizeArray<Phaser.Tile>, ?layer: obj): unit = jsNative
        member __.putTile(tile: obj, x: float, y: float, ?layer: obj): Phaser.Tile = jsNative
        member __.putTileWorldXY(tile: obj, x: float, y: float, tileWidth: float, tileHeight: float, ?layer: obj): unit = jsNative
        member __.random(x: float, y: float, width: float, height: float, ?layer: obj): unit = jsNative
        member __.removeAllLayers(): unit = jsNative
        member __.removeTile(x: float, y: float, ?layer: obj): Phaser.Tile = jsNative
        member __.removeTileWorldXY(x: float, y: float, tileWidth: float, tileHeight: float, ?layer: obj): Phaser.Tile = jsNative
        member __.replace(source: float, dest: float, x: float, y: float, width: float, height: float, ?layer: obj): unit = jsNative
        member __.searchTileIndex(index: float, ?skip: float, ?reverse: bool, ?layer: obj): Phaser.Tile = jsNative
        member __.setCollision(indexes: obj, ?collides: bool, ?layer: obj, ?recalculate: bool): unit = jsNative
        member __.setCollisionBetween(start: float, stop: float, ?collides: bool, ?layer: obj, ?recalculate: bool): unit = jsNative
        member __.setCollisionByExclusion(indexes: ResizeArray<obj>, ?collides: bool, ?layer: obj, ?recalculate: bool): unit = jsNative
        member __.setCollisionByIndex(index: float, ?collides: bool, ?layer: float, ?recalculate: bool): unit = jsNative
        member __.setLayer(layer: obj): unit = jsNative
        member __.setPreventRecalculate(value: bool): unit = jsNative
        member __.setTileIndexCallback(indexes: obj, callback: Function, callbackContext: obj, ?layer: obj): unit = jsNative
        member __.setTileLocationCallback(x: float, y: float, width: float, height: float, callback: Function, callbackContext: obj, ?layer: obj): unit = jsNative
        member __.setTileSize(tileWidth: float, tileHeight: float): unit = jsNative
        member __.shuffle(x: float, y: float, width: float, height: float, layer: obj): unit = jsNative
        member __.swap(tileA: float, tileB: float, x: float, y: float, width: float, height: float, ?layer: obj): unit = jsNative

    and [<AllowNullLiteral>] [<Import("TilemapLayer","Phaser")>] TilemapLayer(game: Phaser.Game, tilemap: Phaser.Tilemap, index: float, ?width: float, ?height: float) =
        inherit Phaser.Sprite()
        member __.cameraOffset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.canvas with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
        member __.collisionHeight with get(): float = jsNative and set(v: float): unit = jsNative
        member __.collisionWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.context with get(): CanvasRenderingContext2D = jsNative and set(v: CanvasRenderingContext2D): unit = jsNative
        member __.data with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.debug with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.debugAlpha with get(): float = jsNative and set(v: float): unit = jsNative
        member __.debugCallbackColor with get(): string = jsNative and set(v: string): unit = jsNative
        member __.debugColor with get(): string = jsNative and set(v: string): unit = jsNative
        member __.debugSettings with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.dirty with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.exists with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.fixedToCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.index with get(): float = jsNative and set(v: float): unit = jsNative
        member __.layer with get(): Phaser.TilemapLayer = jsNative and set(v: Phaser.TilemapLayer): unit = jsNative
        member __.map with get(): Phaser.Tilemap = jsNative and set(v: Phaser.Tilemap): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.physicsType with get(): float = jsNative and set(v: float): unit = jsNative
        member __.renderSettings with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.scrollFactorX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.scrollFactorY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.scrollX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.scrollY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.wrap with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.postUpdate(): unit = jsNative
        member __.render(): unit = jsNative
        member __.resize(width: float, height: float): unit = jsNative
        member __.resizeWorld(): unit = jsNative
        member __.resetTilesetCache(): unit = jsNative
        member __.setScale(?xScale: float, ?yScale: float): unit = jsNative
        member __.updateMax(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("TilemapLayerGL","Phaser")>] TilemapLayerGL(game: Phaser.Game, tilemap: Phaser.Tilemap, index: float, ?width: float, ?height: float, ?tileset: Phaser.Tileset) =
        member __.collisionHeight with get(): float = jsNative and set(v: float): unit = jsNative
        member __.collisionWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.data with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.dirty with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.exists with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.fixedToCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.index with get(): float = jsNative and set(v: float): unit = jsNative
        member __.layer with get(): Phaser.TilemapLayer = jsNative and set(v: Phaser.TilemapLayer): unit = jsNative
        member __.map with get(): Phaser.Tilemap = jsNative and set(v: Phaser.Tilemap): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.physicsType with get(): float = jsNative and set(v: float): unit = jsNative
        member __.scrollFactorX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.scrollFactorY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.scrollX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.scrollY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.wrap with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.postUpdate(): unit = jsNative
        member __.render(): unit = jsNative
        member __.resize(width: float, height: float): unit = jsNative
        member __.resizeWorld(): unit = jsNative
        member __.resetTilesetCache(): unit = jsNative
        member __.setScale(?xScale: float, ?yScale: float): unit = jsNative
        member __.updateMax(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("TilemapParser","Phaser")>] TilemapParser() =
        member __.INSERT_NULL with get(): bool = jsNative and set(v: bool): unit = jsNative
        static member getEmptyData(?tileWidth: float, ?tileHeight: float, ?width: float, ?height: float): obj = jsNative
        static member parse(game: Phaser.Game, key: string, ?tileWidth: float, ?tileHeight: float, ?width: float, ?height: float): obj = jsNative
        static member parseCSV(key: string, data: string, ?tileWidth: float, ?tileHeight: float): obj = jsNative
        static member parseJSON(json: obj): obj = jsNative

    and [<AllowNullLiteral>] [<Import("Tileset","Phaser")>] Tileset(name: string, firstgid: float, ?width: float, ?height: float, ?margin: float, ?spacing: float, ?properties: obj) =
        member __.columns with get(): float = jsNative and set(v: float): unit = jsNative
        member __.firstgid with get(): float = jsNative and set(v: float): unit = jsNative
        member __.image with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.lastgid with get(): float = jsNative and set(v: float): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.properties with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.rows with get(): float = jsNative and set(v: float): unit = jsNative
        member __.tileHeight with get(): float = jsNative and set(v: float): unit = jsNative
        member __.tileMargin with get(): float = jsNative and set(v: float): unit = jsNative
        member __.tileSpacing with get(): float = jsNative and set(v: float): unit = jsNative
        member __.tileWidth with get(): float = jsNative and set(v: float): unit = jsNative
        member __.total with get(): float = jsNative and set(v: float): unit = jsNative
        member __.containsTileIndex(tileIndex: float): bool = jsNative
        member __.draw(context: CanvasRenderingContext2D, x: float, y: float, index: float): unit = jsNative
        member __.drawGl(glBatch: ResizeArray<obj>, x: float, y: float, index: float, alpha: float, flippedVal: float): unit = jsNative
        member __.setImage(image: obj): unit = jsNative
        member __.setSpacing(?margin: float, ?spacing: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("TileSprite","Phaser")>] TileSprite(game: Phaser.Game, x: float, y: float, width: float, height: float, ?key: U4<string, Phaser.RenderTexture, Phaser.BitmapData, PIXI.Texture>, ?frame: U2<string, float>) =
        // interface PIXI.TilingSprite
        member __.alive with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
        member __.animations with get(): Phaser.AnimationManager = jsNative and set(v: Phaser.AnimationManager): unit = jsNative
        member __.autoCull with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.body with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
        member __.cameraOffset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.checkWorldBounds with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.components with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.customRender with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.data with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.debug with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.destroyPhase with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.events with get(): Phaser.Events = jsNative and set(v: Phaser.Events): unit = jsNative
        member __.exists with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.fixedToCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.frame with get(): U2<string, float> = jsNative and set(v: U2<string, float>): unit = jsNative
        member __.frameName with get(): string = jsNative and set(v: string): unit = jsNative
        member __.fresh with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.inCamera with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.input with get(): Phaser.InputHandler = jsNative and set(v: Phaser.InputHandler): unit = jsNative
        member __.inputEnabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.inWorld with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.key with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.left with get(): float = jsNative and set(v: float): unit = jsNative
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.offsetX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.offsetY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.outOfBoundsKill with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.pendingDestroy with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.physicsType with get(): float = jsNative and set(v: float): unit = jsNative
        member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.smoothed with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.previousPosition with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.previousRoation with get(): float = jsNative and set(v: float): unit = jsNative
        member __.right with get(): float = jsNative and set(v: float): unit = jsNative
        member __.top with get(): float = jsNative and set(v: float): unit = jsNative
        member __.renderOrderID with get(): float = jsNative and set(v: float): unit = jsNative
        member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
        member __.world with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.z with get(): float = jsNative and set(v: float): unit = jsNative
        member __.alignIn(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): obj = jsNative
        member __.alignTo(container: obj, ?position: float, ?offsetX: float, ?offsetY: float): obj = jsNative
        member __.autoScroll(x: float, y: float): unit = jsNative
        member __.destroy(?destroyChildren: bool): unit = jsNative
        member __.loadTexture(key: obj, ?frame: U2<string, float>, ?stopAnimation: bool): unit = jsNative
        member __.play(name: string, ?frameRate: float, ?loop: bool, ?killOnComplete: bool): Phaser.Animation = jsNative
        member __.postUpdate(): unit = jsNative
        member __.preUpdate(): unit = jsNative
        member __.overlap(displayObject: obj): bool = jsNative
        member __.reset(x: float, y: float, ?health: float): Phaser.TileSprite = jsNative
        member __.resizeFrame(parent: obj, width: float, height: float): unit = jsNative
        member __.resetFrame(): unit = jsNative
        member __.setFrame(frame: Phaser.Frame): unit = jsNative
        member __.stopScroll(): unit = jsNative
        member __.update(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Time","Phaser")>] Time(game: Phaser.Game) =
        member __.advancedTiming with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.desiredFps with get(): float = jsNative and set(v: float): unit = jsNative
        member __.desiredFpsMult with get(): float = jsNative and set(v: float): unit = jsNative
        member __.elapsed with get(): float = jsNative and set(v: float): unit = jsNative
        member __.events with get(): Phaser.Timer = jsNative and set(v: Phaser.Timer): unit = jsNative
        member __.elapsedMS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fps with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fpsMax with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fpsMin with get(): float = jsNative and set(v: float): unit = jsNative
        member __.frames with get(): float = jsNative and set(v: float): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.lastTime with get(): float = jsNative and set(v: float): unit = jsNative
        member __.msMax with get(): float = jsNative and set(v: float): unit = jsNative
        member __.msMin with get(): float = jsNative and set(v: float): unit = jsNative
        member __.now with get(): float = jsNative and set(v: float): unit = jsNative
        member __.pausedTime with get(): float = jsNative and set(v: float): unit = jsNative
        member __.pauseDuration with get(): float = jsNative and set(v: float): unit = jsNative
        member __.physicsElapsed with get(): float = jsNative and set(v: float): unit = jsNative
        member __.physicsElapsedMS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.prevTime with get(): float = jsNative and set(v: float): unit = jsNative
        member __.slowMotion with get(): float = jsNative and set(v: float): unit = jsNative
        member __.suggestedFps with get(): float = jsNative and set(v: float): unit = jsNative
        member __.time with get(): float = jsNative and set(v: float): unit = jsNative
        member __.timeExpected with get(): float = jsNative and set(v: float): unit = jsNative
        member __.timeToCall with get(): float = jsNative and set(v: float): unit = jsNative
        member __.add(timer: Phaser.Timer): Phaser.Timer = jsNative
        member __.boot(): unit = jsNative
        member __.create(?autoDestroy: bool): Phaser.Timer = jsNative
        member __.elapsedSecondsSince(since: float): float = jsNative
        member __.elapsedSince(since: float): float = jsNative
        member __.removeAll(): unit = jsNative
        member __.reset(): unit = jsNative
        member __.totalElapsedSeconds(): float = jsNative
        member __.update(time: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Timer","Phaser")>] Timer(game: Phaser.Game, ?autoDestroy: bool) =
        member __.HALF with get(): float = jsNative and set(v: float): unit = jsNative
        member __.MINUTE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.QUARTER with get(): float = jsNative and set(v: float): unit = jsNative
        member __.SECOND with get(): float = jsNative and set(v: float): unit = jsNative
        member __.autoDestroy with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.duration with get(): float = jsNative and set(v: float): unit = jsNative
        member __.events with get(): ResizeArray<Phaser.TimerEvent> = jsNative and set(v: ResizeArray<Phaser.TimerEvent>): unit = jsNative
        member __.expired with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.length with get(): float = jsNative and set(v: float): unit = jsNative
        member __.ms with get(): float = jsNative and set(v: float): unit = jsNative
        member __.next with get(): float = jsNative and set(v: float): unit = jsNative
        member __.nextTick with get(): float = jsNative and set(v: float): unit = jsNative
        member __.onComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.running with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.paused with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.seconds with get(): float = jsNative and set(v: float): unit = jsNative
        member __.add(delay: float, callback: Function, callbackContext: obj, [<ParamArray>] args: obj[]): Phaser.TimerEvent = jsNative
        member __.clearPendingEvents(): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.loop(delay: float, callback: Function, callbackContext: obj, [<ParamArray>] args: obj[]): Phaser.TimerEvent = jsNative
        member __.order(): unit = jsNative
        member __.pause(): unit = jsNative
        member __.remove(``event``: Phaser.TimerEvent): bool = jsNative
        member __.removeAll(): unit = jsNative
        member __.repeat(delay: float, repeatCount: float, callback: Function, callbackContext: obj, [<ParamArray>] args: obj[]): Phaser.TimerEvent = jsNative
        member __.resume(): unit = jsNative
        member __.sortHandler(a: obj, b: obj): float = jsNative
        member __.start(?startDelay: float): unit = jsNative
        member __.stop(?clearEvents: bool): unit = jsNative
        member __.update(time: float): bool = jsNative

    and [<AllowNullLiteral>] [<Import("TimerEvent","Phaser")>] TimerEvent(timer: Phaser.Timer, delay: float, tick: float, repeatCount: float, loop: bool, callback: Function, callbackContext: obj, [<ParamArray>] args: obj[]) =
        member __.args with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
        member __.callback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.callbackContext with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.delay with get(): float = jsNative and set(v: float): unit = jsNative
        member __.loop with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.pendingDelete with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.repeatCount with get(): float = jsNative and set(v: float): unit = jsNative
        member __.tick with get(): float = jsNative and set(v: float): unit = jsNative
        member __.timer with get(): Phaser.Timer = jsNative and set(v: Phaser.Timer): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Touch","Phaser")>] Touch(game: Phaser.Game) =
        member __.callbackContext with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.enabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.``event`` with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.preventDefault with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.touchCancelCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.touchEndCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.touchEnterCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.touchLeaveCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.touchMoveCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.touchStartCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.touchLockCallbacks with get(): ResizeArray<Function> = jsNative and set(v: ResizeArray<Function>): unit = jsNative
        member __.addTouchLockCallback(callback: Function, ?context: obj, ?onEnd: Function): unit = jsNative
        member __.removeTouchLockCallback(callback: Function, ?context: obj): bool = jsNative
        member __.consumeTouchMove(): unit = jsNative
        member __.onTouchCancel(``event``: obj): unit = jsNative
        member __.onTouchEnd(``event``: obj): unit = jsNative
        member __.onTouchEnter(``event``: obj): unit = jsNative
        member __.onTouchLeave(``event``: obj): unit = jsNative
        member __.onTouchMove(``event``: obj): unit = jsNative
        member __.onTouchStart(``event``: obj): unit = jsNative
        member __.start(): unit = jsNative
        member __.stop(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Tween","Phaser")>] Tween(target: obj, game: Phaser.Game, manager: Phaser.TweenManager) =
        member __.chainedTween with get(): Phaser.Tween = jsNative and set(v: Phaser.Tween): unit = jsNative
        member __.current with get(): float = jsNative and set(v: float): unit = jsNative
        member __.frameBased with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.isRunning with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isPaused with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.manager with get(): Phaser.TweenManager = jsNative and set(v: Phaser.TweenManager): unit = jsNative
        member __.onChildComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onLoop with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onRepeat with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onStart with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.pendingDelete with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.properties with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.repeatCounter with get(): float = jsNative and set(v: float): unit = jsNative
        member __.reverse with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.target with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.timeline with get(): ResizeArray<Phaser.TweenData> = jsNative and set(v: ResizeArray<Phaser.TweenData>): unit = jsNative
        member __.timeScale with get(): float = jsNative and set(v: float): unit = jsNative
        member __.totalDuration with get(): float = jsNative and set(v: float): unit = jsNative
        member __.chain([<ParamArray>] args: obj[]): Phaser.Tween = jsNative
        member __.delay(duration: float, ?index: float): Phaser.Tween = jsNative
        member __.easing(ease: Function, ?index: float): Phaser.Tween = jsNative
        member __.easing(ease: string, ?index: float): Phaser.Tween = jsNative
        member __.from(properties: obj, ?duration: float, ?ease: Function, ?autoStart: bool, ?delay: float, ?repeat: float, ?yoyo: bool): Phaser.Tween = jsNative
        member __.from(properties: obj, ?duration: float, ?ease: string, ?autoStart: bool, ?delay: float, ?repeat: float, ?yoyo: bool): Phaser.Tween = jsNative
        member __.generateData(?frameRate: float, ?data: obj): ResizeArray<obj> = jsNative
        member __.interpolation(interpolation: Function, ?context: obj, ?index: float): Phaser.Tween = jsNative
        member __.loop(?value: bool): Phaser.Tween = jsNative
        member __.onUpdateCallback(callback: Function, ?callbackContext: obj): Phaser.Tween = jsNative
        member __.pause(): unit = jsNative
        member __.repeat(total: float, ?repeatDelay: float, ?index: float): Phaser.Tween = jsNative
        member __.repeatDelay(duration: float, ?index: float): Phaser.Tween = jsNative
        member __.repeatAll(?total: float): Phaser.Tween = jsNative
        member __.resume(): unit = jsNative
        member __.start(?index: float): Phaser.Tween = jsNative
        member __.stop(?complete: bool): Phaser.Tween = jsNative
        member __.``to``(properties: obj, ?duration: float, ?ease: Function, ?autoStart: bool, ?delay: float, ?repeat: float, ?yoyo: bool): Phaser.Tween = jsNative
        member __.``to``(properties: obj, ?duration: float, ?ease: string, ?autoStart: bool, ?delay: float, ?repeat: float, ?yoyo: bool): Phaser.Tween = jsNative
        member __.update(time: float): bool = jsNative
        member __.updateTweenData(property: string, value: U2<float, Function>, ?index: float): Phaser.Tween = jsNative
        member __.yoyo(enable: bool, ?yoyoDelay: float, ?index: float): Phaser.Tween = jsNative
        member __.yoyoDelay(duration: float, ?index: float): Phaser.Tween = jsNative

    and [<AllowNullLiteral>] [<Import("TweenData","Phaser")>] TweenData(parent: Phaser.Tween) =
        member __.COMPLETE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.LOOPED with get(): float = jsNative and set(v: float): unit = jsNative
        member __.PENDING with get(): float = jsNative and set(v: float): unit = jsNative
        member __.RUNNING with get(): float = jsNative and set(v: float): unit = jsNative
        member __.delay with get(): float = jsNative and set(v: float): unit = jsNative
        member __.dt with get(): float = jsNative and set(v: float): unit = jsNative
        member __.duration with get(): float = jsNative and set(v: float): unit = jsNative
        member __.easingFunction with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.inReverse with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.interpolate with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.interpolateFunctionContext with get(): Phaser.Math = jsNative and set(v: Phaser.Math): unit = jsNative
        member __.interpolationContext with get(): Phaser.Math = jsNative and set(v: Phaser.Math): unit = jsNative
        member __.interpolationFunction with get(): Function = jsNative and set(v: Function): unit = jsNative
        member __.isRunning with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isFrom with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.parent with get(): Phaser.Tween = jsNative and set(v: Phaser.Tween): unit = jsNative
        member __.percent with get(): float = jsNative and set(v: float): unit = jsNative
        member __.repeatCounter with get(): float = jsNative and set(v: float): unit = jsNative
        member __.startTime with get(): float = jsNative and set(v: float): unit = jsNative
        member __.value with get(): float = jsNative and set(v: float): unit = jsNative
        member __.yoyo with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.yoyoDelay with get(): float = jsNative and set(v: float): unit = jsNative
        member __.from(properties: obj, ?duration: float, ?ease: Function, ?delay: float, ?repeat: float, ?yoyo: bool): Phaser.TweenData = jsNative
        member __.generateData(?frameRate: float): ResizeArray<obj> = jsNative
        member __.repeat(): float = jsNative
        member __.start(): Phaser.TweenData = jsNative
        member __.``to``(properties: obj, ?duration: float, ?ease: Function, ?delay: float, ?repeat: float, ?yoyo: bool): Phaser.TweenData = jsNative
        member __.update(time: float): float = jsNative

    and [<AllowNullLiteral>] [<Import("TweenManager","Phaser")>] TweenManager(game: Phaser.Game) =
        member __.frameBased with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.add(tween: Phaser.Tween): Phaser.Tween = jsNative
        member __.create(``object``: obj): Phaser.Tween = jsNative
        member __.getAll(): ResizeArray<Phaser.Tween> = jsNative
        member __.isTweening(``object``: obj): bool = jsNative
        member __.remove(tween: Phaser.Tween): Phaser.Tween = jsNative
        member __.removeAll(): unit = jsNative
        member __.removeFrom(obj: obj, ?children: bool): unit = jsNative
        member __.resumeAll(): unit = jsNative
        member __.update(): bool = jsNative
        member __.pauseAll(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Utils","Phaser")>] Utils() =
        static member getProperty(obj: obj, prop: string): obj = jsNative
        static member setProperty(obj: obj, prop: string, value: obj): obj = jsNative
        static member chanceRoll(chance: float): bool = jsNative
        static member randomChoice(choice1: U2<string, float>, choice2: obj): obj = jsNative
        static member reverseString(string: string): string = jsNative
        static member parseDimension(size: obj, dimension: float): float = jsNative
        static member pad(str: string, ?len: float, ?pad: string, ?dir: float): string = jsNative
        static member isPlainObject(``object``: obj): bool = jsNative
        static member extend(deep: bool, target: obj, [<ParamArray>] args: obj[]): obj = jsNative
        static member mixinPrototype(target: obj, ``mixin``: obj, ?replace: bool): unit = jsNative
        static member ``mixin``(from: 'T, ``to``: obj): 'T = jsNative

    and [<AllowNullLiteral>] [<Import("Weapon","Phaser")>] Weapon(game: Phaser.Game, parent: Phaser.PluginManager) =
        inherit Phaser.Plugin()
        member __.KILL_NEVER with get(): float = jsNative and set(v: float): unit = jsNative
        member __.KILL_LIFESPAN with get(): float = jsNative and set(v: float): unit = jsNative
        member __.KILL_DISTANCE with get(): float = jsNative and set(v: float): unit = jsNative
        member __.KILL_WEAPON_BOUNDS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.KILL_CAMERA_BOUNDS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.KILL_WORLD_BOUNDS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.KILL_STATIC_BOUNDS with get(): float = jsNative and set(v: float): unit = jsNative
        member __.autoExpandBulletsGroup with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.autofire with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.bounds with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.bulletAngleOffset with get(): float = jsNative and set(v: float): unit = jsNative
        member __.bulletAngleVariance with get(): float = jsNative and set(v: float): unit = jsNative
        member __.bulletAnimation with get(): string = jsNative and set(v: string): unit = jsNative
        member __.bulletClass with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.bulletCollideWorldBounds with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.bulletFrame with get(): string = jsNative and set(v: string): unit = jsNative
        member __.bulletFrameCycle with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.bulletFrameRandom with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.bulletFrames with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
        member __.bulletGravity with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.bulletInheritSpriteSpeed with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.bulletKey with get(): string = jsNative and set(v: string): unit = jsNative
        member __.bulletKillDistance with get(): float = jsNative and set(v: float): unit = jsNative
        member __.bulletKillType with get(): float = jsNative and set(v: float): unit = jsNative
        member __.bulletLifespan with get(): float = jsNative and set(v: float): unit = jsNative
        member __.bulletRotateToVelocity with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.bullets with get(): Phaser.Group = jsNative and set(v: Phaser.Group): unit = jsNative
        member __.bulletSpeed with get(): float = jsNative and set(v: float): unit = jsNative
        member __.bulletSpeedVariance with get(): float = jsNative and set(v: float): unit = jsNative
        member __.bulletWorldWrap with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.bulletWorldWrapPadding with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fireAngle with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fireFrom with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.fireLimit with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fireRate with get(): float = jsNative and set(v: float): unit = jsNative
        member __.fireRateVariance with get(): float = jsNative and set(v: float): unit = jsNative
        member __.onFire with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onFireLimit with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.onKill with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
        member __.shots with get(): float = jsNative and set(v: float): unit = jsNative
        member __.trackedPointer with get(): Phaser.Pointer = jsNative and set(v: Phaser.Pointer): unit = jsNative
        member __.trackedSprite with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.trackOffset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
        member __.trackRotation with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.x with get(): float = jsNative and set(v: float): unit = jsNative
        member __.y with get(): float = jsNative and set(v: float): unit = jsNative
        member __.addBulletAnimation(name: string, ?frames: U2<ResizeArray<float>, ResizeArray<string>>, ?frameRate: float, ?loop: bool, ?useNumericIndex: bool): Phaser.Weapon = jsNative
        member __.createBullets(?quantity: float, ?key: obj, ?frame: obj, ?group: Phaser.Group): Phaser.Weapon = jsNative
        member __.debug(?x: float, ?y: float, ?debugBodies: bool): unit = jsNative
        member __.destroy(): unit = jsNative
        member __.fire(?from: obj, ?x: float, ?y: float): Phaser.Bullet = jsNative
        member __.fireAtPointer(pointer: Phaser.Pointer): Phaser.Bullet = jsNative
        member __.fireAtSprite(sprite: Phaser.Sprite): Phaser.Bullet = jsNative
        member __.fireAtXY(x: float, y: float): Phaser.Bullet = jsNative
        member __.forEach(callback: obj, callbackContext: obj): Phaser.Weapon = jsNative
        member __.killAll(): Phaser.Weapon = jsNative
        member __.pauseAll(): Phaser.Weapon = jsNative
        member __.resetShots(?newLimit: float): Phaser.Weapon = jsNative
        member __.resumeAll(): Phaser.Weapon = jsNative
        member __.setBulletBodyOffset(width: float, height: float, ?offsetX: float, ?offsetY: float): Phaser.Weapon = jsNative
        member __.setBulletFrames(min: float, max: float, ?cycle: bool, ?random: bool): Phaser.Weapon = jsNative
        member __.trackPointer(pointer: Phaser.Pointer, ?offsetX: float, ?offsetY: float): Phaser.Weapon = jsNative
        member __.trackSprite(sprite: Phaser.Sprite, ?offsetX: float, ?offsetY: float, ?trackRotation: bool): Phaser.Weapon = jsNative

    and [<AllowNullLiteral>] [<Import("World","Phaser")>] World(game: Phaser.Game) =
        inherit Phaser.Group()
        member __.bounds with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
        member __.camera with get(): Phaser.Camera = jsNative and set(v: Phaser.Camera): unit = jsNative
        member __.centerX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.centerY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
        member __.height with get(): float = jsNative and set(v: float): unit = jsNative
        member __.isPaused with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.randomX with get(): float = jsNative and set(v: float): unit = jsNative
        member __.randomY with get(): float = jsNative and set(v: float): unit = jsNative
        member __.stats with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.width with get(): float = jsNative and set(v: float): unit = jsNative
        member __.boot(): unit = jsNative
        member __.getObjectsUnderPointer(pointer: Phaser.Pointer, group: Phaser.Group, ?callback: Function, ?callbackContext: obj): Phaser.Sprite = jsNative
        member __.resize(width: float, height: float): unit = jsNative
        member __.setBounds(x: float, y: float, width: float, height: float): unit = jsNative
        member __.sortLeftRight(a: Phaser.Sprite, b: Phaser.Sprite): float = jsNative
        member __.sortRightLeft(a: Phaser.Sprite, b: Phaser.Sprite): float = jsNative
        member __.sortTopBottom(a: Phaser.Sprite, b: Phaser.Sprite): float = jsNative
        member __.sortBottomTop(a: Phaser.Sprite, b: Phaser.Sprite): float = jsNative
        member __.sort(group: Phaser.Group, ?sortDirection: float): unit = jsNative
        member __.sort(?key: string, ?order: float): unit = jsNative
        member __.shutdown(): unit = jsNative
        member __.wrap(sprite: obj, ?padding: float, ?useBounds: bool, ?horizontal: bool, ?vertical: bool): unit = jsNative

    module Easing =
        type [<AllowNullLiteral>] [<Import("Easing.Back","Phaser")>] Back() =
            static member In(k: float): float = jsNative
            static member Out(k: float): float = jsNative
            static member InOut(k: float): float = jsNative

        and [<AllowNullLiteral>] [<Import("Easing.Bounce","Phaser")>] Bounce() =
            static member In(k: float): float = jsNative
            static member Out(k: float): float = jsNative
            static member InOut(k: float): float = jsNative

        and [<AllowNullLiteral>] [<Import("Easing.Circular","Phaser")>] Circular() =
            static member In(k: float): float = jsNative
            static member Out(k: float): float = jsNative
            static member InOut(k: float): float = jsNative

        and [<AllowNullLiteral>] [<Import("Easing.Cubic","Phaser")>] Cubic() =
            static member In(k: float): float = jsNative
            static member Out(k: float): float = jsNative
            static member InOut(k: float): float = jsNative

        and [<AllowNullLiteral>] [<Import("Easing.Elastic","Phaser")>] Elastic() =
            static member In(k: float): float = jsNative
            static member Out(k: float): float = jsNative
            static member InOut(k: float): float = jsNative

        and [<AllowNullLiteral>] [<Import("Easing.Exponential","Phaser")>] Exponential() =
            static member In(k: float): float = jsNative
            static member Out(k: float): float = jsNative
            static member InOut(k: float): float = jsNative

        and [<AllowNullLiteral>] [<Import("Easing.Linear","Phaser")>] Linear() =
            static member None(k: float): float = jsNative

        and [<AllowNullLiteral>] [<Import("Easing.Quadratic","Phaser")>] Quadratic() =
            static member In(k: float): float = jsNative
            static member Out(k: float): float = jsNative
            static member InOut(k: float): float = jsNative

        and [<AllowNullLiteral>] [<Import("Easing.Quartic","Phaser")>] Quartic() =
            static member In(k: float): float = jsNative
            static member Out(k: float): float = jsNative
            static member InOut(k: float): float = jsNative

        and [<AllowNullLiteral>] [<Import("Easing.Quintic","Phaser")>] Quintic() =
            static member In(k: float): float = jsNative
            static member Out(k: float): float = jsNative
            static member InOut(k: float): float = jsNative

        and [<AllowNullLiteral>] [<Import("Easing.Sinusoidal","Phaser")>] Sinusoidal() =
            static member In(k: float): float = jsNative
            static member Out(k: float): float = jsNative
            static member InOut(k: float): float = jsNative

        type [<Import("Easing","Phaser")>] Globals =
            static member Default with get(): Function = jsNative and set(v: Function): unit = jsNative
            static member Power0 with get(): Function = jsNative and set(v: Function): unit = jsNative
            static member Power1 with get(): Function = jsNative and set(v: Function): unit = jsNative
            static member power2 with get(): Function = jsNative and set(v: Function): unit = jsNative
            static member power3 with get(): Function = jsNative and set(v: Function): unit = jsNative
            static member power4 with get(): Function = jsNative and set(v: Function): unit = jsNative



    module Filter =
        type [<AllowNullLiteral>] [<Import("Filter.BinarySerpents","Phaser")>] BinarySerpents(game: Phaser.Game, width: float, height: float, ?march: float, ?maxDistance: float) =
            inherit Phaser.Filter()
            member __.fog with get(): float = jsNative and set(v: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.BlurX","Phaser")>] BlurX() =
            inherit Phaser.Filter()
            member __.blur with get(): float = jsNative and set(v: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.BlurY","Phaser")>] BlurY() =
            inherit Phaser.Filter()
            member __.blur with get(): float = jsNative and set(v: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.CausticLight","Phaser")>] CausticLight(game: Phaser.Game, width: float, height: float, ?divisor: float) =
            inherit Phaser.Filter()
            member __.init(width: float, height: float, ?divisor: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.CheckerWave","Phaser")>] CheckerWave(game: Phaser.Game, width: float, height: float) =
            inherit Phaser.Filter()
            member __.alpha with get(): float = jsNative and set(v: float): unit = jsNative
            member __.cameraX with get(): float = jsNative and set(v: float): unit = jsNative
            member __.cameraY with get(): float = jsNative and set(v: float): unit = jsNative
            member __.cameraZ with get(): float = jsNative and set(v: float): unit = jsNative
            member __.init(width: float, height: float): unit = jsNative
            member __.setColor1(red: float, green: float, blue: float): unit = jsNative
            member __.setColor2(red: float, green: float, blue: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.ColorBars","Phaser")>] ColorBars(game: Phaser.Game, width: float, height: float) =
            inherit Phaser.Filter()
            member __.alpha with get(): float = jsNative and set(v: float): unit = jsNative
            member __.init(width: float, height: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.Fire","Phaser")>] Fire(width: float, height: float, ?alpha: float, ?shift: float) =
            inherit Phaser.Filter()
            member __.alpha with get(): float = jsNative and set(v: float): unit = jsNative
            member __.shift with get(): float = jsNative and set(v: float): unit = jsNative
            member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
            member __.init(width: float, height: float, ?alpha: float, ?shift: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.Gray","Phaser")>] Gray() =
            inherit Phaser.Filter()
            member __.gray with get(): float = jsNative and set(v: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.HueRotate","Phaser")>] HueRotate(game: Phaser.Game, width: float, height: float, texture: obj) =
            inherit Phaser.Filter()
            member __.alpha with get(): float = jsNative and set(v: float): unit = jsNative
            member __.init(width: float, height: float, texture: obj): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.LazerBeam","Phaser")>] LazerBeam() =
            inherit Phaser.Filter()
            member __.init(width: float, height: float, ?divisor: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.LightBeam","Phaser")>] LightBeam(game: Phaser.Game, width: float, height: float) =
            inherit Phaser.Filter()
            member __.alpha with get(): float = jsNative and set(v: float): unit = jsNative
            member __.blue with get(): float = jsNative and set(v: float): unit = jsNative
            member __.green with get(): float = jsNative and set(v: float): unit = jsNative
            member __.red with get(): float = jsNative and set(v: float): unit = jsNative
            member __.thickness with get(): float = jsNative and set(v: float): unit = jsNative
            member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
            member __.init(width: float, height: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.Marble","Phaser")>] Marble(game: Phaser.Game, width: float, height: float, ?speed: float, ?intensity: float) =
            inherit Phaser.Filter()
            member __.alpha with get(): float = jsNative and set(v: float): unit = jsNative
            member __.intensity with get(): float = jsNative and set(v: float): unit = jsNative
            member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
            member __.init(width: float, height: float, ?speed: float, ?intensity: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.Pixelate","Phaser")>] Pixelate() =
            inherit Phaser.Filter()
            member __.size with get(): float = jsNative and set(v: float): unit = jsNative
            member __.sizeX with get(): float = jsNative and set(v: float): unit = jsNative
            member __.sizeY with get(): float = jsNative and set(v: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.Plasma","Phaser")>] Plasma(game: Phaser.Game, width: float, height: float, ?alpha: float, ?size: float) =
            inherit Phaser.Filter()
            member __.alpha with get(): float = jsNative and set(v: float): unit = jsNative
            member __.blueShift with get(): float = jsNative and set(v: float): unit = jsNative
            member __.greenShift with get(): float = jsNative and set(v: float): unit = jsNative
            member __.redShift with get(): float = jsNative and set(v: float): unit = jsNative
            member __.size with get(): float = jsNative and set(v: float): unit = jsNative
            member __.init(width: float, height: float, ?alpha: float, ?size: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.SampleFilter","Phaser")>] SampleFilter(game: Phaser.Game, width: float, height: float, ?divisor: float) =
            inherit Phaser.Filter()
            member __.init(width: float, height: float, ?divisor: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filter.Tunnel","Phaser")>] Tunnel(game: Phaser.Game, width: float, height: float, texture: obj) =
            inherit Phaser.Filter()
            member __.alpha with get(): float = jsNative and set(v: float): unit = jsNative
            member __.origin with get(): float = jsNative and set(v: float): unit = jsNative
            member __.init(width: float, height: float, texture: obj): unit = jsNative



    module Particles =
        module Arcade =
            type [<AllowNullLiteral>] [<Import("Particles.Arcade.Emitter","Phaser")>] Emitter(game: Phaser.Game, ?x: float, ?y: float, ?maxParticles: float) =
                inherit Phaser.Group()
                member __.alphaData with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
                member __.autoAlpha with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.autoScale with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
                member __.angularDrag with get(): float = jsNative and set(v: float): unit = jsNative
                member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
                member __.bounce with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.emitX with get(): float = jsNative and set(v: float): unit = jsNative
                member __.emitY with get(): float = jsNative and set(v: float): unit = jsNative
                member __.exists with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.frequency with get(): float = jsNative and set(v: float): unit = jsNative
                member __.gravity with get(): float = jsNative and set(v: float): unit = jsNative
                member __.group with get(): Phaser.Group = jsNative and set(v: Phaser.Group): unit = jsNative
                member __.height with get(): float = jsNative and set(v: float): unit = jsNative
                member __.left with get(): float = jsNative and set(v: float): unit = jsNative
                member __.lifespan with get(): float = jsNative and set(v: float): unit = jsNative
                member __.maxParticles with get(): float = jsNative and set(v: float): unit = jsNative
                member __.maxParticleScale with get(): float = jsNative and set(v: float): unit = jsNative
                member __.maxParticleSpeed with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.maxRotation with get(): float = jsNative and set(v: float): unit = jsNative
                member __.minParticleScale with get(): float = jsNative and set(v: float): unit = jsNative
                member __.minParticleSpeed with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.minRotation with get(): float = jsNative and set(v: float): unit = jsNative
                member __.name with get(): string = jsNative and set(v: string): unit = jsNative
                member __.on with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.particleAnchor with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.particleBringToTop with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.particleSendToBack with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.particleClass with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.particleDrag with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.physicsType with get(): float = jsNative and set(v: float): unit = jsNative
                member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.right with get(): float = jsNative and set(v: float): unit = jsNative
                member __.scaleData with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
                member __.top with get(): float = jsNative and set(v: float): unit = jsNative
                member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
                member __.width with get(): float = jsNative and set(v: float): unit = jsNative
                member __.x with get(): float = jsNative and set(v: float): unit = jsNative
                member __.y with get(): float = jsNative and set(v: float): unit = jsNative
                member __.at(``object``: obj): obj = jsNative
                member __.emitParticle(?x: float, ?y: float, ?key: obj, ?frame: U2<string, float>): bool = jsNative
                member __.explode(?lifespan: float, ?quantity: float): obj = jsNative
                member __.flow(?lifespan: float, ?frequency: float, ?quantity: float, ?total: float, ?immediate: bool): obj = jsNative
                member __.kill(): obj = jsNative
                member __.makeParticles(keys: obj, ?frames: obj, ?quantity: float, ?collide: bool, ?collideWorldBounds: bool): obj = jsNative
                member __.reset(x: float, y: float, ?health: float): Phaser.Particles = jsNative
                member __.setAlpha(?min: float, ?max: float, ?rate: float, ?ease: Func<float, float>, ?yoyo: bool): obj = jsNative
                member __.setRotation(?min: float, ?max: float): obj = jsNative
                member __.setScale(?minX: float, ?maxX: float, ?minY: float, ?maxY: float, ?rate: float, ?ease: Func<float, float>, ?yoyo: bool): obj = jsNative
                member __.setSize(width: float, height: float): obj = jsNative
                member __.setXSpeed(min: float, max: float): obj = jsNative
                member __.setYSpeed(min: float, max: float): obj = jsNative
                member __.start(?explode: bool, ?lifespan: float, ?frequency: float, ?quantity: float, ?forceQuantity: bool): obj = jsNative
                member __.update(): unit = jsNative
                member __.revive(): obj = jsNative



    module Physics =
        type [<AllowNullLiteral>] [<Import("Physics.Arcade","Phaser")>] Arcade(game: Phaser.Game) =
            member __.SORT_NONE with get(): float = jsNative and set(v: float): unit = jsNative
            member __.LEFT_RIGHT with get(): float = jsNative and set(v: float): unit = jsNative
            member __.RIGHT_LEFT with get(): float = jsNative and set(v: float): unit = jsNative
            member __.TOP_BOTTOM with get(): float = jsNative and set(v: float): unit = jsNative
            member __.BOTTOM_TOP with get(): float = jsNative and set(v: float): unit = jsNative
            member __.OVERLAP_BIAS with get(): float = jsNative and set(v: float): unit = jsNative
            member __.TILE_BIAS with get(): float = jsNative and set(v: float): unit = jsNative
            member __.bounds with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
            member __.checkCollision with get(): obj = jsNative and set(v: obj): unit = jsNative
            member __.forceX with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
            member __.gravity with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
            member __.quadTree with get(): Phaser.QuadTree = jsNative and set(v: Phaser.QuadTree): unit = jsNative
            member __.maxObjects with get(): float = jsNative and set(v: float): unit = jsNative
            member __.maxLevels with get(): float = jsNative and set(v: float): unit = jsNative
            member __.skipQuadTree with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.sortDirection with get(): float = jsNative and set(v: float): unit = jsNative
            member __.accelerationFromRotation(rotation: float, ?speed: float, ?point: Phaser.Point): Phaser.Point = jsNative
            member __.accelerateToObject(displayObject: obj, destination: obj, ?speed: float, ?xSpeedMax: float, ?ySpeedMax: float): float = jsNative
            member __.accelerateToPointer(displayObject: obj, ?pointer: Phaser.Pointer, ?speed: float, ?xSpeedMax: float, ?ySpeedMax: float): float = jsNative
            member __.accelerateToXY(displayObject: obj, x: float, y: float, ?speed: float, ?xSpeedMax: float, ?ySpeedMax: float): float = jsNative
            member __.angleBetween(source: obj, target: obj, ?world: bool): float = jsNative
            member __.angleToPointer(displayObject: obj, ?pointer: Phaser.Pointer, ?world: bool): float = jsNative
            member __.angleToXY(displayObject: obj, x: float, y: float, ?world: bool): float = jsNative
            member __.collide(object1: obj, ?object2: obj, ?collideCallback: Function, ?processCallback: Function, ?callbackContext: obj): bool = jsNative
            member __.computeVelocity(axis: float, body: obj, velocity: float, acceleration: float, drag: float, ?max: float): float = jsNative
            member __.distanceBetween(source: obj, target: obj, ?world: bool): float = jsNative
            member __.distanceToPointer(displayObject: obj, ?pointer: Phaser.Pointer, ?world: bool): float = jsNative
            member __.distanceToXY(displayObject: obj, x: float, y: float, ?world: bool): float = jsNative
            member __.enable(``object``: obj, ?children: Boolean): unit = jsNative
            member __.enableBody(``object``: obj): unit = jsNative
            member __.getObjectsAtLocation(x: float, y: float, group: Phaser.Group, ?callback: Func<obj, obj, unit>, ?callbackContext: obj, ?callbackArg: obj): ResizeArray<Sprite> = jsNative
            member __.getOverlapX(body1: obj, body2: obj): float = jsNative
            member __.getOverlapY(body1: obj, body2: obj): float = jsNative
            member __.intersects(body1: obj, body2: obj): bool = jsNative
            member __.moveToObject(displayObject: obj, destination: obj, ?speed: float, ?maxTime: float): float = jsNative
            member __.moveToPointer(displayObject: obj, ?speed: float, ?pointer: Phaser.Pointer, ?maxTime: float): float = jsNative
            member __.moveToXY(displayObject: obj, x: float, y: float, ?speed: float, ?maxTime: float): float = jsNative
            member __.overlap(object1: obj, object2: obj, ?overlapCallback: Function, ?processCallback: Function, ?callbackContext: obj): bool = jsNative
            member __.processTileSeparationX(body: obj, x: float): bool = jsNative
            member __.processTileSeparationY(body: obj, y: float): unit = jsNative
            member __.setBounds(x: float, y: float, width: float, height: float): unit = jsNative
            member __.setBoundsToWorld(): unit = jsNative
            member __.separate(body1: obj, body2: obj, ?processCallback: Function, ?callbackContext: obj, ?overlapOnly: bool): bool = jsNative
            member __.separateX(body1: obj, body2: obj, overlapOnly: bool): bool = jsNative
            member __.separateY(body1: obj, body2: obj, overlapOnly: bool): bool = jsNative
            member __.separateTile(i: float, body: obj, tile: Phaser.Tile): bool = jsNative
            member __.sort(group: Phaser.Group): unit = jsNative
            member __.tileCheckX(body: obj, tile: Phaser.Tile): float = jsNative
            member __.tileCheckY(body: obj, tile: Phaser.Tile): float = jsNative
            member __.updateMotion(body: obj): unit = jsNative
            member __.velocityFromAngle(angle: float, ?speed: float, ?point: Phaser.Point): Phaser.Point = jsNative
            member __.velocityFromRotation(rotation: float, ?speed: float, ?point: Phaser.Point): Phaser.Point = jsNative

        and [<AllowNullLiteral>] [<Import("Physics.Ninja","Phaser")>] Ninja(game: Phaser.Game) =
            member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
            member __.gravity with get(): float = jsNative and set(v: float): unit = jsNative
            member __.bounds with get(): Phaser.Rectangle = jsNative and set(v: Phaser.Rectangle): unit = jsNative
            member __.maxObjects with get(): float = jsNative and set(v: float): unit = jsNative
            member __.maxLevels with get(): float = jsNative and set(v: float): unit = jsNative
            member __.quadTree with get(): Phaser.QuadTree = jsNative and set(v: Phaser.QuadTree): unit = jsNative
            member __.time with get(): Phaser.Time = jsNative and set(v: Phaser.Time): unit = jsNative
            member __.clearTilemapLayerBodies(map: Phaser.Tilemap, layer: obj): unit = jsNative
            member __.collide(object1: obj, object2: obj, ?collideCallback: Function, ?processCallback: Function, ?callbackContext: obj): bool = jsNative
            member __.convertTilemap(map: Phaser.Tilemap, layer: obj, slopeMap: obj): ResizeArray<obj> = jsNative
            member __.enableAABB(``object``: obj, ?children: bool): unit = jsNative
            member __.enableCircle(``object``: obj, radius: float, ?children: bool): unit = jsNative
            member __.enableTile(``object``: obj, id: float, ?children: bool): unit = jsNative
            member __.enable(``object``: obj, ?``type``: float, ?id: float, ?radius: float, ?children: bool): unit = jsNative
            member __.enableBody(``object``: obj, ?``type``: float, ?id: float, ?radius: float): unit = jsNative
            member __.overlap(object1: obj, object2: obj, ?overlapCallback: Function, ?processCallback: Function, ?callbackContext: obj): bool = jsNative
            member __.separate(body1: obj, body2: obj, ?processCallback: Function, ?callbackContext: obj, ?overlapOnly: bool): bool = jsNative
            member __.setBounds(x: float, y: float, width: float, height: float): unit = jsNative
            member __.setBoundsToWorld(): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Physics.P2","Phaser")>] P2(game: Phaser.Game, ?config: obj) =
            member __.applyDamping with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.applyGravity with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.applySpringForces with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.boundsCollidesWith with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
            member __.boundsCollisionGroup with get(): obj = jsNative and set(v: obj): unit = jsNative
            member __.config with get(): obj = jsNative and set(v: obj): unit = jsNative
            member __.callbackContext with get(): obj = jsNative and set(v: obj): unit = jsNative
            member __.collisionGroups with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
            member __.contactMaterial with get(): obj = jsNative and set(v: obj): unit = jsNative
            member __.emitImpactEvent with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.everythingCollisionGroup with get(): obj = jsNative and set(v: obj): unit = jsNative
            member __.frameRate with get(): float = jsNative and set(v: float): unit = jsNative
            member __.friction with get(): float = jsNative and set(v: float): unit = jsNative
            member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
            member __.gravity with get(): obj = jsNative and set(v: obj): unit = jsNative
            member __.materials with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
            member __.nothingCollisionGroup with get(): obj = jsNative and set(v: obj): unit = jsNative
            member __.onBodyAdded with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
            member __.onBodyRemoved with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
            member __.onBeginContact with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
            member __.onConstraintAdded with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
            member __.onConstraintRemoved with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
            member __.onContactMaterialAdded with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
            member __.onContactMaterialRemoved with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
            member __.onEndContact with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
            member __.onSpringAdded with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
            member __.onSpringRemoved with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
            member __.paused with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.postBroaddphaseCallback with get(): Function = jsNative and set(v: Function): unit = jsNative
            member __.restitution with get(): float = jsNative and set(v: float): unit = jsNative
            member __.solveConstraints with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.time with get(): obj = jsNative and set(v: obj): unit = jsNative
            member __.total with get(): float = jsNative and set(v: float): unit = jsNative
            member __.useElapsedTime with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.walls with get(): obj = jsNative and set(v: obj): unit = jsNative
            member __.world with get(): p2.World = jsNative and set(v: obj): unit = jsNative
            member __.addBody(body: obj): bool = jsNative
            member __.addContactMaterial(material: obj): obj = jsNative
            member __.addConstraint(``constraint``: 'T): 'T = jsNative
            member __.addSpring(spring: obj): obj = jsNative
            member __.beginContactHandler(``event``: obj): unit = jsNative
            member __.clear(): unit = jsNative
            member __.clearTilemapLayerBodies(map: Phaser.Tilemap, ?layer: obj): unit = jsNative
            member __.convertCollisionObjects(map: Phaser.Tilemap, ?layer: obj, ?addToWorld: bool): ResizeArray<obj> = jsNative
            member __.convertTilemap(map: Phaser.Tilemap, ?layer: obj, ?addToWorld: Boolean, ?optimize: bool): ResizeArray<obj> = jsNative
            member __.createBody(x: float, y: float, mass: float, ?addToWorld: bool, ?options: obj, ?data: ResizeArray<ResizeArray<float>>): obj = jsNative
            member __.createBody(x: float, y: float, mass: float, ?addToWorld: bool, ?options: obj, ?data: ResizeArray<float>): obj = jsNative
            member __.createCollisionGroup(?group: Phaser.Group): obj = jsNative
            member __.createCollisionGroup(?group: Phaser.Sprite): obj = jsNative
            member __.createContactMaterial(materialA: obj, materialB: obj, ?options: obj): obj = jsNative
            member __.createDistanceConstraint(bodyA: obj, bodyB: obj, distance: float, ?localAnchorA: ResizeArray<float>, ?localAnchorB: ResizeArray<float>, ?maxForce: float): obj = jsNative
            member __.createGearConstraint(bodyA: obj, bodyB: obj, ?angle: float, ?ratio: float): obj = jsNative
            member __.createLockConstraint(bodyA: obj, bodyB: obj, ?offset: ResizeArray<float>, ?angle: float, ?maxForce: float): obj = jsNative
            member __.createMaterial(?name: string, ?body: obj): obj = jsNative
            member __.createParticle(x: float, y: float, mass: float, ?addToWorld: bool, ?options: obj, ?data: ResizeArray<ResizeArray<float>>): obj = jsNative
            member __.createParticle(x: float, y: float, mass: float, ?addToWorld: bool, ?options: obj, ?data: ResizeArray<float>): obj = jsNative
            member __.createPrismaticConstraint(body: obj, bodyB: obj, ?lockRotation: bool, ?anchorA: ResizeArray<float>, ?anchorB: ResizeArray<float>, ?axis: Float32Array, ?maxForce: float): obj = jsNative
            member __.createRevoluteConstraint(bodyA: obj, pivotA: ResizeArray<float>, bodyB: obj, pivotB: ResizeArray<float>, ?maxForce: float, ?worldPivot: ResizeArray<float>): obj = jsNative
            member __.createRotationalSpring(bodyA: obj, bodyB: obj, ?restAngle: float, ?stiffness: float, ?damping: float): obj = jsNative
            member __.createSpring(bodyA: obj, bodyB: obj, ?restLength: float, ?stiffness: float, ?damping: float, ?worldA: ResizeArray<float>, ?worldB: ResizeArray<float>, ?localA: ResizeArray<float>, ?localB: ResizeArray<float>): obj = jsNative
            member __.destroy(): unit = jsNative
            member __.enable(``object``: obj, ?debug: bool, ?children: bool): unit = jsNative
            member __.enableBody(``object``: obj, debug: bool): unit = jsNative
            member __.endContactHandler(``event``: obj): unit = jsNative
            member __.getBodies(): ResizeArray<obj> = jsNative
            member __.getBody(``object``: obj): obj = jsNative
            member __.getConstraints(): ResizeArray<obj> = jsNative
            member __.getSprings(): ResizeArray<obj> = jsNative
            member __.getContactMaterial(materialA: obj, materialB: obj): obj = jsNative
            member __.hitTest(worldPoint: Phaser.Point, ?bodies: ResizeArray<obj>, ?precision: float, ?filterStatic: bool): ResizeArray<obj> = jsNative
            member __.mpx(v: float): float = jsNative
            member __.mpxi(v: float): float = jsNative
            member __.pause(): unit = jsNative
            member __.preUpdate(): unit = jsNative
            member __.pxm(v: float): float = jsNative
            member __.pxmi(v: float): float = jsNative
            member __.removeBody(body: obj): obj = jsNative
            member __.removeBodyNextStep(body: obj): unit = jsNative
            member __.removeConstraint(``constraint``: 'T): 'T = jsNative
            member __.removeContactMaterial(material: obj): obj = jsNative
            member __.removeSpring(spring: obj): obj = jsNative
            member __.reset(): unit = jsNative
            member __.resume(): unit = jsNative
            member __.setBounds(x: float, y: float, width: float, height: float, ?left: Boolean, ?right: bool, ?top: bool, ?bottom: bool, ?setCollisionGroup: bool): unit = jsNative
            member __.setBoundsToWorld(?left: bool, ?right: bool, ?top: bool, ?bottom: bool, ?setCollisionGroup: bool): unit = jsNative
            member __.setCollisionGroup(``object``: obj, group: obj): unit = jsNative
            member __.setImpactEvents(state: bool): unit = jsNative
            member __.setMaterial(material: obj, ?bodies: ResizeArray<obj>): unit = jsNative
            member __.setPostBroadphaseCallback(callback: Function, context: obj): unit = jsNative
            member __.setWorldMaterial(material: obj, ?left: bool, ?right: bool, ?top: bool, ?bottom: bool): unit = jsNative
            member __.toJSON(): obj = jsNative
            member __.update(): unit = jsNative
            member __.updateBoundsCollisionGroup(?setCollisionGroup: bool): unit = jsNative

        module Arcade =
            type [<AllowNullLiteral>] [<Import("Physics.Arcade.Body","Phaser")>] Body(sprite: Phaser.Sprite) =
                member __.acceleration with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.allowGravity with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.allowRotation with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
                member __.angularAcceleration with get(): float = jsNative and set(v: float): unit = jsNative
                member __.angularDrag with get(): float = jsNative and set(v: float): unit = jsNative
                member __.angularVelocity with get(): float = jsNative and set(v: float): unit = jsNative
                member __.blocked with get(): FaceChoices = jsNative and set(v: FaceChoices): unit = jsNative
                member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
                member __.bounce with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.center with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.checkCollision with get(): FaceChoices = jsNative and set(v: FaceChoices): unit = jsNative
                member __.collideWorldBounds with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.customSeparateX with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.customSeparateY with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.deltaMax with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.dirty with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.drag with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.embedded with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.enable with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.facing with get(): float = jsNative and set(v: float): unit = jsNative
                member __.friction with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
                member __.gravity with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.halfWidth with get(): float = jsNative and set(v: float): unit = jsNative
                member __.halfHeight with get(): float = jsNative and set(v: float): unit = jsNative
                member __.height with get(): float = jsNative and set(v: float): unit = jsNative
                member __.immovable with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.isCircle with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.isMoving with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.mass with get(): float = jsNative and set(v: float): unit = jsNative
                member __.maxAngular with get(): float = jsNative and set(v: float): unit = jsNative
                member __.maxVelocity with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.moves with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.movementCallback with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.movementCallbackContext with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.newVelocity with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.offset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.onCollide with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
                member __.onMoveComplete with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
                member __.onOverlap with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
                member __.onWorldBounds with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
                member __.overlapX with get(): float = jsNative and set(v: float): unit = jsNative
                member __.overlapY with get(): float = jsNative and set(v: float): unit = jsNative
                member __.phase with get(): float = jsNative and set(v: float): unit = jsNative
                member __.position with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.preRotation with get(): float = jsNative and set(v: float): unit = jsNative
                member __.prev with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.radius with get(): float = jsNative and set(v: float): unit = jsNative
                member __.right with get(): float = jsNative and set(v: float): unit = jsNative
                member __.rotation with get(): float = jsNative and set(v: float): unit = jsNative
                member __.skipQuadTree with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.sourceWidth with get(): float = jsNative and set(v: float): unit = jsNative
                member __.sourceHeight with get(): float = jsNative and set(v: float): unit = jsNative
                member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
                member __.sprite with get(): Phaser.Sprite = jsNative and set(v: Phaser.Sprite): unit = jsNative
                member __.stopVelocityOnCollide with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.syncBounds with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.tilePadding with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.touching with get(): FaceChoices = jsNative and set(v: FaceChoices): unit = jsNative
                member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
                member __.wasTouching with get(): FaceChoices = jsNative and set(v: FaceChoices): unit = jsNative
                member __.width with get(): float = jsNative and set(v: float): unit = jsNative
                member __.worldBounce with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.velocity with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.x with get(): float = jsNative and set(v: float): unit = jsNative
                member __.y with get(): float = jsNative and set(v: float): unit = jsNative
                member __.checkWorldBounds(): unit = jsNative
                member __.deltaX(): float = jsNative
                member __.deltaY(): float = jsNative
                member __.deltaZ(): float = jsNative
                member __.deltaAbsX(): float = jsNative
                member __.deltaAbsY(): float = jsNative
                member __.destroy(): unit = jsNative
                member __.getBounds(obj: obj): obj = jsNative
                member __.hitTest(x: float, y: float): bool = jsNative
                member __.moveFrom(duration: float, ?speed: float, ?direction: float): bool = jsNative
                member __.moveTo(duration: float, distance: float, ?direction: float): bool = jsNative
                member __.onFloor(): bool = jsNative
                member __.onWall(): bool = jsNative
                member __.preUpdate(): unit = jsNative
                member __.postUpdate(): unit = jsNative
                member __.render(context: obj, body: obj, ?color: string, ?filled: bool): unit = jsNative
                member __.renderBodyInfo(debug: obj, body: obj): unit = jsNative
                member __.reset(x: float, y: float): unit = jsNative
                member __.setCircle(radius: float, ?offsetX: float, ?offsetY: float): unit = jsNative
                member __.setSize(width: float, height: float, ?offsetX: float, ?offsetY: float): unit = jsNative
                member __.updateBounds(): bool = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.Arcade.FaceChoices","Phaser")>] FaceChoices() =
                member __.none with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.any with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.up with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.down with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.left with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.right with get(): bool = jsNative and set(v: bool): unit = jsNative



        module Ninja =
            type [<AllowNullLiteral>] [<Import("Physics.Ninja.Body","Phaser")>] Body(system: obj, sprite: Phaser.Sprite, ?``type``: float, ?id: float, ?radius: float, ?x: float, ?y: float, ?width: float, ?height: float) =
                member __.aabb with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
                member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
                member __.bounce with get(): float = jsNative and set(v: float): unit = jsNative
                member __.checkCollision with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.circle with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.collideWorldBounds with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.drag with get(): float = jsNative and set(v: float): unit = jsNative
                member __.facing with get(): float = jsNative and set(v: float): unit = jsNative
                member __.friction with get(): float = jsNative and set(v: float): unit = jsNative
                member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
                member __.gravityScale with get(): float = jsNative and set(v: float): unit = jsNative
                member __.height with get(): float = jsNative and set(v: float): unit = jsNative
                member __.immovable with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.maxSpeed with get(): float = jsNative and set(v: float): unit = jsNative
                member __.right with get(): float = jsNative and set(v: float): unit = jsNative
                member __.sprite with get(): Phaser.Sprite = jsNative and set(v: Phaser.Sprite): unit = jsNative
                member __.system with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.tile with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.touching with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
                member __.shape with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
                member __.velocity with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.wasTouching with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.width with get(): float = jsNative and set(v: float): unit = jsNative
                member __.x with get(): float = jsNative and set(v: float): unit = jsNative
                member __.y with get(): float = jsNative and set(v: float): unit = jsNative
                member __.deltaAbsX(): float = jsNative
                member __.deltaAbsY(): float = jsNative
                member __.deltaX(): float = jsNative
                member __.deltaY(): float = jsNative
                member __.destroy(): unit = jsNative
                member __.setZeroVelocity(): unit = jsNative
                member __.moveTo(speed: float, angle: float): unit = jsNative
                member __.moveFrom(speed: float, angle: float): unit = jsNative
                member __.moveLeft(speed: float): unit = jsNative
                member __.moveRight(speed: float): unit = jsNative
                member __.moveUp(speed: float): unit = jsNative
                member __.moveDown(speed: float): unit = jsNative
                member __.poseUpdate(): unit = jsNative
                member __.preUpdate(): unit = jsNative
                member __.render(context: obj, body: obj, ?color: string, ?filled: bool): unit = jsNative
                member __.reset(): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.Ninja.AABB","Phaser")>] AABB(body: obj, x: float, y: float, width: float, height: float) =
                member __.COL_NONE with get(): float = jsNative and set(v: float): unit = jsNative
                member __.COL_AXIS with get(): float = jsNative and set(v: float): unit = jsNative
                member __.COL_OTHER with get(): float = jsNative and set(v: float): unit = jsNative
                member __.aabbTileProjections with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.body with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.height with get(): float = jsNative and set(v: float): unit = jsNative
                member __.oldPos with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.pos with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.system with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.width with get(): float = jsNative and set(v: float): unit = jsNative
                member __.velocity with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.xw with get(): float = jsNative and set(v: float): unit = jsNative
                member __.yw with get(): float = jsNative and set(v: float): unit = jsNative
                member __.collideWorldBounds(): unit = jsNative
                member __.collideAABBVsAABB(aabb: obj): bool = jsNative
                member __.collideAABBVsTile(tile: obj): bool = jsNative
                member __.destroy(): unit = jsNative
                member __.integrate(): unit = jsNative
                member __.render(context: obj, xOffset: float, yOffset: float, color: string, filled: bool): unit = jsNative
                member __.reportCollision(px: float, py: float, dx: float, dy: float): unit = jsNative
                member __.reportCollisionVsWorld(px: float, py: float, dx: float, dy: float, obj: obj): unit = jsNative
                member __.reportCollisionVsBody(px: float, py: float, dx: float, dy: float, obj: obj): unit = jsNative
                member __.resolveTile(x: float, y: float, body: obj, tile: obj): bool = jsNative
                member __.reverse(): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.Ninja.Circle","Phaser")>] Circle(body: obj, x: float, y: float, radius: float) =
                member __.COL_NONE with get(): float = jsNative and set(v: float): unit = jsNative
                member __.COL_AXIS with get(): float = jsNative and set(v: float): unit = jsNative
                member __.COL_OTHER with get(): float = jsNative and set(v: float): unit = jsNative
                member __.body with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.circleTileProjections with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.oldPos with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.height with get(): float = jsNative and set(v: float): unit = jsNative
                member __.pos with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.radius with get(): float = jsNative and set(v: float): unit = jsNative
                member __.system with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
                member __.velocity with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.width with get(): float = jsNative and set(v: float): unit = jsNative
                member __.xw with get(): float = jsNative and set(v: float): unit = jsNative
                member __.yw with get(): float = jsNative and set(v: float): unit = jsNative
                member __.collideCircleVsTile(tile: obj): bool = jsNative
                member __.collideWorldBounds(): unit = jsNative
                member __.destroy(): unit = jsNative
                member __.distance(dest: float, ?round: bool): float = jsNative
                member __.integrate(): unit = jsNative
                member __.render(context: obj, xOffset: float, yOffset: float, color: string, filled: bool): unit = jsNative
                member __.reportCollisionVsWorld(px: float, py: float, dx: float, dy: float, obj: obj): unit = jsNative
                member __.reportCollisionVsBody(px: float, py: float, dx: float, dy: float, obj: obj): unit = jsNative
                member __.resolveCircleTile(x: float, y: float, oH: float, oV: float, obj: obj, t: obj): bool = jsNative

            and TileType =
                | TYPE_EMPTY = 0
                | TYPE_FULL = 1
                | TYPE_45DEG = 2
                | TYPE_CONCAVE = 3
                | TYPE_CONVEX = 4
                | TYPE_22DEGs = 5
                | TYPE_22DEGb = 6
                | TYPE_67DEGs = 7
                | TYPE_67DEGb = 8
                | TYPE_HALF = 9

            and [<AllowNullLiteral>] [<Import("Physics.Ninja.Tile","Phaser")>] Tile(body: obj, x: float, y: float, width: float, height: float, ?``type``: float) =
                member __.body with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
                member __.flipped with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.height with get(): float = jsNative and set(v: float): unit = jsNative
                member __.id with get(): float = jsNative and set(v: float): unit = jsNative
                member __.oldpos with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.pos with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.right with get(): float = jsNative and set(v: float): unit = jsNative
                member __.rotation with get(): float = jsNative and set(v: float): unit = jsNative
                member __.system with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.``type`` with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.velocity with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.width with get(): float = jsNative and set(v: float): unit = jsNative
                member __.xw with get(): float = jsNative and set(v: float): unit = jsNative
                member __.yw with get(): float = jsNative and set(v: float): unit = jsNative
                member __.x with get(): float = jsNative and set(v: float): unit = jsNative
                member __.y with get(): float = jsNative and set(v: float): unit = jsNative
                member __.clear(): unit = jsNative
                member __.collideWorldBounds(): unit = jsNative
                member __.destroy(): unit = jsNative
                member __.integrate(): unit = jsNative
                member __.reportCollisionVsWorld(px: float, py: float, dx: float, dy: float, obj: obj): unit = jsNative
                member __.setType(id: float): float = jsNative



        module P2 =
            type [<AllowNullLiteral>] [<Import("Physics.P2.Body","Phaser")>] Body(game: Phaser.Game, ?sprite: Phaser.Sprite, ?x: float, ?y: float, ?mass: float) =
                member __.DYNAMIC with get(): float = jsNative and set(v: float): unit = jsNative
                member __.STATIC with get(): float = jsNative and set(v: float): unit = jsNative
                member __.KINEMATIC with get(): float = jsNative and set(v: float): unit = jsNative
                member __.allowSleep with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
                member __.angularDamping with get(): float = jsNative and set(v: float): unit = jsNative
                member __.angularForce with get(): float = jsNative and set(v: float): unit = jsNative
                member __.angularVelocity with get(): float = jsNative and set(v: float): unit = jsNative
                member __.collidesWith with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
                member __.collideWorldBounds with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.damping with get(): float = jsNative and set(v: float): unit = jsNative
                member __.data with get(): p2.Body = jsNative and set(v: p2.Body): unit = jsNative
                member __.debug with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.debugBody with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.dynamic with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.fixedRotation with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.force with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.kinematic with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
                member __.gravity with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.id with get(): float = jsNative and set(v: float): unit = jsNative
                member __.inertia with get(): float = jsNative and set(v: float): unit = jsNative
                member __.mass with get(): float = jsNative and set(v: float): unit = jsNative
                member __.motionState with get(): float = jsNative and set(v: float): unit = jsNative
                member __.offset with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
                member __.onBeginContact with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
                member __.onEndContact with get(): Phaser.Signal = jsNative and set(v: Phaser.Signal): unit = jsNative
                member __.rotation with get(): float = jsNative and set(v: float): unit = jsNative
                member __.removeNextStep with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.sprite with get(): Phaser.Sprite = jsNative and set(v: Phaser.Sprite): unit = jsNative
                member __.sleepSpeedLimit with get(): float = jsNative and set(v: float): unit = jsNative
                member __.``static`` with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
                member __.velocity with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.world with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.x with get(): float = jsNative and set(v: float): unit = jsNative
                member __.y with get(): float = jsNative and set(v: float): unit = jsNative
                member __.addToWorld(): unit = jsNative
                member __.addCapsule(length: float, radius: float, ?offsetX: float, ?offsetY: float, ?rotation: float): p2.Capsule = jsNative
                member __.addCircle(radius: float, ?offsetX: float, ?offsetY: float, ?rotation: float): p2.Circle = jsNative
                member __.addFixture(fixtureData: string): ResizeArray<p2.Shape> = jsNative
                member __.addLine(length: float, ?offsetX: float, ?offsetY: float, ?rotation: float): p2.Line = jsNative
                member __.addParticle(?offsetX: float, ?offsetY: float, ?rotation: float): p2.Particle = jsNative
                member __.addPolygon(options: obj, points: ResizeArray<ResizeArray<float>>): bool = jsNative
                member __.addPhaserPolygon(key: string, ``object``: string): obj = jsNative
                member __.addPlane(?offsetX: float, ?offsetY: float, ?rotation: float): p2.Plane = jsNative
                member __.addRectangle(width: float, height: float, ?offsetX: float, ?offsetY: float, ?rotation: float): p2.Rectangle = jsNative
                member __.addShape(shape: p2.Shape, ?offsetX: float, ?offsetY: float, ?rotation: float): p2.Shape = jsNative
                member __.adjustCenterOfMass(): unit = jsNative
                member __.applyDamping(dt: float): unit = jsNative
                member __.applyForce(force: ResizeArray<float>, worldX: float, worldY: float): unit = jsNative
                member __.applyImpulse(impulse: ResizeArray<float>, worldX: float, worldY: float): unit = jsNative
                member __.applyImpulseLocal(impulse: ResizeArray<float>, localX: float, localY: float): unit = jsNative
                member __.clearCollision(?clearGroup: bool, ?cleanMask: bool, ?shape: p2.Shape): unit = jsNative
                member __.clearShapes(): unit = jsNative
                member __.collides(group: obj, ?callback: Function, ?callbackContext: obj, ?shape: p2.Shape): unit = jsNative
                member __.createBodyCallback(``object``: obj, callback: Function, callbackContext: obj): unit = jsNative
                member __.createGroupCallback(group: obj, callback: Function, callbackContext: obj): unit = jsNative
                member __.destroy(): unit = jsNative
                member __.getCollisionMask(): float = jsNative
                member __.getVelocityAtPoint(result: ResizeArray<float>, relativePoint: ResizeArray<float>): ResizeArray<float> = jsNative
                member __.loadPolygon(key: string, ``object``: string): bool = jsNative
                member __.moveBackward(speed: float): unit = jsNative
                member __.moveDown(speed: float): unit = jsNative
                member __.moveForward(speed: float): unit = jsNative
                member __.moveLeft(speed: float): unit = jsNative
                member __.moveRight(speed: float): unit = jsNative
                member __.moveUp(speed: float): unit = jsNative
                member __.preUpdate(): unit = jsNative
                member __.postUpdate(): unit = jsNative
                member __.removeCollisionGroup(group: obj, ?clearCallback: bool, ?shape: p2.Shape): unit = jsNative
                member __.removeFromWorld(): unit = jsNative
                member __.removeShape(shape: p2.Shape): bool = jsNative
                member __.reverse(speed: float): unit = jsNative
                member __.rotateLeft(speed: float): unit = jsNative
                member __.rotateRight(speed: float): unit = jsNative
                member __.reset(x: float, y: float, ?resetDamping: bool, ?resetMass: bool): unit = jsNative
                member __.shapeChanged(): unit = jsNative
                member __.setCircle(radius: float, ?offsetX: float, ?offsetY: float, ?rotation: float): p2.Circle = jsNative
                member __.setCollisionGroup(group: obj, ?shape: p2.Shape): unit = jsNative
                member __.setRectangle(?width: float, ?height: float, ?offsetX: float, ?offsetY: float, ?rotation: float): p2.Rectangle = jsNative
                member __.setRectangleFromSprite(sprite: obj): p2.Rectangle = jsNative
                member __.setMaterial(material: obj, ?shape: p2.Shape): unit = jsNative
                member __.setZeroDamping(): unit = jsNative
                member __.setZeroForce(): unit = jsNative
                member __.setZeroRotation(): unit = jsNative
                member __.setZeroVelocity(): unit = jsNative
                member __.toLocalFrame(out: ResizeArray<float>, worldPoint: ResizeArray<float>): unit = jsNative
                member __.thrust(speed: float): unit = jsNative
                member __.thrustLeft(speed: float): unit = jsNative
                member __.thrustRight(speed: float): unit = jsNative
                member __.toWorldFrame(out: ResizeArray<float>, localPoint: ResizeArray<float>): unit = jsNative
                member __.updateCollisionMask(?shape: p2.Shape): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.P2.BodyDebug","Phaser")>] BodyDebug(game: Phaser.Game, body: obj, settings: obj) =
                inherit Phaser.Group()
                member __.body with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.canvas with get(): Phaser.Graphics = jsNative and set(v: Phaser.Graphics): unit = jsNative
                member __.ppu with get(): float = jsNative and set(v: float): unit = jsNative
                member __.updateSpriteTransform(): unit = jsNative
                member __.draw(): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.P2.CollisionGroup","Phaser")>] CollisionGroup(bitmask: float) =
                member __.mask with get(): float = jsNative and set(v: float): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.P2.ContactMaterial","Phaser")>] ContactMaterial() =
                // interface p2.ContactMaterial
                class end


            and [<AllowNullLiteral>] [<Import("Physics.P2.DistanceConstraint","Phaser")>] DistanceConstraint(world: obj, bodyA: obj, bodyB: obj, distance: float, maxForce: float) =
                // interface p2.DistanceConstraint
                member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
                member __.world with get(): obj = jsNative and set(v: obj): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.P2.FixtureList","Phaser")>] FixtureList(list: ResizeArray<obj>) =
                member __.flatten(array: ResizeArray<obj>): ResizeArray<obj> = jsNative
                member __.getFixtures(keys: string): ResizeArray<obj> = jsNative
                member __.getFixtureByKey(key: string): ResizeArray<obj> = jsNative
                member __.getGroup(groupID: float): ResizeArray<obj> = jsNative
                member __.init(): unit = jsNative
                member __.parse(): unit = jsNative
                member __.setCategory(bit: float, fictureKey: string): unit = jsNative
                member __.setMask(bit: float, fixtureKey: string): unit = jsNative
                member __.setMaterial(material: obj, fixtureKey: string): unit = jsNative
                member __.setSensor(value: bool, fixtureKey: string): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.P2.GearConstraint","Phaser")>] GearConstraint(world: obj, bodyA: obj, bodyB: obj, ?angle: float, ?ratio: float) =
                // interface p2.GearConstraint
                member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
                member __.world with get(): obj = jsNative and set(v: obj): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.P2.InversePointProxy","Phaser")>] InversePointProxy(world: obj, destination: obj) =
                member __.x with get(): float = jsNative and set(v: float): unit = jsNative
                member __.y with get(): float = jsNative and set(v: float): unit = jsNative
                member __.mx with get(): float = jsNative and set(v: float): unit = jsNative
                member __.my with get(): float = jsNative and set(v: float): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.P2.LockConstraint","Phaser")>] LockConstraint(world: obj, bodyA: obj, bodyB: obj, ?offset: ResizeArray<float>, ?angle: float, ?maxForce: float) =
                // interface p2.LockConstraint
                member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
                member __.world with get(): obj = jsNative and set(v: obj): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.P2.Material","Phaser")>] Material(name: string) =
                // interface p2.Material
                member __.name with get(): string = jsNative and set(v: string): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.P2.PointProxy","Phaser")>] PointProxy(world: obj, destination: obj) =
                member __.x with get(): float = jsNative and set(v: float): unit = jsNative
                member __.y with get(): float = jsNative and set(v: float): unit = jsNative
                member __.mx with get(): float = jsNative and set(v: float): unit = jsNative
                member __.my with get(): float = jsNative and set(v: float): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.P2.PrismaticConstraint","Phaser")>] PrismaticConstraint(world: obj, ?bodyA: obj, ?bodyB: obj, ?lockRotation: bool, ?anchorA: ResizeArray<float>, ?anchorB: ResizeArray<float>, ?axis: ResizeArray<float>, ?maxForce: float) =
                // interface p2.PrismaticConstraint
                member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
                member __.world with get(): obj = jsNative and set(v: obj): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.P2.RevoluteConstraint","Phaser")>] RevoluteConstraint(world: obj, bodyA: obj, pivotA: ResizeArray<float>, bodyB: obj, pivotB: ResizeArray<float>, ?maxForce: float) =
                // interface p2.RevoluteConstraint
                member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
                member __.world with get(): obj = jsNative and set(v: obj): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Physics.P2.Spring","Phaser")>] Spring(world: obj, bodyA: obj, bodyB: obj, ?restLength: float, ?stiffness: float, ?damping: float, ?worldA: ResizeArray<float>, ?worldB: ResizeArray<float>, ?localA: ResizeArray<float>, ?localB: ResizeArray<float>) =
                member __.data with get(): p2.LinearSpring = jsNative and set(v: p2.LinearSpring): unit = jsNative
                member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
                member __.world with get(): obj = jsNative and set(v: obj): unit = jsNative



    module Plugin =
        type [<AllowNullLiteral>] [<Import("Plugin.SaveCPU","Phaser")>] SaveCPU() =
            inherit Phaser.Plugin()
            member __.renderOnFPS with get(): float = jsNative and set(v: float): unit = jsNative
            member __.renderOnPointerChange with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.forceRender(): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Plugin.AStar","Phaser")>] AStar(parent: PIXI.DisplayObject) =
            inherit Phaser.Plugin()
            member __.VERSION with get(): string = jsNative and set(v: string): unit = jsNative
            member __.COST_ORTHAGONAL with get(): float = jsNative and set(v: float): unit = jsNative
            member __.COST_DIAGAONAL with get(): float = jsNative and set(v: float): unit = jsNative
            member __.DISTANCE_MANHATTEN with get(): string = jsNative and set(v: string): unit = jsNative
            member __.DISTANCE_EUCLIDIAN with get(): string = jsNative and set(v: string): unit = jsNative
            member __.parent with get(): PIXI.DisplayObject = jsNative and set(v: PIXI.DisplayObject): unit = jsNative
            member __.version with get(): string = jsNative and set(v: string): unit = jsNative
            member __.findPath(startPoint: Phaser.Point, goalPoint: Phaser.Point): obj = jsNative
            member __.isWalkable(x: float, y: float): bool = jsNative
            member __.setAStarMap(map: Phaser.Tilemap, layerName: string, tilesetName: string): obj = jsNative

        and [<AllowNullLiteral>] [<Import("Plugin.ColorHarmony","Phaser")>] ColorHarmony() =
            inherit Phaser.Plugin()
            member __.getAnalogousHarmony(color: float, ?threshold: float): obj = jsNative
            member __.getComplementHarmony(color: float): float = jsNative
            member __.getSplitComplementHarmony(color: float, threshold: float): obj = jsNative
            member __.getTriadicHarmony(color: float): obj = jsNative

        and [<AllowNullLiteral>] [<Import("Plugin.CSS3Filters","Phaser")>] CSS3Filters(parent: PIXI.DisplayObject) =
            inherit Phaser.Plugin()
            member __.blur with get(): float = jsNative and set(v: float): unit = jsNative
            member __.brightness with get(): float = jsNative and set(v: float): unit = jsNative
            member __.contrast with get(): float = jsNative and set(v: float): unit = jsNative
            member __.grayscale with get(): float = jsNative and set(v: float): unit = jsNative
            member __.hueRotate with get(): float = jsNative and set(v: float): unit = jsNative
            member __.invert with get(): float = jsNative and set(v: float): unit = jsNative
            member __.opacity with get(): float = jsNative and set(v: float): unit = jsNative
            member __.saturate with get(): float = jsNative and set(v: float): unit = jsNative
            member __.sepia with get(): float = jsNative and set(v: float): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Plugin.TilemapWalker","Phaser")>] TilemapWalker(game: Phaser.Game, map: Phaser.Tilemap, ?layer: obj, ?x: float, ?y: float) =
            inherit Phaser.Plugin()
            member __.collides with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
            member __.history with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.facing with get(): float = jsNative and set(v: float): unit = jsNative
            member __.map with get(): Phaser.Tilemap = jsNative and set(v: Phaser.Tilemap): unit = jsNative
            member __.location with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
            member __.locationLayer with get(): float = jsNative and set(v: float): unit = jsNative
            member __.checkTile(x: float, y: float): bool = jsNative
            member __.getTileFromLocation(x: float, y: float): Phaser.Tile = jsNative
            member __.getTiles(width: float, height: float, ?center: bool): ResizeArray<obj> = jsNative
            member __.getTileBehind(?distance: float): Phaser.Tile = jsNative
            member __.getTileBehindLeft(?distance: float): Phaser.Tile = jsNative
            member __.getTileBehindRight(?distance: float): Phaser.Tile = jsNative
            member __.getTileAhead(?distance: float): Phaser.Tile = jsNative
            member __.getTileAheadLeft(?distance: float): Phaser.Tile = jsNative
            member __.getTileAheadRight(?distance: float): Phaser.Tile = jsNative
            member __.getTileLeft(distance: float): Phaser.Tile = jsNative
            member __.getTileRight(distance: float): Phaser.Tile = jsNative
            member __.moveForward(): bool = jsNative
            member __.moveBackward(): bool = jsNative
            member __.moveLeft(): bool = jsNative
            member __.moveRight(): bool = jsNative
            member __.putTile(index: float): unit = jsNative
            member __.setLocation(x: float, y: float, ?layer: obj): bool = jsNative
            member __.turnLeft(): unit = jsNative
            member __.turnRight(): unit = jsNative
            member __.updateLocation(x: float, y: float): bool = jsNative

        and [<AllowNullLiteral>] [<Import("Plugin.SamplePlugin","Phaser")>] SamplePlugin(game: Phaser.Game, parent: PIXI.DisplayObject) =
            inherit Phaser.Plugin()
            member __.addSprite(sprite: Phaser.Sprite): unit = jsNative
            member __.update(): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Plugin.VirtualJoystick","Phaser")>] VirtualJoystick(game: Phaser.Game, parent: obj) =
            inherit Phaser.Plugin()
            member __.angle with get(): float = jsNative and set(v: float): unit = jsNative
            member __.``base`` with get(): Phaser.Sprite = jsNative and set(v: Phaser.Sprite): unit = jsNative
            member __.baseBMD with get(): Phaser.BitmapData = jsNative and set(v: Phaser.BitmapData): unit = jsNative
            member __.baseCircle with get(): Phaser.Circle = jsNative and set(v: Phaser.Circle): unit = jsNative
            member __.deltaX with get(): float = jsNative and set(v: float): unit = jsNative
            member __.deltaY with get(): float = jsNative and set(v: float): unit = jsNative
            member __.distance with get(): float = jsNative and set(v: float): unit = jsNative
            member __.force with get(): float = jsNative and set(v: float): unit = jsNative
            member __.isDragging with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.limit with get(): float = jsNative and set(v: float): unit = jsNative
            member __.limitPoint with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
            member __.location with get(): Phaser.Point = jsNative and set(v: Phaser.Point): unit = jsNative
            member __.nub with get(): Phaser.Sprite = jsNative and set(v: Phaser.Sprite): unit = jsNative
            member __.nubBMD with get(): Phaser.BitmapData = jsNative and set(v: Phaser.BitmapData): unit = jsNative
            member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
            member __.x with get(): float = jsNative and set(v: float): unit = jsNative
            member __.y with get(): float = jsNative and set(v: float): unit = jsNative
            member __.init(x: float, y: float, ?diameter: float, ?limit: float): unit = jsNative
            member __.move(pointer: Phaser.Pointer, x: float, y: float): unit = jsNative
            member __.render(): unit = jsNative
            member __.setVelocity(sprite: Phaser.Sprite, ?minSpeed: float, ?maxSpeed: float): Phaser.Sprite = jsNative
            member __.startDrag(): unit = jsNative
            member __.stopDrag(nub: Phaser.Sprite, pointer: Phaser.Pointer): unit = jsNative
            member __.update(): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Plugin.Webcam","Phaser")>] Webcam(game: Phaser.Game, parent: PIXI.DisplayObject) =
            inherit Phaser.Plugin()
            member __.active with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.context with get(): obj = jsNative and set(v: obj): unit = jsNative
            member __.stream with get(): obj = jsNative and set(v: obj): unit = jsNative
            member __.video with get(): HTMLVideoElement = jsNative and set(v: HTMLVideoElement): unit = jsNative
            member __.connectCallback with get(): Func<obj, unit> = jsNative and set(v: Func<obj, unit>): unit = jsNative
            member __.errorCallback with get(): Func<obj, unit> = jsNative and set(v: Func<obj, unit>): unit = jsNative
            member __.grab with get(): Func<obj, float, float, unit> = jsNative and set(v: Func<obj, float, float, unit>): unit = jsNative
            member __.start(width: float, height: float, context: obj): unit = jsNative
            member __.stop(): unit = jsNative
            member __.update(): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Plugin.Juicy","Phaser")>] Juicy(game: Phaser.Game) =
            inherit Phaser.Plugin()
            member __.createScreenFlash(?color: string): obj = jsNative
            member __.createTrail(?length: float, ?color: float): obj = jsNative
            member __.overScale(``object``: Phaser.Sprite, ?scale: float, ?initialScale: Phaser.Point): unit = jsNative
            member __.jelly(``object``: Phaser.Sprite, ?strength: float, ?delay: float, ?initialScale: Phaser.Point): unit = jsNative
            member __.mouseStretch(``object``: Phaser.Sprite, ?strength: float, ?initialScale: Phaser.Point): unit = jsNative
            member __.update(): unit = jsNative
            member __.shake(?duration: float, ?strength: float): unit = jsNative

        module AStar =
            type [<AllowNullLiteral>] [<Import("Plugin.AStar.AStarNode","Phaser")>] AStarNode(x: float, y: float, isWalkable: bool) =
                member __.x with get(): float = jsNative and set(v: float): unit = jsNative
                member __.y with get(): float = jsNative and set(v: float): unit = jsNative
                member __.g with get(): float = jsNative and set(v: float): unit = jsNative
                member __.h with get(): float = jsNative and set(v: float): unit = jsNative
                member __.f with get(): float = jsNative and set(v: float): unit = jsNative
                member __.parent with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.travelCost with get(): float = jsNative and set(v: float): unit = jsNative
                member __.walkable with get(): bool = jsNative and set(v: bool): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Plugin.AStar.AStarPath","Phaser")>] AStarPath(nodes: ResizeArray<obj>, start: obj, goal: obj) =
                member __.nodes with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
                member __.start with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.goal with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.visited with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative



        module Juicy =
            type [<AllowNullLiteral>] [<Import("Plugin.Juicy.Trail","Phaser")>] Trail(game: Phaser.Game, ?trailLength: float, ?color: float) =
                member __.target with get(): Phaser.Sprite = jsNative and set(v: Phaser.Sprite): unit = jsNative
                member __.trailLength with get(): float = jsNative and set(v: float): unit = jsNative
                member __.trailWidth with get(): float = jsNative and set(v: float): unit = jsNative
                member __.trailScaling with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.trailColor with get(): float = jsNative and set(v: float): unit = jsNative
                member __.update(): unit = jsNative
                member __.addSegment(x: float, y: float): unit = jsNative
                member __.redrawSegments(offsetX: float, offsetY: float): unit = jsNative

            and [<AllowNullLiteral>] [<Import("Plugin.Juicy.ScreenFlash","Phaser")>] ScreenFlash(game: Phaser.Game, ?color: string) =
                member __.flash(?maxAlpha: float, ?duration: float): unit = jsNative



    module Utils =
        type [<AllowNullLiteral>] [<Import("Utils.Debug","Phaser")>] Debug(game: Phaser.Game) =
            member __.bmd with get(): Phaser.BitmapData = jsNative and set(v: Phaser.BitmapData): unit = jsNative
            member __.canvas with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
            member __.columnWidth with get(): float = jsNative and set(v: float): unit = jsNative
            member __.context with get(): CanvasRenderingContext2D = jsNative and set(v: CanvasRenderingContext2D): unit = jsNative
            member __.currentAlpha with get(): float = jsNative and set(v: float): unit = jsNative
            member __.currentX with get(): float = jsNative and set(v: float): unit = jsNative
            member __.currentY with get(): float = jsNative and set(v: float): unit = jsNative
            member __.dirty with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.font with get(): string = jsNative and set(v: string): unit = jsNative
            member __.game with get(): Phaser.Game = jsNative and set(v: Phaser.Game): unit = jsNative
            member __.lineHeight with get(): float = jsNative and set(v: float): unit = jsNative
            member __.renderShadow with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.sprite with get(): Phaser.Image = jsNative and set(v: Phaser.Image): unit = jsNative
            member __.AStar(astar: obj, x: float, y: float, showVisited: bool): unit = jsNative
            member __.boot(): unit = jsNative
            member __.body(sprite: Phaser.Sprite, ?color: string, ?filled: bool): unit = jsNative
            member __.bodyInfo(sprite: Phaser.Sprite, x: float, y: float, ?color: string): unit = jsNative
            member __.box2dBody(body: Phaser.Sprite, ?color: string): unit = jsNative
            member __.box2dWorld(): unit = jsNative
            member __.cameraInfo(camera: Phaser.Camera, x: float, y: float, ?color: string): unit = jsNative
            member __.destroy(): unit = jsNative
            member __.geom(``object``: obj, ?color: string, ?fiiled: bool, ?forceType: float): unit = jsNative
            member __.inputInfo(x: float, y: float, ?color: string): unit = jsNative
            member __.lineInfo(line: Phaser.Line, x: float, y: float, ?color: string): unit = jsNative
            member __.key(key: Phaser.Key, ?x: float, ?y: float, ?color: string): unit = jsNative
            member __.line([<ParamArray>] args: string[]): unit = jsNative
            member __.preUpdate(): unit = jsNative
            member __.pixel(x: float, y: float, ?color: string, ?size: float): unit = jsNative
            member __.pointer(pointer: Phaser.Pointer, ?hideIfUp: bool, ?downColor: string, ?upColor: string, ?color: string): unit = jsNative
            member __.quadTree(quadtree: Phaser.QuadTree, ?color: string): unit = jsNative
            member __.rectangle(``object``: Phaser.Rectangle, ?color: string, ?filled: bool): unit = jsNative
            member __.reset(): unit = jsNative
            member __.ropeSegments(rope: Phaser.Rope, ?color: float, ?filled: bool): unit = jsNative
            member __.soundInfo(sound: Phaser.Sound, x: float, y: float, ?color: string): unit = jsNative
            member __.spriteBounds(sprite: obj, ?color: string, ?filled: bool): unit = jsNative
            member __.spriteCoords(sprite: obj, x: float, y: float, ?color: string): unit = jsNative
            member __.spriteInfo(sprite: Phaser.Sprite, x: float, y: float, ?color: string): unit = jsNative
            member __.spriteInputInfo(sprite: Phaser.Sprite, x: float, y: float, ?color: string): unit = jsNative
            member __.start(?x: float, ?y: float, ?color: string, ?columnWidth: float): unit = jsNative
            member __.stop(): unit = jsNative
            member __.text(text: string, x: float, y: float, ?color: string, ?font: string): unit = jsNative
            member __.timer(timer: Phaser.Timer, x: float, y: float, ?color: string): unit = jsNative

