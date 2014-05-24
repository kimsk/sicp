// Square Roots by Newton's Method
let sqrt x = 
    let goodEnough guess x =
        let square x = x * x
        abs((square guess) - x) < 0.001

    let improve guess x = (guess + (x/guess))/2.

    let rec sqrtIter guess x =
        printfn "%.4f" guess
        if goodEnough guess x then 
            guess
        else
            sqrtIter (improve guess x) x

    sqrtIter 1.0 x

sqrt 16.

