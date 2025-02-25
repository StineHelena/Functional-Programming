module Reduplication

open System

let text = Console.ReadLine()

let line = Console.ReadLine()
let number = int line

printfn "%s" (String.replicate number text)