module Docs.Pages.Components.Select

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Select () =
    UI.PreviewAndCode(
        nameof Select,
        Shadcn.select [
            Shadcn.selectTrigger [
                prop.className "w-[180px]"
                prop.children [ Shadcn.selectValue [ prop.placeholder "Select a fruit" ] ]
            ]
            Shadcn.selectContent [
                Shadcn.selectGroup [
                    Shadcn.selectLabel "Fruits"
                    Shadcn.selectItem [ prop.value "apple"; prop.text "Apple" ]
                    Shadcn.selectItem [ prop.value "banana"; prop.text "Banana" ]
                    Shadcn.selectItem [ prop.value "blueberry"; prop.text "Blueberry" ]
                    Shadcn.selectItem [ prop.value "grapes"; prop.text "Grapes" ]
                    Shadcn.selectItem [ prop.value "pineapple"; prop.text "Pineapple" ]
                ]
            ]
        ],
        """Shadcn.select [
    Shadcn.selectTrigger [
        prop.className "w-[180px]"
        prop.children [
            Shadcn.selectValue [
                prop.placeholder "Select a fruit"
            ]
        ]
    ]
    Shadcn.selectContent [
        Shadcn.selectGroup [
            Shadcn.selectLabel "Fruits"
            Shadcn.selectItem [
                prop.value "apple"
                prop.text "Apple"
            ]
            Shadcn.selectItem [
                prop.value "banana"
                prop.text "Banana"
            ]
            Shadcn.selectItem [
                prop.value "blueberry"
                prop.text "Blueberry"
            ]
            Shadcn.selectItem [
                prop.value "grapes"
                prop.text "Grapes"
            ]
            Shadcn.selectItem [
                prop.value "pineapple"
                prop.text "Pineapple"
            ]
        ]
    ]
]"""
    )
