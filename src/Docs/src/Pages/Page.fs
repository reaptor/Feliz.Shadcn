module Docs.Pages.Page

open Feliz
open Feliz.Shadcn
open ElmishLand
open Docs.Shared
open Docs.Pages.Components.Common

type Model = { Dummy: unit }

type Msg = LayoutMsg of Layout.Msg

let init () = { Dummy = () }, Command.none

let update (msg: Msg) (model: Model) =
    match msg with
    | LayoutMsg _ -> model, Command.none

let Code (s: string) =
    Html.pre [
        prop.className "bg-slate-800 text-slate-200 text-sm rounded p-4"
        prop.text s
    ]

let Bold (s: string) =
    Html.span [ prop.className "font-semibold"; prop.text s ]

let InlineCode (s: string) =
    Html.span [
        prop.className "bg-slate-100 rounded py-1 px-2 font-mono text-sm"
        prop.text s
    ]

let view (model: Model) (dispatch: Msg -> unit) =
    Html.article [
        prop.className "max-w-180 flex flex-col gap-4 m-1"
        prop.children [
            UI.Markdown
                """# Introduction

Fable/Feliz types for the Shadcn UI component library.

## TL;DR

### 1. Install Tailwind CSS
https://tailwindcss.com/docs/installation/using-vite

### 2. Install shadcn/ui
```bash
npx shadcn@latest init
npx shadcn@latest add button
```

***Tip: '`npx shadcn@latest add --all`' will install all availabe components***

### 3. Install Feliz.Shadcn
```bash
dotnet add package Feliz.Shadcn
```

### 4. Start using the components

```fsharp
open Feliz.Shadcn

Shadcn.button [
    prop.text "Click me"
    prop.onClick (fun _ -> Browser.Dom.window.alert "Hello, shadcn/ui!")
]
```

## Setting Up Feliz.Shadcn with Elmish Land

Integrating Feliz.Shadcn into your Elmish Land application is straightforward. The following example demonstrates how to set up a basic Elmish Land app
that incorporates Shadcn components.

### 1. Create a new Elmish Land project

```bash
mkdir FelizShadcnIntro
cd FelizShadcnIntro
dotnet new tool-manifest
dotnet tool install elmish-land
dotnet elmish-land init
```

### 2. Install Tailwind CSS

```bash
npm install tailwindcss @tailwindcss/vite
```

### 3. Configure Vite

Add the @tailwindcss/vite plugin and shadcn's component alias to your Vite configuration `vite.config.js`:

```javascript
import { defineConfig } from 'vite'
import path from "path"
import tailwindcss from '@tailwindcss/vite'

export default defineConfig({
    plugins: [
        tailwindcss(),
    ],
    build: {
        outDir: "dist"
    },
    resolve: {
        alias: {
            "@": path.resolve(__dirname, "./src"),
        },
    },
})
```

### 4. Import Tailwind CSS

Create a file named `styles.css` in the root folder of your project and add an `@import` for Tailwind CSS.

```css
@import "tailwindcss";
```

### 5. Add your CSS file to index.html

Add a link to your `styles.css` in the `<head>` section of your `index.html`.

```html
<!DOCTYPE html>
<html lang="en">
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta charset="UTF-8">
        <link href="/styles.css" rel="stylesheet">
        <title>TailwindElmishLand</title>
    </head>
    <body>
        <div id="app"></div>
        <script type="module" src=".elmish-land/App/App.fs.js"></script>
    </body>
</html>
```

### 6. Configure import alias in tsconfig

Create a file named `tsconfig.json` in the root folder of your project and add the following:

```json
{
    "files": [],
    "compilerOptions": {
        "baseUrl": ".",
        "paths": {
            "@/*": [
                "./src/*"
            ]
        }
    }
}
```


### 7. Install shadcn/ui

```bash
npx shadcn@latest init
```

You will be asked a few questions to configure components.json.

### 8. Add Feliz.Shadcn
```bash
dotnet add package Feliz.Shadcn
```

### 9. That's it

You can now start adding components to your project.

```bash
npx shadcn@latest add button
```

The command above will add the Button component to your project. You can then use it in your pages like this:

```fsharp
module FelizShadcnIntro.Pages.Page

open Feliz
open ElmishLand
open FelizShadcnIntro.Shared
open FelizShadcnIntro.Pages
open Feliz.Shadcn

type Model = unit

type Msg =
    | LayoutMsg of Layout.Msg

let init () =
    (),
    Command.none

let update (msg: Msg) (model: Model) =
    match msg with
    | LayoutMsg _ -> model, Command.none

let view (_model: Model) (_dispatch: Msg -> unit) =
    Html.div [
        Shadcn.button [
            prop.text "Click me"
            prop.onClick (fun _ -> Browser.Dom.window.alert "Hello, shadcn/ui!")
        ]
    ]

let page (_shared: SharedModel) (_route: HomeRoute) =
    Page.from init update view () LayoutMsg
```

Run:

```bash
dotnet elmish-land server
```

to start your application.
"""
        ]
    ]

let page (_shared: SharedModel) (_route: HomeRoute) =
    Page.from init update view { Layout.CurrentComponentName = "" } LayoutMsg
