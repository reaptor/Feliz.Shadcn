#r "nuget: FSharp.Data"
#load "Common.fsx"

open System
open System.IO
open System.Net
open System.Text.RegularExpressions
open FSharp.Data
open Common

let getRadixProps name =
    try
        let results =
            HtmlDocument.Load($"https://www.radix-ui.com/primitives/docs/components/%s{name}#api-reference")

        let props, _, _, _ =
            results.Descendants()
            |> Seq.fold
                (fun (res, isApiReference, pick, elementName) node ->
                    if node.Name() = "h2" && node.HasAttribute("id", "api-reference") then
                        (res, true, true, elementName)
                    elif
                        node.Name() = "h2" && node.HasAttribute("id", "examples")
                        || node.Name() = "h3" && node.HasAttribute("id", "keyboard-interactions")
                    then
                        (res, false, false, elementName)
                    else if pick && node.Name() = "h3" then
                        (res,
                         isApiReference,
                         true,
                         node.Descendants("a")
                         |> Seq.tryHead
                         |> Option.defaultWith (fun () -> failwith $"'a' not found. %A{node}")
                         |> _.InnerText())
                    else if pick && node.Name() = "table" && node.HasAttribute("class", "rt-TableRootTable") then
                        let props =
                            node.Descendants("tr")
                            |> Seq.choose (fun row ->
                                let codes = row.Descendants("code") |> Seq.toList

                                if codes.Length > 1 then
                                    let trim (s: string) =
                                        s
                                        |> Seq.map int
                                        |> Seq.choose (fun c ->
                                            if
                                                c > 47 && c < 58
                                                || c > 64 && c < 91
                                                || c > 96 && c < 123
                                                || c = 91
                                                || c = 93
                                            then
                                                Some(char c)
                                            else
                                                None)
                                        |> Seq.toArray
                                        |> String

                                    let name = trim (codes[0].InnerText())
                                    let value = trim (codes[1].InnerText())
                                    Some(name, value)
                                else
                                    None)
                            |> Seq.choose (fun (name, value) ->
                                if
                                    name = "[datastate]"
                                    || name = "[dataorientation]"
                                    || name = "[dataside]"
                                    || name = "[dataalign]"
                                    || name = "[datamotion]"
                                    || name.StartsWith("radix")
                                then
                                    None
                                else
                                    Some(name, value))

                        if Seq.length props > 0 then
                            ((camelCase $"""%s{name}%s{elementName.Replace("Root", "")}""", props) :: res,
                             isApiReference,
                             true,
                             elementName)
                        else
                            (res, isApiReference, pick, elementName)
                    else
                        (res, isApiReference, pick, elementName))
                ([], false, false, "")

        props
    with
    | :? WebException as ex when ex.Status = WebExceptionStatus.ProtocolError -> []
    | ex ->
        printfn "Exception for %s: %s" name ex.Message
        []

let radixUi = File.CreateText(Path.Combine(__SOURCE_DIRECTORY__, "RadixUI.fs"))

radixUi.WriteLine(
    """// This file is auto-generated by the Generate.fsx script

namespace Feliz.Shadcn

open System.ComponentModel

[<EditorBrowsable(EditorBrowsableState.Never)>]
[<AutoOpen>]
module RadixUI =
    open Browser.Types
    open Fable.Core
    open Fable.Core.JsInterop
    open Feliz

    let inline mkProperty (name: string, value: obj): IReactProperty = unbox (name, value)

    [<Erase>]
    let inline internal collisionPaddingValue (top: int option) (right: int option) (bottom: int option) (left: int option) =
        createObj [
            "top" ==> Option.defaultValue 0 top
            "right" ==> Option.defaultValue 0 right
            "bottom" ==> Option.defaultValue 0 bottom
            "left" ==> Option.defaultValue 0 left
        ]

    [<Erase>]
    let inline internal directionType () = {|
        ltr = mkProperty ("dir", "ltr")
        rtl = mkProperty ("dir", "rtl")
    |}

    [<Erase>]
    let inline internal orientationType () = {|
        horizontal = mkProperty ("orientation", "horizontal")
        vertical = mkProperty ("orientation", "vertical")
    |}

    [<Erase>]
    let inline internal sideType () = {|
        top = mkProperty ("side", "top")
        right = mkProperty ("side", "right")
        bottom = mkProperty ("side", "bottom")
        left = mkProperty ("side", "left")
    |}

    [<Erase>]
    let inline internal alignType () = {|
        center = mkProperty ("align", "center")
        start = mkProperty ("align", "start")
        end' = mkProperty ("align", "end")
    |}

    [<Erase>]
    let inline internal stickyType () = {|
        always = mkProperty ("sticky", "always")
        partial = mkProperty ("sticky", "partial")
    |}

    [<Erase>]
    let inline internal checkedType () = {|
        boolean = mkProperty ("checkedState", "boolean")
        indeterminate = mkProperty ("checkedState", "indeterminate")
    |}
"""
)

