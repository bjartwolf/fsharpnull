let a = [|8; 9; 3|]
open FooLib 
printfn "Refering module from program 3 which is console app with entry point"
printfn "Non Point Free: %A" (add1ArrayWithArg a)
printfn "Point free: %A" (add1Array a)

open Foo 

printfn "Refering module from program 1 which is console app withOUT entry point"
printfn "Non Point Free: %A" (add1ArrayWithArg a)
printfn "Point free: %A" (add1Array a)