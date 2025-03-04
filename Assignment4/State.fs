module Interpreter.State

    open Result
    open Language
    
    
    
    let reservedVariableName (v : string) = List.exists ((=) v) ["if"; "then"; "else"; "while"; "declare"; "print"; "random"; "fork"; "__result__"]
    
    let validVariableName (v : string) =
        match v with
        | v when v[0] = '_' -> true
        | v -> System.Char.IsAsciiLetter(char v[0]) || v |> String.forall System.Char.IsAsciiLetterOrDigit
    
    type state = {map : Map<string, int>}
    
    let mkState () = {map = Map.empty }
    let random _ = failwith "not implemented"
    let declare _ = failwith "not implemented"
            
    
    let getVar _ = failwith "not implemented"
    let setVar _ = failwith "not implemented"
    
    let push _ = failwith "not implemented"
    let pop _ = failwith "not implemented"     