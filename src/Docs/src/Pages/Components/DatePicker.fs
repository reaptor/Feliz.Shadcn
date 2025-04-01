module Docs.Pages.Components.DatePicker

open System
open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

[<ReactComponent>]
let rec DatePicker () =
    let date, setDate = React.useState<DateTime option> (None)

    UI.PreviewAndCode(
        nameof DatePicker,
        Shadcn.popover [
            Shadcn.popoverTrigger [
                popoverTrigger.asChild
                prop.children [
                    Shadcn.button [
                        button.variant.outline
                        prop.classes [
                            "w-[240px] justify-start text-left font-normal"
                            if date.IsNone then
                                "text-muted-foreground"
                        ]
                        prop.children [
                            Html.span [ prop.className "lucide-calendar h-4 w-4" ]
                            match date with
                            | Some date -> Html.text (date.ToString("MMMM d, yyyy"))
                            | None -> Html.span "Pick a date"
                        ]
                    ]
                ]
            ]
            Shadcn.popoverContent [
                prop.className "w-auto p-0"
                popoverContent.align.start
                prop.children [
                    Shadcn.calendar [
                        calendar.mode.single
                        calendar.selected date
                        calendar.onSelect setDate
                        prop.custom ("initialFocus", true)
                    ]
                ]
            ]
        ],
        """"""
    )
