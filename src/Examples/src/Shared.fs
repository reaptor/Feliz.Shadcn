module Examples.Shared

open System
open ElmishLand

type SharedModel = unit

type SharedMsg = | NoOp

let init () = (), Command.none

let update (msg: SharedMsg) (model: SharedModel) =
    match msg with
    | NoOp -> model, Command.none

// https://elmish.github.io/elmish/docs/subscription.html
let subscriptions _model : (string list * ((SharedMsg -> unit) -> IDisposable)) list = []
