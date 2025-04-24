module Docs.Pages.CompName.Page

open Docs.Pages.Layout
open Feliz
open Feliz.Shadcn
open ElmishLand
open Docs.Shared
open Docs.Pages
open Docs.Pages.Components.Common

type Model = { Dummy: unit }

type Msg = LayoutMsg of Layout.Msg

let init () = { Dummy = () }, Command.none

let update (msg: Msg) (model: Model) =
    match msg with
    | LayoutMsg _ -> model, Command.none

type ApiReferenceElement = { Name: string; Description: string }

// apiReferences elements begin
let apiReferencesElements: Map<string, string list> =
    Map [
        "accordion",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "accordionItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "accordionTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "accordionContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alert",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alertTitle",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alertDescription",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alertDialog",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alertDialogPortal",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alertDialogOverlay",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alertDialogTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alertDialogContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alertDialogHeader",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alertDialogFooter",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alertDialogTitle",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alertDialogDescription",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alertDialogAction",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "alertDialogCancel",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "aspectRatio",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "avatar",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "avatarImage",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "avatarFallback",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "badge",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "breadcrumb",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "breadcrumbList",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "breadcrumbItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "breadcrumbLink",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "breadcrumbPage",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "breadcrumbSeparator",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "breadcrumbEllipsis",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "button",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "calendar",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "card",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "cardHeader",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "cardFooter",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "cardTitle",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "cardAction",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "cardDescription",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "cardContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "carousel",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "carouselContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "carouselItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "carouselPrevious",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "carouselNext",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "chartContainer",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "chartTooltip",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "chartTooltipContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "chartLegend",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "chartLegendContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "chartStyle",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "checkbox",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "collapsible",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "collapsibleTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "collapsibleContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "command",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "commandDialog",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "commandInput",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "commandList",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "commandEmpty",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "commandGroup",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "commandItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "commandShortcut",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "commandSeparator",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenu",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuCheckboxItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuRadioItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuLabel",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuSeparator",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuShortcut",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuGroup",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuPortal",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuSub",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuSubContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuSubTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "contextMenuRadioGroup",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dialog",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dialogClose",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dialogContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dialogDescription",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dialogFooter",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dialogHeader",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dialogOverlay",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dialogPortal",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dialogTitle",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dialogTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "drawer",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "drawerPortal",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "drawerOverlay",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "drawerTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "drawerClose",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "drawerContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "drawerHeader",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "drawerFooter",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "drawerTitle",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "drawerDescription",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenu",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuPortal",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuGroup",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuLabel",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuCheckboxItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuRadioGroup",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuRadioItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuSeparator",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuShortcut",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuSub",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuSubTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "dropdownMenuSubContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "form",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "formItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "formLabel",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "formControl",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "formDescription",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "formMessage",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "formField",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "hoverCard",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "hoverCardTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "hoverCardContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "input",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "inputOTP",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "inputOTPGroup",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "inputOTPSlot",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "inputOTPSeparator",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "label",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubar",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarPortal",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarMenu",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarGroup",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarSeparator",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarLabel",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarShortcut",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarCheckboxItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarRadioGroup",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarRadioItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarSub",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarSubTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "menubarSubContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "navigationMenu",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "navigationMenuList",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "navigationMenuItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "navigationMenuContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "navigationMenuTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "navigationMenuLink",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "navigationMenuIndicator",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "navigationMenuViewport",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "navigationMenuTriggerStyle",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "pagination",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "paginationContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "paginationLink",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "paginationItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "paginationPrevious",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "paginationNext",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "paginationEllipsis",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "popover",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "popoverTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "popoverContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "popoverAnchor",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "progress",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "radioGroup",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "radioGroupItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "resizablePanelGroup",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "resizablePanel",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "resizableHandle",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "scrollArea",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "scrollBar",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "select",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "selectContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "selectGroup",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "selectItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "selectLabel",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "selectScrollDownButton",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "selectScrollUpButton",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "selectSeparator",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "selectTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "selectValue",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "separator",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sheet",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sheetTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sheetClose",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sheetContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sheetHeader",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sheetFooter",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sheetTitle",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sheetDescription",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebar",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarFooter",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarGroup",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarGroupAction",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarGroupContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarGroupLabel",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarHeader",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarInput",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarInset",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarMenu",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarMenuAction",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarMenuBadge",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarMenuButton",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarMenuItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarMenuSkeleton",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarMenuSub",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarMenuSubButton",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarMenuSubItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarProvider",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarRail",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarSeparator",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "sidebarTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "skeleton",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "slider",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "toaster",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "switch",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "table",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tableHeader",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tableBody",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tableFooter",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tableHead",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tableRow",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tableCell",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tableCaption",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tabs",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tabsList",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tabsTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tabsContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "textarea",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "toggle",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "toggleGroup",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "toggleGroupItem",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tooltip",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tooltipTrigger",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tooltipContent",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
        "tooltipProvider",
        [
            "(children: #seq<ReactElement>): ReactElement"
            "(props: list<IReactProperty>): ReactElement"
            "(text: string): ReactElement"
        ]
    ]
// apiReferences elements end

