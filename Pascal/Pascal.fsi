module Pascal

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k.
// Will cause out of bounds error if n or k are not natural numbers. Use the optional method to safely call the function.
// May cause stack overflow error when k > 0 and k != n when n is an extreme number.
val pascal : int * int -> int

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k.
// Will cause out of bounds error if n or k are not natural numbers. Use the optional method to safely call the function.
// May cause stack overflow error when k > 0 and k != n when n is an extreme number.
val pascalNoRec : int * int -> int

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k.
// Will return none if n or k are not natural numbers.
// May cause stack overflow error when k > 0 and k != n when n is an extreme number.
val pascalOptional : int * int -> option<int>

// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k.
// Will return none if n or k are not natural numbers.
// May cause stack overflow error when k > 0 and k != n when n is an extreme number.
val pascalNoRecOptional : int * int -> option<int>