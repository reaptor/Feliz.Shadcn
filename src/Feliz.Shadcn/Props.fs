namespace Feliz.Shadcn

open System
open System.ComponentModel
open Fable.Core
open Feliz

[<AutoOpen>]
module Props =
    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module alertProps =
        let variant = {|
            default' = prop.custom ("variant", "default")
            destructive = prop.custom ("variant", "destructive")
        |}

    type alert =
        static member variant = alertProps.variant


    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module badgeProps =
        let variant = {|
            default' = prop.custom ("variant", "default")
            secondary = prop.custom ("variant", "secondary")
            destructive = prop.custom ("variant", "destructive")
            outline = prop.custom ("variant", "outline")
        |}

    [<Erase>]
    type badge =
        static member variant = badgeProps.variant


    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module buttonProps =
        let variant = {|
            default' = prop.custom ("variant", "default")
            destructive = prop.custom ("variant", "destructive")
            outline = prop.custom ("variant", "outline")
            secondary = prop.custom ("variant", "secondary")
            ghost = prop.custom ("variant", "ghost")
            link = prop.custom ("variant", "link")
        |}

        let size = {|
            default' = prop.custom ("size", "default")
            sm = prop.custom ("size", "sm")
            lg = prop.custom ("size", "lg")
            icon = prop.custom ("size", "icon")
        |}

    [<Erase>]
    type button =
        static member variant = buttonProps.variant
        static member size = buttonProps.size


    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module calendarProps =
        let mode = {|
            single = prop.custom("mode", "single")
            multiple = prop.custom("mode", "multiple")
            range = prop.custom("mode", "range")
        |}

    type DateRange = {
        from: DateTime option
        to': DateTime option
    }

    [<Erase>]
    type calendar =
        static member mode = calendarProps.mode
        static member selected (value: DateTime) = prop.custom("selected", value)
        static member selected (value: DateTime option) = prop.custom("selected", value)
        static member onSelect (f: DateTime -> unit) = prop.custom("onSelect", f)
        static member onSelect (f: DateTime option -> unit) = prop.custom("onSelect", f)
        static member required (value: bool) = prop.custom("required", value)

        static member max (value: int) = prop.custom("max", value)
        static member min (value: int) = prop.custom("min", value)
        static member selected (value: #seq<DateTime>) = prop.custom("selected", Seq.toArray value)
        static member onSelect (f: #seq<DateTime> -> unit) = prop.custom("onSelect", f)

        static member disabled (value: bool) = prop.custom("disabled", value)
        static member disabled (matcher: DateTime -> bool) = prop.custom("disabled", matcher)
        static member disabled (date: DateTime) = prop.custom("disabled", date)
        static member disabled (dates: DateTime seq) = prop.custom("disabled", dates)
        static member excludeDisabled (value: bool) = prop.custom("excludeDisabled", value)
        static member selected (value: DateRange) = prop.custom("selected", value)
        static member onSelect (f: DateRange -> unit) = prop.custom("onSelect", f)

    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module sheetProps =
        let side = {|
            top = prop.custom ("side", "top")
            bottom = prop.custom ("side", "bottom")
            left = prop.custom ("side", "left")
            right = prop.custom ("side", "right")
        |}

    [<Erase>]
    type sheet =
        static member side = sheetProps.side


    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module sidebarProps =
        let variant = {|
            default' = prop.custom ("variant", "default")
            outline = prop.custom ("variant", "outline")
        |}

        let size = {|
            default' = prop.custom ("size", "default")
            sm = prop.custom ("size", "sm")
            lg = prop.custom ("size", "lg")
        |}

    [<Erase>]
    type sidebar =
        static member variant = sidebarProps.variant
        static member size = sidebarProps.size


    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module toggleProps =
        let variant = {|
            default' = prop.custom ("variant", "default")
            outline = prop.custom ("variant", "outline")
        |}

        let size = {|
            default' = prop.custom ("size", "default")
            sm = prop.custom ("size", "sm")
            lg = prop.custom ("size", "lg")
        |}

    [<Erase>]
    type toggle =
        static member variant = toggleProps.variant
        static member size = toggleProps.size
