module Docs.Pages.Components.Slider

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Slider () =
    UI.PreviewAndCode(
        nameof Slider,
        Shadcn.slider [
            prop.defaultValue [| 50 |]
            prop.max 100
            prop.step 1
            prop.className "w-[60%]"
        ],
        """Shadcn.slider [
    prop.defaultValue [| 50 |]
    prop.max 100
    prop.step 1
    prop.className "w-[60%]"
]"""
    )
