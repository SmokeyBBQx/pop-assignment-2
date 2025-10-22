module Pascal

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k.
// Will cause out of bounds error if n or k are not natural numbers.
val pascal : int * int -> int

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k.
// Will cause out of bounds error if n or k are not natural numbers.
val pascalNoRec : int * int -> int

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k.
// Will return none if n or k are not natural numbers.
val pascalOptional : int * int -> option<int>

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k.
// Will return none if n or k are not natural numbers.
val pascalNoRecOptional : int * int -> option<int>