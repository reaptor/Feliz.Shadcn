module Docs.Pages.Components.Carousel

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Carousel () =
    UI.PreviewAndCode(
        nameof Carousel,
        Shadcn.carousel [
            prop.className "w-full max-w-xs"
            prop.children [
                Shadcn.carouselContent [
                    for i in 1..5 do
                        Shadcn.carouselItem [
                            prop.key (string i)
                            prop.children [
                                Html.div [
                                    prop.className "p-1"
                                    prop.children [
                                        Shadcn.card [
                                            Shadcn.cardContent [
                                                prop.className "flex aspect-square items-center justify-center p-6"
                                                prop.children [
                                                    Html.span [
                                                        prop.className "text-4xl font-semibold"
                                                        prop.text (string i)
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                ]

                Shadcn.carouselPrevious []
                Shadcn.carouselNext []
            ]
        ],
        """Shadcn.carousel [
    prop.className "w-full max-w-xs"
    prop.children [
        Shadcn.carouselContent [
            for i in 1..5 do
                Shadcn.carouselItem [
                    prop.key (string i)
                    prop.children [
                        Html.div [
                            prop.className "p-1"
                            prop.children [
                                Shadcn.card [
                                    Shadcn.cardContent [
                                        prop.className "flex aspect-square items-center justify-center p-6"
                                        prop.children [
                                            Html.span [
                                                prop.className "text-4xl font-semibold"
                                                prop.text (string i)
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
        ]

        Shadcn.carouselPrevious []
        Shadcn.carouselNext []
    ]
]"""
    )
