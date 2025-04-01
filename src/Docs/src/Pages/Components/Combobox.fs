module Docs.Pages.Components.Combobox

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

[<ReactComponent>]
let rec Combobox () =
    let frameworks = [|
        {|
            value = "next.js"
            label = "Next.js"
        |}
        {|
            value = "sveltekit"
            label = "SvelteKit"
        |}
        {|
            value = "nuxt.js"
            label = "Nuxt.js"
        |}
        {| value = "remix"; label = "Remix" |}
        {| value = "astro"; label = "Astro" |}
    |]

    let open', setOpen = React.useState (false)
    let value, setValue = React.useState ("")

    // Helper to find the selected framework label
    let selectedFrameworkLabel =
        match frameworks |> Array.tryFind (fun f -> f.value = value) with
        | Some framework -> framework.label
        | None -> "Select framework..."

    UI.PreviewAndCode(
        nameof Combobox,
        Shadcn.popover [
            popover.open' open'
            popover.onOpenChange setOpen
            prop.children [
                Shadcn.popoverTrigger [
                    popoverTrigger.asChild
                    prop.children [
                        Shadcn.button [
                            button.variant.outline
                            prop.role "combobox"
                            prop.ariaExpanded open'
                            prop.className "w-[200px] justify-between"
                            prop.children [
                                Html.text selectedFrameworkLabel
                                Lucide.ChevronsUpDown [ svg.className "opacity-50" ]
                            ]
                        ]
                    ]
                ]
                Shadcn.popoverContent [
                    prop.className "w-[200px] p-0"
                    prop.children [
                        Shadcn.command [
                            Shadcn.commandInput [ prop.placeholder "Search framework..."; prop.className "h-9" ]
                            Shadcn.commandList [
                                Shadcn.commandEmpty "No framework found."
                                Shadcn.commandGroup [
                                    for framework in frameworks do
                                        Shadcn.commandItem [
                                            prop.key framework.value
                                            prop.value framework.value
                                            prop.custom (
                                                "onSelect",
                                                (fun (currentValue: string) ->
                                                    if currentValue = value then
                                                        setValue ""
                                                    else
                                                        setValue currentValue

                                                    setOpen false)
                                            )
                                            prop.children [
                                                Html.text framework.label
                                                Lucide.Check [
                                                    svg.classes [
                                                        "ml-auto"
                                                        if value = framework.value then
                                                            "opacity-100"
                                                        else
                                                            "opacity-0"
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
        ],
        """// Define frameworks data
let frameworks = [|
    {| value = "next.js"; label = "Next.js" |}
    {| value = "sveltekit"; label = "SvelteKit" |}
    {| value = "nuxt.js"; label = "Nuxt.js" |}
    {| value = "remix"; label = "Remix" |}
    {| value = "astro"; label = "Astro" |}
|]

// State for popover and selected value
let open', setOpen = React.useState(false)
let value, setValue = React.useState("")

// Helper function for class names
let cn classes = String.concat " " classes

// Helper to find selected framework label
let selectedFrameworkLabel =
    match frameworks |> Array.tryFind (fun f -> f.value = value) with
    | Some framework -> framework.label
    | None -> "Select framework..."

Shadcn.popover [
    prop.custom("open", open')
    prop.custom("onOpenChange", setOpen)
    prop.children [
        Shadcn.popoverTrigger [
            popoverTrigger.asChild
            prop.children [
                Shadcn.button [
                    button.variant.outline
                    prop.role "combobox"
                    prop.custom("aria-expanded", open')
                    prop.className "w-[200px] justify-between"
                    prop.children [
                        Html.text selectedFrameworkLabel
                        // ChevronsUpDown icon
                        UI.ChevronsUpDownIcon(className = "opacity-50")
                    ]
                ]
            ]
        ]
        Shadcn.popoverContent [
            prop.className "w-[200px] p-0"
            prop.children [
                Shadcn.command [
                    Shadcn.commandInput [
                        prop.placeholder "Search framework..."
                        prop.className "h-9"
                    ]
                    Shadcn.commandList [
                        Shadcn.commandEmpty "No framework found."
                        Shadcn.commandGroup [
                            for framework in frameworks do
                                Shadcn.commandItem [
                                    prop.key framework.value
                                    prop.value framework.value
                                    prop.custom("onSelect", (fun (currentValue: string) ->
                                        if currentValue = value then setValue ""
                                        else setValue currentValue
                                        setOpen false
                                    ))
                                    prop.children [
                                        Html.text framework.label
                                        UI.CheckIcon(className = cn [
                                            "ml-auto"
                                            if value = framework.value then "opacity-100" else "opacity-0"
                                        ])
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