// apiReferences props begin
let apiReferencesProps: Map<string, string list> = Map [
    "accordion", [ "asChild: IReactProperty"; "type': accordionTypes.type' ()"; "value (value: string): IReactProperty"; "defaultValue (value: string): IReactProperty"; "onValueChange (value: string -> unit): IReactProperty"; "value (value: string seq): IReactProperty"; "defaultValue (value: string seq): IReactProperty"; "onValueChange (value: string -> unit): IReactProperty"; "collapsible (value: bool): IReactProperty"; "disabled (value: bool): IReactProperty"; "dir: directionType ()"; "orientation: orientationType ()" ]
    "accordionContent", [ "asChild: IReactProperty"; "forceMount (value: bool): IReactProperty" ]
    "accordionItem", [ "asChild: IReactProperty"; "disabled (value: bool): IReactProperty"; "value (value: string): IReactProperty" ]
    "accordionTrigger", [ "asChild: IReactProperty" ]
    "alert", [ "asChild: IReactProperty" ]
    "alertDescription", [ "asChild: IReactProperty" ]
    "alertTitle", [ "asChild: IReactProperty" ]
    "alertDialog", [ "defaultOpen (value: bool): IReactProperty"; "open' (value: bool): IReactProperty"; "onOpenChange (value: bool -> unit): IReactProperty" ]
    "alertDialogAction", [ "asChild: IReactProperty" ]
    "alertDialogCancel", [ "asChild: IReactProperty" ]
    "alertDialogContent", [ "asChild: IReactProperty"; "forceMount (value: bool): IReactProperty"; "onOpenAutoFocus (value: Event -> unit): IReactProperty"; "onCloseAutoFocus (value: Event -> unit): IReactProperty"; "onEscapeKeyDown (value: KeyboardEvent -> unit): IReactProperty" ]
    "alertDialogDescription", [ "asChild: IReactProperty" ]
    "alertDialogFooter", [ "asChild: IReactProperty" ]
    "alertDialogHeader", [ "asChild: IReactProperty" ]
    "alertDialogOverlay", [ "asChild: IReactProperty"; "forceMount (value: bool): IReactProperty" ]
    "alertDialogPortal", [ "forceMount (value: bool): IReactProperty"; "container (value: HTMLElement): IReactProperty" ]
    "alertDialogTitle", [ "asChild: IReactProperty" ]
    "alertDialogTrigger", [ "asChild: IReactProperty" ]
    "aspectRatio", [ "asChild: IReactProperty"; "ratio (value: int): IReactProperty"; "ratio (value: float)" ]
    "avatar", [ "asChild: IReactProperty" ]
    "avatarFallback", [ "asChild: IReactProperty"; "delayMs (value: int): IReactProperty"; "delayMs (value: float)" ]
    "avatarImage", [ "asChild: IReactProperty"; "onLoadingStatusChange (value: string -> unit): IReactProperty" ]
    "badge", [ "asChild: IReactProperty" ]
    "breadcrumb", [ "asChild: IReactProperty" ]
    "breadcrumbEllipsis", [ "asChild: IReactProperty" ]
    "breadcrumbItem", [ "asChild: IReactProperty" ]
    "breadcrumbLink", [ "asChild: IReactProperty" ]
    "breadcrumbList", [ "asChild: IReactProperty" ]
    "breadcrumbPage", [ "asChild: IReactProperty" ]
    "breadcrumbSeparator", [ "asChild: IReactProperty" ]
    "button", [ "asChild: IReactProperty" ]
    "calendar", [ "asChild: IReactProperty" ]
    "card", [ "asChild: IReactProperty" ]
    "cardAction", [ "asChild: IReactProperty" ]
    "cardContent", [ "asChild: IReactProperty" ]
    "cardDescription", [ "asChild: IReactProperty" ]
    "cardFooter", [ "asChild: IReactProperty" ]
    "cardHeader", [ "asChild: IReactProperty" ]
    "cardTitle", [ "asChild: IReactProperty" ]
    "carousel", [ "asChild: IReactProperty" ]
    "carouselContent", [ "asChild: IReactProperty" ]
    "carouselItem", [ "asChild: IReactProperty" ]
    "carouselNext", [ "asChild: IReactProperty" ]
    "carouselPrevious", [ "asChild: IReactProperty" ]
    "chartContainer", [ "asChild: IReactProperty" ]
    "checkbox", [ "asChild: IReactProperty"; "defaultChecked (value: bool option -> unit): IReactProperty"; "checked' (value: bool): IReactProperty"; "onCheckedChange (value: bool option -> unit): IReactProperty"; "disabled (value: bool): IReactProperty"; "required (value: bool): IReactProperty"; "name (value: string): IReactProperty"; "value (value: string): IReactProperty" ]
    "collapsible", [ "asChild: IReactProperty"; "defaultOpen (value: bool): IReactProperty"; "open' (value: bool): IReactProperty"; "onOpenChange (value: bool -> unit): IReactProperty"; "disabled (value: bool): IReactProperty" ]
    "collapsibleContent", [ "asChild: IReactProperty"; "forceMount (value: bool): IReactProperty" ]
    "collapsibleTrigger", [ "asChild: IReactProperty" ]
    "command", [ "asChild: IReactProperty" ]
    "commandDialog", [ "asChild: IReactProperty" ]
    "commandEmpty", [ "asChild: IReactProperty" ]
    "commandGroup", [ "asChild: IReactProperty" ]
    "commandInput", [ "asChild: IReactProperty" ]
    "commandItem", [ "asChild: IReactProperty" ]
    "commandList", [ "asChild: IReactProperty" ]
    "commandSeparator", [ "asChild: IReactProperty" ]
    "commandShortcut", [ "asChild: IReactProperty" ]
    "contextMenu", [ "dir: directionType ()"; "onOpenChange (value: bool -> unit): IReactProperty"; "modal (value: bool): IReactProperty" ]
    "contextMenuCheckboxItem", [ "asChild: IReactProperty"; "checked' (value: bool): IReactProperty"; "onCheckedChange (value: bool -> unit): IReactProperty"; "disabled (value: bool): IReactProperty"; "onSelect (value: Event -> unit): IReactProperty"; "textValue (value: string): IReactProperty" ]
    "contextMenuContent", [ "asChild: IReactProperty"; "loop (value: bool): IReactProperty"; "onCloseAutoFocus (value: Event -> unit): IReactProperty"; "onEscapeKeyDown (value: KeyboardEvent -> unit): IReactProperty"; "onPointerDownOutside (value: PointerEvent -> unit): IReactProperty"; "onFocusOutside (value: FocusEvent -> unit): IReactProperty"; "onInteractOutside (value: Event -> unit): IReactProperty"; "forceMount (value: bool): IReactProperty"; "alignOffset (value: int): IReactProperty"; "alignOffset (value: float)"; "avoidCollisions (value: bool): IReactProperty"; "collisionBoundary (value: HTMLElement): IReactProperty"; "collisionPadding (all: int): IReactProperty"; "sticky: stickyType ()"; "hideWhenDetached (value: bool): IReactProperty" ]
    "contextMenuGroup", [ "asChild: IReactProperty" ]
    "contextMenuItem", [ "asChild: IReactProperty"; "disabled (value: bool): IReactProperty"; "onSelect (value: Event -> unit): IReactProperty"; "textValue (value: string): IReactProperty" ]
    "contextMenuLabel", [ "asChild: IReactProperty" ]
    "contextMenuPortal", [ "forceMount (value: bool): IReactProperty"; "container (value: HTMLElement): IReactProperty" ]
    "contextMenuRadioGroup", [ "asChild: IReactProperty"; "value (value: string): IReactProperty"; "onValueChange (value: string -> unit): IReactProperty" ]
    "contextMenuRadioItem", [ "asChild: IReactProperty"; "value (value: string): IReactProperty"; "disabled (value: bool): IReactProperty"; "onSelect (value: Event -> unit): IReactProperty"; "textValue (value: string): IReactProperty" ]
    "contextMenuSeparator", [ "asChild: IReactProperty" ]
    "contextMenuShortcut", [ "asChild: IReactProperty" ]
    "contextMenuSub", [ "defaultOpen (value: bool): IReactProperty"; "open' (value: bool): IReactProperty"; "onOpenChange (value: bool -> unit): IReactProperty" ]
    "contextMenuSubContent", [ "asChild: IReactProperty"; "loop (value: bool): IReactProperty"; "onEscapeKeyDown (value: KeyboardEvent -> unit): IReactProperty"; "onPointerDownOutside (value: PointerEvent -> unit): IReactProperty"; "onFocusOutside (value: FocusEvent -> unit): IReactProperty"; "onInteractOutside (value: Event -> unit): IReactProperty"; "forceMount (value: bool): IReactProperty"; "sideOffset (value: int): IReactProperty"; "sideOffset (value: float)"; "alignOffset (value: int): IReactProperty"; "alignOffset (value: float)"; "avoidCollisions (value: bool): IReactProperty"; "collisionBoundary (value: HTMLElement): IReactProperty"; "collisionPadding (all: int): IReactProperty"; "arrowPadding (value: int): IReactProperty"; "arrowPadding (value: float)"; "sticky: stickyType ()"; "hideWhenDetached (value: bool): IReactProperty" ]
    "contextMenuSubTrigger", [ "asChild: IReactProperty"; "disabled (value: bool): IReactProperty"; "textValue (value: string): IReactProperty" ]
    "contextMenuTrigger", [ "asChild: IReactProperty"; "disabled (value: bool): IReactProperty" ]
    "dialog", [ "defaultOpen (value: bool): IReactProperty"; "open' (value: bool): IReactProperty"; "onOpenChange (value: bool -> unit): IReactProperty"; "modal (value: bool): IReactProperty" ]
    "dialogClose", [ "asChild: IReactProperty" ]
    "dialogContent", [ "asChild: IReactProperty"; "forceMount (value: bool): IReactProperty"; "onOpenAutoFocus (value: Event -> unit): IReactProperty"; "onCloseAutoFocus (value: Event -> unit): IReactProperty"; "onEscapeKeyDown (value: KeyboardEvent -> unit): IReactProperty"; "onPointerDownOutside (value: PointerEvent -> unit): IReactProperty"; "onInteractOutside (value: Event -> unit): IReactProperty" ]
    "dialogDescription", [ "asChild: IReactProperty" ]
    "dialogFooter", [ "asChild: IReactProperty" ]
    "dialogHeader", [ "asChild: IReactProperty" ]
    "dialogOverlay", [ "asChild: IReactProperty"; "forceMount (value: bool): IReactProperty" ]
    "dialogPortal", [ "forceMount (value: bool): IReactProperty"; "container (value: HTMLElement): IReactProperty" ]
    "dialogTitle", [ "asChild: IReactProperty" ]
    "dialogTrigger", [ "asChild: IReactProperty" ]
    "drawer", [ "asChild: IReactProperty" ]
    "drawerClose", [ "asChild: IReactProperty" ]
    "drawerContent", [ "asChild: IReactProperty" ]
    "drawerDescription", [ "asChild: IReactProperty" ]
    "drawerFooter", [ "asChild: IReactProperty" ]
    "drawerHeader", [ "asChild: IReactProperty" ]
    "drawerOverlay", [ "asChild: IReactProperty" ]
    "drawerPortal", [ "asChild: IReactProperty" ]
    "drawerTitle", [ "asChild: IReactProperty" ]
    "drawerTrigger", [ "asChild: IReactProperty" ]
    "dropdownMenu", [ "defaultOpen (value: bool): IReactProperty"; "open' (value: bool): IReactProperty"; "onOpenChange (value: bool -> unit): IReactProperty"; "modal (value: bool): IReactProperty"; "dir: directionType ()" ]
    "dropdownMenuCheckboxItem", [ "asChild: IReactProperty"; "checked' (value: bool): IReactProperty"; "onCheckedChange (value: bool -> unit): IReactProperty"; "disabled (value: bool): IReactProperty"; "onSelect (value: Event -> unit): IReactProperty"; "textValue (value: string): IReactProperty" ]
    "dropdownMenuContent", [ "asChild: IReactProperty"; "loop (value: bool): IReactProperty"; "onCloseAutoFocus (value: Event -> unit): IReactProperty"; "onEscapeKeyDown (value: KeyboardEvent -> unit): IReactProperty"; "onPointerDownOutside (value: PointerEvent -> unit): IReactProperty"; "onFocusOutside (value: FocusEvent -> unit): IReactProperty"; "onInteractOutside (value: Event -> unit): IReactProperty"; "forceMount (value: bool): IReactProperty"; "side: sideType ()"; "sideOffset (value: int): IReactProperty"; "sideOffset (value: float)"; "align: alignType ()"; "alignOffset (value: int): IReactProperty"; "alignOffset (value: float)"; "avoidCollisions (value: bool): IReactProperty"; "collisionBoundary (value: HTMLElement): IReactProperty"; "collisionPadding (all: int): IReactProperty"; "arrowPadding (value: int): IReactProperty"; "arrowPadding (value: float)"; "sticky: stickyType ()"; "hideWhenDetached (value: bool): IReactProperty" ]
    "dropdownMenuGroup", [ "asChild: IReactProperty" ]
    "dropdownMenuItem", [ "asChild: IReactProperty"; "disabled (value: bool): IReactProperty"; "onSelect (value: Event -> unit): IReactProperty"; "textValue (value: string): IReactProperty" ]
    "dropdownMenuLabel", [ "asChild: IReactProperty" ]
    "dropdownMenuPortal", [ "forceMount (value: bool): IReactProperty"; "container (value: HTMLElement): IReactProperty" ]
    "dropdownMenuRadioGroup", [ "asChild: IReactProperty"; "value (value: string): IReactProperty"; "onValueChange (value: string -> unit): IReactProperty" ]
    "dropdownMenuRadioItem", [ "asChild: IReactProperty"; "value (value: string): IReactProperty"; "disabled (value: bool): IReactProperty"; "onSelect (value: Event -> unit): IReactProperty"; "textValue (value: string): IReactProperty" ]
    "dropdownMenuSeparator", [ "asChild: IReactProperty" ]
    "dropdownMenuShortcut", [ "asChild: IReactProperty" ]
    "dropdownMenuSub", [ "defaultOpen (value: bool): IReactProperty"; "open' (value: bool): IReactProperty"; "onOpenChange (value: bool -> unit): IReactProperty" ]
    "dropdownMenuSubContent", [ "asChild: IReactProperty"; "loop (value: bool): IReactProperty"; "onEscapeKeyDown (value: KeyboardEvent -> unit): IReactProperty"; "onPointerDownOutside (value: PointerEvent -> unit): IReactProperty"; "onFocusOutside (value: FocusEvent -> unit): IReactProperty"; "onInteractOutside (value: Event -> unit): IReactProperty"; "forceMount (value: bool): IReactProperty"; "sideOffset (value: int): IReactProperty"; "sideOffset (value: float)"; "alignOffset (value: int): IReactProperty"; "alignOffset (value: float)"; "avoidCollisions (value: bool): IReactProperty"; "collisionBoundary (value: HTMLElement): IReactProperty"; "collisionPadding (all: int): IReactProperty"; "arrowPadding (value: int): IReactProperty"; "arrowPadding (value: float)"; "sticky: stickyType ()"; "hideWhenDetached (value: bool): IReactProperty" ]
    "dropdownMenuSubTrigger", [ "asChild: IReactProperty"; "disabled (value: bool): IReactProperty"; "textValue (value: string): IReactProperty" ]
    "dropdownMenuTrigger", [ "asChild: IReactProperty" ]
    "form", [ "asChild: IReactProperty"; "onClearServerErrors (value: unit -> unit): IReactProperty" ]
    "hoverCard", [ "defaultOpen (value: bool): IReactProperty"; "open' (value: bool): IReactProperty"; "onOpenChange (value: bool -> unit): IReactProperty"; "open'Delay (value: int): IReactProperty"; "open'Delay (value: float)"; "closeDelay (value: int): IReactProperty"; "closeDelay (value: float)" ]
    "hoverCardContent", [ "asChild: IReactProperty"; "forceMount (value: bool): IReactProperty"; "side: sideType ()"; "sideOffset (value: int): IReactProperty"; "sideOffset (value: float)"; "align: alignType ()"; "alignOffset (value: int): IReactProperty"; "alignOffset (value: float)"; "avoidCollisions (value: bool): IReactProperty"; "collisionBoundary (value: HTMLElement): IReactProperty"; "collisionPadding (all: int): IReactProperty"; "arrowPadding (value: int): IReactProperty"; "arrowPadding (value: float)"; "sticky: stickyType ()"; "hideWhenDetached (value: bool): IReactProperty" ]
    "hoverCardTrigger", [ "asChild: IReactProperty" ]
    "input", [ "asChild: IReactProperty" ]
    "inputOTP", [ "asChild: IReactProperty" ]
    "inputOTPGroup", [ "asChild: IReactProperty" ]
    "inputOTPSeparator", [ "asChild: IReactProperty" ]
    "inputOTPSlot", [ "asChild: IReactProperty" ]
    "label", [ "asChild: IReactProperty"; "htmlFor (value: string): IReactProperty" ]
    "menubar", [ "asChild: IReactProperty"; "defaultValue (value: string): IReactProperty"; "value (value: string): IReactProperty"; "onValueChange (value: int list -> unit): IReactProperty"; "onValueChange (value: float list -> unit): IReactProperty"; "dir: directionType ()"; "loop (value: bool): IReactProperty" ]
    "menubarCheckboxItem", [ "asChild: IReactProperty"; "checked' (value: bool): IReactProperty"; "onCheckedChange (value: bool -> unit): IReactProperty"; "disabled (value: bool): IReactProperty"; "onSelect (value: Event -> unit): IReactProperty"; "textValue (value: string): IReactProperty" ]
    "menubarContent", [ "asChild: IReactProperty"; "loop (value: bool): IReactProperty"; "onCloseAutoFocus (value: Event -> unit): IReactProperty"; "onEscapeKeyDown (value: KeyboardEvent -> unit): IReactProperty"; "onPointerDownOutside (value: PointerEvent -> unit): IReactProperty"; "onFocusOutside (value: FocusEvent -> unit): IReactProperty"; "onInteractOutside (value: Event -> unit): IReactProperty"; "forceMount (value: bool): IReactProperty"; "side: sideType ()"; "sideOffset (value: int): IReactProperty"; "sideOffset (value: float)"; "align: alignType ()"; "alignOffset (value: int): IReactProperty"; "alignOffset (value: float)"; "avoidCollisions (value: bool): IReactProperty"; "collisionBoundary (value: HTMLElement): IReactProperty"; "collisionPadding (all: int): IReactProperty"; "arrowPadding (value: int): IReactProperty"; "arrowPadding (value: float)"; "sticky: stickyType ()"; "hideWhenDetached (value: bool): IReactProperty" ]
    "menubarGroup", [ "asChild: IReactProperty" ]
    "menubarItem", [ "asChild: IReactProperty"; "disabled (value: bool): IReactProperty"; "onSelect (value: Event -> unit): IReactProperty"; "textValue (value: string): IReactProperty" ]
    "menubarLabel", [ "asChild: IReactProperty" ]
    "menubarMenu", [ "asChild: IReactProperty"; "value (value: string): IReactProperty" ]
    "menubarPortal", [ "forceMount (value: bool): IReactProperty"; "container (value: HTMLElement): IReactProperty" ]
    "menubarRadioGroup", [ "asChild: IReactProperty"; "value (value: string): IReactProperty"; "onValueChange (value: string -> unit): IReactProperty" ]
    "menubarRadioItem", [ "asChild: IReactProperty"; "value (value: string): IReactProperty"; "disabled (value: bool): IReactProperty"; "onSelect (value: Event -> unit): IReactProperty"; "textValue (value: string): IReactProperty" ]
    "menubarSeparator", [ "asChild: IReactProperty" ]
    "menubarShortcut", [ "asChild: IReactProperty" ]
    "menubarSub", [ "defaultOpen (value: bool): IReactProperty"; "open' (value: bool): IReactProperty"; "onOpenChange (value: bool -> unit): IReactProperty" ]
    "menubarSubContent", [ "asChild: IReactProperty"; "loop (value: bool): IReactProperty"; "onEscapeKeyDown (value: KeyboardEvent -> unit): IReactProperty"; "onPointerDownOutside (value: PointerEvent -> unit): IReactProperty"; "onFocusOutside (value: FocusEvent -> unit): IReactProperty"; "onInteractOutside (value: Event -> unit): IReactProperty"; "forceMount (value: bool): IReactProperty"; "sideOffset (value: int): IReactProperty"; "sideOffset (value: float)"; "alignOffset (value: int): IReactProperty"; "alignOffset (value: float)"; "avoidCollisions (value: bool): IReactProperty"; "collisionBoundary (value: HTMLElement): IReactProperty"; "collisionPadding (all: int): IReactProperty"; "arrowPadding (value: int): IReactProperty"; "arrowPadding (value: float)"; "sticky: stickyType ()"; "hideWhenDetached (value: bool): IReactProperty" ]
    "menubarSubTrigger", [ "asChild: IReactProperty"; "disabled (value: bool): IReactProperty"; "textValue (value: string): IReactProperty" ]
    "menubarTrigger", [ "asChild: IReactProperty" ]
    "navigationMenu", [ "defaultValue (value: string): IReactProperty"; "value (value: string): IReactProperty"; "onValueChange (value: int list -> unit): IReactProperty"; "onValueChange (value: float list -> unit): IReactProperty"; "delayDuration (value: int): IReactProperty"; "delayDuration (value: float)"; "skipDelayDuration (value: int): IReactProperty"; "skipDelayDuration (value: float)"; "dir: directionType ()"; "orientation: orientationType ()" ]
    "navigationMenuContent", [ "asChild: IReactProperty"; "onEscapeKeyDown (value: KeyboardEvent -> unit): IReactProperty"; "onPointerDownOutside (value: PointerEvent -> unit): IReactProperty"; "onFocusOutside (value: FocusEvent -> unit): IReactProperty"; "onInteractOutside (value: Event -> unit): IReactProperty"; "forceMount (value: bool): IReactProperty" ]
    "navigationMenuIndicator", [ "asChild: IReactProperty"; "forceMount (value: bool): IReactProperty" ]
    "navigationMenuItem", [ "asChild: IReactProperty"; "value (value: string): IReactProperty" ]
    "navigationMenuLink", [ "asChild: IReactProperty"; "active (value: bool): IReactProperty"; "onSelect (value: Event -> unit): IReactProperty" ]
    "navigationMenuList", [ "asChild: IReactProperty" ]
    "navigationMenuTrigger", [ "asChild: IReactProperty" ]
    "navigationMenuViewport", [ "asChild: IReactProperty"; "forceMount (value: bool): IReactProperty" ]
    "pagination", [ "asChild: IReactProperty" ]
    "paginationContent", [ "asChild: IReactProperty" ]
    "paginationEllipsis", [ "asChild: IReactProperty" ]
    "paginationItem", [ "asChild: IReactProperty" ]
    "paginationLink", [ "asChild: IReactProperty" ]
    "paginationNext", [ "asChild: IReactProperty" ]
    "paginationPrevious", [ "asChild: IReactProperty" ]
    "popover", [ "defaultOpen (value: bool): IReactProperty"; "open' (value: bool): IReactProperty"; "onOpenChange (value: bool -> unit): IReactProperty"; "modal (value: bool): IReactProperty" ]
    "popoverAnchor", [ "asChild: IReactProperty" ]
    "popoverContent", [ "asChild: IReactProperty"; "onOpenAutoFocus (value: Event -> unit): IReactProperty"; "onCloseAutoFocus (value: Event -> unit): IReactProperty"; "onEscapeKeyDown (value: KeyboardEvent -> unit): IReactProperty"; "onPointerDownOutside (value: PointerEvent -> unit): IReactProperty"; "onFocusOutside (value: FocusEvent -> unit): IReactProperty"; "onInteractOutside (value: Event -> unit): IReactProperty"; "forceMount (value: bool): IReactProperty"; "side: sideType ()"; "sideOffset (value: int): IReactProperty"; "sideOffset (value: float)"; "align: alignType ()"; "alignOffset (value: int): IReactProperty"; "alignOffset (value: float)"; "avoidCollisions (value: bool): IReactProperty"; "collisionBoundary (value: HTMLElement): IReactProperty"; "collisionPadding (all: int): IReactProperty"; "arrowPadding (value: int): IReactProperty"; "arrowPadding (value: float)"; "sticky: stickyType ()"; "hideWhenDetached (value: bool): IReactProperty" ]
    "popoverTrigger", [ "asChild: IReactProperty" ]
    "progress", [ "asChild: IReactProperty"; "value (value: int option): IReactProperty"; "value (value: float option): IReactProperty"; "max (value: int): IReactProperty"; "max (value: float)"; "getValueLabel (value: int -> int -> string): IReactProperty" ]
    "radioGroup", [ "asChild: IReactProperty"; "defaultValue (value: string): IReactProperty"; "value (value: string): IReactProperty"; "onValueChange (value: int list -> unit): IReactProperty"; "onValueChange (value: float list -> unit): IReactProperty"; "disabled (value: bool): IReactProperty"; "name (value: string): IReactProperty"; "required (value: bool): IReactProperty"; "orientation: orientationType ()"; "dir: directionType ()"; "loop (value: bool): IReactProperty" ]
    "radioGroupItem", [ "asChild: IReactProperty"; "value (value: string): IReactProperty"; "disabled (value: bool): IReactProperty"; "required (value: bool): IReactProperty" ]
    "resizablePanelGroup", [ "asChild: IReactProperty" ]
    "scrollArea", [ "asChild: IReactProperty"; "type': scrollAreaTypes.type' ()"; "scrollHideDelay (value: int): IReactProperty"; "scrollHideDelay (value: float)"; "dir: directionType ()"; "nonce (value: string): IReactProperty" ]
    "select", [ "defaultValue (value: string): IReactProperty"; "value (value: string): IReactProperty"; "onValueChange (value: string -> unit): IReactProperty"; "defaultOpen (value: bool): IReactProperty"; "open' (value: bool): IReactProperty"; "onOpenChange (value: bool -> unit): IReactProperty"; "dir: directionType ()"; "name (value: string): IReactProperty"; "disabled (value: bool): IReactProperty"; "required (value: bool): IReactProperty" ]
    "selectContent", [ "asChild: IReactProperty"; "onCloseAutoFocus (value: Event -> unit): IReactProperty"; "onEscapeKeyDown (value: KeyboardEvent -> unit): IReactProperty"; "onPointerDownOutside (value: PointerEvent -> unit): IReactProperty"; "position: selectContentTypes.position ()"; "side: sideType ()"; "sideOffset (value: int): IReactProperty"; "sideOffset (value: float)"; "align: alignType ()"; "alignOffset (value: int): IReactProperty"; "alignOffset (value: float)"; "avoidCollisions (value: bool): IReactProperty"; "collisionBoundary (value: HTMLElement): IReactProperty"; "collisionPadding (all: int): IReactProperty"; "arrowPadding (value: int): IReactProperty"; "arrowPadding (value: float)"; "sticky: stickyType ()"; "hideWhenDetached (value: bool): IReactProperty" ]
    "selectGroup", [ "asChild: IReactProperty" ]
    "selectItem", [ "asChild: IReactProperty"; "value (value: string): IReactProperty"; "disabled (value: bool): IReactProperty"; "textValue (value: string): IReactProperty" ]
    "selectLabel", [ "asChild: IReactProperty" ]
    "selectScrollDownButton", [ "asChild: IReactProperty" ]
    "selectScrollUpButton", [ "asChild: IReactProperty" ]
    "selectSeparator", [ "asChild: IReactProperty" ]
    "selectTrigger", [ "asChild: IReactProperty" ]
    "selectValue", [ "asChild: IReactProperty"; "placeholder (value: ReactElement): IReactProperty" ]
    "separator", [ "asChild: IReactProperty"; "orientation: orientationType ()"; "decorative (value: bool): IReactProperty" ]
    "sheet", [ "asChild: IReactProperty" ]
    "sheetClose", [ "asChild: IReactProperty" ]
    "sheetContent", [ "asChild: IReactProperty" ]
    "sheetDescription", [ "asChild: IReactProperty" ]
    "sheetFooter", [ "asChild: IReactProperty" ]
    "sheetHeader", [ "asChild: IReactProperty" ]
    "sheetTitle", [ "asChild: IReactProperty" ]
    "sheetTrigger", [ "asChild: IReactProperty" ]
    "sidebar", [ "asChild: IReactProperty" ]
    "sidebarContent", [ "asChild: IReactProperty" ]
    "sidebarFooter", [ "asChild: IReactProperty" ]
    "sidebarGroup", [ "asChild: IReactProperty" ]
    "sidebarGroupAction", [ "asChild: IReactProperty" ]
    "sidebarGroupContent", [ "asChild: IReactProperty" ]
    "sidebarGroupLabel", [ "asChild: IReactProperty" ]
    "sidebarHeader", [ "asChild: IReactProperty" ]
    "sidebarInput", [ "asChild: IReactProperty" ]
    "sidebarInset", [ "asChild: IReactProperty" ]
    "sidebarMenu", [ "asChild: IReactProperty" ]
    "sidebarMenuAction", [ "asChild: IReactProperty" ]
    "sidebarMenuBadge", [ "asChild: IReactProperty" ]
    "sidebarMenuButton", [ "asChild: IReactProperty" ]
    "sidebarMenuItem", [ "asChild: IReactProperty" ]
    "sidebarMenuSkeleton", [ "asChild: IReactProperty" ]
    "sidebarMenuSub", [ "asChild: IReactProperty" ]
    "sidebarMenuSubButton", [ "asChild: IReactProperty" ]
    "sidebarMenuSubItem", [ "asChild: IReactProperty" ]
    "sidebarProvider", [ "asChild: IReactProperty" ]
    "sidebarRail", [ "asChild: IReactProperty" ]
    "sidebarSeparator", [ "asChild: IReactProperty" ]
    "sidebarTrigger", [ "asChild: IReactProperty" ]
    "skeleton", [ "asChild: IReactProperty" ]
    "slider", [ "asChild: IReactProperty"; "defaultValue (value: int list): IReactProperty: IReactProperty"; "defaultValue (value: float list): IReactProperty"; "value (value: int list): IReactProperty: IReactProperty"; "value (value: float list): IReactProperty"; "onValueChange (value: int list -> unit): IReactProperty"; "onValueChange (value: float list -> unit): IReactProperty"; "onValueCommit (value: int list -> unit): IReactProperty"; "onValueCommit (value: float list -> unit): IReactProperty"; "name (value: string): IReactProperty"; "disabled (value: bool): IReactProperty"; "orientation: orientationType ()"; "dir: directionType ()"; "inverted (value: bool): IReactProperty"; "min (value: int): IReactProperty"; "min (value: float)"; "max (value: int): IReactProperty"; "max (value: float)"; "step (value: int): IReactProperty"; "step (value: float)"; "minStepsBetweenThumbs (value: int): IReactProperty"; "minStepsBetweenThumbs (value: float)"; "form (value: string): IReactProperty" ]
    "toaster", [ "asChild: IReactProperty" ]
    "switch", [ "asChild: IReactProperty"; "defaultChecked (value: bool): IReactProperty"; "checked' (value: bool): IReactProperty"; "onCheckedChange (value: bool -> unit): IReactProperty"; "disabled (value: bool): IReactProperty"; "required (value: bool): IReactProperty"; "name (value: string): IReactProperty"; "value (value: string): IReactProperty" ]
    "table", [ "asChild: IReactProperty" ]
    "tableBody", [ "asChild: IReactProperty" ]
    "tableCaption", [ "asChild: IReactProperty" ]
    "tableCell", [ "asChild: IReactProperty" ]
    "tableFooter", [ "asChild: IReactProperty" ]
    "tableHead", [ "asChild: IReactProperty" ]
    "tableHeader", [ "asChild: IReactProperty" ]
    "tableRow", [ "asChild: IReactProperty" ]
    "tabs", [ "asChild: IReactProperty"; "defaultValue (value: string): IReactProperty"; "value (value: string): IReactProperty"; "onValueChange (value: string -> unit): IReactProperty"; "orientation: orientationType ()"; "dir: directionType ()"; "activationMode: tabsTypes.activationMode ()" ]
    "tabsContent", [ "asChild: IReactProperty"; "value (value: string): IReactProperty"; "forceMount (value: bool): IReactProperty" ]
    "tabsList", [ "asChild: IReactProperty"; "loop (value: bool): IReactProperty" ]
    "tabsTrigger", [ "asChild: IReactProperty"; "value (value: string): IReactProperty"; "disabled (value: bool): IReactProperty" ]
    "textarea", [ "asChild: IReactProperty" ]
    "toggle", [ "asChild: IReactProperty"; "defaultPressed (value: bool): IReactProperty"; "pressed (value: bool): IReactProperty"; "onPressedChange (value: bool -> unit): IReactProperty"; "disabled (value: bool): IReactProperty" ]
    "toggleGroup", [ "asChild: IReactProperty"; "type': toggleGroupTypes.type' ()"; "value (value: string): IReactProperty"; "defaultValue (value: string): IReactProperty"; "onValueChange (value: string -> unit): IReactProperty"; "value (value: string seq): IReactProperty"; "defaultValue (value: string seq): IReactProperty"; "onValueChange (value: string -> unit): IReactProperty"; "disabled (value: bool): IReactProperty"; "rovingFocus (value: bool): IReactProperty"; "orientation: orientationType ()"; "dir: directionType ()"; "loop (value: bool): IReactProperty" ]
    "toggleGroupItem", [ "asChild: IReactProperty"; "value (value: string): IReactProperty"; "disabled (value: bool): IReactProperty" ]
    "tooltip", [ "defaultOpen (value: bool): IReactProperty"; "open' (value: bool): IReactProperty"; "onOpenChange (value: bool -> unit): IReactProperty"; "delayDuration (value: int): IReactProperty"; "delayDuration (value: float)"; "disableHoverableContent (value: bool): IReactProperty" ]
    "tooltipContent", [ "asChild: IReactProperty"; "arialabel (value: string): IReactProperty"; "onEscapeKeyDown (value: KeyboardEvent -> unit): IReactProperty"; "onPointerDownOutside (value: PointerEvent -> unit): IReactProperty"; "forceMount (value: bool): IReactProperty"; "side: sideType ()"; "sideOffset (value: int): IReactProperty"; "sideOffset (value: float)"; "align: alignType ()"; "alignOffset (value: int): IReactProperty"; "alignOffset (value: float)"; "avoidCollisions (value: bool): IReactProperty"; "collisionBoundary (value: HTMLElement): IReactProperty"; "collisionPadding (all: int): IReactProperty"; "arrowPadding (value: int): IReactProperty"; "arrowPadding (value: float)"; "sticky: stickyType ()"; "hideWhenDetached (value: bool): IReactProperty" ]
    "tooltipProvider", [ "delayDuration (value: int): IReactProperty"; "delayDuration (value: float)"; "skipDelayDuration (value: int): IReactProperty"; "skipDelayDuration (value: float)"; "disableHoverableContent (value: bool): IReactProperty" ]
    "tooltipTrigger", [ "asChild: IReactProperty" ]
]
// apiReferences props end

