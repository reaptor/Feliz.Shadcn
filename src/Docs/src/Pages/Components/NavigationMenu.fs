module Docs.Pages.Components.NavigationMenu

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let ListItem
    (props:
        {|
            href: string
            title: string
            description: string
        |})
    =
    Html.li [
        Shadcn.navigationMenuLink [
            navigationMenuLink.asChild
            prop.children [
                Html.a [
                    prop.className
                        "block select-none space-y-1 rounded-md p-3 leading-none no-underline outline-none transition-colors hover:bg-accent hover:text-accent-foreground focus:bg-accent focus:text-accent-foreground"
                    prop.href props.href
                    prop.key props.title
                    prop.children [
                        Html.div [ prop.className "text-sm font-medium leading-none"; prop.text props.title ]
                        Html.p [
                            prop.className "line-clamp-2 text-sm leading-snug text-muted-foreground"
                            prop.text props.description
                        ]
                    ]
                ]
            ]
        ]
    ]

let components = [
    {|
        title = "Alert Dialog"
        href = "/docs/primitives/alert-dialog"
        description = "A modal dialog that interrupts the user with important content and expects a response."
    |}
    {|
        title = "Hover Card"
        href = "/docs/primitives/hover-card"
        description = "For sighted users to preview content available behind a link."
    |}
    {|
        title = "Progress"
        href = "/docs/primitives/progress"
        description =
            "Displays an indicator showing the completion progress of a task, typically displayed as a progress bar."
    |}
    {|
        title = "Scroll-area"
        href = "/docs/primitives/scroll-area"
        description = "Visually or semantically separates content."
    |}
    {|
        title = "Tabs"
        href = "/docs/primitives/tabs"
        description = "A set of layered sections of content—known as tab panels—that are displayed one at a time."
    |}
    {|
        title = "Tooltip"
        href = "/docs/primitives/tooltip"
        description =
            "A popup that displays information related to an element when the element receives keyboard focus or the mouse hovers over it."
    |}
]

