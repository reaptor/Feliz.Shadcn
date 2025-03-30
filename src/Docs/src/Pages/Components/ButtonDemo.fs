module Docs.Pages.Components.Button

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Button () =
    UI.PreviewAndCode (
        nameof Button,
        Shadcn.button [ prop.text "Button" ],
            """Shadcn.button [
    prop.text "Button" ]
""")
