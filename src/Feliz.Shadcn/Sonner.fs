namespace Feliz.Shadcn

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<RequireQualifiedAccess>]
[<Erase>]
type ToastAction =
    | Element of ReactElement
    | Object of
        {|
            label: string
            onClick: unit -> unit
        |}

[<AllowNullLiteral>]
[<Global>]
type ToastOptions
    [<ParamObject; Emit("$0")>]
    (
        ?className: string,
        ?description: ReactElement,
        ?closeButton: bool,
        ?invert: bool,
        ?duration: int,
        ?position: string,
        ?dismissible: bool,
        ?icon: ReactElement,
        ?action: ToastAction,
        ?cancel: ToastAction,
        ?id': string,
        ?onDismiss: unit -> unit,
        ?onAutoClose: unit -> unit,
        ?containerAriaLabel: string,
        ?actionButtonStyle: IStyleAttribute list,
        ?cancelButtonStyle: IStyleAttribute list
    ) =
    member val className = className
    member val description = description
    member val closeButton = closeButton
    member val invert = invert
    member val duration = duration
    member val position = position
    member val dismissible = dismissible
    member val icon = icon
    member val action = action
    member val cancel = cancel
    member val id' = id'
    member val onDismiss = onDismiss
    member val onAutoClose = onAutoClose
    member val containerAriaLabel = containerAriaLabel
    member val actionButtonStyle = actionButtonStyle
    member val cancelButtonStyle = cancelButtonStyle

module private Interop =
    let toastText (text: string, option: ToastOptions option) : unit = import "toast" "sonner"
    let toastObj: obj = import "toast" "sonner"
    let toastElement (element: ReactElement) : unit = import "toast" "sonner"

[<Erase>]
type Sonner =
    static member toast(text: string, ?options: ToastOptions) : unit = Interop.toastText (text, options)

    static member toastSuccess(text: string, ?options: ToastOptions) : unit =
        Interop.toastObj?success (text, options)

    static member toastError(text: string, ?options: ToastOptions) : unit = Interop.toastObj?error (text, options)

    static member toastLoading(text: string, ?options: ToastOptions) : unit =
        Interop.toastObj?loading (text, options)

    static member toastCustom(element: ReactElement) : unit = Interop.toastElement element
