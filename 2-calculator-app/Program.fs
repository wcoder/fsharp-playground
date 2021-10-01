open System

[<EntryPoint>]
let main argv =
    printfn "Welcome to the calculator program"

    printfn "Type the first number"
    let firstNo = Console.ReadLine()
    printfn "Type the second number"
    let secondNo = Console.ReadLine()
    printfn "First %s, Second %s" firstNo secondNo

    let sum = (int firstNo) + (int secondNo)
    printfn "The sum is %i" sum

    0