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
    let declare x (st : state) =
        match x, st with
        | x, st when (validVariableName(x))
                     && (reservedVariableName(x) = false)
                     && (Map.containsKey x st.map = false) ->
            let st' = {map = Map.add x 0 st.map}
            Some st'
        | _ -> None
    
    let getVar (x : string) (st : state) : int option =
        match x, st with
        | x, st when (Map.containsKey x st.map = true) ->
            let variableV' = Map.find x st.map
            Some variableV'
        | _ -> None
        
    let setVar (x : string) (v : int) (st : state) : state option =
        match x, v, st with
        | x, v, st when (Map.containsKey x st.map = true) ->
            let updateSt' = {map = Map.add x v st.map}
            Some updateSt'
        | _ -> None
    
    let push _ = failwith "not implemented"
    let pop _ = failwith "not implemented"     