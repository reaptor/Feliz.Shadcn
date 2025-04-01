module Docs.Pages.Components.AlertDialog

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec AlertDialog () =
    UI.PreviewAndCode(
        nameof AlertDialog,
        Shadcn.alertDialog [
            Shadcn.alertDialogTrigger [
                alertDialogTrigger.asChild
                prop.children [ Shadcn.button [ button.variant.outline; prop.text "Show Dialog" ] ]
            ]
            Shadcn.alertDialogContent [
                Shadcn.alertDialogHeader [
                    Shadcn.alertDialogTitle "Are you absolutely sure?"
                    Shadcn.alertDialogDescription
                        "This action cannot be undone. This will permanently delete your account and remove your data from our servers."
                ]
                Shadcn.alertDialogFooter [ Shadcn.alertDialogCancel "Cancel"; Shadcn.alertDialogAction "Continue" ]
            ]
        ],
        """Shadcn.alertDialog [
    Shadcn.alertDialogTrigger [
        alertDialogTrigger.asChild
        prop.children [
            Shadcn.button [
                button.variant.outline
                prop.text "Show Dialog"
            ]
        ]
    ]
    Shadcn.alertDialogContent [
        Shadcn.alertDialogHeader [
            Shadcn.alertDialogTitle "Are you absolutely sure?"
            Shadcn.alertDialogDescription
                "This action cannot be undone. This will permanently delete your account and remove your data from our servers."
        ]
        Shadcn.alertDialogFooter [
            Shadcn.alertDialogCancel "Cancel"
            Shadcn.alertDialogAction "Continue"
        ]
    ]
]"""
    )
