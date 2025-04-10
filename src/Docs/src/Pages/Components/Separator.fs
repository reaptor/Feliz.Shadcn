module Docs.Pages.Components.Separator

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Separator () =
    UI.PreviewAndCode(
        nameof Separator,
        Html.div [
            Html.div [
                prop.className "space-y-1"
                prop.children [
                    Html.h4 [
                        prop.className "text-sm font-medium leading-none"
                        prop.text "Radix Primitives"
                    ]
                    Html.p [
                        prop.className "text-sm text-muted-foreground"
                        prop.text "An open-source UI component library."
                    ]
                ]
            ]
            Shadcn.separator [ prop.className "my-4" ]
            Html.div [
                prop.className "flex h-5 items-center space-x-4 text-sm"
                prop.children [
                    Html.div [ prop.text "Blog" ]
                    Shadcn.separator [ separator.orientation.vertical ]
                    Html.div [ prop.text "Docs" ]
                    Shadcn.separator [ separator.orientation.vertical ]
                    Html.div [ prop.text "Source" ]
                ]
            ]
        ],
        """Html.div [
    Html.div [
        prop.className "space-y-1"
        prop.children [
            Html.h4 [
                prop.className "text-sm font-medium leading-none"
                prop.text "Radix Primitives"
            ]
            Html.p [
                prop.className "text-sm text-muted-foreground"
                prop.text "An open-source UI component library."
            ]
        ]
    ]
    Shadcn.separator [
        prop.className "my-4"
    ]
    Html.div [
        prop.className "flex h-5 items-center space-x-4 text-sm"
        prop.children [
            Html.div [
                prop.text "Blog"
            ]
            Shadcn.separator [
                separator.orientation.vertical
            ]
            Html.div [
                prop.text "Docs"
            ]
            Shadcn.separator [
                separator.orientation.vertical
            ]
            Html.div [
                prop.text "Source"
            ]
        ]
    ]
]"""
    )
