namespace Feliz.Shadcn

open System.ComponentModel

[<AutoOpen>]
module Radix =
    open Fable.Core
    open Fable.Core.JsInterop
    open Feliz
    open Feliz.Shadcn.Helpers

    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module accordionEnums =
        let type' = {|
            single = prop.custom ("type", "single")
            multiple = prop.custom ("type", "multiple")
        |}

        let dir = {|
            ltr = prop.custom ("dir", "ltr")
            rtl = prop.custom ("dir", "rtl")
        |}

        let orientation = {|
            horizontal = prop.custom ("orientation", "horizontal")
            vertical = prop.custom ("orientation", "vertical")
        |}

    [<Erase>]
    type accordion =
        static member asChild(value: bool) = prop.custom ("asChild", value)
        static member type' = accordionEnums.type'
        static member value(value: string) = prop.custom ("value", value)
        static member defaultValue(value: string) = prop.custom ("defaultValue", value)
        static member onValueChange(fn: string -> unit) = prop.custom ("onValueChange", fn)
        static member value(value: string seq) = prop.custom ("value", value)
        static member defaultValue(value: string seq) = prop.custom ("value", value)
        static member onValueChange(fn: string seq -> unit) = prop.custom ("value", fn)
        static member collapsible(value: bool) = prop.custom ("collapsible", value)
        static member disabled(value: bool) = prop.custom ("disabled", value)
        static member dir = accordionEnums.dir
        static member orientation = accordionEnums.orientation
        static member forceMount(value: bool) = prop.custom ("forceMount", value)

    [<Erase>]
    type alertDialog =
        static member asChild(value: bool) = prop.custom ("asChild", value)
        static member defaultOpen(value: bool) = prop.custom ("defaultOpen", value)
        static member open'(value: bool) = prop.custom ("open", value)
        static member onOpenChange(fn: bool -> unit) = prop.custom ("onOpenChange", fn)
        static member forceMount(value: bool) = prop.custom ("forceMount", value)
