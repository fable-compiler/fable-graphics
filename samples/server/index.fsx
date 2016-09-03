#r "../node_modules/fable-core/Fable.Core.dll"
open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Node

let finalhandler = importDefault<obj> "finalhandler"
let serveStatic = importDefault<obj> "serve-static"
let opener = importDefault<obj> "open"

let port =
    match ``process``.argv with
    | args when args.Count >= 3 -> int args.[2]
    | _ -> 8080

let samplesPath = path.resolve("../..")
let relPath = path.relative(samplesPath, ".")

let server =
    let serve = serveStatic$(samplesPath)
    let server =
        http.createServer(Func<_,_,_>(fun req res ->
            let isDone = finalhandler$(req, res)
            serve$(req, res, isDone)
            |> ignore))
    server.listen(port)

opener$(sprintf "http://localhost:%i/%s" port relPath)
