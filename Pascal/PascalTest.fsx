#r "bin/Debug/net9.0/Pascal.dll"

open Pascal

printfn "%A" (pascal (4, 2))
printfn "%A" (pascalNoRec (10, 5))

printfn "%A" (pascalOptional (-4, -2))
printfn "%A" (pascalOptional (4, 2))
printfn "%A" (pascalNoRecOptional (0, 2))
printfn "%A" (pascalNoRecOptional (1, 1))
