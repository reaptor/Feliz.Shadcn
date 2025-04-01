#r "nuget: FSharp.Data"

open System
open System.IO

let camelCase (s: string) =
    s.Split('-')
    |> Array.map (fun s -> $"%c{Char.ToUpperInvariant s[0]}%s{s[1..]}")
    |> String.concat ""
    |> fun s -> $"%c{Char.ToLowerInvariant s[0]}%s{s[1..]}"

let componentsDir =
    Path.Combine(__SOURCE_DIRECTORY__, "..", "Docs", "src", "components", "ui")

let componentPaths =
    Directory.GetFiles(componentsDir, "*.tsx")
    |> Array.sortBy Path.GetFileNameWithoutExtension
