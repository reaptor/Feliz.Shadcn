module Docs.Pages.Components.Card

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Card () =
    UI.PreviewAndCode(
        nameof Card,
        Shadcn.card [
            prop.className "w-[350px]"
            prop.children [
                Shadcn.cardHeader [
                    Shadcn.cardTitle "Create project"
                    Shadcn.cardDescription "Deploy your new project in one-click."
                ]

                Shadcn.cardContent [
                    Html.form [
                        prop.children [
                            Html.div [
                                prop.className "grid w-full items-center gap-4"
                                prop.children [
                                    Html.div [
                                        prop.className "flex flex-col space-y-1.5"
                                        prop.children [
                                            Shadcn.label [ prop.htmlFor "name"; prop.text "Name" ]
                                            Shadcn.input [ prop.id "name"; prop.placeholder "Name of your project" ]
                                        ]
                                    ]

                                    Html.div [
                                        prop.className "flex flex-col space-y-1.5"
                                        prop.children [
                                            Shadcn.label [ prop.htmlFor "framework"; prop.text "Framework" ]
                                            Shadcn.select [
                                                Shadcn.selectTrigger [
                                                    prop.id "framework"
                                                    prop.children [
                                                        Shadcn.selectValue [
                                                            selectValue.placeholder (Html.span "Select")
                                                        ]
                                                    ]
                                                ]
                                                Shadcn.selectContent [
                                                    selectContent.position.popper
                                                    prop.children [
                                                        Shadcn.selectItem [
                                                            prop.value "elmish-land"
                                                            prop.text "Elmish Land"
                                                        ]
                                                        Shadcn.selectItem [ prop.value "next"; prop.text "Next.js" ]
                                                        Shadcn.selectItem [
                                                            prop.value "sveltekit"
                                                            prop.text "SvelteKit"
                                                        ]
                                                        Shadcn.selectItem [ prop.value "astro"; prop.text "Astro" ]
                                                        Shadcn.selectItem [ prop.value "nuxt"; prop.text "Nuxt.js" ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]

                Shadcn.cardFooter [
                    prop.className "flex justify-between"
                    prop.children [
                        Shadcn.button [ button.variant.outline; prop.text "Cancel" ]
                        Shadcn.button [ prop.text "Deploy" ]
                    ]
                ]
            ]
        ],
        """Shadcn.card [
    prop.className "w-[350px]"
    prop.children [
        Shadcn.cardHeader [
            Shadcn.cardTitle "Create project"
            Shadcn.cardDescription "Deploy your new project in one-click."
        ]

        Shadcn.cardContent [
            Html.form [
                prop.children [
                    Html.div [
                        prop.className "grid w-full items-center gap-4"
                        prop.children [
                            Html.div [
                                prop.className "flex flex-col space-y-1.5"
                                prop.children [
                                    Shadcn.label [ prop.htmlFor "name"; prop.text "Name" ]
                                    Shadcn.input [ prop.id "name"; prop.placeholder "Name of your project" ]
                                ]
                            ]

                            Html.div [
                                prop.className "flex flex-col space-y-1.5"
                                prop.children [
                                    Shadcn.label [ prop.htmlFor "framework"; prop.text "Framework" ]
                                    Shadcn.select [
                                        Shadcn.selectTrigger [
                                            prop.id "framework"
                                            prop.children [
                                                Shadcn.selectValue [
                                                    selectValue.placeholder (Html.span "Select")
                                                ]
                                            ]
                                        ]
                                        Shadcn.selectContent [
                                            selectContent.position.popper
                                            prop.children [
                                                Shadcn.selectItem [
                                                    prop.value "elmish-land"
                                                    prop.text "Elmish Land"
                                                ]
                                                Shadcn.selectItem [ prop.value "next"; prop.text "Next.js" ]
                                                Shadcn.selectItem [
                                                    prop.value "sveltekit"
                                                    prop.text "SvelteKit"
                                                ]
                                                Shadcn.selectItem [ prop.value "astro"; prop.text "Astro" ]
                                                Shadcn.selectItem [ prop.value "nuxt"; prop.text "Nuxt.js" ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

        Shadcn.cardFooter [
            prop.className "flex justify-between"
            prop.children [
                Shadcn.button [ button.variant.outline; prop.text "Cancel" ]
                Shadcn.button [ prop.text "Deploy" ]
            ]
        ]
    ]
]"""
    )
