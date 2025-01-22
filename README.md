# Unhandled Exception in C# Loop

This repository demonstrates a common but easily overlooked error in C#: an unhandled exception occurring within a loop. The code includes a `while` loop that simulates some work and throws an exception at a specific iteration. Without proper exception handling, this will cause the application to crash.  The solution demonstrates how to use a `try-catch` block to gracefully handle the exception and prevent application termination.

## Bug

The `bug.cs` file contains the C# code with the unhandled exception.  Running this code will result in the application terminating abruptly when the exception is thrown.

## Solution

The `bugSolution.cs` file provides a corrected version of the code.  A `try-catch` block is added to handle the exception.  This prevents the application from crashing and allows for more controlled error handling.
