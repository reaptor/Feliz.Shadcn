module Docs.Pages.Components.Checkbox

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Checkbox () =
    UI.PreviewAndCode(
        nameof Checkbox,
        Html.div [
            prop.className "flex items-center space-x-2"
            prop.children [
                Shadcn.checkbox [ prop.id "terms" ]
                Html.label [
                    prop.htmlFor "terms"
                    prop.className
                        "text-sm font-medium leading-none peer-disabled:cursor-not-allowed peer-disabled:opacity-70"
                    prop.text "Accept terms and conditions"
                ]
            ]
        ],
        """Html.div [
    prop.className "flex items-center space-x-2"
    prop.children [
        Shadcn.checkbox [
            prop.id "terms"
        ]
        Html.label [
            prop.htmlFor "terms"
            prop.className "text-sm font-medium leading-none peer-disabled:cursor-not-allowed peer-disabled:opacity-70"
            prop.text "Accept terms and conditions"
        ]
    ]
]"""
    )
