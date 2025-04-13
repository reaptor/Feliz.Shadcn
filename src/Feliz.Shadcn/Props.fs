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

    [<Erase>]
    [<RequireQualifiedAccess>]
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
    [<RequireQualifiedAccess>]
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
    [<RequireQualifiedAccess>]
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

        let inline captionLayout () = {|
            label = mkProperty("captionLayout", "label")
            dropdown = mkProperty("captionLayout", "dropdown")
            dropdownMonths = mkProperty("captionLayout", "dropdown-months")
            dropdownYears = mkProperty("captionLayout", "dropdown-years")
        |}

        let inline dir () = {|
            ltr = mkProperty("dir", "ltr")
            rtl = mkProperty("dir", "rtl")
        |}

    type DateRange = {
        from: DateTime option
        to': DateTime option
    }

    [<Erase>]
    [<RequireQualifiedAccess>]
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
        static member defaultMonth (value: DateTime) = mkProperty("defaultMonth", value)
        static member month (value: DateTime) = mkProperty("month", value)
        static member numberOfMonths (value: int) = mkProperty("numberOfMonths", value)
        static member startMonth (value: DateTime) = mkProperty("startMonth", value)
        static member endMonth (value: DateTime) = mkProperty("endMonth", value)
        static member pagedNavigation (value: bool) = mkProperty("pagedNavigation", value)
        static member reverseMonths (value: bool) = mkProperty("reverseMonths", value)
        static member hideNavigation (value: bool) = mkProperty("hideNavigation", value)
        static member disableNavigation (value: bool) = mkProperty("disableNavigation", value)
        static member captionLayout = calendarTypes.captionLayout()
        static member fixedWeeks (value: bool) = mkProperty("fixedWeeks", value)
        static member hideWeekdays (value: bool) = mkProperty("hideWeekdays", value)
        static member showOutsideDays (value: bool) = mkProperty("showOutsideDays", value)
        static member showWeekNumber (value: bool) = mkProperty("showWeekNumber", value)
        static member animate (value: bool) = mkProperty("animate", value)
        static member broadcastCalendar (value: bool) = mkProperty("broadcastCalendar", value)
        static member ISOWeek (value: bool) = mkProperty("ISOWeek", value)
        static member timeZone (value: string) = mkProperty("timeZone", value)
        static member footer (value: ReactElement) = mkProperty("footer", value)
        static member footer (value: string) = mkProperty("footer", value)
        static member autoFocus (value: bool) = mkProperty("autoFocus", value)
        static member hidden (value: obj) = mkProperty("hidden", value)
        static member today (value: DateTime) = mkProperty("today", value)
        static member modifiers (value: obj) = mkProperty("modifiers", value)
        static member dir = calendarTypes.dir()
        static member ariaLabel (value: string) = mkProperty("aria-label", value)
        static member role (value: string) = mkProperty("role", value)
        static member nonce (value: string) = mkProperty("nonce", value)
        static member title (value: string) = mkProperty("title", value)
        static member lang (value: string) = mkProperty("lang", value)
        static member locale (value: obj) = mkProperty("locale", value)
        static member weekStartsOn (value: int) = mkProperty("weekStartsOn", value)
        static member firstWeekContainsDate (value: int) = mkProperty("firstWeekContainsDate", value)
        static member useAdditionalWeekYearTokens (value: bool) = mkProperty("useAdditionalWeekYearTokens", value)
        static member useAdditionalDayOfYearTokens (value: bool) = mkProperty("useAdditionalDayOfYearTokens", value)
        static member onMonthChange (handler: obj -> unit) = mkProperty("onMonthChange", handler)
        static member onNextClick (handler: obj -> unit) = mkProperty("onNextClick", handler)
        static member onPrevClick (handler: obj -> unit) = mkProperty("onPrevClick", handler)
        static member onDayClick (handler: obj -> unit) = mkProperty("onDayClick", handler)
        static member onDayFocus (handler: obj -> unit) = mkProperty("onDayFocus", handler)
        static member onDayBlur (handler: obj -> unit) = mkProperty("onDayBlur", handler)
        static member onDayKeyDown (handler: obj -> unit) = mkProperty("onDayKeyDown", handler)
        static member onDayMouseEnter (handler: obj -> unit) = mkProperty("onDayMouseEnter", handler)
        static member onDayMouseLeave (handler: obj -> unit) = mkProperty("onDayMouseLeave", handler)

    [<Erase>]
    module private sheetTypes =
        let inline side () = {|
            top = mkProperty ("side", "top")
            bottom = mkProperty ("side", "bottom")
            left = mkProperty ("side", "left")
            right = mkProperty ("side", "right")
        |}

    [<Erase>]
    [<RequireQualifiedAccess>]
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
    [<RequireQualifiedAccess>]
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
    [<RequireQualifiedAccess>]
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
    [<RequireQualifiedAccess>]
    type resizablePanelGroup =
        static member autoSaveId (value: string) = mkProperty ("autoSaveId", value)
        static member direction = resizablePanelGroupTypes.direction ()
        static member onLayout (value: int [] -> unit) = mkProperty ("onLayout", value)
        static member tagName (value: string) = mkProperty ("tagName", value)

    [<Erase>]
    [<RequireQualifiedAccess>]
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
    [<RequireQualifiedAccess>]
    type resizableHandle =
        static member hitAreaMargins (coarse: int, fine: int) = mkProperty ("hitAreaMargins", {| coarse = coarse; fine = fine |})
        static member onDragging (value: bool -> unit) = mkProperty ("onDragging", value)
        static member tagName (value: string) = mkProperty ("tagName", value)

    [<Erase>]
    [<RequireQualifiedAccess>]
    type commandItem =
        /// Whether this item is currently disabled.
        static member disabled (value: bool) = mkProperty ("disabled", value)
        /// Event handler for when this item is selected, either via click or keyboard selection.
        static member onSelect (handler: string -> unit) = mkProperty ("onSelect", handler)
        /// A unique value for this item.
        /// If no value is provided, it will be inferred from children or the rendered textContent.
        /// If your textContent changes between renders, you must provide a stable, unique value.
        static member value (value: string) = mkProperty ("value", value)
        /// Optional keywords to match against when filtering.
        static member keywords (values: string[]) = mkProperty ("keywords", values)
        /// Optional keywords to match against when filtering.
        static member keywords (values: string seq) = mkProperty ("keywords", Seq.toArray values)
        /// Whether this item is forcibly rendered regardless of filtering.
        static member forceMount (value: bool) = mkProperty ("forceMount", value)
        /// Whether to render the component without the default component implementation
        static member asChild = mkProperty ("asChild", null)

    [<Erase>]
    [<RequireQualifiedAccess>]
    type commandGroup =
        /// Optional heading to render for this group.
        static member heading (value: ReactElement) = mkProperty ("heading", value)
        /// Optional heading to render for this group.
        static member heading (value: string) = mkProperty ("heading", value)
        /// If no heading is provided, you must provide a value that is unique for this group.
        static member value (value: string) = mkProperty ("value", value)
        /// Whether this group is forcibly rendered regardless of filtering.
        static member forceMount (value: bool) = mkProperty ("forceMount", value)
        /// Whether to render the component without the default component implementation
        static member asChild = mkProperty ("asChild", null)

    [<Erase>]
    [<RequireQualifiedAccess>]
    type commandSeparator =
        /// Whether this separator should always be rendered. Useful if you disable automatic filtering.
        static member alwaysRender (value: bool) = mkProperty ("alwaysRender", value)
        /// Whether to render the component without the default component implementation
        static member asChild = mkProperty ("asChild", null)

    [<Erase>]
    [<RequireQualifiedAccess>]
    type commandInput =
        /// Optional controlled state for the value of the search input.
        static member value (value: string) = mkProperty ("value", value)
        /// Event handler called when the search value changes.
        static member onValueChange (handler: string -> unit) = mkProperty ("onValueChange", handler)
        /// Whether to render the component without the default component implementation
        static member asChild = mkProperty ("asChild", null)

    [<Erase>]
    [<RequireQualifiedAccess>]
    type commandList =
        /// Accessible label for this List of suggestions. Not shown visibly.
        static member label (value: string) = mkProperty ("label", value)
        /// Whether to render the component without the default component implementation
        static member asChild = mkProperty ("asChild", null)

    [<Erase>]
    [<RequireQualifiedAccess>]
    type commandDialog =
        /// Accessible label for this command menu. Not shown visibly.
        static member label (value: string) = mkProperty ("label", value)
        /// Optionally set to false to turn off the automatic filtering and sorting.
        /// If false, you must conditionally render valid items based on the search query yourself.
        static member shouldFilter (value: bool) = mkProperty ("shouldFilter", value)
        /// Custom filter function for whether each command menu item should match the given search query.
        static member filter (value: obj) = mkProperty ("filter", value)
        /// Optional default item value when it is initially rendered.
        static member defaultValue (value: string) = mkProperty ("defaultValue", value)
        /// Optional controlled state of the selected command menu item.
        static member value (value: string) = mkProperty ("value", value)
        /// Event handler called when the selected item of the menu changes.
        static member onValueChange (handler: string -> unit) = mkProperty ("onValueChange", handler)
        /// Optionally set to true to turn on looping around when using the arrow keys.
        static member loop (value: bool) = mkProperty ("loop", value)
        /// Optionally set to true to disable selection via pointer events.
        static member disablePointerSelection (value: bool) = mkProperty ("disablePointerSelection", value)
        /// Set to false to disable ctrl+n/j/p/k shortcuts. Defaults to true.
        static member vimBindings (value: bool) = mkProperty ("vimBindings", value)
        /// Provide a className to the Dialog overlay.
        static member overlayClassName (value: string) = mkProperty ("overlayClassName", value)
        /// Provide a className to the Dialog content.
        static member contentClassName (value: string) = mkProperty ("contentClassName", value)
        /// Whether the dialog is open
        static member open' (value: bool) = mkProperty ("open", value)
        /// Event handler called when the open state of the dialog changes.
        static member onOpenChange (handler: bool -> unit) = mkProperty ("onOpenChange", handler)
        /// Whether to render the component without the default component implementation
        static member asChild = mkProperty ("asChild", null)

    [<Erase>]
    [<RequireQualifiedAccess>]
    type commandEmpty =
        /// Whether to render the component without the default component implementation
        static member asChild = mkProperty ("asChild", null)

    [<Erase>]
    module private contextMenuItemTypes =
        let inline variant () = {|
            default' = mkProperty ("variant", "default")
            destructive = mkProperty ("variant", "destructive")
        |}

    [<Erase>]
    [<RequireQualifiedAccess>]
    type contextMenuItem =
        static member inset = mkProperty ("inset", null)
        static member variant = contextMenuItemTypes.variant ()

    [<Erase>]
    [<RequireQualifiedAccess>]
    type contextMenuSubTrigger =
        static member inset = mkProperty ("inset", null)

    [<Erase>]
    [<RequireQualifiedAccess>]
    type contextMenuLabel =
        static member inset = mkProperty ("inset", null)

    [<Erase>]
    module private menubarItemTypes =
        let inline variant () = {|
            default' = mkProperty ("variant", "default")
            destructive = mkProperty ("variant", "destructive")
        |}

    [<Erase>]
    [<RequireQualifiedAccess>]
    type menubarItem =
        static member inset = mkProperty ("inset", null)
        static member variant = contextMenuItemTypes.variant ()

    [<Erase>]
    [<RequireQualifiedAccess>]
    type paginationLink =
        static member isActive (value: bool) = mkProperty ("isActive", value)
        static member size = buttonTypes.size ()

    [<Erase>]
    module private sidebarMenuButtonTypes =
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
    [<RequireQualifiedAccess>]
    type sidebarMenuButton =
        static member isActive (value: bool) = mkProperty ("isActive", value)
        static member variant = sidebarMenuButtonTypes.variant ()
        static member size = sidebarMenuButtonTypes.size ()
        static member tooltip (value: string) = mkProperty ("tooltip", value)
        static member tooltip (value: ReactElement) = mkProperty ("tooltip", value)

    [<Erase>]
    [<RequireQualifiedAccess>]
    type inputOTP =
        static member containerClassName (value: string) = mkProperty ("containerClassName", value)

    [<Erase>]
    [<RequireQualifiedAccess>]
    type inputOTPSlot =
        static member index (value: int) = mkProperty ("index", value)
        static member index (value: float) = mkProperty ("index", value)
