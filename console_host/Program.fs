let a = [|8; 9; 3|]
open ConsoleWithMain 
printfn "Refering module from console app with entry point"
printfn "Non Point Free: %A" (add1ArrayWithArg a)
printfn "Point free: %A" (add1Array a)

open ConsoleNoMain 
printfn "Refering module from console app with no entry point/main"
printfn "Non Point Free: %A" (add1ArrayWithArg a)
printfn "Point free: %A" (add1Array a)