module Docs.Pages.Components.RadioGroup

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec RadioGroup () =
    UI.PreviewAndCode(
        nameof RadioGroup,
        Shadcn.radioGroup [
            prop.defaultValue "comfortable"
            prop.children [
                Html.div [
                    prop.className "flex items-center space-x-2"
                    prop.children [
                        Shadcn.radioGroupItem [ prop.value "default"; prop.id "r1" ]
                        Shadcn.label [ prop.htmlFor "r1"; prop.text "Default" ]
                    ]
                ]
                Html.div [
                    prop.className "flex items-center space-x-2"
                    prop.children [
                        Shadcn.radioGroupItem [ prop.value "comfortable"; prop.id "r2" ]
                        Shadcn.label [ prop.htmlFor "r2"; prop.text "Comfortable" ]
                    ]
                ]
                Html.div [
                    prop.className "flex items-center space-x-2"
                    prop.children [
                        Shadcn.radioGroupItem [ prop.value "compact"; prop.id "r3" ]
                        Shadcn.label [ prop.htmlFor "r3"; prop.text "Compact" ]
                    ]
                ]
            ]
        ],
        """Shadcn.radioGroup [
    prop.defaultValue "comfortable"
    prop.children [
        Html.div [
            prop.className "flex items-center space-x-2"
            prop.children [
                Shadcn.radioGroupItem [
                    prop.value "default"
                    prop.id "r1"
                ]
                Shadcn.label [
                    prop.htmlFor "r1"
                    prop.text "Default"
                ]
            ]
        ]
        Html.div [
            prop.className "flex items-center space-x-2"
            prop.children [
                Shadcn.radioGroupItem [
                    prop.value "comfortable"
                    prop.id "r2"
                ]
                Shadcn.label [
                    prop.htmlFor "r2"
                    prop.text "Comfortable"
                ]
            ]
        ]
        Html.div [
            prop.className "flex items-center space-x-2"
            prop.children [
                Shadcn.radioGroupItem [
                    prop.value "compact"
                    prop.id "r3"
                ]
                Shadcn.label [
                    prop.htmlFor "r3"
                    prop.text "Compact"
                ]
            ]
        ]
    ]
]"""
    )
