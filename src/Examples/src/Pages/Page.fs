module Examples.Pages.Page

open Fable.Core.JsInterop
open Feliz
open Feliz.Shadcn
open ElmishLand
open Examples.Shared
open Examples.Pages

type Model = unit

type Msg = LayoutMsg of Layout.Msg

let init () = (), Command.none

let update (msg: Msg) (model: Model) =
    match msg with
    | LayoutMsg _ -> model, Command.none

let AccordionDemo () =
    Shadcn.accordion [
        accordion.type'.single
        prop.children [
            Shadcn.accordionItem [
                prop.value "item-1"
                prop.children [
                    Shadcn.accordionTrigger "Is it accessible?"
                    Shadcn.accordionContent "Yes. It adheres to the WAI-ARIA design pattern."
                ]
            ]
            Shadcn.accordionItem [
                prop.value "item-2"
                prop.children [
                    Shadcn.accordionTrigger "Is it styled?"
                    Shadcn.accordionContent
                        "Yes. It comes with default styles that matches the other components & aesthetic.."
                ]
            ]
        ]
    ]

let AlertDialogDemo () =
    Shadcn.alertDialog [
        Shadcn.alertDialogTrigger [
            alertDialogTrigger.asChild
            prop.children [ Shadcn.button [ button.variant.outline; prop.text "Show Dialog" ] ]
        ]
        Shadcn.alertDialogContent [
            Shadcn.alertDialogHeader [
                Shadcn.alertDialogTitle "Are you absolutely sure?"
                Shadcn.alertDialogDescription
                    "This action cannot be undone. This will permanently delete your account and remove your data from our servers."
            ]
            Shadcn.alertDialogFooter [ Shadcn.alertDialogCancel "Cancel"; Shadcn.alertDialogAction "Continue" ]
        ]
    ]

let button () =
    Html.div [
        Html.h2 "Button"
        Html.div [ prop.children [ Shadcn.button [ prop.text "Button" ] ] ]
    ]

let view (_model: Model) (_dispatch: Msg -> unit) =
    Html.div [ AccordionDemo(); AlertDialogDemo(); button () ]

let page (_shared: SharedModel) (_route: HomeRoute) = Page.from init update view () LayoutMsg