for path in componentPaths do
    let contents = File.ReadAllText(path)

    if contents.Contains("variants: {") then
        printfn $"%s{path} contains variants. Add them manually to Props.fs"

    let exports =
        Regex.Matches(contents, @"export\s*{([^}]+)}")
        |> Seq.filter (fun m -> m.Success && m.Groups.Count > 0)
        |> Seq.collect (fun m -> m.Groups[1].Value.Split(",") |> Array.map _.Trim())
        |> Seq.choose (fun x -> if x.Contains " " || x = "" then None else Some x)
        |> List.ofSeq

    let filename = Path.GetFileNameWithoutExtension(path)

    let elementName =
        exports |> List.skipWhile (fun x -> Char.IsLower x[0]) |> List.head

    let propList =
        exports
        |> List.takeWhile (fun x -> x.StartsWith elementName)
        |> List.filter (fun x -> x <> elementName)

    let allElementNames =
        elementName :: propList |> List.map camelCase |> List.sortDescending

    let radixProps =
        getRadixProps filename
        |> List.filter (fun (name, _) -> List.contains name allElementNames)

    let allProps =
        allElementNames
        |> List.map (fun elName ->
            let rProps = radixProps |> List.tryFind (fun (rName, _) -> rName = elName)

            match rProps with
            | Some rProps' -> rProps'
            | None -> elName, [ "asChild", "boolean" ])

    for name, props in List.rev allProps do
        match name with
        | "accordion" ->
            radixUi.WriteLine
                """
    [<Erase>]
    module internal accordionTypes =
        let inline type' () = {|
            single = mkProperty ("type", "single")
            multiple = mkProperty ("type", "multiple")
        |}
"""
        | "scrollArea" ->
            radixUi.WriteLine
                """
    [<Erase>]
    module internal scrollAreaTypes =
        let inline type' () = {|
            auto = mkProperty ("type", "auto")
            always = mkProperty ("type", "always")
            scroll = mkProperty ("type", "scroll")
            hover = mkProperty ("type", "hover")
        |}
"""
        | "tabs" ->
            radixUi.WriteLine
                """
    [<Erase>]
    module internal tabsTypes =
        let inline activationMode () = {|
            automatic = mkProperty ("activationMode", "automatic")
            manual = mkProperty ("activationMode", "manual")
        |}
"""
        | "toggleGroup" ->
            radixUi.WriteLine
                """
    [<Erase>]
    module internal toggleGroupTypes =
        let inline type' () = {|
            single = mkProperty ("activationMode", "single")
            multiple = mkProperty ("activationMode", "multiple")
        |}
"""
        | "selectContent" ->
            radixUi.WriteLine
                """
    [<Erase>]
    module internal selectContentTypes =
        let inline position () = {|
            itemAligned = mkProperty ("position", "item-aligned")
            popper = mkProperty ("position", "popper")
        |}
"""
        | _ -> ()

        radixUi.WriteLine(
            $"""    [<RequireQualifiedAccess>]
    type %s{name} ="""
        )

        for propName, propType in props do
            let safePropName =
                propName
                    .Trim()
                    .Replace("root", elementName)
                    .Replace("type", "type'")
                    .Replace("open", "open'")
                    .Replace("checked", "checked'")

            let propType =
                propType
                    .Trim()
                    .Replace("boolean", "bool")
                    .Replace("boolindeterminate", "bool")
                    .Replace("string[]", "string seq")

            let defaultFn propType =
                if propName = "asChild" then
                    radixUi.WriteLine(
                        $"""        static member inline %s{safePropName}: IReactProperty = mkProperty ("%s{propName}", null)"""
                    )
                else if propType = "number" then
                    radixUi.WriteLine(
                        $"""        static member inline %s{safePropName} (value: int): IReactProperty = mkProperty ("%s{propName}", value)"""
                    )

                    radixUi.WriteLine(
                        $"""        static member inline %s{safePropName} (value: float): IReactProperty = mkProperty ("%s{propName}", value)"""
                    )
                else if propType = "number option" then
                    radixUi.WriteLine(
                        $"""        static member inline %s{safePropName} (value: int option): IReactProperty = mkProperty ("%s{propName}", value)"""
                    )

                    radixUi.WriteLine(
                        $"""        static member inline %s{safePropName} (value: float option): IReactProperty = mkProperty ("%s{propName}", value)"""
                    )
                else if propType = "number[]" then
                    radixUi.WriteLine(
                        $"""        static member inline %s{safePropName} (value: int list): IReactProperty = mkProperty ("%s{propName}", value)"""
                    )

                    radixUi.WriteLine(
                        $"""        static member inline %s{safePropName} (value: float list): IReactProperty = mkProperty ("%s{propName}", value)"""
                    )
                else if propType = "number [] -> unit" then
                    radixUi.WriteLine(
                        $"""        static member inline %s{safePropName} (value: int list -> unit): IReactProperty = mkProperty ("%s{propName}", value)"""
                    )

                    radixUi.WriteLine(
                        $"""        static member inline %s{safePropName} (value: float list -> unit): IReactProperty = mkProperty ("%s{propName}", value)"""
                    )
                else
                    radixUi.WriteLine(
                        $"""        static member inline %s{safePropName} (value: %s{propType}): IReactProperty = mkProperty ("%s{propName}", value)"""
                    )

            let enumFn body =
                radixUi.WriteLine($"""        static member inline %s{safePropName} = %s{body}""")

            let commonProps propType =
                match propName, propType with
                | "dir", "enum" -> enumFn "directionType ()"
                | "orientation", "enum" -> enumFn "orientationType ()"
                | "side", "enum" -> enumFn "sideType ()"
                | "align", "enum" -> enumFn "alignType ()"
                | "sticky", "enum" -> enumFn "stickyType ()"
                | "value", "numbernull" -> defaultFn "number option"
                | "checked", "booleanindeterminate" -> enumFn "checkedType ()"
                | "onOpenChange", "function"
                | "onCheckedChange", "function" -> defaultFn "bool -> unit"
                | "onOpenAutoFocus", "function"
                | "onCloseAutoFocus", "function"
                | "onInteractOutside", "function"
                | "onSelect", "function" -> defaultFn "Event -> unit"
                | "onEscapeKeyDown", "function" -> defaultFn "KeyboardEvent -> unit"
                | "onPointerDownOutside", "function" -> defaultFn "PointerEvent -> unit"
                | "onFocusOutside", "function" -> defaultFn "FocusEvent -> unit"
                | "onValueChange", "function" -> defaultFn "string -> unit"
                | "collisionBoundary", "Boundary" ->
                    radixUi.WriteLine(
                        """        static member inline collisionBoundary (value: HTMLElement): IReactProperty = mkProperty ("collisionBoundary", value)
        static member inline collisionBoundary (value: HTMLElement array): IReactProperty = mkProperty ("collisionBoundary", value)
"""
                    )
                | "collisionPadding", "numberPadding" ->
                    radixUi.WriteLine(
                        """        static member inline collisionPadding (all: int): IReactProperty = mkProperty ("collisionPadding", all)
        static member inline collisionPadding (?top: int, ?right: int, ?bottom: int, ?left: int) =
            mkProperty ("collisionPadding", collisionPaddingValue top right bottom left)
"""
                    )
                | _, "ReactNode" -> defaultFn "ReactElement"
                | _ -> defaultFn propType

            match name with
            | "accordion" ->
                match safePropName with
                | "type'" -> enumFn "accordionTypes.type' ()"
                | _ -> commonProps propType
            | "avatarImage" ->
                match safePropName with
                | "onLoadingStatusChange" -> defaultFn "string -> unit"
                | _ -> commonProps propType
            | "menubar"
            | "navigationMenu"
            | "radioGroup"
            | "slider" ->
                match safePropName with
                | "onValueChange" -> defaultFn "number [] -> unit"
                | "onValueCommit" -> defaultFn "number [] -> unit"
                | _ -> commonProps propType
            | "checkbox" ->
                match safePropName with
                | "defaultChecked"
                | "onCheckedChange" -> defaultFn "bool option -> unit"
                | _ -> commonProps propType
            | "form" ->
                match safePropName with
                | "onClearServerErrors" -> defaultFn "unit -> unit"
                | _ -> commonProps propType
            | "toggle" ->
                match safePropName with
                | "onPressedChange" -> defaultFn "bool -> unit"
                | _ -> commonProps propType
            | "switch" ->
                match safePropName with
                | "onCheckedChange" -> defaultFn "bool -> unit"
                | _ -> commonProps propType
            | "progress" ->
                match safePropName with
                | "getValueLabel" -> defaultFn "int -> int -> string"
                | _ -> commonProps propType
            | "scrollArea" ->
                match safePropName with
                | "type'" -> enumFn "scrollAreaTypes.type' ()"
                | _ -> commonProps propType
            | "tabs" ->
                match safePropName with
                | "activationMode" -> enumFn "tabsTypes.activationMode ()"
                | _ -> commonProps propType
            | "toggleGroup" ->
                match safePropName with
                | "type'" -> enumFn "toggleGroupTypes.type' ()"
                | _ -> commonProps propType
            | "selectContent" ->
                match safePropName with
                | "position" -> enumFn "selectContentTypes.position ()"
                | _ -> commonProps propType
            | _ -> commonProps propType

        radixUi.WriteLine("")

radixUi.Close()
