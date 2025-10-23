module MyList

type 'a MyList = Empty | Something of 'a * 'a MyList

let rec take (n: int) (list: MyList<'a>) : MyList<'a> =
    if n <= 0 then Empty else
    match list with
    | Empty -> Empty
    | Something (value, rest) -> 
        Something (value, take (n-1) rest)

let rec drop (n: int) (list: MyList<'a>) : MyList<'a> =
    if n <= 0 then list else
    match list with
    | Empty -> Empty
    | Something (value, rest) -> drop (n-1) rest

let length (list: MyList<'a>) : int =
    let rec count n list' =
        match list' with
        | Empty -> n
        | Something (value, rest) -> count (n+1) rest
    count 0 list

let rec map (func: 'a -> 'a) (list: MyList<'a>) : MyList<'a> =
    match list with
        | Empty -> list
        | Something (value, rest) ->
            Something (func value, map func rest)