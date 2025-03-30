module Docs.Pages.Components.Breadcrumb

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Breadcrumb () =
    UI.PreviewAndCode (
        nameof Breadcrumb,
        Shadcn.breadcrumb [
            Shadcn.breadcrumbList [
                Shadcn.breadcrumbItem [ Shadcn.breadcrumbLink [ prop.text "Home" ] ]

                Shadcn.breadcrumbSeparator []

                Shadcn.breadcrumbItem [
                    Shadcn.dropdownMenu [
                        Shadcn.dropdownMenuTrigger [
                            prop.className "flex items-center gap-1"
                            prop.children [
                                Shadcn.breadcrumbEllipsis [ prop.className "h-4 w-4" ]
                                Html.span [ prop.className "sr-only"; prop.text "Toggle menu" ]
                            ]
                        ]
                        Shadcn.dropdownMenuContent [
                            prop.custom ("align", "start")
                            prop.children [
                                Shadcn.dropdownMenuItem [ prop.text "Documentation" ]
                                Shadcn.dropdownMenuItem [ prop.text "Themes" ]
                                Shadcn.dropdownMenuItem [ prop.text "GitHub" ]
                            ]
                        ]
                    ]
                ]

                Shadcn.breadcrumbSeparator []

                Shadcn.breadcrumbItem [
                    Shadcn.breadcrumbLink [ prop.text "Components" ]
                ]

                Shadcn.breadcrumbSeparator []

                Shadcn.breadcrumbItem [ Shadcn.breadcrumbPage [ prop.text "Breadcrumb" ] ]
            ]
        ],
            """Shadcn.breadcrumb [
    Shadcn.breadcrumbList [
        Shadcn.breadcrumbItem [
            Shadcn.breadcrumbLink [ prop.href "/"; prop.text "Home" ]
        ]

        Shadcn.breadcrumbSeparator []

        Shadcn.breadcrumbItem [
            Shadcn.dropdownMenu [
                Shadcn.dropdownMenuTrigger [
                    prop.className "flex items-center gap-1"
                    prop.children [
                        Shadcn.breadcrumbEllipsis [ prop.className "h-4 w-4" ]
                        Html.span [ prop.className "sr-only"; prop.text "Toggle menu" ]
                    ]
                ]
                Shadcn.dropdownMenuContent [
                    prop.custom ("align", "start")
                    prop.children [
                        Shadcn.dropdownMenuItem [ prop.text "Documentation" ]
                        Shadcn.dropdownMenuItem [ prop.text "Themes" ]
                        Shadcn.dropdownMenuItem [ prop.text "GitHub" ]
                    ]
                ]
            ]
        ]

        Shadcn.breadcrumbSeparator []

        Shadcn.breadcrumbItem [
            Shadcn.breadcrumbLink [ prop.href "/docs/components"; prop.text "Components" ]
        ]

        Shadcn.breadcrumbSeparator []

        Shadcn.breadcrumbItem [ Shadcn.breadcrumbPage [ prop.text "Breadcrumb" ] ]
    ]
]""")
