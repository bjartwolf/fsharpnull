let a = [|8; 9; 3|]
open FooLib 
printfn "Refering module from program 3 which is lib"
printfn "Non Point Free: %A" (add1ArrayWithArg a)
printfn "Point free: %A" (add1Array a)

open Foo 
printfn "Refering module from program 1 which is exe"
printfn "Non Point Free: %A" (add1ArrayWithArg a)
printfn "Point free: %A" (add1Array a)