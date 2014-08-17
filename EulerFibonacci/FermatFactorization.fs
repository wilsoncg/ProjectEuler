module FermatFactorization

// fun progress(int a, int b2, int N) -> (int, int)
let progress (a, b2, N) = ((a+1),(a*a - N))


let findFactors n =  
    match n with
    | n when (n % 2 = 0) -> (0, 0)
    | _ -> 
        let x = float n
        let a = int (ceil(sqrt(x)))
        let b2 = (a*a - n)
        progress (a, b2, n)

// http://en.wikipedia.org/wiki/Fermat's_factorization_method
// FermatFactor(N): // N should be odd
//  a ← ceil(sqrt(N))
//  b2 ← a*a - N
//  while b2 isn't a square:
//    a ← a + 1 // equivalently: b2 ← b2 + 2*a + 1
//    b2 ← a*a - N // a ← a + 1
//  endwhile
//  return a - sqrt(b2) // or a + sqrt(b2)

//Try:    1       2       3
//a       78      79      80
//b2      125     282     441
//b       11.18   16.79   21