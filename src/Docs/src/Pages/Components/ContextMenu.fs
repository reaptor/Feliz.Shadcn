module Docs.Pages.Components.ContextMenu

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec ContextMenu () =
    UI.PreviewAndCode(
        nameof ContextMenu,
        Shadcn.contextMenu [
            Shadcn.contextMenuTrigger [
                prop.className
                    "flex h-[150px] w-[300px] items-center justify-center rounded-md border border-dashed text-sm"
                prop.text "Right click here"
            ]
            Shadcn.contextMenuContent [
                prop.className "w-64"
                prop.children [
                    Shadcn.contextMenuItem [
                        contextMenuItem.inset
                        prop.children [ Html.text "Back"; Shadcn.contextMenuShortcut "⌘[" ]
                    ]
                    Shadcn.contextMenuItem [
                        contextMenuItem.inset
                        prop.disabled true
                        prop.children [ Html.text "Forward"; Shadcn.contextMenuShortcut "⌘]" ]
                    ]
                    Shadcn.contextMenuItem [
                        contextMenuItem.inset
                        prop.children [ Html.text "Reload"; Shadcn.contextMenuShortcut "⌘R" ]
                    ]
                    Shadcn.contextMenuSub [
                        Shadcn.contextMenuSubTrigger [ contextMenuSubTrigger.inset; prop.text "More Tools" ]
                        Shadcn.contextMenuSubContent [
                            prop.className "w-48"
                            prop.children [
                                Shadcn.contextMenuItem [
                                    prop.children [ Html.text "Save Page As..."; Shadcn.contextMenuShortcut "⇧⌘S" ]
                                ]
                                Shadcn.contextMenuItem "Create Shortcut..."
                                Shadcn.contextMenuItem "Name Window..."
                                Shadcn.contextMenuSeparator []
                                Shadcn.contextMenuItem "Developer Tools"
                            ]
                        ]
                    ]
                    Shadcn.contextMenuSeparator []
                    Shadcn.contextMenuCheckboxItem [
                        contextMenuCheckboxItem.checked' true
                        prop.children [ Html.text "Show Bookmarks Bar"; Shadcn.contextMenuShortcut "⌘⇧B" ]
                    ]
                    Shadcn.contextMenuCheckboxItem "Show Full URLs"
                    Shadcn.contextMenuSeparator []
                    Shadcn.contextMenuRadioGroup [
                        prop.value "pedro"
                        prop.children [
                            Shadcn.contextMenuLabel [ contextMenuLabel.inset; prop.text "People" ]
                            Shadcn.contextMenuSeparator []
                            Shadcn.contextMenuRadioItem [ prop.value "pedro"; prop.text "Pedro Duarte" ]
                            Shadcn.contextMenuRadioItem [ prop.value "colm"; prop.text "Colm Tuite" ]
                        ]
                    ]
                ]
            ]
        ],
        """Shadcn.contextMenu [
    Shadcn.contextMenuTrigger [
        prop.className
            "flex h-[150px] w-[300px] items-center justify-center rounded-md border border-dashed text-sm"
        prop.text "Right click here"
    ]
    Shadcn.contextMenuContent [
        prop.className "w-64"
        prop.children [
            Shadcn.contextMenuItem [
                contextMenuItem.inset
                prop.children [ Html.text "Back"; Shadcn.contextMenuShortcut "⌘[" ]
            ]
            Shadcn.contextMenuItem [
                contextMenuItem.inset
                prop.disabled true
                prop.children [ Html.text "Forward"; Shadcn.contextMenuShortcut "⌘]" ]
            ]
            Shadcn.contextMenuItem [
                contextMenuItem.inset
                prop.children [ Html.text "Reload"; Shadcn.contextMenuShortcut "⌘R" ]
            ]
            Shadcn.contextMenuSub [
                Shadcn.contextMenuSubTrigger [ contextMenuSubTrigger.inset; prop.text "More Tools" ]
                Shadcn.contextMenuSubContent [
                    prop.className "w-48"
                    prop.children [
                        Shadcn.contextMenuItem [
                            prop.children [ Html.text "Save Page As..."; Shadcn.contextMenuShortcut "⇧⌘S" ]
                        ]
                        Shadcn.contextMenuItem "Create Shortcut..."
                        Shadcn.contextMenuItem "Name Window..."
                        Shadcn.contextMenuSeparator []
                        Shadcn.contextMenuItem "Developer Tools"
                    ]
                ]
            ]
            Shadcn.contextMenuSeparator []
            Shadcn.contextMenuCheckboxItem [
                contextMenuCheckboxItem.checked' true
                prop.children [ Html.text "Show Bookmarks Bar"; Shadcn.contextMenuShortcut "⌘⇧B" ]
            ]
            Shadcn.contextMenuCheckboxItem "Show Full URLs"
            Shadcn.contextMenuSeparator []
            Shadcn.contextMenuRadioGroup [
                prop.value "pedro"
                prop.children [
                    Shadcn.contextMenuLabel [ contextMenuLabel.inset; prop.text "People" ]
                    Shadcn.contextMenuSeparator []
                    Shadcn.contextMenuRadioItem [ prop.value "pedro"; prop.text "Pedro Duarte" ]
                    Shadcn.contextMenuRadioItem [ prop.value "colm"; prop.text "Colm Tuite" ]
                ]
            ]
        ]
    ]
]"""
    )
