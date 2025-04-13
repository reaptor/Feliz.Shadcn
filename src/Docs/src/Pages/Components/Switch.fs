module Docs.Pages.Components.Switch

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Switch () =
    UI.PreviewAndCode(
        nameof Switch,
        Html.div [
            prop.className "flex items-center space-x-2"
            prop.children [
                Shadcn.switch [ prop.id "airplane-mode" ]
                Shadcn.label [ prop.htmlFor "airplane-mode"; prop.text "Airplane Mode" ]
            ]
        ],
        """Html.div [
    prop.className "flex items-center space-x-2"
    prop.children [
        Shadcn.switch [
            prop.id "airplane-mode"
        ]
        Shadcn.label [
            prop.htmlFor "airplane-mode"
            prop.text "Airplane Mode"
        ]
    ]
]"""
    )
