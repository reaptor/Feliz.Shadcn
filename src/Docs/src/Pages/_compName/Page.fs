module Docs.Pages.CompName.Page

open Docs.Pages.Layout
open Feliz
open Feliz.Shadcn
open ElmishLand
open Docs.Shared
open Docs.Pages
open Docs.Pages.Components.Common

type Model = { Dummy: unit }

type Msg =
    | LayoutMsg of Layout.Msg

let init () =
    { Dummy = () }, Command.none

let update (msg: Msg) (model: Model) =
    match msg with
    | LayoutMsg _ -> model, Command.none

let group (name: string) (comp: Component) =
    Html.div [
        prop.className "flex flex-col gap-4"
        prop.children [
            UI.Header1 comp.Title
            Html.div [ prop.text comp.Description ]
            Shadcn.badge [
                badge.variant.secondary
                prop.children [
                    Html.a [
                        prop.className "flex gap-2 items-center font-semibold"
                        prop.href $"https://ui.shadcn.com/docs/components/%s{name}"
                        prop.children [
                            Html.text "Original Docs"
                            UI.LinkIcon ()
                        ]
                    ]
                ]
            ]
            comp.Constructor ()
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
                        Html.span [
                            prop.className "text-lg font-bold"
                            prop.text "Feliz.Shadcn"
                        ]
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
                                                            mkProperty ("asChild", null)
                                                            mkProperty ("isActive", name' = name)
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
                        prop.className "mt-16"
                        prop.children [
                            group name (getComponent name)
                        ]
                    ]
                ]
            ]
        ]
    ]

let view name (model: Model) (dispatch: Msg -> unit) =
    group name (getComponent name)

let page (_shared: SharedModel) (route: CompNameRoute) =
    Page.from init update (view route.CompName) { Layout.CurrentComponentName = route.CompName } LayoutMsg
