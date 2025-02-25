module Assignment1

    open System
    
    //Write a function sqr : int -> int that given an integer x returns x squared
    let sqr x = x * x
    
    //Write a function pow : float -> float -> float that given two floating point numbers x and n returns x to the power of n
    let pow x n = Math.Pow(x, n)
    
    //Write a recursive function sum : int -> int such that given an integer n such that n 0 returns the sum of all integers from 0 to n inclusive.
    let rec sum = function
        |   0 -> 0
        |   n -> n + sum(n-1)  
    //You can write both sum(n-1) like above but it will also work with sum n-1.
    //Just remember not to have spaces between the params or it will not work
    //So n-1 will but n - 1 will not work
    let rec sumAlt = function
        |   0 -> 0
        |   n -> n + sum n-1  
    

    //Fibonacci with recursion. Write a function fib : int -> int
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