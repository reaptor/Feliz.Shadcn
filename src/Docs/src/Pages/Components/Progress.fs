module Docs.Pages.Components.Progress

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Progress () =
    UI.PreviewAndCode(
        nameof Progress,
        Shadcn.progress [ prop.className "w-[60%]"; prop.value 60 ],
        """Shadcn.progress [
            prop.className "w-[60%]"
            prop.value 60
        ]"""
    )
