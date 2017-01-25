# fable-import-dimple

Fable bindings for Dimple.js

## Installation

```sh
$ npm install --save fable-core git+https://github.com/PMSI-AlignAlytics/dimple.git
$ npm install --save-dev fable-import-dimple
```

## Usage

Note: To prevent naming conflicts, module names start with upper case,
while variables containing global methods are lower case.

### In a F# project (.fsproj)

```xml
  <ItemGroup>
    <Reference Include="node_modules/fable-core/Fable.Core.dll" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="node_modules/fable-import-dimple/Fable.Import.Dimple.fs" />
  </ItemGroup>
```

### In a F# script (.fsx)

```fsharp
#r "node_modules/fable-core/Fable.Core.dll"
#load "node_modules/fable-import-dimple/Fable.Import.Dimple.fs"

open Fable.Core
open Fable.Import
```
