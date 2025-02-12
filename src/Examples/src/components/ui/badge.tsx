import * as React from "react"
import { Slot } from "@radix-ui/react-slot"
import { cva, type VariantProps } from "class-variance-authority"

import { cn } from "@/lib/utils"

const badgeVariants = cva(
  "inline-flex items-center justify-center rounded-md border border-neutral-200 px-2 py-0.5 text-xs font-semibold w-fit whitespace-nowrap shrink-0 [&>svg]:size-3 gap-1 [&>svg]:pointer-events-none ring-neutral-950/10 dark:ring-neutral-950/20 dark:outline-ring/40 outline-ring/50 focus-visible:ring-4 focus-visible:outline-1 aria-invalid:focus-visible:ring-0 transition-[color,box-shadow] dark:border-neutral-800 dark:ring-neutral-300/10 dark:dark:ring-neutral-300/20",
  {
    variants: {
      variant: {
        default:
          "border-transparent bg-neutral-900 text-neutral-50 shadow-sm [a&]:hover:bg-neutral-900/90 dark:bg-neutral-50 dark:text-neutral-900 dark:[a&]:hover:bg-neutral-50/90",
        secondary:
          "border-transparent bg-neutral-100 text-neutral-900 [a&]:hover:bg-neutral-100/90 dark:bg-neutral-800 dark:text-neutral-50 dark:[a&]:hover:bg-neutral-800/90",
        destructive:
          "border-transparent bg-red-500 text-neutral-50 shadow-sm [a&]:hover:bg-red-500/90 dark:bg-red-900 dark:text-neutral-50 dark:[a&]:hover:bg-red-900/90",
        outline:
          "text-neutral-950 [a&]:hover:bg-neutral-100 [a&]:hover:text-neutral-900 dark:text-neutral-50 dark:[a&]:hover:bg-neutral-800 dark:[a&]:hover:text-neutral-50",
      },
    },
    defaultVariants: {
      variant: "default",
    },
  }
)

function Badge({
  className,
  variant,
  asChild = false,
  ...props
}: React.ComponentProps<"span"> &
  VariantProps<typeof badgeVariants> & { asChild?: boolean }) {
  const Comp = asChild ? Slot : "span"

  return (
    <Comp
      data-slot="badge"
      className={cn(badgeVariants({ variant }), className)}
      {...props}
    />
  )
}

export { Badge, badgeVariants }
