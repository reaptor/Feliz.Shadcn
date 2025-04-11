module Docs.Pages.Components.InputOTP

open Feliz
open Feliz.Shadcn
open Docs.Pages.Components.Common

let rec InputOTP () =
    UI.PreviewAndCode(
        nameof InputOTP,
        Shadcn.inputOTP [
            prop.maxLength 6
            prop.children [
                Shadcn.inputOTPGroup [
                    Shadcn.inputOTPSlot [ prop.custom ("index", 0) ]
                    Shadcn.inputOTPSlot [ prop.custom ("index", 1) ]
                    Shadcn.inputOTPSlot [ prop.custom ("index", 2) ]
                ]
                Shadcn.inputOTPSeparator []
                Shadcn.inputOTPGroup [
                    Shadcn.inputOTPSlot [ prop.custom ("index", 3) ]
                    Shadcn.inputOTPSlot [ prop.custom ("index", 4) ]
                    Shadcn.inputOTPSlot [ prop.custom ("index", 5) ]
                ]
            ]
        ],
        """Shadcn.inputOTP [
    prop.maxLength 6
    prop.children [
        Shadcn.inputOTPGroup [
            Shadcn.inputOTPSlot [
                prop.index 0
            ]
            Shadcn.inputOTPSlot [
                prop.index 1
            ]
            Shadcn.inputOTPSlot [
                prop.index 2
            ]
        ]
        Shadcn.inputOTPSeparator []
        Shadcn.inputOTPGroup [
            Shadcn.inputOTPSlot [
                prop.index 3
            ]
            Shadcn.inputOTPSlot [
                prop.index 4
            ]
            Shadcn.inputOTPSlot [
                prop.index 5
            ]
        ]
    ]
]"""
    )
