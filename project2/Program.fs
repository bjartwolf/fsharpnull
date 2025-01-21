open Foo 
let a = [|8; 9; 3|]
printfn "Program 2 with reference"
printfn "Non Point Free: %A" (add1ArrayWithArg a)
printfn "Point free: %A" (add1Array a)