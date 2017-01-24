namespace Fable.Import
    
open Fable.Core

module Dimple =

    type Chart =
        abstract addLegend: int*int*int*int*string -> unit
        abstract addLegend: int*int*int*int*string*Series array -> unit
        abstract addMeasureAxis: string*string -> Axis
        abstract addCategoryAxis: string*string -> Axis
        abstract addPctAxis: string*string -> Axis
        abstract draw: unit -> unit
        abstract setMargins: int*int*int*int -> unit
        abstract setBounds: int*int*int*int -> unit
        abstract setBounds: string*string*string*string -> unit
        abstract defaultColors: Color array with get,set
        [<Emit("$0.addSeries($1,$2)")>]
        abstract addSeries: string*Plot -> Series
        [<Emit("$0.addSeries($1,$2)")>]
        abstract addPieSeries: string*Plot -> PieSeries

    and Axis =
        abstract colors: string array with get,set
        abstract floatingBarWidth: float with get,set
        abstract fontSize: string with get,set
        abstract hidden: bool with get,set
        abstract shapes: D3.Selection<obj> with get,set
        abstract showGridlines: bool with get,set
        abstract ticks: int with get,set
        abstract title: string with get,set
    and Plot = interface end

    and Svg = inherit Fable.Import.D3.Selection<obj>

    and Color = 
        abstract opacity: float with get,set
    
    and Series =
        abstract addOrderRule: string array -> unit
        abstract addEventHandler: string*(EventArgs->unit) -> unit
        abstract afterDraw: (D3.Selection<obj>*obj -> unit) with get,set
        abstract barGap: float with get,set
        abstract interpolation: string with get,set
        abstract lineWeight: float with get,set
        abstract shapes: D3.Selection<obj> with get,set
    
    and PieSeries =
        abstract innerRadius: string with get,set
        abstract outerRadius: string with get,set
        inherit Series

    and EventArgs =
        abstract seriesValue: string array with get
        abstract xValue: float with get
        abstract yValue: float with get
        abstract zValue: float with get
        abstract pValue: float with get
        abstract colorValue: int with get
        abstract frameValue: string with get
        abstract seriesShapes: obj with get
        abstract selectedShape: obj with get

    and Plots =
        abstract pie: Plot
        abstract bar: Plot
        abstract area: Plot

    and [<Import("*","d3")>] Globals =
        [<Emit("new $0.chart($1,$2)")>]
        abstract chart: Svg*obj -> Chart
        [<Emit("new $0.color($1)")>]
        abstract color: string -> Color
        [<Emit("new $0.color($1,$2)")>]
        abstract color: string*string -> Color
        abstract newSvg: string*int*int -> Svg
        abstract plot: Plots with get