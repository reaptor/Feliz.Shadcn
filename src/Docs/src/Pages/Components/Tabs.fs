module Docs.Pages.Components.Tabs

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Tabs () =
    UI.PreviewAndCode(
        nameof Tabs,
        Shadcn.tabs [
            prop.defaultValue "account"
            prop.className "w-[400px]"
            prop.children [
                Shadcn.tabsList [
                    prop.className "grid w-full grid-cols-2"
                    prop.children [
                        Shadcn.tabsTrigger [ prop.value "account"; prop.text "Account" ]
                        Shadcn.tabsTrigger [ prop.value "password"; prop.text "Password" ]
                    ]
                ]
                Shadcn.tabsContent [
                    prop.value "account"
                    prop.children [
                        Shadcn.card [
                            Shadcn.cardHeader [
                                Shadcn.cardTitle "Account"
                                Shadcn.cardDescription "Make changes to your account here. Click save when you're done."
                            ]
                            Shadcn.cardContent [
                                prop.className "space-y-2"
                                prop.children [
                                    Html.div [
                                        prop.className "space-y-1"
                                        prop.children [
                                            Shadcn.label [ prop.htmlFor "name"; prop.text "Name" ]
                                            Shadcn.input [ prop.id "name"; prop.defaultValue "Pedro Duarte" ]
                                        ]
                                    ]
                                    Html.div [
                                        prop.className "space-y-1"
                                        prop.children [
                                            Shadcn.label [ prop.htmlFor "username"; prop.text "Username" ]
                                            Shadcn.input [ prop.id "username"; prop.defaultValue "@peduarte" ]
                                        ]
                                    ]
                                ]
                            ]
                            Shadcn.cardFooter [ Shadcn.button "Save changes" ]
                        ]
                    ]
                ]
                Shadcn.tabsContent [
                    prop.value "password"
                    prop.children [
                        Shadcn.card [
                            Shadcn.cardHeader [
                                Shadcn.cardTitle "Password"
                                Shadcn.cardDescription "Change your password here. After saving, you'll be logged out."
                            ]
                            Shadcn.cardContent [
                                prop.className "space-y-2"
                                prop.children [
                                    Html.div [
                                        prop.className "space-y-1"
                                        prop.children [
                                            Shadcn.label [ prop.htmlFor "current"; prop.text "Current password" ]
                                            Shadcn.input [ prop.id "current"; prop.type' "password" ]
                                        ]
                                    ]
                                    Html.div [
                                        prop.className "space-y-1"
                                        prop.children [
                                            Shadcn.label [ prop.htmlFor "new"; prop.text "New password" ]
                                            Shadcn.input [ prop.id "new"; prop.type' "password" ]
                                        ]
                                    ]
                                ]
                            ]
                            Shadcn.cardFooter [ Shadcn.button "Save password" ]
                        ]
                    ]
                ]
            ]
        ],
        """Shadcn.tabs [
    prop.defaultValue "account"
    prop.className "w-[400px]"
    prop.children [
        Shadcn.tabsList [
            prop.className "grid w-full grid-cols-2"
            prop.children [
                Shadcn.tabsTrigger [
                    prop.value "account"
                    prop.text "Account"
                ]
                Shadcn.tabsTrigger [
                    prop.value "password"
                    prop.text "Password"
                ]
            ]
        ]
        Shadcn.tabsContent [
            prop.value "account"
            prop.children [
                Shadcn.card [
                    Shadcn.cardHeader [
                        Shadcn.cardTitle "Account"
                        Shadcn.cardDescription "Make changes to your account here. Click save when you're done."
                    ]
                    // Card content with name/username fields
                    Shadcn.cardFooter [
                        Shadcn.button "Save changes"
                    ]
                ]
            ]
        ]
        Shadcn.tabsContent [
            prop.value "password"
            prop.children [
                Shadcn.card [
                    Shadcn.cardHeader [
                        Shadcn.cardTitle "Password"
                        Shadcn.cardDescription "Change your password here. After saving, you'll be logged out."
                    ]
                    // Card content with password fields
                    Shadcn.cardFooter [
                        Shadcn.button "Save password"
                    ]
                ]
            ]
        ]
    ]
]"""
    )
