# Feliz.Shadcn

Fable/Feliz types for the Shadcn UI component library.

Read [the Shadcn documentation](https://ui.shadcn.com) for more information.

## TL;DR

### 1. Install shadcn/ui
https://ui.shadcn.com/docs/installation/vite

### 2. Install Feliz.Shadcn
```bash
dotnet add package Feliz.Shadcn
```

### 3. Start using the components

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
// highlight-start
import path from "path"
import tailwindcss from '@tailwindcss/vite'
// highlight-end

export default defineConfig({
    // highlight-start
    plugins: [
        tailwindcss(),
    ],
    // highlight-end
    build: {
        outDir: "dist"
    },
    // highlight-start
    resolve: {
        alias: {
            "@": path.resolve(__dirname, "./src"),
        },
    },
    // highlight-end
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
        // highlight-start
        <link href="/styles.css" rel="stylesheet">
        // highlight-end
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
// highlight-start
open Feliz.Shadcn
// highlight-end

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
    // highlight-start
    Html.div [
        Shadcn.button [
            prop.text "Click me"
            prop.onClick (fun _ -> Browser.Dom.window.alert "Hello, shadcn/ui!")
        ]
    ]
    // highlight-end

let page (_shared: SharedModel) (_route: HomeRoute) =
    Page.from init update view () LayoutMsg
```

Run:

```bash
dotnet elmish-land server
```

to start your application.
