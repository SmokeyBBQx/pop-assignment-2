module MyList

// Recursively defined list that can hold elements of any type 'a
type 'a MyList = 
    | Empty // Represents an empty list
    | Something of 'a * 'a MyList // Represents a value and the rest of the list

// Takes an integer n and a MyList list and returns a new MyList containing the first n elements of the original list. 
// If the input list is empty or n < 1, an empty list will be returned.
val take : int -> MyList<'a> -> MyList<'a>

// Takes an integer n and a MyList list and returns a new MyList without the first n elements of the original list. 
// If the input list is empty or n < 1, an empty list will be returned.
val drop : int -> MyList<'a> -> MyList<'a>

// Takes a MyList list and returns an int representing the number of elements it contains.
val length : MyList<'a> -> int

// Takes a function func and a MyList list and returns a new MyList with the function applied to each element of the original list.
// If the input list is empty, an empty list will be returned.
val map : ('a -> 'a) -> MyList<'a> -> MyList<'a>