let rec NavigationMenu () =
    UI.PreviewAndCode(
        nameof NavigationMenu,
        Shadcn.navigationMenu [
            Shadcn.navigationMenuList [
                Shadcn.navigationMenuItem [
                    Shadcn.navigationMenuTrigger "Getting started"
                    Shadcn.navigationMenuContent [
                        Html.ul [
                            prop.className "grid gap-3 p-4 md:w-[400px] lg:w-[500px] lg:grid-cols-[.75fr_1fr]"
                            prop.children [
                                Html.li [
                                    prop.className "row-span-3"
                                    prop.children [
                                        Shadcn.navigationMenuLink [
                                            navigationMenuLink.asChild
                                            prop.children [
                                                Html.a [
                                                    prop.className
                                                        "cursor-pointer flex h-full w-full select-none flex-col justify-end rounded-md bg-gradient-to-b from-muted/50 to-muted p-6 no-underline outline-none focus:shadow-md"
                                                    prop.children [
                                                        Html.div [ prop.className "h-6 w-6"; prop.text "🔷" ]
                                                        Html.div [
                                                            prop.className "mb-2 mt-4 text-lg font-medium"
                                                            prop.text "shadcn/ui"
                                                        ]
                                                        Html.p [
                                                            prop.className "text-sm leading-tight text-muted-foreground"
                                                            prop.text
                                                                "Beautifully designed components built with Radix UI and Tailwind CSS."
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                ListItem {|
                                    href = "/docs"
                                    title = "Introduction"
                                    description = "Re-usable components built using Radix UI and Tailwind CSS."
                                |}
                                ListItem {|
                                    href = "/docs/installation"
                                    title = "Installation"
                                    description = "How to install dependencies and structure your app."
                                |}
                                ListItem {|
                                    href = "/docs/primitives/typography"
                                    title = "Typography"
                                    description = "Styles for headings, paragraphs, lists...etc"
                                |}
                            ]
                        ]
                    ]
                ]
                Shadcn.navigationMenuItem [
                    Shadcn.navigationMenuTrigger "Components"
                    Shadcn.navigationMenuContent [
                        Html.ul [
                            prop.className "grid w-[400px] gap-3 p-4 md:w-[500px] md:grid-cols-2 lg:w-[600px]"
                            prop.children [
                                for component' in components do
                                    ListItem {|
                                        href = component'.href
                                        title = component'.title
                                        description = component'.description
                                    |}
                            ]
                        ]
                    ]
                ]
                Shadcn.navigationMenuItem [
                    Shadcn.navigationMenuLink [ prop.className "cursor-pointer"; prop.text "Documentation" ]
                ]
            ]
        ],
        """let ListItem (props: {| href: string; title: string; description: string |}) =
    Html.li [
        Shadcn.navigationMenuLink [
            navigationMenuLink.asChild
            prop.children [
                Html.a [
                    prop.className "block select-none space-y-1 rounded-md p-3 leading-none no-underline outline-none transition-colors hover:bg-accent hover:text-accent-foreground focus:bg-accent focus:text-accent-foreground"
                    prop.href props.href
                    prop.key props.title
                    prop.children [
                        Html.div [
                            prop.className "text-sm font-medium leading-none"
                            prop.text props.title
                        ]
                        Html.p [
                            prop.className "line-clamp-2 text-sm leading-snug text-muted-foreground"
                            prop.text props.description
                        ]
                    ]
                ]
            ]
        ]
    ]

let components = [
    {|
        title = "Alert Dialog"
        href = "/docs/primitives/alert-dialog"
        description = "A modal dialog that interrupts the user with important content and expects a response."
    |}
    {|
        title = "Hover Card"
        href = "/docs/primitives/hover-card"
        description = "For sighted users to preview content available behind a link."
    |}
    {|
        title = "Progress"
        href = "/docs/primitives/progress"
        description = "Displays an indicator showing the completion progress of a task, typically displayed as a progress bar."
    |}
    {|
        title = "Scroll-area"
        href = "/docs/primitives/scroll-area"
        description = "Visually or semantically separates content."
    |}
    {|
        title = "Tabs"
        href = "/docs/primitives/tabs"
        description = "A set of layered sections of content—known as tab panels—that are displayed one at a time."
    |}
    {|
        title = "Tooltip"
        href = "/docs/primitives/tooltip"
        description = "A popup that displays information related to an element when the element receives keyboard focus or the mouse hovers over it."
    |}
]

Shadcn.navigationMenu [
    Shadcn.navigationMenuList [
        Shadcn.navigationMenuItem [
            Shadcn.navigationMenuTrigger "Getting started"
            Shadcn.navigationMenuContent [
                Html.ul [
                    prop.className "grid gap-3 p-4 md:w-[400px] lg:w-[500px] lg:grid-cols-[.75fr_1fr]"
                    prop.children [
                        Html.li [
                            prop.className "row-span-3"
                            prop.children [
                                Shadcn.navigationMenuLink [
                                    navigationMenuLink.asChild
                                    prop.children [
                                        Html.a [
                                            prop.className "flex h-full w-full select-none flex-col justify-end rounded-md bg-gradient-to-b from-muted/50 to-muted p-6 no-underline outline-none focus:shadow-md"
                                            prop.href "/"
                                            prop.children [
                                                Html.div [
                                                    prop.className "h-6 w-6"
                                                    prop.text "🔷"
                                                ]
                                                Html.div [
                                                    prop.className "mb-2 mt-4 text-lg font-medium"
                                                    prop.text "shadcn/ui"
                                                ]
                                                Html.p [
                                                    prop.className "text-sm leading-tight text-muted-foreground"
                                                    prop.text "Beautifully designed components built with Radix UI and Tailwind CSS."
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        ListItem {|
                            href = "/docs"
                            title = "Introduction"
                            description = "Re-usable components built using Radix UI and Tailwind CSS."
                        |}
                        ListItem {|
                            href = "/docs/installation"
                            title = "Installation"
                            description = "How to install dependencies and structure your app."
                        |}
                        ListItem {|
                            href = "/docs/primitives/typography"
                            title = "Typography"
                            description = "Styles for headings, paragraphs, lists...etc"
                        |}
                    ]
                ]
            ]
        ]
        Shadcn.navigationMenuItem [
            Shadcn.navigationMenuTrigger "Components"
            Shadcn.navigationMenuContent [
                Html.ul [
                    prop.className "grid w-[400px] gap-3 p-4 md:w-[500px] md:grid-cols-2 lg:w-[600px]"
                    prop.children [
                        for component' in components do
                            ListItem {|
                                href = component'.href
                                title = component'.title
                                description = component'.description
                            |}
                    ]
                ]
            ]
        ]
        Shadcn.navigationMenuItem [
            Shadcn.navigationMenuLink [
                prop.href "/docs"
                prop.text "Documentation"
            ]
        ]
    ]
    ]
"""
    )
