module FermatFactorization

let isSquare y =
    match y with
    | y when (y < 0) -> false
    | _ ->
        let tst = int (sqrt(float y) + 0.5)
        tst*tst = y

let isprime n =
    let rec check i =
        i > n/2 || (n % i <> 0 && check (i + 1))
    check 2

// fun progress(int a, int b2, int N) -> (int, int)
let rec progress a b2 n = 
    match b2 with
    | b2 when not (isSquare b2) -> progress (a+1) ((a+1)*(a+1) - n) n
    | _ -> 
        let b = int (sqrt(float b2))
        [a-b; a+b]

let fermatFactorization n =  
    match n with
    | n when (n % 2 = 0) -> []
    | _ -> 
        let a = int (ceil(sqrt(float n)))
        let b2 = (a*a - n)
        progress a b2 n

let findFactors n = fermatFactorization n

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