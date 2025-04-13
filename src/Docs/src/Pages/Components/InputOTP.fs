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
                    Shadcn.inputOTPSlot [ inputOTPSlot.index 0 ]
                    Shadcn.inputOTPSlot [ inputOTPSlot.index 1 ]
                    Shadcn.inputOTPSlot [ inputOTPSlot.index 2 ]
                ]
                Shadcn.inputOTPSeparator []
                Shadcn.inputOTPGroup [
                    Shadcn.inputOTPSlot [ inputOTPSlot.index 3 ]
                    Shadcn.inputOTPSlot [ inputOTPSlot.index 4 ]
                    Shadcn.inputOTPSlot [ inputOTPSlot.index 5 ]
                ]
            ]
        ],
        """Shadcn.inputOTP [
    prop.maxLength 6
    prop.children [
        Shadcn.inputOTPGroup [
            Shadcn.inputOTPSlot [ inputOTPSlot.index 0 ]
            Shadcn.inputOTPSlot [ inputOTPSlot.index 1 ]
            Shadcn.inputOTPSlot [ inputOTPSlot.index 2 ]
        ]
        Shadcn.inputOTPSeparator []
        Shadcn.inputOTPGroup [
            Shadcn.inputOTPSlot [ inputOTPSlot.index 3 ]
            Shadcn.inputOTPSlot [ inputOTPSlot.index 4 ]
            Shadcn.inputOTPSlot [ inputOTPSlot.index 5 ]
        ]
    ]
]"""
    )
