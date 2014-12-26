module LSchemer

let add1 = fun x -> x + 1
let sub1 = fun x -> x - 1
let zero = fun x -> x = 0

let rec plus a b =
    if (zero b) then a
    else (plus (add1 a) (sub1 b))

let rec minus a b =
    if (zero b) then a
    else (minus (sub1 a) (sub1 b))

let rec addtup x =
    match x with
    | head :: tail -> head + addtup tail
    | [] -> 0 

printfn "Sum [1,2,3,4] = %O" (addtup [1..4])

let rec ismember x a =
    match x with
    | head :: tail ->
        if (head = a) then true
        else (ismember tail a)
    | [] -> false

let rec removemember x a =
    match x with
    | head :: tail ->
        if (head = a) then (removemember tail a)
        else head :: (removemember tail a)
    | [] -> []

let rec substitute x a b =
    match x with
    | head :: tail ->
        if (head = a) then b :: (substitute tail a b)
        else head :: (substitute tail a b)
    | [] -> []

printfn "Substitute 3 for 4 in [1,4,4,1,1,4] = %O" (substitute [1;4;4;4;1;4] 4 3)
    