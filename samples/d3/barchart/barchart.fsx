(**
 - title: Bar chart sample
 - tagline: Bar chart implemented using Fable-D3 bindings
 - app-style: width:800px; margin:20px auto 50px auto;
 - intro: Creating a bar chart using Fable-D3 bindings
*)

#r "../../node_modules/fable-core/Fable.Core.dll"
#load "../../node_modules/fable-import-d3/Fable.Import.D3.fs"

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser

let random = new System.Random()
let dataset = Array.init 25 (fun _ -> (random.Next(3,25)))
let barHeight x = x * 5 
let barPadding = 1.
let width = 500.
let height = 100.
let dataSetLength = float dataset.Length

let svg = D3.Globals.select("#display")
                    .append("svg")
                    .attr("width", U3.Case1 width)
                    .attr("height", U3.Case1 height)

svg.selectAll("rect")
    .data(dataset)
|> fun x -> (unbox<D3.Selection.Update<int>> x).enter()
|> fun x -> x.append("rect")
|> fun x -> x.attr("width", fun _ _ _ -> U3.Case1 (System.Math.Abs(width / dataSetLength - barPadding)))
                .attr("height", fun data _ _ -> U3.Case1 (float data * 4.))
                .attr("x", fun _ x _ -> U3.Case1 (x * (width/dataSetLength))) 
                .attr("y", fun data _ _ -> U3.Case1 (height - float data * 4.))
                .attr("fill", fun data _ _ -> U3.Case2 (sprintf "rgb(63,%A,150)" (data * 10))) 
|> ignore
            

svg.selectAll("text")
    .data(dataset)
|> fun x -> (unbox<D3.Selection.Update<int>> x).enter()
|> fun x -> x.append("text")
|> fun x -> x.text(fun data _ _ -> U3.Case2 (string data))
             .attr("x", fun _ x _ -> U3.Case1 (x * (width/dataSetLength))) 
             .attr("y", fun data _ _ -> U3.Case1 (height - (float data * 4.)))
|> ignore