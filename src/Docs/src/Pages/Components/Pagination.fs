module Docs.Pages.Components.Pagination

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec Pagination () =
    UI.PreviewAndCode(
        nameof Pagination,
        Shadcn.pagination [
            Shadcn.paginationContent [
                Shadcn.paginationItem [ Shadcn.paginationPrevious [ prop.className "cursor-pointer" ] ]
                Shadcn.paginationItem [ Shadcn.paginationLink [ prop.className "cursor-pointer"; prop.text "1" ] ]
                Shadcn.paginationItem [
                    Shadcn.paginationLink [
                        prop.className "cursor-pointer"
                        prop.custom ("isActive", true)
                        prop.text "2"
                    ]
                ]
                Shadcn.paginationItem [ Shadcn.paginationLink [ prop.className "cursor-pointer"; prop.text "3" ] ]
                Shadcn.paginationItem [ Shadcn.paginationEllipsis [] ]
                Shadcn.paginationItem [ Shadcn.paginationNext [ prop.className "cursor-pointer" ] ]
            ]
        ],
        """Shadcn.pagination [
    Shadcn.paginationContent [
        Shadcn.paginationItem [
            Shadcn.paginationPrevious [
                prop.href "#"
            ]
        ]
        Shadcn.paginationItem [
            Shadcn.paginationLink [
                prop.href "#"
                prop.text "1"
            ]
        ]
        Shadcn.paginationItem [
            Shadcn.paginationLink [
                prop.href "#"
                mkProperty ("isActive", true)
                prop.text "2"
            ]
        ]
        Shadcn.paginationItem [
            Shadcn.paginationLink [
                prop.href "#"
                prop.text "3"
            ]
        ]
        Shadcn.paginationItem [
            Shadcn.paginationEllipsis []
        ]
        Shadcn.paginationItem [
            Shadcn.paginationNext [
                prop.href "#"
            ]
        ]
    ]
]"""
    )
