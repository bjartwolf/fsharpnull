module FooLib

let add1 x = x + 1

let add1Array = Array.map add1
let add1ArrayWithArg a = a |> Array.map add1

[<EntryPoint>]
let main args =
    0

