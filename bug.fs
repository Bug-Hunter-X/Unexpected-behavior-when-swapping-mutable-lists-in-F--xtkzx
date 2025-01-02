let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 10 which is expected

let tupleSwap (x,y) = (y,x)
let x1 = 10
let y1 = 20
let (x2, y2) = tupleSwap (x1,y1)
printf "%d %d" x2 y2 //This will print 20 10 which is expected as well

let mutable x3 = 10
let mutable y3 = 20
let mutable z3 = 30

let swap3 x y z = 
    let temp = x
    x <- y
    y <- z
    z <- temp

swap3 x3 y3 z3
printf "%d %d %d" x3 y3 z3 //This will print 20 30 10 which is expected

//Consider this:
let mutable a = [1;2;3]
let mutable b = [4;5;6]

let swapList x y = 
    let temp = x
    x <- y
    y <- temp

swapList a b
printf "%A %A" a b //This will print [4;5;6] [4;5;6]  which is unexpected. why? 
//The problem is that when we assign x <- y and y <- temp, the references of x and y point to the same place in memory which is the location of y. So, when y is assigned the value of temp, x also changes to the same value. This happens because lists are mutable and the assignment operator does not create a copy of the list. 
//The solution is to create a new list and copy the values, or to create a new reference to the list. 