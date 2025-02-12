module Examples.Pages.Page

open Feliz
open Feliz.Shadcn
open ElmishLand
open Examples.Shared
open Examples.Pages

type Model = unit

type Msg =
    | LayoutMsg of Layout.Msg

let init () =
    (),
    Command.none

let update (msg: Msg) (model: Model) =
    match msg with
    | LayoutMsg _ -> model, Command.none

let view (_model: Model) (_dispatch: Msg -> unit) =
    Html.div [
        Shadcn.accordion [
            prop.custom ("type", "single")
            prop.children [                
                accordion.item [
                    prop.value "item-1"
                    prop.children [                        
                        accordion.trigger "Is it accessible?"
                        accordion.content "Yes. It adheres to the WAI-ARIA design pattern."
                    ]
                ]
                accordion.item [
                    prop.value "item-2"
                    prop.children [                        
                        accordion.trigger "Is it styled?"
                        accordion.content "Yes. It comes with default styles that matches the other components&apos; aesthetic.."
                    ]
                ]
            ]
        ]
    ]

let page (_shared: SharedModel) (_route: HomeRoute) =
    Page.from init update view () LayoutMsg
