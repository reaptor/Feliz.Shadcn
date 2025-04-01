module Docs.Pages.Components.Badge

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Badge () =
    UI.PreviewAndCode(
        nameof Badge,
        Shadcn.badge [ prop.text "Badge" ],
        """Shadcn.badge [
    prop.text "Badge"
]
"""
    )
