module Assignment1

    open System
    
    let sqr x = x * x

    let pow x n = Math.Pow(x, n)
    
    let rec sum = function
        |   0 -> 0
        |   n -> n + sum(n-1)

    let rec fib = function
        | 0 -> 0
        | 1 -> 1
        | n -> fib(n-1) + fib(n-2)

    let dup x : string = x + x
    //Alternative for dup
    //let dup x : string = String.replicate 2 x
   
    let dupn x n: string = String.replicate n x
    
    //Alternative for dupn
    //let rec dupn (x : string)= function
        //| 0 -> ""
        //| 1 -> x
        //| n -> x + dupn(x) (n-1)
    
    let rec bin = function
        | (0,0) -> 1
        | (n, k) when k = 0 || n = k -> 1
        | (n, k) -> bin(n-1, k-1) + bin(n-1, k)
    
    let readFromConsole () = System.Console.ReadLine().Trim()
    let tryParseInt (str : string) = System.Int32.TryParse str
    
    let rec readInt() =
        let line = readFromConsole()
        let parseInt = tryParseInt(line)
        match parseInt with
        | (false, x) ->
            printfn $"{line} is not an integer"
            readInt()
        | (true, x) ->
            printfn $"{x} is an integer"
            x

    let timediff ((a, b) : int * int) (c, d : int*int) = failwith "not implemented"

    let minutes _ = failwith "not implemented"

    let curry _ = failwith "not implemented"
    let uncurry _ = failwith "not implemented"