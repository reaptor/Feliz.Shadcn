module Docs.Pages.Components.Common

open Microsoft.FSharp.Core
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Feliz.Shadcn

[<AutoOpen>]
module Interop =
    import "" "highlight.js/styles/atom-one-dark.css"
    let private hljs: obj = importDefault "highlight.js"
    let highlight (code: string) (lang: string) = hljs?highlight(code, {| language = lang |})?value

    let private markedHighlight: obj -> obj = import "markedHighlight" "marked-highlight"

    [<Import("Marked", "marked")>]
    type private Marked(o: obj) = class end

    let private marked =
        Marked(markedHighlight({|
            emptyLangClass = "hljs"
            langPrefix = "hljs language-"
            highlight = fun code lang _ ->
                let language = if hljs?getLanguage(lang) then lang else "plaintext"
                highlight code language
        |}))

    let parseMarkdown (s: string) = marked?parse(s)

type UI =
    static member Header1 (s: string) =
        Html.h1 [
            prop.className "text-3xl font-bold"
            prop.text s
        ]

    static member Header2 (s: string) =
        Html.h3 [
            prop.className "text-md font-semibold"
            prop.text s
        ]

    static member LinkIcon (?size: int) =
        let size = defaultArg size 3
        Svg.svg [
            svg.width 16
            svg.height 16
            svg.viewBox (0, 0, 24, 24)
            svg.fill "none"
            svg.stroke "currentColor"
            svg.strokeWidth 2
            svg.strokeLineCap "round"
            svg.strokeLineJoin "round"
            svg.className $"lucide lucide-external-link h-%i{size} w-%i{size}"
            svg.children [
                Svg.path [
                    svg.d "M15 3h6v6"
                ]
                Svg.path [
                    svg.d "M10 14 21 3"
                ]
                Svg.path [
                    svg.d "M18 13v6a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V8a2 2 0 0 1 2-2h6"
                ]
            ]
        ]

    static member HamburgerIcon (?size: int) =
        let size = defaultArg size 6
        Svg.svg [
            svg.width 24
            svg.height 24
            svg.fill "none"
            svg.viewBox (0, 0, 24, 24)
            svg.strokeWidth 1.5
            svg.stroke "currentColor"
            svg.className $"!size-%i{size}"
            svg.children [
                Svg.path [
                    svg.strokeLineCap "round"
                    svg.strokeLineJoin "round"
                    svg.d "M3.75 9h16.5m-16.5 6.75h16.5"
                ]
            ]
        ]

    static member Markdown (s: string) =
        Html.div [
            prop.className "markdown"
            prop.dangerouslySetInnerHTML (parseMarkdown s)
        ]

    static member PreviewAndCode (name: string, preview: ReactElement, code: string, ?title: string) =
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
                                Shadcn.tabsTrigger [
                                    prop.value tabPreview
                                    prop.text "Preview"
                                ]
                                Shadcn.tabsTrigger [
                                    prop.value tabCode
                                    prop.text "Code"
                                ]
                            ]
                            Shadcn.tabsContent [
                                prop.value tabPreview
                                prop.className "max-w-xl border rounded p-4 flex justify-center"
                                prop.children [
                                    preview
                                ]
                            ]
                            Shadcn.tabsContent [
                                prop.value tabCode
                                prop.className "max-w-4xl border rounded-lg p-4  bg-[#282c34] text-[#abb2bf]"
                                prop.children [
                                    Html.pre [
                                        prop.className "text-xs overflow-auto"
                                        prop.children [
                                            Html.code [
                                                let code = $"""open Feliz
open Feliz.Shadcn

%s{code}
                                                """
                                                prop.dangerouslySetInnerHTML (highlight code "fsharp")
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
