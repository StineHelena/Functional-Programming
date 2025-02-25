module Interpreter.State

    open Result
    open Language
    
    
    
    let reservedVariableName (v : string) =
        let variableNamesList = ["if"; "then"; "else"; "while"; "declare"; "print"; "random"; "fork"; "__result__"]
        match v with
        | v -> variableNamesList |> List.exists (fun v -> v = (v))
        

    let validVariableName _ = failwith "not implemented"
    
    type state = unit // your type goes here
    
    let mkState _ = failwith "not implemented"
    let random _ = failwith "not implemented"
    
    let declare _ = failwith "not implemented"
    
    let getVar _ = failwith "not implemented"
    let setVar _ = failwith "not implemented"
    
    let push _ = failwith "not implemented"
    let pop _ = failwith "not implemented"     