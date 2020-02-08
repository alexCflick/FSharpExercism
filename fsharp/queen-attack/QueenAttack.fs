module QueenAttack

//if the x values are the same, they can attack
//if the y values are the same, they can attack

//if -x,+y converge, they can attack
//if -x, -y converge, they can attack
//if +x, +y converge, they can attack
//if +x, -y converge, they can attack
let onBoard x =
    x > 0 && x < 8

let create(x,y) =
    onBoard x && onBoard y

let canAttack (x1, y1) (x2, y2):bool =
    let sameRow = (x1=x2)
    let sameColumn = (y1=y2)
    let sameDiagonal() = (x1 - x2)/(y1-y2) |> abs = 1
    sameRow || sameColumn || sameDiagonal()