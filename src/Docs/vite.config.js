import path from 'path'
import { defineConfig } from 'vite'
import tailwindcss from '@tailwindcss/vite'
import react from '@vitejs/plugin-react'

export default defineConfig({
    plugins: [
        tailwindcss(),
        react()
    ],
    base: "/Feliz.Shadcn",
    build: {
        outDir: "dist",
        rollupOptions: {
            external: ['sonner'],
        },
    },
    resolve: {
        alias: {
            "@": path.resolve(__dirname, "./src"),
        },
    },
})
