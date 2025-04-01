module Docs.Pages.Components.Accordion

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Accordion () =
    UI.PreviewAndCode(
        nameof Accordion,
        Shadcn.accordion [
            accordion.type'.single
            prop.className "w-full"
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
        ],
        """Shadcn.accordion [
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
"""
    )
