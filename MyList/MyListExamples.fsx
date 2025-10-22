#r "bin/Debug/net9.0/MyList.dll"

open MyList

// Example list
let listOfThree = Something (1, Something (2, Something (3, Empty)))

printfn "=== Take examples ===" 
// Taking nothing from the list
printfn "Taking 0 elements: %A" (take 0 listOfThree)
// Taking one element from the list
printfn "Taking 1 element: %A" (take 1 listOfThree)
// Taking all elements from the list
printfn "Taking 3 elements: %A" (take 3 listOfThree)

printfn "=== Drop examples ===" 
// Dropping no elements from the list
printfn "Dropping 0 elements: %A" (drop 0 listOfThree)
// Dropping one element from the list
printfn "Dropping 1 element: %A" (drop 1 listOfThree)
// Dropping all elements from the list
printfn "Dropping 3 elements: %A" (drop 3 listOfThree)

printfn "=== Length examples ===" 
// Getting the length of the list
printfn "Getting the length of the list: %A" (length listOfThree)
// Getting the length of the list where two elements have been dropped
printfn "Getting the length of the list where two elements have been dropped: %A" (length (drop 2 listOfThree))
// Getting the length of the list with only the first element
printfn "Getting the length of the list with only the first element: %A" (length (take 1 listOfThree))

printfn "=== Map examples ===" 
// Multiplying each element in the list
printfn "Multiplying each element in the list by 2: %A" (listOfThree |> map (fun(x) -> 2*x)) 
// Returning the same list
printfn "Returning the same list: %A" (listOfThree |> map (fun(x) -> x))
// Setting all values to 0 
printfn "Setting all values to 0: %A" (listOfThree |> map (fun(x) -> x-x))