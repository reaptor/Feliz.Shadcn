module Docs.Pages.Components.Sheet

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Sheet () =
    UI.PreviewAndCode(
        nameof Sheet,
        Shadcn.sheet [
            Shadcn.sheetTrigger [
                sheetTrigger.asChild
                prop.children [ Shadcn.button [ button.variant.outline; prop.text "Open" ] ]
            ]
            Shadcn.sheetContent [
                Shadcn.sheetHeader [
                    Shadcn.sheetTitle "Edit profile"
                    Shadcn.sheetDescription "Make changes to your profile here. Click save when you're done."
                ]
                Html.div [
                    prop.className "grid gap-4 p-4"
                    prop.children [
                        Html.div [
                            prop.className "grid grid-cols-4 items-center gap-4"
                            prop.children [
                                Shadcn.label [ prop.htmlFor "name"; prop.className "text-right"; prop.text "Name" ]
                                Shadcn.input [ prop.id "name"; prop.value "Pedro Duarte"; prop.className "col-span-3" ]
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
                                Shadcn.input [ prop.id "username"; prop.value "@peduarte"; prop.className "col-span-3" ]
                            ]
                        ]
                    ]
                ]
                Shadcn.sheetFooter [
                    Shadcn.sheetClose [
                        sheetClose.asChild
                        prop.children [ Shadcn.button [ prop.type' "submit"; prop.text "Save changes" ] ]
                    ]
                ]
            ]
        ],
        """Shadcn.sheet [
    Shadcn.sheetTrigger [
        sheetTrigger.asChild
        prop.children [
            Shadcn.button [
                button.variant.outline
                prop.text "Open"
            ]
        ]
    ]
    Shadcn.sheetContent [
        Shadcn.sheetHeader [
            Shadcn.sheetTitle "Edit profile"
            Shadcn.sheetDescription "Make changes to your profile here. Click save when you're done."
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
        Shadcn.sheetFooter [
            Shadcn.sheetClose [
                sheetClose.asChild
                prop.children [
                    Shadcn.button [
                        prop.type' "submit"
                        prop.text "Save changes"
                    ]
                ]
            ]
        ]
    ]
]"""
    )
