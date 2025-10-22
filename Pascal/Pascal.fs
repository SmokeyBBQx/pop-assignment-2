module Pascal

let rec pascal (nk: int * int) : int =
    let n = fst nk
    let k = snd nk
    match k with
    | 0 -> 1
    | _ when k = n -> 1
    | _ -> pascal (n-1, k-1) + pascal (n-1, k)

let pascalNoRec (nk: int * int) : int = 
    let n = fst nk
    let k = snd nk
    if k = 0 || k = n then 1 else
        let mutable coefficients: int list list = [[1]]
        for i = 1 to n do
            let mutable row = [1]
            let prevRow = coefficients.Head
            for j = 1 to i - 1 do
                row <- prevRow[j - 1] + prevRow[j] :: row
            row <- 1 :: row
            coefficients <- row :: coefficients
        coefficients.Head[k]

let pascalOptional (nk: int * int) : int option =
    let n = fst nk
    let k = snd nk
    match n, k with
    | _ when n < 0 || k < 0 -> None
    | _ when n < k -> None
    | _ -> Some (pascal nk)

let pascalNoRecOptional (nk: int * int) : int option =
    let n = fst nk
    let k = snd nk
    match n, k with
    | _ when n < 0 || k < 0 -> None
    | _ when n < k -> None
    | _ -> Some (pascalNoRec nk)