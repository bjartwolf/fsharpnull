module Foo

let add1 x = x + 1

let add1Array = Array.map add1
let add1ArrayWithArg a = a|> Array.map add1

let a = [|1; 2; 3|]
printfn "Program 1 with reference"
printfn "Non Point Free: %A" (add1ArrayWithArg a)
printfn "Point free: %A" (add1Array a)



