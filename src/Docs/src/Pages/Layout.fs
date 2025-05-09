module Docs.Pages.Layout

open Feliz
open Feliz.Shadcn
open ElmishLand
open Docs.Shared
open Docs.Pages.Components

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
        "card",
        {
            Title = "Card"
            Description = "Displays a card with header, content, and footer."
            Constructor = Card.Card
        }
        "carousel",
        {
            Title = "Carousel"
            Description = "A carousel with motion and swipe built using Embla."
            Constructor = Carousel.Carousel
        }
        "checkbox",
        {
            Title = "Checkbox"
            Description = "A control that allows the user to toggle between checked and not checked."
            Constructor = Checkbox.Checkbox
        }
        "collapsible",
        {
            Title = "Collapsible"
            Description = "An interactive component which expands/collapses a panel."
            Constructor = Collapsible.Collapsible
        }
        "combobox",
        {
            Title = "Combobox"
            Description = "Autocomplete input and command palette with a list of suggestions."
            Constructor = Combobox.Combobox
        }
        "command",
        {
            Title = "Command"
            Description = "Fast, composable, unstyled command menu for React."
            Constructor = Command.Command
        }
        "context-menu",
        {
            Title = "Context Menu"
            Description = "Displays a menu to the user — such as a set of actions or functions — triggered by a button."
            Constructor = ContextMenu.ContextMenu
        }
        "date-picker",
        {
            Title = "Date Picker"
            Description = "A date picker component with range and presets."
            Constructor = DatePicker.DatePicker
        }
        "dialog",
        {
            Title = "Dialog"
            Description =
                "A window overlaid on either the primary window or another dialog window, rendering the content underneath inert."
            Constructor = Dialog.Dialog
        }
        "drawer",
        {
            Title = "Drawer"
            Description = "A drawer component for React."
            Constructor = Drawer.Drawer
        }
        "dropdown-menu",
        {
            Title = "Dropdown Menu"
            Description = "Displays a menu to the user — such as a set of actions or functions — triggered by a button."
            Constructor = DropdownMenu.DropdownMenu
        }
        "hover-card",
        {
            Title = "Hover Card"
            Description = "For sighted users to preview content available behind a link."
            Constructor = HoverCard.HoverCard
        }
        "input",
        {
            Title = "Input"
            Description = "Displays a form input field or a component that looks like an input field."
            Constructor = Input.Input
        }
        "input-otp",
        {
            Title = "Input OTP"
            Description = "Verify with a one-time password input."
            Constructor = InputOTP.InputOTP
        }
        "label",
        {
            Title = "Label"
            Description = "Renders an accessible label associated with controls."
            Constructor = Label.Label
        }
        "menubar",
        {
            Title = "Menubar"
            Description = "A visually persistent menu common in desktop applications."
            Constructor = Menubar.Menubar
        }
        "navigation-menu",
        {
            Title = "Navigation Menu"
            Description = "A collection of links for navigating websites."
            Constructor = NavigationMenu.NavigationMenu
        }
        "pagination",
        {
            Title = "Pagination"
            Description = "Pagination with page navigation, next and previous links."
            Constructor = Pagination.Pagination
        }
        "popover",
        {
            Title = "Popover"
            Description = "Displays rich content in a portal, triggered by a button."
            Constructor = Popover.Popover
        }
        "progress",
        {
            Title = "Progress"
            Description = "Displays an indicator showing the completion progress of a task."
            Constructor = Progress.Progress
        }
        "radio-group",
        {
            Title = "Radio Group"
            Description =
                "A set of checkable buttons—known as radio buttons—where no more than one can be checked at a time."
            Constructor = RadioGroup.RadioGroup
        }
        "resizable",
        {
            Title = "Resizable"
            Description = "Accessible resizable panels with keyboard support."
            Constructor = Resizable.Resizable
        }
        "scroll-area",
        {
            Title = "Scroll Area"
            Description = "Augments native scroll functionality for custom, cross-browser styling."
            Constructor = ScrollArea.ScrollArea
        }
        "select",
        {
            Title = "Select"
            Description = "Displays a list of options for the user to pick from—triggered by a button."
            Constructor = Select.Select
        }
        "separator",
        {
            Title = "Separator"
            Description = "Visually or semantically separates content."
            Constructor = Separator.Separator
        }
        "sheet",
        {
            Title = "Sheet"
            Description =
                "Extends the Dialog component to display content that complements the main content of the screen."
            Constructor = Sheet.Sheet
        }
        "sidebar",
        {
            Title = "Sidebar"
            Description = "A responsive application sidebar with support for vertical and inline layouts."
            Constructor = Sidebar.Sidebar
        }
        "skeleton",
        {
            Title = "Skeleton"
            Description = "Used to show a placeholder while content is loading."
            Constructor = Skeleton.Skeleton
        }
        "slider",
        {
            Title = "Slider"
            Description = "An input slider that allows selecting a value from a range."
            Constructor = Slider.Slider
        }
        "sonner",
        {
            Title = "Sonner"
            Description = "Beautifully designed toast component built using Sonner."
            Constructor = Sonner.Sonner
        }
        "switch",
        {
            Title = "Switch"
            Description = "A control that allows the user to toggle between checked and not checked states."
            Constructor = Switch.Switch
        }
        "table",
        {
            Title = "Table"
            Description = "A responsive table component with formatting for various data types."
            Constructor = Table.Table
        }
        "tabs",
        {
            Title = "Tabs"
            Description = "A set of layered sections of content—known as tab panels—that are displayed one at a time."
            Constructor = Tabs.Tabs
        }
        "textarea",
        {
            Title = "Textarea"
            Description = "Displays a form textarea field or a component that looks like a textarea field."
            Constructor = Textarea.Textarea
        }
        "toggle",
        {
            Title = "Toggle"
            Description = "A two-state button that can be either on or off."
            Constructor = Toggle.Toggle
        }
        "toggle-group",
        {
            Title = "Toggle Group"
            Description = "A set of two-state buttons that can be toggled on or off."
            Constructor = ToggleGroup.ToggleGroup
        }
        "tooltip",
        {
            Title = "Tooltip"
            Description =
                "A popup that displays information related to an element when the element receives keyboard focus or the mouse hovers over it."
            Constructor = Tooltip.Tooltip
        }
    ]

