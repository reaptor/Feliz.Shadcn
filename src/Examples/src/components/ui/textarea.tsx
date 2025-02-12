import * as React from "react"

import { cn } from "@/lib/utils"

function Textarea({ className, ...props }: React.ComponentProps<"textarea">) {
  return (
    <textarea
      data-slot="textarea"
      className={cn(
        "border-neutral-200 placeholder:text-neutral-500 ring-neutral-950/10 dark:ring-neutral-950/20 dark:outline-ring/40 outline-ring/50 aria-invalid:outline-destructive/60 dark:aria-invalid:outline-destructive dark:aria-invalid:ring-red-500/40 aria-invalid:ring-red-500/20 aria-invalid:border-red-500/60 dark:aria-invalid:border-red-500 dark:aria-invalid:ring-red-500/50 flex field-sizing-content min-h-16 w-full rounded-md border bg-transparent px-3 py-2 text-base shadow-xs transition-[color,box-shadow] focus-visible:ring-4 focus-visible:outline-1 disabled:cursor-not-allowed disabled:opacity-50 aria-invalid:focus-visible:ring-[3px] aria-invalid:focus-visible:outline-none md:text-sm dark:aria-invalid:focus-visible:ring-4 dark:border-neutral-800 dark:placeholder:text-neutral-400 dark:ring-neutral-300/10 dark:dark:ring-neutral-300/20 dark:dark:aria-invalid:ring-red-900/40 dark:aria-invalid:ring-red-900/20 dark:aria-invalid:border-red-900/60 dark:dark:aria-invalid:border-red-900 dark:dark:aria-invalid:ring-red-900/50",
        className
      )}
      {...props}
    />
  )
}

export { Textarea }
