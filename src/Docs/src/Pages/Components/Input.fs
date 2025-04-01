module Docs.Pages.Components.Input

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Input () =
    UI.PreviewAndCode(
        nameof Input,
        Shadcn.input [
            prop.type' "email"
            prop.placeholder "Email"
        ],
        """Shadcn.input [
    prop.type' "email"
    prop.placeholder "Email"
]"""
    )
