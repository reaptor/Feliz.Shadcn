module Docs.Pages.Components.Menubar

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Menubar () =
    UI.PreviewAndCode(
        nameof Menubar,
        Shadcn.menubar [
            Shadcn.menubarMenu [
                Shadcn.menubarTrigger "File"
                Shadcn.menubarContent [
                    Shadcn.menubarItem [ prop.children [ Html.text "New Tab "; Shadcn.menubarShortcut "⌘T" ] ]
                    Shadcn.menubarItem [ prop.children [ Html.text "New Window "; Shadcn.menubarShortcut "⌘N" ] ]
                    Shadcn.menubarItem [ prop.disabled true; prop.text "New Incognito Window" ]
                    Shadcn.menubarSeparator []
                    Shadcn.menubarSub [
                        Shadcn.menubarSubTrigger "Share"
                        Shadcn.menubarSubContent [
                            Shadcn.menubarItem [ prop.text "Email link" ]
                            Shadcn.menubarItem [ prop.text "Messages" ]
                            Shadcn.menubarItem [ prop.text "Notes" ]
                        ]
                    ]
                    Shadcn.menubarSeparator []
                    Shadcn.menubarItem [ prop.children [ Html.text "Print... "; Shadcn.menubarShortcut "⌘P" ] ]
                ]
            ]
            Shadcn.menubarMenu [
                Shadcn.menubarTrigger "Edit"
                Shadcn.menubarContent [
                    Shadcn.menubarItem [ prop.children [ Html.text "Undo "; Shadcn.menubarShortcut "⌘Z" ] ]
                    Shadcn.menubarItem [ prop.children [ Html.text "Redo "; Shadcn.menubarShortcut "⇧⌘Z" ] ]
                    Shadcn.menubarSeparator []
                    Shadcn.menubarSub [
                        Shadcn.menubarSubTrigger "Find"
                        Shadcn.menubarSubContent [
                            Shadcn.menubarItem [ prop.text "Search the web" ]
                            Shadcn.menubarSeparator []
                            Shadcn.menubarItem [ prop.text "Find..." ]
                            Shadcn.menubarItem [ prop.text "Find Next" ]
                            Shadcn.menubarItem [ prop.text "Find Previous" ]
                        ]
                    ]
                    Shadcn.menubarSeparator []
                    Shadcn.menubarItem [ prop.text "Cut" ]
                    Shadcn.menubarItem [ prop.text "Copy" ]
                    Shadcn.menubarItem [ prop.text "Paste" ]
                ]
            ]
            Shadcn.menubarMenu [
                Shadcn.menubarTrigger "View"
                Shadcn.menubarContent [
                    Shadcn.menubarCheckboxItem [ prop.text "Always Show Bookmarks Bar" ]
                    Shadcn.menubarCheckboxItem [ menubarCheckboxItem.checked' true; prop.text "Always Show Full URLs" ]
                    Shadcn.menubarSeparator []
                    Shadcn.menubarItem [
                        menubarItem.inset
                        prop.children [ Html.text "Reload "; Shadcn.menubarShortcut "⌘R" ]
                    ]
                    Shadcn.menubarItem [
                        prop.disabled true
                        menubarItem.inset
                        prop.children [ Html.text "Force Reload "; Shadcn.menubarShortcut "⇧⌘R" ]
                    ]
                    Shadcn.menubarSeparator []
                    Shadcn.menubarItem [ menubarItem.inset; prop.text "Toggle Fullscreen" ]
                    Shadcn.menubarSeparator []
                    Shadcn.menubarItem [ menubarItem.inset; prop.text "Hide Sidebar" ]
                ]
            ]
            Shadcn.menubarMenu [
                Shadcn.menubarTrigger "Profiles"
                Shadcn.menubarContent [
                    Shadcn.menubarRadioGroup [
                        prop.value "benoit"
                        prop.children [
                            Shadcn.menubarRadioItem [ prop.value "andy"; prop.text "Andy" ]
                            Shadcn.menubarRadioItem [ prop.value "benoit"; prop.text "Benoit" ]
                            Shadcn.menubarRadioItem [ prop.value "Luis"; prop.text "Luis" ]
                        ]
                    ]
                    Shadcn.menubarSeparator []
                    Shadcn.menubarItem [ menubarItem.inset; prop.text "Edit..." ]
                    Shadcn.menubarSeparator []
                    Shadcn.menubarItem [ menubarItem.inset; prop.text "Add Profile..." ]
                ]
            ]
        ],
        """Shadcn.menubar [
    Shadcn.menubarMenu [
        Shadcn.menubarTrigger "File"
        Shadcn.menubarContent [
            Shadcn.menubarItem [ prop.children [ Html.text "New Tab "; Shadcn.menubarShortcut "⌘T" ] ]
            Shadcn.menubarItem [ prop.children [ Html.text "New Window "; Shadcn.menubarShortcut "⌘N" ] ]
            Shadcn.menubarItem [ prop.disabled true; prop.text "New Incognito Window" ]
            Shadcn.menubarSeparator []
            Shadcn.menubarSub [
                Shadcn.menubarSubTrigger "Share"
                Shadcn.menubarSubContent [
                    Shadcn.menubarItem [ prop.text "Email link" ]
                    Shadcn.menubarItem [ prop.text "Messages" ]
                    Shadcn.menubarItem [ prop.text "Notes" ]
                ]
            ]
            Shadcn.menubarSeparator []
            Shadcn.menubarItem [ prop.children [ Html.text "Print... "; Shadcn.menubarShortcut "⌘P" ] ]
        ]
    ]
    Shadcn.menubarMenu [
        Shadcn.menubarTrigger "Edit"
        Shadcn.menubarContent [
            Shadcn.menubarItem [ prop.children [ Html.text "Undo "; Shadcn.menubarShortcut "⌘Z" ] ]
            Shadcn.menubarItem [ prop.children [ Html.text "Redo "; Shadcn.menubarShortcut "⇧⌘Z" ] ]
            Shadcn.menubarSeparator []
            Shadcn.menubarSub [
                Shadcn.menubarSubTrigger "Find"
                Shadcn.menubarSubContent [
                    Shadcn.menubarItem [ prop.text "Search the web" ]
                    Shadcn.menubarSeparator []
                    Shadcn.menubarItem [ prop.text "Find..." ]
                    Shadcn.menubarItem [ prop.text "Find Next" ]
                    Shadcn.menubarItem [ prop.text "Find Previous" ]
                ]
            ]
            Shadcn.menubarSeparator []
            Shadcn.menubarItem [ prop.text "Cut" ]
            Shadcn.menubarItem [ prop.text "Copy" ]
            Shadcn.menubarItem [ prop.text "Paste" ]
        ]
    ]
    Shadcn.menubarMenu [
        Shadcn.menubarTrigger "View"
        Shadcn.menubarContent [
            Shadcn.menubarCheckboxItem [ prop.text "Always Show Bookmarks Bar" ]
            Shadcn.menubarCheckboxItem [ menubarCheckboxItem.checked' true; prop.text "Always Show Full URLs" ]
            Shadcn.menubarSeparator []
            Shadcn.menubarItem [
                menubarItem.inset
                prop.children [ Html.text "Reload "; Shadcn.menubarShortcut "⌘R" ]
            ]
            Shadcn.menubarItem [
                prop.disabled true
                menubarItem.inset
                prop.children [ Html.text "Force Reload "; Shadcn.menubarShortcut "⇧⌘R" ]
            ]
            Shadcn.menubarSeparator []
            Shadcn.menubarItem [ menubarItem.inset; prop.text "Toggle Fullscreen" ]
            Shadcn.menubarSeparator []
            Shadcn.menubarItem [ menubarItem.inset; prop.text "Hide Sidebar" ]
        ]
    ]
    Shadcn.menubarMenu [
        Shadcn.menubarTrigger "Profiles"
        Shadcn.menubarContent [
            Shadcn.menubarRadioGroup [
                prop.value "benoit"
                prop.children [
                    Shadcn.menubarRadioItem [ prop.value "andy"; prop.text "Andy" ]
                    Shadcn.menubarRadioItem [ prop.value "benoit"; prop.text "Benoit" ]
                    Shadcn.menubarRadioItem [ prop.value "Luis"; prop.text "Luis" ]
                ]
            ]
            Shadcn.menubarSeparator []
            Shadcn.menubarItem [ menubarItem.inset; prop.text "Edit..." ]
            Shadcn.menubarSeparator []
            Shadcn.menubarItem [ menubarItem.inset; prop.text "Add Profile..." ]
        ]
    ]
]"""
    )
