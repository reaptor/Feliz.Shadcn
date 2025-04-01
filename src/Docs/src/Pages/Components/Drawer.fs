module Docs.Pages.Components.Drawer

open System
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

// Define the data for the chart
let data = [|
    {| goal = 400 |}
    {| goal = 300 |}
    {| goal = 200 |}
    {| goal = 300 |}
    {| goal = 200 |}
    {| goal = 278 |}
    {| goal = 189 |}
    {| goal = 239 |}
    {| goal = 300 |}
    {| goal = 200 |}
    {| goal = 278 |}
    {| goal = 189 |}
    {| goal = 349 |}
|]

[<ReactComponent>]
let rec Drawer () =
    let goal, setGoal = React.useState (350)

    let onClick (adjustment: int) =
        let newGoal = Math.Max(200, Math.Min(400, goal + adjustment))
        setGoal (newGoal)

    UI.PreviewAndCode(
        nameof Drawer,
        Shadcn.drawer [
            Shadcn.drawerTrigger [
                //drawerTrigger.asChild
                prop.children [ Shadcn.button [ button.variant.outline; prop.text "Open Drawer" ] ]
            ]
            Shadcn.drawerContent [
                Html.div [
                    prop.className "mx-auto w-full max-w-sm"
                    prop.children [
                        Shadcn.drawerHeader [
                            Shadcn.drawerTitle "Move Goal"
                            Shadcn.drawerDescription "Set your daily activity goal."
                        ]
                        Html.div [
                            prop.className "p-4 pb-0"
                            prop.children [
                                Html.div [
                                    prop.className "flex items-center justify-center space-x-2"
                                    prop.children [
                                        Shadcn.button [
                                            button.variant.outline
                                            button.size.icon
                                            prop.className "h-8 w-8 shrink-0 rounded-full"
                                            prop.onClick (fun _ -> onClick (-10))
                                            prop.disabled (goal <= 200)
                                            prop.children [
                                                Html.span [ prop.className "lucide-minus h-4 w-4" ]
                                                Html.span [ prop.className "sr-only"; prop.text "Decrease" ]
                                            ]
                                        ]
                                        Html.div [
                                            prop.className "flex-1 text-center"
                                            prop.children [
                                                Html.div [
                                                    prop.className "text-7xl font-bold tracking-tighter"
                                                    prop.text (string goal)
                                                ]
                                                Html.div [
                                                    prop.className "text-[0.70rem] uppercase text-muted-foreground"
                                                    prop.text "Calories/day"
                                                ]
                                            ]
                                        ]
                                        Shadcn.button [
                                            button.variant.outline
                                            button.size.icon
                                            prop.className "h-8 w-8 shrink-0 rounded-full"
                                            prop.onClick (fun _ -> onClick (10))
                                            prop.disabled (goal >= 400)
                                            prop.children [
                                                Html.span [ prop.className "lucide-plus h-4 w-4" ]
                                                Html.span [ prop.className "sr-only"; prop.text "Increase" ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Shadcn.drawerFooter [
                            Shadcn.button [ prop.text "Submit" ]
                            Shadcn.drawerClose [
                                // drawerClose.asChild
                                prop.children [ Shadcn.button [ button.variant.outline; prop.text "Cancel" ] ]
                            ]
                        ]
                    ]
                ]
            ]
        ],
        """// Define the data for the chart
let data = [|
    {| goal = 400 |}
    {| goal = 300 |}
    {| goal = 200 |}
    // ... (more data)
|]

// Import Recharts components
let ResponsiveContainer: obj -> ReactElement = importDefault "recharts/es6/component/ResponsiveContainer"
let BarChart: obj -> ReactElement = importDefault "recharts/es6/chart/BarChart"
let Bar: obj -> ReactElement = importDefault "recharts/es6/cartesian/Bar"

// Component
let goal, setGoal = React.useState(350)

let onClick (adjustment: int) =
    let newGoal = Math.Max(200, Math.Min(400, goal + adjustment))
    setGoal(newGoal)

Shadcn.drawer [
    Shadcn.drawerTrigger [
        drawerTrigger.asChild
        prop.children [
            Shadcn.button [
                button.variant.outline
                prop.text "Open Drawer"
            ]
        ]
    ]
    Shadcn.drawerContent [
        Html.div [
            prop.className "mx-auto w-full max-w-sm"
            prop.children [
                Shadcn.drawerHeader [
                    Shadcn.drawerTitle "Move Goal"
                    Shadcn.drawerDescription "Set your daily activity goal."
                ]
                Html.div [
                    prop.className "p-4 pb-0"
                    prop.children [
                        Html.div [
                            prop.className "flex items-center justify-center space-x-2"
                            prop.children [
                                // Decrease button
                                Shadcn.button [
                                    button.variant.outline
                                    button.size.icon
                                    prop.className "h-8 w-8 shrink-0 rounded-full"
                                    prop.onClick (fun _ -> onClick(-10))
                                    prop.disabled (goal <= 200)
                                    prop.children [
                                        Lucide.minus []
                                        Html.span [
                                            prop.className "sr-only"
                                            prop.text "Decrease"
                                        ]
                                    ]
                                ]
                                // Goal display
                                Html.div [
                                    prop.className "flex-1 text-center"
                                    prop.children [
                                        Html.div [
                                            prop.className "text-7xl font-bold tracking-tighter"
                                            prop.text (string goal)
                                        ]
                                        Html.div [
                                            prop.className "text-[0.70rem] uppercase text-muted-foreground"
                                            prop.text "Calories/day"
                                        ]
                                    ]
                                ]
                                // Increase button
                                Shadcn.button [
                                    button.variant.outline
                                    button.size.icon
                                    prop.className "h-8 w-8 shrink-0 rounded-full"
                                    prop.onClick (fun _ -> onClick(10))
                                    prop.disabled (goal >= 400)
                                    prop.children [
                                        Lucide.plus []
                                        Html.span [
                                            prop.className "sr-only"
                                            prop.text "Increase"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        // Chart
                        Html.div [
                            prop.className "mt-3 h-[120px]"
                            prop.children [
                                ResponsiveContainer {| width = "100%"; height = "100%" |} [
                                    BarChart {| data = data |} [
                                        Bar {|
                                            dataKey = "goal"
                                            style = {|
                                                fill = "hsl(var(--foreground))"
                                                opacity = 0.9
                                            |}
                                        |} []
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Shadcn.drawerFooter [
                    Shadcn.button "Submit"
                    Shadcn.drawerClose [
                        drawerClose.asChild
                        prop.children [
                            Shadcn.button [
                                button.variant.outline
                                prop.text "Cancel"
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]
]"""
    )
