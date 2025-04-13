module Docs.Pages.Components.AspectRatio

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec AspectRatio () =
    UI.PreviewAndCode(
        nameof AspectRatio,
        Shadcn.aspectRatio [
            aspectRatio.ratio (16.0 / 9.0)
            prop.children [
                Html.img [
                    prop.src "https://images.unsplash.com/photo-1588345921523-c2dcdb7f1dcd?w=800&dpr=2&q=80"
                    prop.alt "Photo by Drew Beamer"
                    prop.className "absolute h-full w-full rounded-md object-cover"
                ]
            ]
        ],
        """Shadcn.aspectRatio [
    aspectRatio.ratio (16.0 / 9.0)
    prop.children [
        Html.img [
            prop.src "https://images.unsplash.com/photo-1588345921523-c2dcdb7f1dcd?w=800&dpr=2&q=80"
            prop.alt "Photo by Drew Beamer"
            prop.style [
                style.position.absolute
                style.height (length.percent 100)
                style.width (length.percent 100)
            ]
            prop.className "h-full w-full rounded-md object-cover"
        ]
    ]
]"""
    )
