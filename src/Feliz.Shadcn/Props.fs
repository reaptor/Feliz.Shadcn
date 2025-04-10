namespace Feliz.Shadcn

open System
open System.ComponentModel
open Fable.Core
open Feliz

[<AutoOpen>]
[<EditorBrowsable(EditorBrowsableState.Never)>]
module Props =
    let inline private mkProperty (name: string, value: obj) : IReactProperty = unbox (name, value)

    [<Erase>]
    module private alertTypes =
        let inline variant () = {|
            default' = mkProperty ("variant", "default")
            destructive = mkProperty ("variant", "destructive")
        |}

    type alert =
        static member variant = alertTypes.variant ()

    [<Erase>]
    module private badgeTypes =
        let inline variant () = {|
            default' = mkProperty ("variant", "default")
            secondary = mkProperty ("variant", "secondary")
            destructive = mkProperty ("variant", "destructive")
            outline = mkProperty ("variant", "outline")
        |}

    [<Erase>]
    type badge =
        static member variant = badgeTypes.variant ()

    [<Erase>]
    module private buttonTypes =
        let inline variant () = {|
            default' = mkProperty ("variant", "default")
            destructive = mkProperty ("variant", "destructive")
            outline = mkProperty ("variant", "outline")
            secondary = mkProperty ("variant", "secondary")
            ghost = mkProperty ("variant", "ghost")
            link = mkProperty ("variant", "link")
        |}

        let inline size () = {|
            default' = mkProperty ("size", "default")
            sm = mkProperty ("size", "sm")
            lg = mkProperty ("size", "lg")
            icon = mkProperty ("size", "icon")
        |}

    [<Erase>]
    type button =
        static member variant = buttonTypes.variant ()
        static member size = buttonTypes.size ()

    [<Erase>]
    module private calendarTypes =
        let inline mode () = {|
            single = mkProperty("mode", "single")
            multiple = mkProperty("mode", "multiple")
            range = mkProperty("mode", "range")
        |}

    type DateRange = {
        from: DateTime option
        to': DateTime option
    }

    [<Erase>]
    type calendar =
        static member mode = calendarTypes.mode ()
        static member selected (value: DateTime) = mkProperty("selected", value)
        static member selected (value: DateTime option) = mkProperty("selected", value)
        static member onSelect (f: DateTime -> unit) = mkProperty("onSelect", f)
        static member onSelect (f: DateTime option -> unit) = mkProperty("onSelect", f)
        static member required (value: bool) = mkProperty("required", value)

        static member max (value: int) = mkProperty("max", value)
        static member min (value: int) = mkProperty("min", value)
        static member selected (value: #seq<DateTime>) = mkProperty("selected", Seq.toArray value)
        static member onSelect (f: #seq<DateTime> -> unit) = mkProperty("onSelect", f)

        static member disabled (value: bool) = mkProperty("disabled", value)
        static member disabled (matcher: DateTime -> bool) = mkProperty("disabled", matcher)
        static member disabled (date: DateTime) = mkProperty("disabled", date)
        static member disabled (dates: DateTime seq) = mkProperty("disabled", dates)
        static member excludeDisabled (value: bool) = mkProperty("excludeDisabled", value)
        static member selected (value: DateRange) = mkProperty("selected", value)
        static member onSelect (f: DateRange -> unit) = mkProperty("onSelect", f)

    [<Erase>]
    module private sheetTypes =
        let inline side () = {|
            top = mkProperty ("side", "top")
            bottom = mkProperty ("side", "bottom")
            left = mkProperty ("side", "left")
            right = mkProperty ("side", "right")
        |}

    [<Erase>]
    type sheet =
        static member side = sheetTypes.side ()

    [<Erase>]
    module private sidebarTypes =
        let inline variant () = {|
            default' = mkProperty ("variant", "default")
            outline = mkProperty ("variant", "outline")
        |}

        let inline size () = {|
            default' = mkProperty ("size", "default")
            sm = mkProperty ("size", "sm")
            lg = mkProperty ("size", "lg")
        |}

    [<Erase>]
    type sidebar =
        static member variant = sidebarTypes.variant ()
        static member size = sidebarTypes.size ()

    [<Erase>]
    module private toggleTypes =
        let inline variant () = {|
            default' = mkProperty ("variant", "default")
            outline = mkProperty ("variant", "outline")
        |}

        let inline size () = {|
            default' = mkProperty ("size", "default")
            sm = mkProperty ("size", "sm")
            lg = mkProperty ("size", "lg")
        |}

    [<Erase>]
    type toggle =
        static member variant = toggleTypes.variant ()
        static member size = toggleTypes.size ()

    [<Erase>]
    module private resizablePanelGroupTypes =
        let inline direction () = {|
            horizontal = mkProperty ("direction", "horizontal")
            vertical = mkProperty ("direction", "vertical")
        |}

    [<Erase>]
    type resizablePanelGroup =
        static member autoSaveId (value: string) = mkProperty ("autoSaveId", value)
        static member direction = resizablePanelGroupTypes.direction ()
        static member onLayout (value: int [] -> unit) = mkProperty ("onLayout", value)
        static member tagName (value: string) = mkProperty ("tagName", value)

    [<Erase>]
    type resizablePanel =
        static member collapsedSize (value: int) = mkProperty ("collapsedSize", value)
        static member collapsible (value: bool) = mkProperty ("collapsible", value)
        static member defaultSize (value: int) = mkProperty ("defaultSize", value)
        static member maxSize (value: int) = mkProperty ("maxSize", value)
        static member minSize (value: int) = mkProperty ("minSize", value)
        static member onCollapse (value: unit -> unit) = mkProperty ("onCollapse", value)
        static member onExpand (value: unit -> unit) = mkProperty ("onExpand", value)
        static member onResize (value: int -> unit) = mkProperty ("onResize", value)
        static member order (value: int) = mkProperty ("order", value)
        static member tagName (value: string) = mkProperty ("tagName", value)

    [<Erase>]
    type resizableHandle =
        static member hitAreaMargins (coarse: int, fine: int) = mkProperty ("hitAreaMargins", {| coarse = coarse; fine = fine |})
        static member onDragging (value: bool -> unit) = mkProperty ("onDragging", value)
        static member tagName (value: string) = mkProperty ("tagName", value)
