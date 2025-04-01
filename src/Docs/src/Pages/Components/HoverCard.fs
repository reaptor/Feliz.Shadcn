module Docs.Pages.Components.HoverCard

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec HoverCard () =
    UI.PreviewAndCode(
        nameof HoverCard,
        Shadcn.hoverCard [
            Shadcn.hoverCardTrigger [
                hoverCardTrigger.asChild
                prop.children [
                    Shadcn.button [
                        button.variant.link
                        prop.text "@nextjs"
                    ]
                ]
            ]
            Shadcn.hoverCardContent [
                prop.className "w-80"
                prop.children [
                    Html.div [
                        prop.className "flex justify-between space-x-4"
                        prop.children [
                            Shadcn.avatar [
                                Shadcn.avatarImage [
                                    prop.src "https://github.com/vercel.png"
                                ]
                                Shadcn.avatarFallback "VC"
                            ]
                            Html.div [
                                prop.className "space-y-1"
                                prop.children [
                                    Html.h4 [
                                        prop.className "text-sm font-semibold"
                                        prop.text "@nextjs"
                                    ]
                                    Html.p [
                                        prop.className "text-sm"
                                        prop.text "The React Framework – created and maintained by @vercel."
                                    ]
                                    Html.div [
                                        prop.className "flex items-center pt-2"
                                        prop.children [
                                            Lucide.Calendar [
                                                svg.className "mr-2 h-4 w-4 opacity-70"
                                            ]
                                            Html.span [
                                                prop.className "text-xs text-muted-foreground"
                                                prop.text "Joined December 2021"
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
        """Shadcn.hoverCard [
    Shadcn.hoverCardTrigger [
        hoverCardTrigger.asChild
        prop.children [
            Shadcn.button [
                button.variant.link
                prop.text "@nextjs"
            ]
        ]
    ]
    Shadcn.hoverCardContent [
        prop.className "w-80"
        prop.children [
            Html.div [
                prop.className "flex justify-between space-x-4"
                prop.children [
                    Shadcn.avatar [
                        Shadcn.avatarImage [
                            prop.src "https://github.com/vercel.png"
                        ]
                        Shadcn.avatarFallback "VC"
                    ]
                    Html.div [
                        prop.className "space-y-1"
                        prop.children [
                            Html.h4 [
                                prop.className "text-sm font-semibold"
                                prop.text "@nextjs"
                            ]
                            Html.p [
                                prop.className "text-sm"
                                prop.text "The React Framework – created and maintained by @vercel."
                            ]
                            Html.div [
                                prop.className "flex items-center pt-2"
                                prop.children [
                                    Lucide.Calendar [
                                        svg.className "mr-2 h-4 w-4 opacity-70"
                                    ]
                                    Html.span [
                                        prop.className "text-xs text-muted-foreground"
                                        prop.text "Joined December 2021"
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
