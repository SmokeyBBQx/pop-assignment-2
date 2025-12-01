#r "bin/Debug/net9.0/Pascal.dll"

open Pascal

// Examples
printfn "%A" (pascal (4, 2))
printfn "%A" (pascalNoRec (10, 5))

printfn "%A" (pascalOptional (-4, -2))
printfn "%A" (pascalOptional (4, 2))
printfn "%A" (pascalNoRecOptional (0, 2))
printfn "%A" (pascalNoRecOptional (1, 1))

// Tests
let hasPropertyOne (nk: int * int) : bool =
    let n = fst nk
    let k = snd nk
    match pascalOptional nk with
    | None -> false
    | Some result ->
        if k = 0 || k = n then
            result = 1
        else
            true

let hasPropertyOneNoRec (nk: int * int) : bool =
    let n = fst nk
    let k = snd nk
    match pascalNoRecOptional nk with
    | None -> false
    | Some result ->
        if k = 0 || k = n then
            result = 1
        else
            true

let hasPropertyTwo (nk: int * int) : bool =
    let n = fst nk
    let k = snd nk
    match pascalOptional nk with
    | None -> false
    | Some result ->
        if k > 0 && k < n then
            match pascalOptional (n-1, k-1), pascalOptional (n-1, k) with
            | Some left, Some right -> result = left + right
            | _ -> false
        else
            true


let hasPropertyTwoNoRec (nk: int * int) : bool =
    let n = fst nk
    let k = snd nk
    match pascalNoRecOptional nk with
    | None -> false
    | Some result ->
        if k > 0 && k < n then
            match pascalNoRecOptional (n-1, k-1), pascalNoRecOptional (n-1, k) with
            | Some left, Some right -> result = left + right
            | _ -> false
        else
            true

let partition1Cases = [
    0, 0
    1, 0
    5, 0
    System.Int32.MaxValue, 0
]

let partition2Cases = [
    0, 0
    1, 1
    System.Int32.MaxValue, System.Int32.MaxValue
]

let partition3Cases = [
    2, 1
    4, 2
    // System.Int32.MaxValue, 1 // Stack Overflow
    // System.Int32.MaxValue, 4 // Stack Overflow
]

let test testProperty testCases =
    let testResults = List.map testProperty testCases
    for i in testResults do
        printfn "%b" i

printfn " "

printfn "Test Results"

printfn " "

printfn "RECURSIVE PASCEL"
printfn "Partition 1: k = 0"
test hasPropertyOne partition1Cases
printfn "Partition 2: k = n"
test hasPropertyOne partition2Cases
printfn "Partition 3: 0 < k < n"
test hasPropertyTwo partition3Cases

printfn " "

printfn "NON-RECURSIVE PASCEL"
printfn "Partition 1: k = 0"
test  hasPropertyOneNoRec partition1Cases
printfn "Partition 2: k = n"
test  hasPropertyOneNoRec partition2Cases
printfn "Partition 3: 0 < k < n"
test hasPropertyTwoNoRec partition3Cases