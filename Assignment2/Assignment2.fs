module Assignment2

    open System

    let rec downto1 n =
        if n > 0 then
            n :: downto1(n-1)
        else
           []
    
    let rec downto2 n =
        match n with
        | n when n <= 0 -> []
        | n -> n :: downto2(n-1)
           
    let rec downto3 = function
        | n when n <= 0 -> []
        | n -> n :: downto3(n-1)

    let rec removeOddIdx xs =
        match xs with
        | [] -> []
        | x :: y :: xs -> x :: (removeOddIdx xs)
        | x :: xs -> [x]

    let rec combinePair xs =
        match xs with
        | [] -> []
        | x :: y :: xs -> (x, y) :: combinePair(xs)
        | x :: xs -> []


    type complex = (float * float) // Fill in your type here
    let mkComplex (x : float) (y : float) = complex(x, y)
    let complexToPair (q : complex) =
        match q with
        | (x, y) -> (x, y)
    
    let (|+|) ((a, b) : complex) ((c, d) : complex) = (a + c, b + d) 
    let (|*|) ((a, b) : complex) ((c, d) : complex) = (a*c - b*d, b*c + a*d)
    let (|-|) ((a, b) : complex) ((c, d) : complex) = (a - c, b - d) 
    let (|/|) ((a, b) : complex) ((c, d) : complex)= (a * c + b * d) / (c * c + d * d), (b * c - a * d) / (c * c + d * d)

    let explode1 (x : string) =
        match x with
        | x when x.Length = 0 -> []
        | x -> List.ofArray(x.ToCharArray())

    let rec explode2 (x : string) =
        match x with
        | x when x.Length = 0 -> []
        | x -> x.Chars(0) :: explode2(x.Remove(0, 1))

    let rec implode (q : char list) =
        match q with
        | [] -> ""
        | q :: xs -> q.ToString() + implode(xs)
        
        
    let rec implodeRev (q : char list) =
        match q with
        | [] -> ""
        | q :: xs -> implodeRev(xs) + q.ToString()
    
    let rec implodetoUpper (q : char list) =
        match q with
        | [] -> []
        | q :: xs -> System.Char.ToUpper(q) :: implodetoUpper(xs)
    
    let toUpper x =
        match x with
        | "" -> ""
        | x -> x |> explode1 |> implodetoUpper |> implode

    let rec ack (m, n) =
        match m with
        | m when m = 0 -> n + 1
        | m when m > 0 && n = 0 -> ack(m - 1, 1)
        | m when m > 0 && n > 0 -> ack(m - 1, ack (m, n - 1))