let x = 10
let y = 20

let add x y = 
    let newX = x + y
    let newY = y + newX
    (newX, newY, newX + newY)

let (newX, newY, result) = add x y
printf "%d %d %d" newX newY result