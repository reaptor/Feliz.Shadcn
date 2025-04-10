module Docs.Pages.Components.Skeleton

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Skeleton () =
    UI.PreviewAndCode(
        nameof Skeleton,
        Html.div [
            prop.className "flex items-center space-x-4"
            prop.children [
                Shadcn.skeleton [ prop.className "h-12 w-12 rounded-full" ]
                Html.div [
                    prop.className "space-y-2"
                    prop.children [
                        Shadcn.skeleton [ prop.className "h-4 w-[250px]" ]
                        Shadcn.skeleton [ prop.className "h-4 w-[200px]" ]
                    ]
                ]
            ]
        ],
        """Html.div [
    prop.className "flex items-center space-x-4"
    prop.children [
        Shadcn.skeleton [
            prop.className "h-12 w-12 rounded-full"
        ]
        Html.div [
            prop.className "space-y-2"
            prop.children [
                Shadcn.skeleton [
                    prop.className "h-4 w-[250px]"
                ]
                Shadcn.skeleton [
                    prop.className "h-4 w-[200px]"
                ]
            ]
        ]
    ]
]"""
    )
