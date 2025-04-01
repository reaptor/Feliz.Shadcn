module Docs.Pages.Components.Alert

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Alert () =
    UI.PreviewAndCode(
        nameof Alert,
        Shadcn.alert [
            prop.className "flex flex-col"
            prop.children [
                Shadcn.alertTitle "Heads up!"
                Shadcn.alertDescription "You can add components to your app using the cli."
            ]
        ],
        """Shadcn.alert [
    prop.className "flex flex-col"
    prop.children [
        Shadcn.alertTitle "Heads up!"
        Shadcn.alertDescription "You can add components to your app using the cli."
    ]
]
"""
    )
