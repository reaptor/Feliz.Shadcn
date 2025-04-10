module Docs.Pages.Components.Sonner

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common


let rec Sonner' () =
    UI.PreviewAndCode(
        nameof Sonner,
        Html.div [
            prop.className "flex flex-col gap-4"
            prop.children [
                Shadcn.button [
                    button.variant.outline
                    prop.onClick (fun _ -> Sonner.toastSuccess "This is a success toast")
                    prop.text "Show Success Toast"
                ]
                Shadcn.button [
                    button.variant.outline
                    prop.onClick (fun _ -> Sonner.toastError "This is an error toast")
                    prop.text "Show Error Toast"
                ]
                Shadcn.button [
                    button.variant.outline
                    prop.onClick (fun _ ->
                        Sonner.toast (
                            "This is an action toast",
                            ToastOptions(
                                action =
                                    ToastAction.Object(
                                        {|
                                            label = "Action"
                                            onClick = fun () -> Browser.Dom.console.log "Action"
                                        |}
                                    )
                            )
                        ))
                    prop.text "Show Action Toast"
                ]
                Shadcn.button [
                    button.variant.outline
                    prop.onClick (fun _ ->
                        Sonner.toast (
                            "My cancel toast",
                            ToastOptions(
                                action =
                                    ToastAction.Object(
                                        {|
                                            label = "Cancel"
                                            onClick = fun () -> Browser.Dom.console.log "Cancel"
                                        |}
                                    )
                            )
                        ))
                    prop.text "Show Cancel Toast"
                ]
                Shadcn.button [
                    button.variant.outline
                    prop.onClick (fun _ -> Sonner.toastLoading "Loading…")
                    prop.text "Show Loading Toast"
                ]
                Shadcn.button [
                    button.variant.outline
                    prop.onClick (fun _ -> Sonner.toastCustom (Html.text "Custom toast"))
                    prop.text "Show Custom Toast"
                ]
                Shadcn.toaster []
            ]
        ],
        """Html.div [
    prop.className "flex flex-col gap-4"
    prop.children [
        Shadcn.button [
            button.variant.outline
            prop.onClick (fun _ -> Sonner.toastSuccess "This is a success toast")
            prop.text "Show Success Toast"
        ]
        Shadcn.button [
            button.variant.outline
            prop.onClick (fun _ -> Sonner.toastError "This is an error toast")
            prop.text "Show Error Toast"
        ]
        Shadcn.button [
            button.variant.outline
            prop.onClick (fun _ ->
                Sonner.toast (
                    "This is an action toast",
                    ToastOptions(
                        action =
                            ToastAction.Object(
                                {|
                                    label = "Action"
                                    onClick = fun () -> Browser.Dom.console.log "Action"
                                |}
                            )
                    )
                ))
            prop.text "Show Action Toast"
        ]
        Shadcn.button [
            button.variant.outline
            prop.onClick (fun _ ->
                Sonner.toast (
                    "My cancel toast",
                    ToastOptions(
                        action =
                            ToastAction.Object(
                                {|
                                    label = "Cancel"
                                    onClick = fun () -> Browser.Dom.console.log "Cancel"
                                |}
                            )
                    )
                ))
            prop.text "Show Cancel Toast"
        ]
        Shadcn.button [
            button.variant.outline
            prop.onClick (fun _ -> Sonner.toastLoading "Loading…")
            prop.text "Show Loading Toast"
        ]
        Shadcn.button [
            button.variant.outline
            prop.onClick (fun _ -> Sonner.toastCustom (Html.text "Custom toast"))
            prop.text "Show Custom Toast"
        ]
        Shadcn.toaster []
    ]
]"""
    )

let Sonner = Sonner'
