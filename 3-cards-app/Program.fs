open System

let cardFace card =
    let no = card % 13
    if no = 1 then "Ace"
    elif no = 0 then "King"
    elif no = 12 then "Queen"
    elif no = 11 then "Jack"
    else string no

let suit card =
    let no = card / 13
    if no = 0 then "Hearts"
    elif no = 1 then "Spades"
    elif no = 2 then "Diamonds"
    else "Clubs"

let shuffle list =
    let random = Random()
    list |> List.sortBy(fun x -> random.Next())

let printCard card = printfn "%s for %s" (cardFace(card)) (suit(card))

let printAll list = List.iter(fun x -> printCard(x)) list

let take n list = List.take n list

let drawCard list =
    printfn "%i" list.Head
    list.Tail

[<EntryPoint>]
let main argv =
    let cards = [ 21; 3; 1; 7; 9; 23 ]

    cards |> shuffle |> take 3 |> printAll

    0