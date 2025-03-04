module Interpreter.Eval

    open Interpreter.Language
    open Result
    open Language
    open State
    
    let rec arithEval (a : aexpr) (st : state) : int option =
        match a with
        | Num x -> Some x
        | Var v -> getVar v st
        | Add(b, c) ->
            let b' = arithEval b st
            let c' = arithEval c st
            if b' = None || c' = None then
                None
                else
                Some (b'.Value + c'.Value)
        | Mul(b, c) ->
            let b' = arithEval b st
            let c' = arithEval c st
            if b' = None || c' = None then
                None
                else
                Some (b'.Value * c'.Value)
        | Div(b, c) ->
            let b' = arithEval b st
            let c' = arithEval c st
            if b' = None || c' = None || c'.Value = 0 then
                None
                else
                    Some (b'.Value / c'.Value)
        | Mod(b, c) ->
            let b' = arithEval b st
            let c' = arithEval c st
            if b' = None || c' = None || c'.Value = 0 then
                None
                else
                    Some (b'.Value % c'.Value)
        | _ -> None

    let arithEval2 (a : aexpr) (st : state) : int option =
        match a with
        | Num x -> Some x
        | Var v -> getVar v st
        | Add(b, c) ->
            let b' = arithEval b st
            let c' = arithEval c st
            Some 0
            //Option.bind (fun ry -> ry) y
            //Option.bind (fun rx -> Option.bind (fun ry -> Some (rx + ry))y )x
        | Mul(b, c) ->
            let b' = arithEval b st
            let c' = arithEval c st
            Some (b'.Value * c'.Value)
    let boolEval (b : bexpr) (st : state) : bool option = failwith "not implemented"
    let stmntEval (s : stmnt) (st : state) : state option = failwith "not implemented"