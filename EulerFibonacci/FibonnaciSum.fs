// Learn more about F# at http://fsharp.net

module FibonnaciSum

let rec sum total = function
    | [] -> total
    | head :: tail -> sum (head + total) tail

let rec fibToN = function
 | 1 -> 0
 | 2 -> 1
 | n -> fibToN (n-1) + fibToN (n-2)

let fibs = (0I, 1I) |> Seq.unfold (fun (a, b) -> Some(a, (b, a + b) ) );;

let fibList n = Seq.take n fibs

let fibListUnderFourMillion = Seq.takeWhile (fun x -> x <= 4000000I) fibs

let evenTermsFibList = fibListUnderFourMillion |> Seq.filter (fun x-> x % 2I = 0I)

let rec sumFibToN n = Seq.fold (fun acc elem -> acc + elem) 0I (fibList n)

let sumFibListUnderFourMillion = Seq.fold(fun accumulator element -> accumulator + element) 0I (evenTermsFibList)

let printSeq seq1 = Seq.iter (printf "%A ") seq1; printfn ""

//let rec sumToN n =
//    if n = 1
//    then 1
//    elif n = 2
//    then 3
//    else 4

//let rec factorial n = 
//    if n = 0 
//    then 1 
//    else n * factorial (n - 1)