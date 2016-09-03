# fable-import-pixi

Fable bindings for [PixiJS](http://www.pixijs.com/) v3

## Installation

```sh
npm install --save fable-core pixi.js@^3.0.0
npm install --save-dev fable-import-pixi
```

> Note: If you're loading PixiJS on the browser with [require.js](http://requirejs.org/),
use the prebuilt file: `node_modules/pixi.js/bin/pixi.min.js`

## Usage

### F# project (.fsproj)

```xml
  <ItemGroup>
    <Reference Include="node_modules/fable-core/Fable.Core.dll" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="node_modules/fable-import-pixi/Fable.Import.Pixi.fs" />
  </ItemGroup>
```

### F# script (.fsx)

```fsharp
#r "node_modules/fable-core/Fable.Core.dll"
#load "node_modules/fable-import-pixi/Fable.Import.Pixi.fs"

open Fable.Core
open Fable.Import
```
