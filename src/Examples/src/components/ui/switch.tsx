import * as React from "react"
import * as SwitchPrimitive from "@radix-ui/react-switch"

import { cn } from "@/lib/utils"

function Switch({
  className,
  ...props
}: React.ComponentProps<typeof SwitchPrimitive.Root>) {
  return (
    <SwitchPrimitive.Root
      data-slot="switch"
      className={cn(
        "peer data-[state=checked]:bg-neutral-900 data-[state=unchecked]:bg-neutral-200 ring-neutral-950/10 dark:ring-neutral-950/20 dark:outline-ring/40 outline-ring/50 inline-flex h-5 w-9 shrink-0 items-center rounded-full border-2 border-transparent shadow-xs transition-[color,box-shadow] focus-visible:ring-4 focus-visible:outline-hidden focus-visible:outline-1 disabled:cursor-not-allowed disabled:opacity-50 aria-invalid:focus-visible:ring-0 dark:data-[state=checked]:bg-neutral-50 dark:data-[state=unchecked]:bg-neutral-800 dark:ring-neutral-300/10 dark:dark:ring-neutral-300/20",
        className
      )}
      {...props}
    >
      <SwitchPrimitive.Thumb
        data-slot="switch-thumb"
        className={cn(
          "bg-white pointer-events-none block size-4 rounded-full ring-0 shadow-lg transition-transform data-[state=checked]:translate-x-4 data-[state=unchecked]:translate-x-0 dark:bg-neutral-950"
        )}
      />
    </SwitchPrimitive.Root>
  )
}

export { Switch }
