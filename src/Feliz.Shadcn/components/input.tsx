import * as React from "react"

import { cn } from "@/lib/utils"

function Input({ className, type, ...props }: React.ComponentProps<"input">) {
  return (
    <input
      type={type}
      data-slot="input"
      className={cn(
        "border-neutral-200 file:text-neutral-950 placeholder:text-neutral-500 selection:bg-neutral-900 selection:text-neutral-50 aria-invalid:outline-destructive/60 aria-invalid:ring-red-500/20 dark:aria-invalid:outline-destructive dark:aria-invalid:ring-red-500/50 ring-neutral-950/10 dark:ring-neutral-950/20 dark:outline-ring/40 outline-ring/50 dark:aria-invalid:ring-red-500/40 aria-invalid:border-red-500/60 dark:aria-invalid:border-red-500 flex h-9 w-full min-w-0 rounded-md border bg-transparent px-3 py-1 text-base shadow-xs transition-[color,box-shadow] file:inline-flex file:h-7 file:border-0 file:bg-transparent file:text-sm file:font-medium focus-visible:ring-4 focus-visible:outline-1 disabled:pointer-events-none disabled:cursor-not-allowed disabled:opacity-50 aria-invalid:focus-visible:ring-[3px] aria-invalid:focus-visible:outline-none md:text-sm dark:aria-invalid:focus-visible:ring-4 dark:border-neutral-800 dark:file:text-neutral-50 dark:placeholder:text-neutral-400 dark:selection:bg-neutral-50 dark:selection:text-neutral-900 dark:aria-invalid:ring-red-900/20 dark:dark:aria-invalid:ring-red-900/50 dark:ring-neutral-300/10 dark:dark:ring-neutral-300/20 dark:dark:aria-invalid:ring-red-900/40 dark:aria-invalid:border-red-900/60 dark:dark:aria-invalid:border-red-900",
        className
      )}
      {...props}
    />
  )
}

export { Input }
