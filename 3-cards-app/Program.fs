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

let drawCard (tuple: list<int> * list<int>) =
    let deck = fst tuple
    let draw = snd tuple
    let firstCard = deck.Head
    printfn "%i" firstCard

    let hand = draw |> List.append [firstCard]
    (deck.Tail, hand)

let cardValue card =
    let value = card % 13
    if value = 0 then 11
    elif value = 10 || value = 11 || value = 12 then 10
    else value

[<EntryPoint>]
let main argv =
    let cards = [ 0..5 ]
    let hand = [0; 25; 31];

    // cards |> shuffle |> take 3 |> printAll

    let d, h = (cards, hand) |> drawCard |> drawCard
    printfn "Deck: %A Hand: %A" d h

    let sum = List.sumBy(fun card -> cardValue(card)) hand
    printfn "Sum: %i" sum

    0