// Not auto generated props
let propsFromPropsFs: Map<string, string list> =
    Map [
        "alert", [ "variant: alertTypes.variant ()" ]
        "badge", [ "variant: badgeTypes.variant ()" ]
        "button", [ "variant: buttonTypes.variant ()"; "size: buttonTypes.size ()" ]
        "calendar",
        [
            "mode: calendarTypes.mode ()"
            "selected (value: DateTime): IReactProperty"
            "selected (value: DateTime option): IReactProperty"
            "onSelect (f: DateTime -> unit): IReactProperty"
            "onSelect (f: DateTime option -> unit): IReactProperty"
            "required (value: bool): IReactProperty"
            "max (value: int): IReactProperty"
            "min (value: int): IReactProperty"
            "selected (value: #seq<DateTime>): IReactProperty"
            "onSelect (f: #seq<DateTime> -> unit): IReactProperty"
            "disabled (value: bool): IReactProperty"
            "disabled (matcher: DateTime -> bool): IReactProperty"
            "disabled (date: DateTime): IReactProperty"
            "disabled (dates: DateTime seq): IReactProperty"
            "excludeDisabled (value: bool): IReactProperty"
            "selected (value: DateRange): IReactProperty"
            "onSelect (f: DateRange -> unit): IReactProperty"
            "defaultMonth (value: DateTime): IReactProperty"
            "month (value: DateTime): IReactProperty"
            "numberOfMonths (value: int): IReactProperty"
            "startMonth (value: DateTime): IReactProperty"
            "endMonth (value: DateTime): IReactProperty"
            "pagedNavigation (value: bool): IReactProperty"
            "reverseMonths (value: bool): IReactProperty"
            "hideNavigation (value: bool): IReactProperty"
            "disableNavigation (value: bool): IReactProperty"
            "captionLayout: calendarTypes.captionLayout()"
            "fixedWeeks (value: bool): IReactProperty"
            "hideWeekdays (value: bool): IReactProperty"
            "showOutsideDays (value: bool): IReactProperty"
            "showWeekNumber (value: bool): IReactProperty"
            "animate (value: bool): IReactProperty"
            "broadcastCalendar (value: bool): IReactProperty"
            "ISOWeek (value: bool): IReactProperty"
            "timeZone (value: string): IReactProperty"
            "footer (value: ReactElement): IReactProperty"
            "footer (value: string): IReactProperty"
            "autoFocus (value: bool): IReactProperty"
            "hidden (value: obj): IReactProperty"
            "today (value: DateTime): IReactProperty"
            "modifiers (value: obj): IReactProperty"
            "dir: calendarTypes.dir()"
            "ariaLabel (value: string): IReactProperty"
            "role (value: string): IReactProperty"
            "nonce (value: string): IReactProperty"
            "title (value: string): IReactProperty"
            "lang (value: string): IReactProperty"
            "locale (value: obj): IReactProperty"
            "weekStartsOn (value: int): IReactProperty"
            "firstWeekContainsDate (value: int): IReactProperty"
            "useAdditionalWeekYearTokens (value: bool): IReactProperty"
            "useAdditionalDayOfYearTokens (value: bool): IReactProperty"
            "onMonthChange (handler: obj -> unit): IReactProperty"
            "onNextClick (handler: obj -> unit): IReactProperty"
            "onPrevClick (handler: obj -> unit): IReactProperty"
            "onDayClick (handler: obj -> unit): IReactProperty"
            "onDayFocus (handler: obj -> unit): IReactProperty"
            "onDayBlur (handler: obj -> unit): IReactProperty"
            "onDayKeyDown (handler: obj -> unit): IReactProperty"
            "onDayMouseEnter (handler: obj -> unit): IReactProperty"
            "onDayMouseLeave (handler: obj -> unit): IReactProperty"
        ]
        "sheet", [ "side: sheetTypes.side ()" ]
        "sidebar", [ "variant: sidebarTypes.variant ()"; "size: sidebarTypes.size ()" ]
        "toggle", [ "variant: toggleTypes.variant ()"; "size: toggleTypes.size ()" ]
        "resizablePanelGroup",
        [
            "autoSaveId (value: string): IReactProperty"
            "direction: resizablePanelGroupTypes.direction ()"
            "onLayout (value: int [] -> unit): IReactProperty"
            "tagName (value: string): IReactProperty"
        ]
        "resizablePanel",
        [
            "collapsedSize (value: int): IReactProperty"
            "collapsible (value: bool): IReactProperty"
            "defaultSize (value: int): IReactProperty"
            "maxSize (value: int): IReactProperty"
            "minSize (value: int): IReactProperty"
            "onCollapse (value: unit -> unit): IReactProperty"
            "onExpand (value: unit -> unit): IReactProperty"
            "onResize (value: int -> unit): IReactProperty"
            "order (value: int): IReactProperty"
            "tagName (value: string): IReactProperty"
        ]
        "resizableHandle",
        [
            "hitAreaMargins (coarse: int, fine: int): IReactProperty"
            "onDragging (value: bool -> unit): IReactProperty"
            "tagName (value: string): IReactProperty"
        ]
        "commandItem",
        [
            "disabled (value: bool): IReactProperty"
            "onSelect (handler: string -> unit): IReactProperty"
            "value (value: string): IReactProperty"
            "keywords (values: string[]): IReactProperty"
            "keywords (values: string seq): IReactProperty"
            "forceMount (value: bool): IReactProperty"
            "asChild: IReactProperty"
        ]
        "commandGroup",
        [
            "heading (value: ReactElement): IReactProperty"
            "heading (value: string): IReactProperty"
            "value (value: string): IReactProperty"
            "forceMount (value: bool): IReactProperty"
            "asChild: IReactProperty"
        ]
        "commandSeparator", [ "alwaysRender (value: bool): IReactProperty"; "asChild: IReactProperty" ]
        "commandInput",
        [
            "value (value: string): IReactProperty"
            "onValueChange (handler: string -> unit): IReactProperty"
            "asChild: IReactProperty"
        ]
        "commandList", [ "label (value: string): IReactProperty"; "asChild: IReactProperty" ]
        "commandDialog",
        [
            "label (value: string): IReactProperty"
            "shouldFilter (value: bool): IReactProperty"
            "filter (value: obj): IReactProperty"
            "defaultValue (value: string): IReactProperty"
            "value (value: string): IReactProperty"
            "onValueChange (handler: string -> unit): IReactProperty"
            "loop (value: bool): IReactProperty"
            "disablePointerSelection (value: bool): IReactProperty"
            "vimBindings (value: bool): IReactProperty"
            "overlayClassName (value: string): IReactProperty"
            "contentClassName (value: string): IReactProperty"
            "open' (value: bool): IReactProperty"
            "onOpenChange (handler: bool -> unit): IReactProperty"
            "asChild: IReactProperty"
        ]
        "commandEmpty", [ "asChild: IReactProperty" ]
        "contextMenuItem", [ "inset: IReactProperty"; "variant: contextMenuItemTypes.variant ()" ]
        "contextMenuSubTrigger", [ "inset: IReactProperty" ]
        "contextMenuLabel", [ "inset: IReactProperty" ]
        "menubarItem", [ "inset: IReactProperty"; "variant: contextMenuItemTypes.variant ()" ]
        "paginationLink", [ "isActive (value: bool): IReactProperty"; "size: buttonTypes.size ()" ]
        "sidebarMenuButton",
        [
            "isActive (value: bool): IReactProperty"
            "variant: sidebarMenuButtonTypes.variant ()"
            "size: sidebarMenuButtonTypes.size ()"
            "tooltip (value: string): IReactProperty"
            "tooltip (value: ReactElement): IReactProperty"
        ]
        "inputOTP", [ "containerClassName (value: string): IReactProperty" ]
        "inputOTPSlot", [ "index (value: int): IReactProperty"; "index (value: float): IReactProperty" ]
    ]

