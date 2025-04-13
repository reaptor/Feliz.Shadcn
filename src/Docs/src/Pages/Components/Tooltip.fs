module Docs.Pages.Components.Tooltip

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Tooltip () =
    UI.PreviewAndCode(
        nameof Tooltip,
        Shadcn.tooltipProvider [
            Shadcn.tooltip [
                Shadcn.tooltipTrigger [
                    tooltipTrigger.asChild
                    prop.children [ Shadcn.button [ button.variant.outline; prop.text "Hover" ] ]
                ]
                Shadcn.tooltipContent [ Html.p "Add to library" ]
            ]
        ],
        """Shadcn.tooltipProvider [
    Shadcn.tooltip [
        Shadcn.tooltipTrigger [
            tooltipTrigger.asChild
            prop.children [
                Shadcn.button [
                    button.variant.outline
                    prop.text "Hover"
                ]
            ]
        ]
        Shadcn.tooltipContent [
            Html.p "Add to library"
        ]
    ]
]"""
    )
