module Docs.Pages.Components.Dialog

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Dialog () =
    UI.PreviewAndCode(
        nameof Dialog,
        Shadcn.dialog [
            Shadcn.dialogTrigger [
                dialogTrigger.asChild
                prop.children [ Shadcn.button [ button.variant.outline; prop.text "Edit Profile" ] ]
            ]
            Shadcn.dialogContent [
                prop.className "sm:max-w-[425px]"
                prop.children [
                    Shadcn.dialogHeader [
                        Shadcn.dialogTitle "Edit profile"
                        Shadcn.dialogDescription "Make changes to your profile here. Click save when you're done."
                    ]
                    Html.div [
                        prop.className "grid gap-4 py-4"
                        prop.children [
                            Html.div [
                                prop.className "grid grid-cols-4 items-center gap-4"
                                prop.children [
                                    Shadcn.label [ prop.htmlFor "name"; prop.className "text-right"; prop.text "Name" ]
                                    Shadcn.input [
                                        prop.id "name"
                                        prop.value "Pedro Duarte"
                                        prop.className "col-span-3"
                                    ]
                                ]
                            ]
                            Html.div [
                                prop.className "grid grid-cols-4 items-center gap-4"
                                prop.children [
                                    Shadcn.label [
                                        prop.htmlFor "username"
                                        prop.className "text-right"
                                        prop.text "Username"
                                    ]
                                    Shadcn.input [
                                        prop.id "username"
                                        prop.value "@peduarte"
                                        prop.className "col-span-3"
                                    ]
                                ]
                            ]
                        ]
                    ]
                    Shadcn.dialogFooter [ Shadcn.button [ prop.type' "submit"; prop.text "Save changes" ] ]
                ]
            ]
        ],
        """Shadcn.dialog [
    Shadcn.dialogTrigger [
        dialogTrigger.asChild
        prop.children [
            Shadcn.button [
                button.variant.outline
                prop.text "Edit Profile"
            ]
        ]
    ]
    Shadcn.dialogContent [
        prop.className "sm:max-w-[425px]"
        prop.children [
            Shadcn.dialogHeader [
                Shadcn.dialogTitle "Edit profile"
                Shadcn.dialogDescription "Make changes to your profile here. Click save when you're done."
            ]
            Html.div [
                prop.className "grid gap-4 py-4"
                prop.children [
                    Html.div [
                        prop.className "grid grid-cols-4 items-center gap-4"
                        prop.children [
                            Shadcn.label [
                                prop.htmlFor "name"
                                prop.className "text-right"
                                prop.text "Name"
                            ]
                            Shadcn.input [
                                prop.id "name"
                                prop.value "Pedro Duarte"
                                prop.className "col-span-3"
                            ]
                        ]
                    ]
                    Html.div [
                        prop.className "grid grid-cols-4 items-center gap-4"
                        prop.children [
                            Shadcn.label [
                                prop.htmlFor "username"
                                prop.className "text-right"
                                prop.text "Username"
                            ]
                            Shadcn.input [
                                prop.id "username"
                                prop.value "@peduarte"
                                prop.className "col-span-3"
                            ]
                        ]
                    ]
                ]
            ]
            Shadcn.dialogFooter [
                Shadcn.button [
                    prop.type' "submit"
                    prop.text "Save changes"
                ]
            ]
        ]
    ]
]"""
    )