let getAllApiReferencesProps () : Map<string, string list> =
    Set apiReferencesProps.Keys
    |> Set.union (Set propsFromPropsFs.Keys)
    |> Set.fold
        (fun state key ->
            let props1 = apiReferencesProps |> Map.tryFind key |> Option.defaultValue []
            let props2 = propsFromPropsFs |> Map.tryFind key |> Option.defaultValue []
            let props = props1 @ props2 |> List.distinct |> List.sort
            state |> Map.add key props)
        (Map [])

let apiReference (name: string) =
    let allProps = getAllApiReferencesProps ()

    Html.div [
        prop.className "flex flex-col gap-6"
        prop.children (
            apiReferencesElements
            |> Map.filter (fun x _ -> x.ToLowerInvariant().StartsWith(name.Replace("-", "").ToLowerInvariant()))
            |> Map.toList
            |> List.sortBy fst
            |> List.map (fun (x, types) ->
                Html.div [
                    prop.className "flex flex-col gap-3 max-w-3xl"
                    prop.children [
                        Shadcn.separator []

                        UI.Header3 $"Shadcn.%s{x}"
                        for type' in types do
                            Shadcn.badge [
                                badge.variant.secondary
                                prop.children [
                                    Html.span [ prop.className "font-mono"; prop.text $"Shadcn.%s{x} %s{type'}" ]
                                ]
                            ]
                        Html.span [ prop.className "font-bold"; prop.text "Properties" ]
                        let props =
                            allProps
                            |> Map.tryPick (fun name props -> if x = name then Some props else None)
                            |> Option.defaultValue []
                            |> List.sort

                        for name in props do
                            Html.div [
                                Shadcn.badge [
                                    badge.variant.secondary
                                    prop.children [
                                        Html.span [ prop.className "font-mono"; prop.text $"%s{x}.%s{name}" ]
                                    ]
                                ]
                            ]
                    ]
                ])
        )
    ]

