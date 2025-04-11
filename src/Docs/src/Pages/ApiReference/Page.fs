module Docs.Pages.ApiReference.Page

open Feliz
open ElmishLand
open Docs.Shared
open Docs.Pages

type Model = { Dummy: unit }

type Msg = LayoutMsg of Layout.Msg

let init () = { Dummy = () }, Command.none

let update (msg: Msg) (model: Model) =
    match msg with
    | LayoutMsg _ -> model, Command.none

let view (_model: Model) (_dispatch: Msg -> unit) = Html.text "ApiReference Page"

let page (_shared: SharedModel) (_route: ApiReferenceRoute) =
    Page.from init update view { Layout.CurrentPage = "" } LayoutMsg
