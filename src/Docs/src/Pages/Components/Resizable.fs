module Docs.Pages.Components.Resizable

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Resizable () =
    UI.PreviewAndCode(
        nameof Resizable,
        Shadcn.resizablePanelGroup [
            resizablePanelGroup.direction.horizontal
            prop.className "max-w-md rounded-lg border md:min-w-[450px]"
            prop.children [
                Shadcn.resizablePanel [
                    resizablePanel.defaultSize 50
                    prop.children [
                        Html.div [
                            prop.className "flex h-[200px] items-center justify-center p-6"
                            prop.children [ Html.span [ prop.className "font-semibold"; prop.text "One" ] ]
                        ]
                    ]
                ]
                Shadcn.resizableHandle []
                Shadcn.resizablePanel [
                    resizablePanel.defaultSize 50
                    prop.children [
                        Shadcn.resizablePanelGroup [
                            resizablePanelGroup.direction.vertical
                            prop.children [
                                Shadcn.resizablePanel [
                                    resizablePanel.defaultSize 25
                                    prop.children [
                                        Html.div [
                                            prop.className "flex h-full items-center justify-center p-6"
                                            prop.children [
                                                Html.span [ prop.className "font-semibold"; prop.text "Two" ]
                                            ]
                                        ]
                                    ]
                                ]
                                Shadcn.resizableHandle []
                                Shadcn.resizablePanel [
                                    resizablePanel.defaultSize 75
                                    prop.children [
                                        Html.div [
                                            prop.className "flex h-full items-center justify-center p-6"
                                            prop.children [
                                                Html.span [ prop.className "font-semibold"; prop.text "Three" ]
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
        """Shadcn.resizablePanelGroup [
    resizablePanelGroup.direction.horizontal
    prop.className "max-w-md rounded-lg border md:min-w-[450px]"
    prop.children [
        Shadcn.resizablePanel [
            resizablePanel.defaultSize 50
            prop.children [
                Html.div [
                    prop.className "flex h-[200px] items-center justify-center p-6"
                    prop.children [
                        Html.span [
                            prop.className "font-semibold"
                            prop.text "One"
                        ]
                    ]
                ]
            ]
        ]
        Shadcn.resizableHandle []
        Shadcn.resizablePanel [
            resizablePanel.defaultSize 50
            prop.children [
                Shadcn.resizablePanelGroup [
                    resizablePanelGroup.direction.vertical
                    prop.children [
                        Shadcn.resizablePanel [
                            resizablePanel.defaultSize 25
                            prop.children [
                                Html.div [
                                    prop.className "flex h-full items-center justify-center p-6"
                                    prop.children [
                                        Html.span [
                                            prop.className "font-semibold"
                                            prop.text "Two"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Shadcn.resizableHandle []
                        Shadcn.resizablePanel [
                            resizablePanel.defaultSize 75
                            prop.children [
                                Html.div [
                                    prop.className "flex h-full items-center justify-center p-6"
                                    prop.children [
                                        Html.span [
                                            prop.className "font-semibold"
                                            prop.text "Three"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]
]"""
    )
