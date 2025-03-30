module Docs.Shared

open System
open Feliz
open ElmishLand

type SharedModel = unit

type SharedMsg = | NoOp


let init () = (), Command.none

let update (msg: SharedMsg) (model: SharedModel) =
    match msg with
    | NoOp -> model, Command.none

// https://elmish.github.io/elmish/docs/subscription.html
let subscriptions _model : (string list * ((SharedMsg -> unit) -> IDisposable)) list = []

let Header2 (s: string) =
    Html.h2 [ prop.className "font-bold"; prop.text s ]
