module Docs.Pages.Components.DropdownMenu

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec DropdownMenu () =
    UI.PreviewAndCode(
        nameof DropdownMenu,
        Shadcn.dropdownMenu [
            Shadcn.dropdownMenuTrigger [
                dropdownMenuTrigger.asChild
                prop.children [
                    Shadcn.button [
                        button.variant.outline
                        prop.text "Open"
                    ]
                ]
            ]
            Shadcn.dropdownMenuContent [
                prop.className "w-56"
                prop.children [
                    Shadcn.dropdownMenuLabel [
                        prop.text "My Account"
                    ]
                    Shadcn.dropdownMenuSeparator []
                    Shadcn.dropdownMenuGroup [
                        Shadcn.dropdownMenuItem [
                            prop.children [
                                Html.text "Profile"
                                Shadcn.dropdownMenuShortcut [
                                    prop.text "⇧⌘P"
                                ]
                            ]
                        ]
                        Shadcn.dropdownMenuItem [
                            prop.children [
                                Html.text "Billing"
                                Shadcn.dropdownMenuShortcut [
                                    prop.text "⌘B"
                                ]
                            ]
                        ]
                        Shadcn.dropdownMenuItem [
                            prop.children [
                                Html.text "Settings"
                                Shadcn.dropdownMenuShortcut [
                                    prop.text "⌘S"
                                ]
                            ]
                        ]
                        Shadcn.dropdownMenuItem [
                            prop.children [
                                Html.text "Keyboard shortcuts"
                                Shadcn.dropdownMenuShortcut [
                                    prop.text "⌘K"
                                ]
                            ]
                        ]
                    ]
                    Shadcn.dropdownMenuSeparator []
                    Shadcn.dropdownMenuGroup [
                        Shadcn.dropdownMenuItem [
                            prop.text "Team"
                        ]
                        Shadcn.dropdownMenuSub [
                            Shadcn.dropdownMenuSubTrigger [
                                prop.text "Invite users"
                            ]
                            Shadcn.dropdownMenuPortal [
                                Shadcn.dropdownMenuSubContent [
                                    Shadcn.dropdownMenuItem [
                                        prop.text "Email"
                                    ]
                                    Shadcn.dropdownMenuItem [
                                        prop.text "Message"
                                    ]
                                    Shadcn.dropdownMenuSeparator []
                                    Shadcn.dropdownMenuItem [
                                        prop.text "More..."
                                    ]
                                ]
                            ]
                        ]
                        Shadcn.dropdownMenuItem [
                            prop.children [
                                Html.text "New Team"
                                Shadcn.dropdownMenuShortcut [
                                    prop.text "⌘+T"
                                ]
                            ]
                        ]
                    ]
                    Shadcn.dropdownMenuSeparator []
                    Shadcn.dropdownMenuItem [
                        prop.text "GitHub"
                    ]
                    Shadcn.dropdownMenuItem [
                        prop.text "Support"
                    ]
                    Shadcn.dropdownMenuItem [
                        prop.disabled true
                        prop.text "API"
                    ]
                    Shadcn.dropdownMenuSeparator []
                    Shadcn.dropdownMenuItem [
                        prop.children [
                            Html.text "Log out"
                            Shadcn.dropdownMenuShortcut [
                                prop.text "⇧⌘Q"
                            ]
                        ]
                    ]
                ]
            ]
        ],
        """Shadcn.dropdownMenu [
    Shadcn.dropdownMenuTrigger [
        dropdownMenuTrigger.asChild
        prop.children [
            Shadcn.button [
                button.variant.outline
                prop.text "Open"
            ]
        ]
    ]
    Shadcn.dropdownMenuContent [
        prop.className "w-56"
        prop.children [
            Shadcn.dropdownMenuLabel [
                prop.text "My Account"
            ]
            Shadcn.dropdownMenuSeparator []
            Shadcn.dropdownMenuGroup [
                Shadcn.dropdownMenuItem [
                    prop.children [
                        Html.text "Profile"
                        Shadcn.dropdownMenuShortcut [
                            prop.text "⇧⌘P"
                        ]
                    ]
                ]
                Shadcn.dropdownMenuItem [
                    prop.children [
                        Html.text "Billing"
                        Shadcn.dropdownMenuShortcut [
                            prop.text "⌘B"
                        ]
                    ]
                ]
                Shadcn.dropdownMenuItem [
                    prop.children [
                        Html.text "Settings"
                        Shadcn.dropdownMenuShortcut [
                            prop.text "⌘S"
                        ]
                    ]
                ]
                Shadcn.dropdownMenuItem [
                    prop.children [
                        Html.text "Keyboard shortcuts"
                        Shadcn.dropdownMenuShortcut [
                            prop.text "⌘K"
                        ]
                    ]
                ]
            ]
            Shadcn.dropdownMenuSeparator []
            Shadcn.dropdownMenuGroup [
                Shadcn.dropdownMenuItem [
                    prop.text "Team"
                ]
                Shadcn.dropdownMenuSub [
                    Shadcn.dropdownMenuSubTrigger [
                        prop.text "Invite users"
                    ]
                    Shadcn.dropdownMenuPortal [
                        Shadcn.dropdownMenuSubContent [
                            Shadcn.dropdownMenuItem [
                                prop.text "Email"
                            ]
                            Shadcn.dropdownMenuItem [
                                prop.text "Message"
                            ]
                            Shadcn.dropdownMenuSeparator []
                            Shadcn.dropdownMenuItem [
                                prop.text "More..."
                            ]
                        ]
                    ]
                ]
                Shadcn.dropdownMenuItem [
                    prop.children [
                        Html.text "New Team"
                        Shadcn.dropdownMenuShortcut [
                            prop.text "⌘+T"
                        ]
                    ]
                ]
            ]
            Shadcn.dropdownMenuSeparator []
            Shadcn.dropdownMenuItem [
                prop.text "GitHub"
            ]
            Shadcn.dropdownMenuItem [
                prop.text "Support"
            ]
            Shadcn.dropdownMenuItem [
                prop.disabled true
                prop.text "API"
            ]
            Shadcn.dropdownMenuSeparator []
            Shadcn.dropdownMenuItem [
                prop.children [
                    Html.text "Log out"
                    Shadcn.dropdownMenuShortcut [
                        prop.text "⇧⌘Q"
                    ]
                ]
            ]
        ]
    ]
]"""
    )
