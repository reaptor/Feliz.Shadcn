module Docs.Pages.Components.Sidebar

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Sidebar () =
    let items = [|
        {|
            title = "Home"
            url = "#"
            icon = Lucide.House
        |}
        {|
            title = "Inbox"
            url = "#"
            icon = Lucide.Inbox
        |}
        {|
            title = "Calendar"
            url = "#"
            icon = Lucide.Calendar
        |}
        {|
            title = "Search"
            url = "#"
            icon = Lucide.Search
        |}
        {|
            title = "Settings"
            url = "#"
            icon = Lucide.Settings
        |}
    |]

    UI.PreviewAndCode(
        nameof Sidebar,
        Html.text "Preview not available",
        """let items = [|
    {| title = "Home"; url = "#"; icon = Lucide.Home |}
    {| title = "Inbox"; url = "#"; icon = Lucide.Inbox |}
    {| title = "Calendar"; url = "#"; icon = Lucide.Calendar |}
    {| title = "Search"; url = "#"; icon = Lucide.Search |}
    {| title = "Settings"; url = "#"; icon = Lucide.Settings |}
|]

Shadcn.sidebar [
    Shadcn.sidebarContent [
        Shadcn.sidebarGroup [
            Shadcn.sidebarGroupLabel "Application"
            Shadcn.sidebarGroupContent [
                Shadcn.sidebarMenu [
                    for item in items do
                        Shadcn.sidebarMenuItem [
                            prop.key item.title
                            prop.children [
                                Shadcn.sidebarMenuButton [
                                    sidebarMenuButton.asChild
                                    prop.children [
                                        Html.a [
                                            prop.href item.url
                                            prop.children [
                                                item.icon []
                                                Html.span [ prop.text item.title ]
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
    ]"""
    )