let getComponent name =
    components
    |> Map.tryFind name
    |> Option.defaultWith (fun () -> failwith $"Page '%s{name}' does not exist")

type Props = { CurrentPage: string }

type Model = { CurrentPage: string }

type Msg = ChangeComponent of string

let init (name: string) = { CurrentPage = name }, Command.none

let update (msg: Msg) (model: Model) =
    match msg with
    | ChangeComponent compName ->
        { model with CurrentPage = compName }, Command.navigate (Route.CompName { CompName = compName })

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
                                            Shadcn.drawerTrigger [ Lucide.Menu [] ]
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
                                                                    prop.onClick (fun _ ->
                                                                        dispatch (ChangeComponent name'))
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
                                Html.a [ prop.className "text-lg font-bold"; prop.href "/"; prop.text "Feliz.Shadcn" ]
                            ]
                        ]
                        Html.a [
                            prop.className "flex items-center"
                            prop.href "https://github.com/reaptor/Feliz.Shadcn"
                            prop.children [
                                Html.span [ prop.className "font-semibold mr-2"; prop.text "GitHub" ]
                                Lucide.SquareArrowOutUpRight [ svg.size 14 ]
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
                                                        sidebarMenuButton.asChild
                                                        sidebarMenuButton.isActive (
                                                            System.String.IsNullOrWhiteSpace model.CurrentPage
                                                        )
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
                                                            sidebarMenuButton.asChild
                                                            sidebarMenuButton.isActive ((name' = model.CurrentPage))
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
                    Shadcn.sidebarInset [ prop.className "mt-20 md:mx-10 p-4"; prop.children [ content ] ]
                ]
            ]
        ]
    ]

let layout (props: Props) (_route: Route) (_shared: SharedModel) =
    Layout.from (fun () -> init props.CurrentPage) update routeChanged view
