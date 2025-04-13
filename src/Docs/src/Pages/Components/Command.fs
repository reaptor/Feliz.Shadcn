module Docs.Pages.Components.Command

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Command () =
    UI.PreviewAndCode(
        nameof Command,
        Shadcn.command [
            prop.className "rounded-lg border shadow-md md:min-w-[450px]"
            prop.children [
                Shadcn.commandInput [ prop.placeholder "Type a command or search..." ]
                Shadcn.commandList [
                    Shadcn.commandEmpty "No results found."
                    Shadcn.commandGroup [
                        commandGroup.heading "Suggestions"
                        prop.children [
                            Shadcn.commandItem [ prop.children [ Lucide.Calendar []; Html.span "Calendar" ] ]
                            Shadcn.commandItem [ prop.children [ Lucide.Smile []; Html.span "Search Emoji" ] ]
                            Shadcn.commandItem [
                                prop.disabled true
                                prop.children [ Lucide.Calculator []; Html.span "Calculator" ]
                            ]
                        ]
                    ]
                    Shadcn.commandSeparator []
                    Shadcn.commandGroup [
                        commandGroup.heading "Settings"
                        prop.children [
                            Shadcn.commandItem [
                                prop.children [ Lucide.User []; Html.span "Profile"; Shadcn.commandShortcut "⌘P" ]
                            ]
                            Shadcn.commandItem [
                                prop.children [ Lucide.CreditCard []; Html.span "Billing"; Shadcn.commandShortcut "⌘B" ]
                            ]
                            Shadcn.commandItem [
                                prop.children [ Lucide.Settings []; Html.span "Settings"; Shadcn.commandShortcut "⌘S" ]
                            ]
                        ]
                    ]
                ]
            ]
        ],
        """Shadcn.command [
    prop.className "rounded-lg border shadow-md md:min-w-[450px]"
    prop.children [
        Shadcn.commandInput [
            prop.placeholder "Type a command or search..."
        ]
        Shadcn.commandList [
            Shadcn.commandEmpty "No results found."
            Shadcn.commandGroup [
                commandGroup.heading "Suggestions"
                prop.children [
                    Shadcn.commandItem [
                        prop.children [
                            UI.CalendarIcon()
                            Html.span "Calendar"
                        ]
                    ]
                    Shadcn.commandItem [
                        prop.children [
                            UI.SmileIcon()
                            Html.span "Search Emoji"
                        ]
                    ]
                    Shadcn.commandItem [
                        prop.disabled true
                        prop.children [
                            UI.CalculatorIcon()
                            Html.span "Calculator"
                        ]
                    ]
                ]
            ]
            Shadcn.commandSeparator []
            Shadcn.commandGroup [
                commandGroup.heading "Settings"
                prop.children [
                    Shadcn.commandItem [
                        prop.children [
                            UI.UserIcon()
                            Html.span "Profile"
                            Shadcn.commandShortcut "⌘P"
                        ]
                    ]
                    Shadcn.commandItem [
                        prop.children [
                            UI.CreditCardIcon()
                            Html.span "Billing"
                            Shadcn.commandShortcut "⌘B"
                        ]
                    ]
                    Shadcn.commandItem [
                        prop.children [
                            UI.SettingsIcon()
                            Html.span "Settings"
                            Shadcn.commandShortcut "⌘S"
                        ]
                    ]
                ]
            ]
        ]
    ]
]"""
    )