let group (name: string) (comp: Component) =
    Html.div [
        prop.className "flex flex-col gap-6"
        prop.children [
            UI.Header1 comp.Title
            Html.div [ prop.text comp.Description ]
            Shadcn.badge [
                badge.variant.secondary
                prop.children [
                    Html.a [
                        prop.className "flex gap-2 items-center font-semibold"
                        prop.href $"https://ui.shadcn.com/docs/components/%s{name}"
                        prop.children [ Html.text "Shadcn/ui Docs"; Lucide.SquareArrowOutUpRight [ svg.size 14 ] ]
                    ]
                ]
            ]
            comp.Constructor()
            UI.Header2 "API Reference"
            Html.div "Namespace: Feliz.Shadcn"
            apiReference name
        ]
    ]

[<ReactComponent>]
let AllDemos (name: string, dispatch) =
    Html.div [
        Html.header [
            prop.className "fixed top-0 z-50 w-full bg-white/80 backdrop-blur-sm border-b dark:bg-gray-950/80"
            prop.children [
                Html.div [
                    prop.className "container flex h-16 items-center px-4 md:px-6"
                    prop.children [
                        Html.span [ prop.className "text-lg font-bold"; prop.text "Feliz.Shadcn" ]
                        Html.span [
                            prop.className "text-md ml-1"
                            prop.text "- shadncn/ui components for F#/Fable"
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
                                    Shadcn.sidebarGroupLabel "Components"
                                    Shadcn.sidebarGroupContent [
                                        Shadcn.sidebarMenu [
                                            for KeyValue(name', { Title = title }) in components do
                                                Shadcn.sidebarMenuItem [
                                                    prop.key name'
                                                    prop.children [
                                                        Shadcn.sidebarMenuButton [
                                                            sidebarMenuButton.asChild
                                                            sidebarMenuButton.isActive ((name' = name))
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
                    Shadcn.sidebarInset [ prop.className "mt-16"; prop.children [ group name (getComponent name) ] ]
                ]
            ]
        ]
    ]

let view name (model: Model) (dispatch: Msg -> unit) = group name (getComponent name)

let page (_shared: SharedModel) (route: CompNameRoute) =
    Page.from init update (view route.CompName) { Layout.CurrentPage = route.CompName } LayoutMsg
