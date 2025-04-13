module Docs.Pages.Components.Collapsible

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

[<ReactComponent>]
let rec Collapsible () =
    let isOpen, setIsOpen = React.useState (false)

    UI.PreviewAndCode(
        nameof Collapsible,
        Shadcn.collapsible [
            collapsible.open' isOpen
            collapsible.onOpenChange setIsOpen
            prop.className "w-[350px] space-y-2"
            prop.children [
                Html.div [
                    prop.className "flex items-center justify-between space-x-4 px-4"
                    prop.children [
                        Html.h4 [
                            prop.className "text-sm font-semibold"
                            prop.text "@peduarte starred 3 repositories"
                        ]
                        Shadcn.collapsibleTrigger [
                            collapsibleTrigger.asChild
                            prop.children [
                                Shadcn.button [
                                    button.variant.ghost
                                    button.size.sm
                                    prop.children [
                                        Lucide.ChevronsUpDown []
                                        Html.span [ prop.className "sr-only"; prop.text "Toggle" ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Html.div [
                    prop.className "rounded-md border px-4 py-2 font-mono text-sm shadow-sm"
                    prop.text "@radix-ui/primitives"
                ]
                Shadcn.collapsibleContent [
                    prop.className "space-y-2"
                    prop.children [
                        Html.div [
                            prop.className "rounded-md border px-4 py-2 font-mono text-sm shadow-sm"
                            prop.text "@radix-ui/colors"
                        ]
                        Html.div [
                            prop.className "rounded-md border px-4 py-2 font-mono text-sm shadow-sm"
                            prop.text "@stitches/react"
                        ]
                    ]
                ]
            ]
        ],
        """let isOpen, setIsOpen = React.useState(false)

Shadcn.collapsible [
    collapsible.open' isOpen
    collapsible.onOpenChange setIsOpen
    prop.className "w-[350px] space-y-2"
    prop.children [
        Html.div [
            prop.className "flex items-center justify-between space-x-4 px-4"
            prop.children [
                Html.h4 [
                    prop.className "text-sm font-semibold"
                    prop.text "@peduarte starred 3 repositories"
                ]
                Shadcn.collapsibleTrigger [
                    collapsibleTrigger.asChild
                    prop.children [
                        Shadcn.button [
                            button.variant.ghost
                            button.size.sm
                            prop.children [
                                // ChevronsUpDown icon
                                UI.ChevronsUpDownIcon()
                                Html.span [
                                    prop.className "sr-only"
                                    prop.text "Toggle"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
        Html.div [
            prop.className "rounded-md border px-4 py-2 font-mono text-sm shadow-sm"
            prop.text "@radix-ui/primitives"
        ]
        Shadcn.collapsibleContent [
            prop.className "space-y-2"
            prop.children [
                Html.div [
                    prop.className "rounded-md border px-4 py-2 font-mono text-sm shadow-sm"
                    prop.text "@radix-ui/colors"
                ]
                Html.div [
                    prop.className "rounded-md border px-4 py-2 font-mono text-sm shadow-sm"
                    prop.text "@stitches/react"
                ]
            ]
        ]
    ]
]"""
    )
