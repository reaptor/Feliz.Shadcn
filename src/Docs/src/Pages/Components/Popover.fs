module Docs.Pages.Components.Popover

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Popover () =
    UI.PreviewAndCode(
        nameof Popover,
        Shadcn.popover [
            Shadcn.popoverTrigger [
                popoverTrigger.asChild
                prop.children [ Shadcn.button [ button.variant.outline; prop.text "Open popover" ] ]
            ]
            Shadcn.popoverContent [
                prop.className "w-80"
                prop.children [
                    Html.div [
                        prop.className "grid gap-4"
                        prop.children [
                            Html.div [
                                prop.className "space-y-2"
                                prop.children [
                                    Html.h4 [ prop.className "font-medium leading-none"; prop.text "Dimensions" ]
                                    Html.p [
                                        prop.className "text-sm text-muted-foreground"
                                        prop.text "Set the dimensions for the layer."
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.className "grid gap-2"
                                prop.children [
                                    Html.div [
                                        prop.className "grid grid-cols-3 items-center gap-4"
                                        prop.children [
                                            Shadcn.label [ prop.htmlFor "width"; prop.text "Width" ]
                                            Shadcn.input [
                                                prop.id "width"
                                                prop.defaultValue "100%"
                                                prop.className "col-span-2 h-8"
                                            ]
                                        ]
                                    ]
                                    Html.div [
                                        prop.className "grid grid-cols-3 items-center gap-4"
                                        prop.children [
                                            Shadcn.label [ prop.htmlFor "maxWidth"; prop.text "Max. width" ]
                                            Shadcn.input [
                                                prop.id "maxWidth"
                                                prop.defaultValue "300px"
                                                prop.className "col-span-2 h-8"
                                            ]
                                        ]
                                    ]
                                    Html.div [
                                        prop.className "grid grid-cols-3 items-center gap-4"
                                        prop.children [
                                            Shadcn.label [ prop.htmlFor "height"; prop.text "Height" ]
                                            Shadcn.input [
                                                prop.id "height"
                                                prop.defaultValue "25px"
                                                prop.className "col-span-2 h-8"
                                            ]
                                        ]
                                    ]
                                    Html.div [
                                        prop.className "grid grid-cols-3 items-center gap-4"
                                        prop.children [
                                            Shadcn.label [ prop.htmlFor "maxHeight"; prop.text "Max. height" ]
                                            Shadcn.input [
                                                prop.id "maxHeight"
                                                prop.defaultValue "none"
                                                prop.className "col-span-2 h-8"
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ],
        """Shadcn.popover [
    Shadcn.popoverTrigger [
        mkProperty ("asChild", true)
        prop.children [
            Shadcn.button [
                button.variant.outline
                prop.text "Open popover"
            ]
        ]
    ]
    Shadcn.popoverContent [
        prop.className "w-80"
        prop.children [
            Html.div [
                prop.className "grid gap-4"
                prop.children [
                    Html.div [
                        prop.className "space-y-2"
                        prop.children [
                            Html.h4 [
                                prop.className "font-medium leading-none"
                                prop.text "Dimensions"
                            ]
                            Html.p [
                                prop.className "text-sm text-muted-foreground"
                                prop.text "Set the dimensions for the layer."
                            ]
                        ]
                    ]
                    Html.div [
                        prop.className "grid gap-2"
                        prop.children [
                            // Form fields for width, max width, height, and max height
                        ]
                    ]
                ]
            ]
        ]
    ]
]"""
    )
