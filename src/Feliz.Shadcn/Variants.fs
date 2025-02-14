namespace Feliz.Shadcn

open System.ComponentModel
open Fable.Core
open Feliz

module Variants =
    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module alertVariant =
        let variant = {|
            ``default`` = prop.custom ("variant", "default")
            destructive = prop.custom ("variant", "destructive")
        |}

    type alert =
        static member variant = alertVariant.variant


    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module badgeVariant =
        let variant = {|
            ``default`` = prop.custom ("variant", "default")
            secondary = prop.custom ("variant", "secondary")
            destructive = prop.custom ("variant", "destructive")
            outline = prop.custom ("variant", "outline")
        |}

    [<Erase>]
    type badge =
        static member variant = badgeVariant.variant


    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module buttonVariant =
        let variant = {|
            ``default`` = prop.custom ("variant", "default")
            destructive = prop.custom ("variant", "destructive")
            outline = prop.custom ("variant", "outline")
            secondary = prop.custom ("variant", "secondary")
            ghost = prop.custom ("variant", "ghost")
            link = prop.custom ("variant", "link")
        |}

        let size = {|
            ``default`` = prop.custom ("size", "default")
            sm = prop.custom ("size", "sm")
            lg = prop.custom ("size", "lg")
            icon = prop.custom ("size", "icon")
        |}

    [<Erase>]
    type button =
        static member variant = buttonVariant.variant
        static member size = buttonVariant.size


    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module sheetVariant =
        let side = {|
            top = prop.custom ("side", "top")
            bottom = prop.custom ("side", "bottom")
            left = prop.custom ("side", "left")
            right = prop.custom ("side", "right")
        |}

    [<Erase>]
    type sheet =
        static member side = sheetVariant.side


    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module sidebarVariant =
        let variant = {|
            ``default`` = prop.custom ("variant", "default")
            outline = prop.custom ("variant", "outline")
        |}

        let size = {|
            ``default`` = prop.custom ("size", "default")
            sm = prop.custom ("size", "sm")
            lg = prop.custom ("size", "lg")
        |}

    [<Erase>]
    type sidebar =
        static member variant = sidebarVariant.variant
        static member size = sidebarVariant.size


    [<EditorBrowsable(EditorBrowsableState.Never)>]
    [<Erase>]
    module toggleVariant =
        let variant = {|
            ``default`` = prop.custom ("variant", "default")
            outline = prop.custom ("variant", "outline")
        |}

        let size = {|
            ``default`` = prop.custom ("size", "default")
            sm = prop.custom ("size", "sm")
            lg = prop.custom ("size", "lg")
        |}

    [<Erase>]
    type toggle =
        static member variant = toggleVariant.variant
        static member size = toggleVariant.size
