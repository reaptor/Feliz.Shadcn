module Docs.Pages.Layout

open Feliz
open Feliz.Shadcn
open ElmishLand
open Docs.Shared
open Docs.Pages.Components
open Docs.Pages.Components.Common

type Component = {
    Title: string
    Description: string
    Constructor: unit -> ReactElement
}

let components =
    Map [
        "accordion",
        {
            Title = "Accordion"
            Description = "A vertically stacked set of interactive headings that each reveal a section of content."
            Constructor = Accordion.Accordion
        }
        "alert",
        {
            Title = "Alert"
            Description = "Displays a callout for user attention."
            Constructor = Alert.Alert
        }
        "alert-dialog",
        {
            Title = "Alert Dialog"
            Description = "A modal dialog that interrupts the user with important content and expects a response."
            Constructor = AlertDialog.AlertDialog
        }
        "aspect-ratio",
        {
            Title = "Aspect Ratio"
            Description = "Displays content within a desired ratio."
            Constructor = AspectRatio.AspectRatio
        }
        "badge",
        {
            Title = "Badge"
            Description = "Displays a badge or a component that looks like a badge."
            Constructor = Badge.Badge
        }
        "breadcrumb",
        {
            Title = "Breadcrumb"
            Description = "Displays the path to the current resource using a hierarchy of links."
            Constructor = Breadcrumb.Breadcrumb
        }
        "button",
        {
            Title = "Button"
            Description = "Displays a button or a component that looks like a button."
            Constructor = Button.Button
        }
        "calendar",
        {
            Title = "Calendar"
            Description = "A date field component that allows users to enter and edit date."
            Constructor = Calendar.Calendar
        }
        "card", { Title = "Card"; Description = "Displays a card with header, content, and footer."; Constructor = Card.Card }
        "carousel",
        {
            Title = "Carousel"
            Description = "A carousel with motion and swipe built using Embla."
            Constructor = Carousel.Carousel
        }
    ]

let getComponent name =
    components
    |> Map.tryFind name
    |> Option.defaultWith (fun () -> failwith $"Component '%s{name}' does not exist")

type Props = { CurrentComponentName: string }

type Model = { CurrentComponentName: string }

type Msg =
    | ChangeComponent of string

let init (name: string) =
    { CurrentComponentName = name }, Command.none

let update (msg: Msg) (model: Model) =
    match msg with
    | ChangeComponent compName ->
        {
            model with
                CurrentComponentName = compName
        },
        Command.navigate (Route.CompName { CompName = compName })

let routeChanged (model: Model) = model, Command.none

let view (model: Model) (content: ReactElement) (dispatch: Msg -> unit) =
    Html.div [
        Html.header [
            prop.className "fixed top-0 z-50 w-full bg-white/80 backdrop-blur-sm border-b dark:bg-gray-950/80"
            prop.children [
                Html.div [
                    prop.className "flex h-14 items-center justify-between px-4"
                    prop.children [
                        Html.div [
                            prop.className "flex gap-3"
                            prop.children [
                                Html.div [
                                    prop.className "flex md:hidden"
                                    prop.children [
                                        Shadcn.drawer [
                                            Shadcn.drawerTrigger [
                                                UI.HamburgerIcon()
                                            ]
                                            Shadcn.drawerContent [
                                                prop.className "overflow-auto"
                                                prop.children [
                                                    Shadcn.drawerClose [
                                                        prop.onClick (fun _ -> dispatch (ChangeComponent ""))
                                                        prop.text "Getting Started"
                                                        prop.className "cursor-pointer"
                                                    ]
                                                    for KeyValue(name', { Title = title }) in components do
                                                        Shadcn.drawerClose [
                                                            prop.key name'
                                                            prop.children [
                                                                Html.div [
                                                                    prop.className "text-2xl"
                                                                    prop.onClick (fun _ -> dispatch (ChangeComponent name'))
                                                                    prop.text title
                                                                    prop.className "cursor-pointer"
                                                                ]
                                                            ]
                                                        ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Html.a [
                                    prop.className "text-lg font-bold"
                                    prop.href "/"
                                    prop.text "Feliz.Shadcn"
                                ]
                            ]
                        ]
                        Html.a [
                            prop.className "flex items-center"
                            prop.href "https://github.com/reaptor/Feliz.Shadcn"
                            prop.children [
                                Html.span [
                                    prop.className "font-semibold mr-2"
                                    prop.text "GitHub"
                                ]
                                UI.LinkIcon 4
                            ]
                        ]
                    ]
                ]
            ]
        ]
        Html.div [
            prop.children [
                Shadcn.sidebarProvider [
                    Shadcn.sidebar [
                        Shadcn.sidebarContent [
                            prop.className "mt-16"
                            prop.children [
                                Shadcn.sidebarGroup [
                                    Shadcn.sidebarGroupContent [
                                        Shadcn.sidebarMenu [
                                            Shadcn.sidebarMenuItem [
                                                prop.key "Getting Started"
                                                prop.children [
                                                    Shadcn.sidebarMenuButton [
                                                        mkProperty ("asChild", null)
                                                        mkProperty ("isActive", System.String.IsNullOrWhiteSpace model.CurrentComponentName)
                                                        prop.onClick (fun _ -> dispatch (ChangeComponent ""))
                                                        prop.text "Getting Started"
                                                        prop.className "cursor-pointer"
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Shadcn.sidebarGroup [
                                    Shadcn.sidebarGroupLabel "Components"
                                    Shadcn.sidebarGroupContent [
                                        Shadcn.sidebarMenu [
                                            for KeyValue(name', { Title = title }) in components do
                                                Shadcn.sidebarMenuItem [
                                                    prop.key name'
                                                    prop.children [
                                                        Shadcn.sidebarMenuButton [
                                                            mkProperty ("asChild", null)
                                                            mkProperty ("isActive", name' = model.CurrentComponentName)
                                                            prop.onClick (fun _ -> dispatch (ChangeComponent name'))
                                                            prop.text title
                                                            prop.className "cursor-pointer"
                                                        ]
                                                    ]
                                                ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                    Shadcn.sidebarInset [
                        prop.className "mt-20 md:mx-10 p-4"
                        prop.children [
                            content
                        ]
                    ]
                ]
            ]
        ]
    ]

let layout (props: Props) (_route: Route) (_shared: SharedModel) =
    Layout.from (fun () -> init props.CurrentComponentName) update routeChanged view
