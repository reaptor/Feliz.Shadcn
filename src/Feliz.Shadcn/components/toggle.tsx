"use client"

import * as React from "react"
import * as TogglePrimitive from "@radix-ui/react-toggle"
import { cva, type VariantProps } from "class-variance-authority"

import { cn } from "@/lib/utils"

const toggleVariants = cva(
  "inline-flex items-center justify-center gap-2 rounded-md text-sm font-medium transition-colors hover:bg-neutral-100 hover:text-neutral-500 disabled:pointer-events-none disabled:opacity-50 data-[state=on]:bg-neutral-100 data-[state=on]:text-neutral-900 [&_svg]:pointer-events-none [&_svg:not([class*='size-'])]:size-4 [&_svg]:shrink-0 ring-neutral-950/10 dark:ring-neutral-950/20 dark:outline-ring/40 outline-ring/50 focus-visible:ring-4 focus-visible:outline-1 aria-invalid:focus-visible:ring-0 transition-[color,box-shadow] dark:hover:bg-neutral-800 dark:hover:text-neutral-400 dark:data-[state=on]:bg-neutral-800 dark:data-[state=on]:text-neutral-50 dark:ring-neutral-300/10 dark:dark:ring-neutral-300/20",
  {
    variants: {
      variant: {
        default: "bg-transparent",
        outline:
          "border border-neutral-200 bg-transparent shadow-xs hover:bg-neutral-100 hover:text-neutral-900 dark:border-neutral-800 dark:hover:bg-neutral-800 dark:hover:text-neutral-50",
      },
      size: {
        default: "h-9 px-2 min-w-9",
        sm: "h-8 px-1.5 min-w-8",
        lg: "h-10 px-2.5 min-w-10",
      },
    },
    defaultVariants: {
      variant: "default",
      size: "default",
    },
  }
)

function Toggle({
  className,
  variant,
  size,
  ...props
}: React.ComponentProps<typeof TogglePrimitive.Root> &
  VariantProps<typeof toggleVariants>) {
  return (
    <TogglePrimitive.Root
      data-slot="toggle"
      className={cn(toggleVariants({ variant, size, className }))}
      {...props}
    />
  )
}

export { Toggle, toggleVariants }
