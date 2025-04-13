module Docs.Pages.Components.Table

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

type Invoice = {
    invoice: string
    paymentStatus: string
    totalAmount: string
    paymentMethod: string
}

let rec Table () =
    let invoices = [
        {
            invoice = "INV001"
            paymentStatus = "Paid"
            totalAmount = "$250.00"
            paymentMethod = "Credit Card"
        }
        {
            invoice = "INV002"
            paymentStatus = "Pending"
            totalAmount = "$150.00"
            paymentMethod = "PayPal"
        }
        {
            invoice = "INV003"
            paymentStatus = "Unpaid"
            totalAmount = "$350.00"
            paymentMethod = "Bank Transfer"
        }
        {
            invoice = "INV004"
            paymentStatus = "Paid"
            totalAmount = "$450.00"
            paymentMethod = "Credit Card"
        }
        {
            invoice = "INV005"
            paymentStatus = "Paid"
            totalAmount = "$550.00"
            paymentMethod = "PayPal"
        }
        {
            invoice = "INV006"
            paymentStatus = "Pending"
            totalAmount = "$200.00"
            paymentMethod = "Bank Transfer"
        }
        {
            invoice = "INV007"
            paymentStatus = "Unpaid"
            totalAmount = "$300.00"
            paymentMethod = "Credit Card"
        }
    ]

    UI.PreviewAndCode(
        nameof Table,
        Shadcn.table [
            Shadcn.tableCaption "A list of your recent invoices."
            Shadcn.tableHeader [
                Shadcn.tableRow [
                    Shadcn.tableHead [ prop.className "w-[100px]"; prop.text "Invoice" ]
                    Shadcn.tableHead "Status"
                    Shadcn.tableHead "Method"
                    Shadcn.tableHead [ prop.className "text-right"; prop.text "Amount" ]
                ]
            ]
            Shadcn.tableBody [
                yield!
                    invoices
                    |> List.map (fun invoice ->
                        Shadcn.tableRow [
                            prop.key invoice.invoice
                            prop.children [
                                Shadcn.tableCell [ prop.className "font-medium"; prop.text invoice.invoice ]
                                Shadcn.tableCell invoice.paymentStatus
                                Shadcn.tableCell invoice.paymentMethod
                                Shadcn.tableCell [ prop.className "text-right"; prop.text invoice.totalAmount ]
                            ]
                        ])
            ]
            Shadcn.tableFooter [
                Shadcn.tableRow [
                    Shadcn.tableCell [ prop.colSpan 3; prop.text "Total" ]
                    Shadcn.tableCell [ prop.className "text-right"; prop.text "$2,500.00" ]
                ]
            ]
        ],
        """let invoices = [
    {
        invoice = "INV001"
        paymentStatus = "Paid"
        totalAmount = "$250.00"
        paymentMethod = "Credit Card"
    }
    // More invoices...
]

Shadcn.table [
    Shadcn.tableCaption "A list of your recent invoices."
    Shadcn.tableHeader [
        Shadcn.tableRow [
            Shadcn.tableHead [
                prop.className "w-[100px]"
                prop.text "Invoice"
            ]
            Shadcn.tableHead "Status"
            Shadcn.tableHead "Method"
            Shadcn.tableHead [
                prop.className "text-right"
                prop.text "Amount"
            ]
        ]
    ]
    Shadcn.tableBody [
        yield! 
            invoices 
            |> List.map (fun invoice ->
                Shadcn.tableRow [
                    prop.key invoice.invoice
                    prop.children [
                        Shadcn.tableCell [
                            prop.className "font-medium"
                            prop.text invoice.invoice
                        ]
                        Shadcn.tableCell invoice.paymentStatus
                        Shadcn.tableCell invoice.paymentMethod
                        Shadcn.tableCell [
                            prop.className "text-right"
                            prop.text invoice.totalAmount
                        ]
                    ]
                ]
            )
    ]
    Shadcn.tableFooter [
        Shadcn.tableRow [
            Shadcn.tableCell [
                prop.colSpan 3
                prop.text "Total"
            ]
            Shadcn.tableCell [
                prop.className "text-right"
                prop.text "$2,500.00"
            ]
        ]
    ]
]"""
    )
