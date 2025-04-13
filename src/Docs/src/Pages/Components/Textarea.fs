module Docs.Pages.Components.Textarea

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Textarea () =
    UI.PreviewAndCode(
        nameof Textarea,
        Shadcn.textarea [ prop.placeholder "Type your message here." ],
        """Shadcn.textarea [
    prop.placeholder "Type your message here."
]"""
    )
