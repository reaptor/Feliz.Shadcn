module Docs.Pages.Components.Common

open Microsoft.FSharp.Core
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Feliz.Shadcn

[<AutoOpen>]
module Interop =
    import "" "highlight.js/styles/atom-one-dark.css"

    [<AllowNullLiteral>]
    [<Global>]
    type HljsOptions [<ParamObject; Emit("$0")>] (language: string) =
        member val language = language

    [<Erase>]
    type HighlightResult =
        abstract member value: string

    [<Erase>]
    type Hljs =
        abstract member highlight: string -> HljsOptions -> HighlightResult
        abstract member getLanguage: string -> obj option

    let hljs: Hljs = importDefault "highlight.js"

    [<AllowNullLiteral>]
    [<Global>]
    type MarkedOptions
        [<ParamObject; Emit("$0")>]
        (emptyLangClass: string, langPrefix: string, highlight: string -> string -> string) =
        member val emptyLangClass = emptyLangClass
        member val langPrefix = langPrefix
        member val highlight = highlight

    let private markedHighlight: MarkedOptions -> MarkedOptions =
        import "markedHighlight" "marked-highlight"

    [<Import("Marked", "marked")>]
    type Marked(options: MarkedOptions) =
        member _.parse: string -> string = jsNative

    let private marked =
        Marked(
            markedHighlight (
                MarkedOptions(
                    emptyLangClass = "hljs",
                    langPrefix = "hljs language-",
                    highlight =
                        (fun code lang ->
                            let language =
                                if (hljs.getLanguage (lang)).IsSome then
                                    lang
                                else
                                    "plaintext"

                            (hljs.highlight code (HljsOptions lang)).value)
                )
            )
        )

    let parseMarkdown (s: string) = marked?parse (s)

[<Erase>]
type UI =
    static member Header1(s: string) =
        Html.h1 [ prop.className "text-4xl font-bold"; prop.text s ]

    static member Header2(s: string) =
        Html.h2 [ prop.className "text-2xl font-bold"; prop.text s ]

    static member Header3(s: string) =
        Html.h3 [ prop.className "text-xl font-bold"; prop.text s ]

    static member Markdown(s: string) =
        Html.div [ prop.className "markdown"; prop.dangerouslySetInnerHTML (parseMarkdown s) ]

    static member PreviewAndCode(name: string, preview: ReactElement, code: string, ?title: string) =
        Html.div [
            let tabPreview = "preview"
            let tabCode = "code"
            prop.key name
            prop.className "flex flex-col gap-2"

            prop.children [
                match title with
                | Some title' -> UI.Header2 title'
                | None -> ()
                Shadcn.tabs [
                    tabs.defaultValue tabPreview
                    prop.children [
                        Shadcn.tabsList [
                            Shadcn.tabsTrigger [ prop.value tabPreview; prop.text "Preview" ]
                            Shadcn.tabsTrigger [ prop.value tabCode; prop.text "Code" ]
                        ]
                        Shadcn.tabsContent [
                            prop.value tabPreview
                            prop.className "max-w-4xl border rounded p-30 flex justify-center items-center min-h-60"
                            prop.children [ preview ]
                        ]
                        Shadcn.tabsContent [
                            prop.value tabCode
                            prop.className "max-w-4xl border rounded-lg p-4 bg-[#282c34] text-[#abb2bf]"
                            prop.children [
                                Html.pre [
                                    prop.className "text-xs overflow-auto"
                                    prop.children [
                                        Html.code [
                                            let code =
                                                $"""open Feliz
open Feliz.Shadcn

%s{code}
                                                """

                                            prop.dangerouslySetInnerHTML
                                                (hljs.highlight code (HljsOptions "fsharp")).value
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
