module Docs.Pages.Components.ToggleGroup

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec ToggleGroup () =
    UI.PreviewAndCode(
        nameof ToggleGroup,
        Shadcn.toggleGroup [
            toggleGroup.type'.multiple
            prop.children [
                Shadcn.toggleGroupItem [
                    prop.value "bold"
                    prop.ariaLabel "Toggle bold"
                    prop.children [ Lucide.Bold [ svg.className "h-4 w-4" ] ]
                ]
                Shadcn.toggleGroupItem [
                    prop.value "italic"
                    prop.ariaLabel "Toggle italic"
                    prop.children [ Lucide.Italic [ svg.className "h-4 w-4" ] ]
                ]
                Shadcn.toggleGroupItem [
                    prop.value "strikethrough"
                    prop.ariaLabel "Toggle strikethrough"
                    prop.children [ Lucide.Underline [ svg.className "h-4 w-4" ] ]
                ]
            ]
        ],
        """Shadcn.toggleGroup [
    toggleGroup.type'.multiple
    prop.children [
        Shadcn.toggleGroupItem [
            prop.value "bold"
            prop.ariaLabel "Toggle bold"
            prop.children [
                Lucide.Bold [
                    svg.className "h-4 w-4"
                ]
            ]
        ]
        Shadcn.toggleGroupItem [
            prop.value "italic"
            prop.ariaLabel "Toggle italic"
            prop.children [
                Lucide.Italic [
                    svg.className "h-4 w-4"
                ]
            ]
        ]
        Shadcn.toggleGroupItem [
            prop.value "strikethrough"
            prop.ariaLabel "Toggle strikethrough"
            prop.children [
                Lucide.Underline [
                    svg.className "h-4 w-4"
                ]
            ]
        ]
    ]
]"""
    )
