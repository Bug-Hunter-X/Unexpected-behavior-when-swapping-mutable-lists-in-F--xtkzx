# F# Mutable List Swap Bug

This repository demonstrates an unexpected behavior when attempting to swap two mutable lists in F#. The issue arises from how F# handles mutable list assignments, leading to unintended side effects.

## Problem Description
The `swapList` function, designed to swap two mutable lists, fails to produce the expected outcome. Instead of swapping the lists' contents, both lists end up referencing the same data after the swap operation. This occurs because the assignment operator in F# does not create a deep copy of mutable lists.  It merely changes the reference.

## Solution
The solution involves creating copies of the lists before assigning them, ensuring that the swap operation modifies independent copies. This maintains the integrity of the original list variables.