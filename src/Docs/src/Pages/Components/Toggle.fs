module Docs.Pages.Components.Toggle

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Toggle () =
    UI.PreviewAndCode(
        nameof Toggle,
        Shadcn.toggle [
            prop.ariaLabel "Toggle italic"
            prop.children [ Lucide.Bold [ svg.className "h-4 w-4" ] ]
        ],
        """Shadcn.toggle [
    prop.ariaLabel "Toggle italic"
    prop.children [
        Lucide.Bold [
            svg.className "h-4 w-4"
        ]
    ]
]"""
    )
