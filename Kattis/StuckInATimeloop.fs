module StuckInATimeloop

open System

let line = Console.ReadLine()

let number = int line

let rec timeloop n =
    if n <= number then
        printfn "%d Abracadabra" n
        timeloop(n + 1)
    
timeloop 1