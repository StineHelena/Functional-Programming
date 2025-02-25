module Assignment3
    
    let add5 x = x + 5
    let mul3 x = x * 3

    let add5mul3 x = x |> add5 |> mul3
    let add5mul3_2 = add5 >> mul3
    
    let add5_2 f a : int = f a |> add5
    let mul3_2 f a : int = f a |> mul3
  
    let rec downto4 f n e =
        match n with
        | _, n, e when n > 0 -> 
        | n -> e
                
    let rec fac x =
        match x with
        | x when x = 0 -> 1
        | x -> x * downto4(x - 1)
    
    let range g n = failwith "not implemented"
    
    let rec double (lst : int list) =
        match lst with
        | [] -> []
        | lst :: xs -> lst + lst :: double xs
        
    let doubleX x = x + x
    let double_2 (lst : int list) = List.map doubleX lst
    
    let rec stringLength (lst : string list) =
        match lst with
        | [] -> []
        | lst :: xs -> lst.Length :: stringLength xs
        
    let stringLengthX (x : string) = x.Length
    let stringLength_2 (lst : string list) = List.map stringLengthX lst
    
    let rec keepEven (lst : int list) =
        match lst with
        | [] -> []
        | lst :: xs when lst % 2 = 0 -> lst :: keepEven xs
        | lst :: xs -> keepEven xs
    
    let filterIsEven x = x % 2 = 0
    let keepEven_2 (lst : int list) = List.filter filterIsEven lst
    
    let rec keepLengthGT5 (lst : string list) =
        match lst with
        | [] -> []
        | lst :: xs when lst.Length > 5 -> lst :: keepLengthGT5 xs
        | lst :: xs -> keepLengthGT5 xs
        
    let filterKeep5 (x : string) = x.Length > 5
    let keepLengthGT5_2 (lst : string list) = List.filter filterKeep5 lst
    
    
    let rec sumPositive _ = failwith "not implemented"
        
    let rec sumPositive_2 _ = failwith "not implemented"
        
    let rec sumPositive_3 _ = failwith "not implemented"
        
  
    let add5mul3_3 _ = failwith "not implemented"
    
 
    let rec mergeFuns _ = failwith "not implemented"
        
    let rec facFuns _ = failwith "not implemented"
        
    let fac_2 _ = failwith "not implemented"

    let removeOddIdx _= failwith "not implemented"
        
    
    let weird _ = failwith "not implemented"
    
   
    let insert _= failwith "not implemented"
                
    let rec permutations _ = failwith "not implemented"