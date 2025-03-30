module Docs.Pages.Components.Calendar

open System
open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

[<ReactComponent>]
let rec CalendarSingle () =
    let date, setDate = React.useState (DateTime.Now)

    UI.PreviewAndCode (
        nameof CalendarSingle,
        title = "Single Mode",
        preview = Shadcn.calendar [ calendar.mode.single; calendar.selected date; calendar.onSelect setDate ],
        code = """let date, setDate = React.useState (DateTime.Now)

Shadcn.calendar [
    calendar.mode.single
    calendar.selected date
    calendar.onSelect setDate
]""")

[<ReactComponent>]
let rec CalendarMulti () =
    let dates, setDates = React.useState ([ DateTime.Now; DateTime.Now.AddDays 3 ])

    UI.PreviewAndCode (
        nameof CalendarMulti,
        title = "Multiple Mode",
        preview = Shadcn.calendar [ calendar.mode.multiple; calendar.selected dates; calendar.onSelect setDates ],
        code = """let dates, setDates = React.useState ([ DateTime.Now; DateTime.Now.AddDays 3 ])

Shadcn.calendar [
    calendar.mode.multiple
    calendar.selected dates
    calendar.onSelect setDates
]""")

[<ReactComponent>]
let rec CalendarRange () =
    let dateRange, setDateRange =
        React.useState (
            {
                from = Some DateTime.Now
                to' = Some(DateTime.Now.AddDays 3)
            }
        )

    UI.PreviewAndCode (
        nameof CalendarRange,
        title = "Range Mode",
        preview =  Shadcn.calendar [
            calendar.mode.range
            calendar.selected dateRange
            calendar.onSelect setDateRange
        ],
        code = """let dateRange, setDateRange =
    React.useState (
        {
            from = Some DateTime.Now
            to' = Some(DateTime.Now.AddDays 3)
        }
    )

Shadcn.calendar [
    calendar.mode.range
    calendar.selected dateRange
    calendar.onSelect setDateRange
]""")

let Calendar () =
    Html.div [
        prop.className "flex flex-col gap-5"
        prop.children [
            CalendarSingle()
            CalendarMulti()
            CalendarRange()
        ]
    ]
