// For more information see https://aka.ms/fsharp-console-apps
open System

let mutable num1=0
let mutable num2=0

let leerNum1 =
    printfn "Ingrese el primer número"
    let e1=Console.ReadLine()
    System.Int32.TryParse(e1,&num1)

let leerNum2 =
    printfn "Ingrese el segundo número"
    let e2=Console.ReadLine()
    System.Int32.TryParse(e2,&num2)

let suma n1 n2 : Int32 =
    n1+n2

let resta n1 n2 : Int32 =
    n1-n2

let multi n1 n2 : Int32 =
    n1*n2

let div n1 n2 : float32 =
    n1=n1+0f
    n2=n2+0f
    if n2<>0f then n1/n2
    else 0f

while not leerNum1 do ignore None
while not leerNum2 do ignore None

let s=suma num1 num2
printfn "Suma de los dos números %i " s
let r=resta num1 num2
printfn "Resta de los dos números %i " r
let m=multi num1 num2
printfn "Multiplicación de los dos números %i " m
let d=div (float32(num1)) (float32(num2))
printfn "División de los dos números %f " d
