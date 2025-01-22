module ConsoleNoMainEarlyModule

let add1 x = x + 1

let add1Array = Array.map add1
let add1ArrayWithArg a = a |> Array.map add1

printfn "%A" (add1Array [|8; 9; 3|])