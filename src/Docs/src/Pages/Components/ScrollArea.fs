module Docs.Pages.Components.ScrollArea

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec ScrollArea () =
    let tags = [| 1..50 |] |> Array.map (fun i -> $"v1.2.0-beta.{50 - i}")

    UI.PreviewAndCode(
        nameof ScrollArea,
        Shadcn.scrollArea [
            prop.className "h-72 w-48 rounded-md border"
            prop.children [
                Html.div [
                    prop.className "p-4"
                    prop.children [
                        Html.h4 [ prop.className "mb-4 text-sm font-medium leading-none"; prop.text "Tags" ]
                        yield!
                            tags
                            |> Array.map (fun tag ->
                                React.fragment [
                                    Html.div [ prop.key tag; prop.className "text-sm"; prop.text tag ]
                                    Shadcn.separator [ prop.className "my-2" ]
                                ])
                    ]
                ]
            ]
        ],
        """let tags =
    [| 1..50 |]
    |> Array.map (fun i -> $"v1.2.0-beta.{50 - i}")

Shadcn.scrollArea [
    prop.className "h-72 w-48 rounded-md border"
    prop.children [
        Html.div [
            prop.className "p-4"
            prop.children [
                Html.h4 [
                    prop.className "mb-4 text-sm font-medium leading-none"
                    prop.text "Tags"
                ]
                yield!
                    tags
                    |> Array.map (fun tag ->
                        Html.fragment [
                            Html.div [
                                prop.key tag
                                prop.className "text-sm"
                                prop.text tag
                            ]
                            Shadcn.separator [
                                prop.className "my-2"
                            ]
                        ]
                    )
            ]
        ]
    ]
]"""
    )
