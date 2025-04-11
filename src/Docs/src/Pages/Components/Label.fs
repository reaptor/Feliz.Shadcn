module Docs.Pages.Components.Label

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Label () =
    UI.PreviewAndCode(
        nameof Label,
        Html.div [
            Html.div [
                prop.className "flex items-center space-x-2"
                prop.children [
                    Shadcn.checkbox [ prop.id "terms" ]
                    Shadcn.label [ prop.htmlFor "terms"; prop.text "Accept terms and conditions" ]
                ]
            ]
        ],
        """Html.div [
    Html.div [
        prop.className "flex items-center space-x-2"
        prop.children [
            Shadcn.checkbox [
                prop.id "terms"
            ]
            Shadcn.label [
                prop.htmlFor "terms"
                prop.text "Accept terms and conditions"
            ]
        ]
    ]
]"""
    )
