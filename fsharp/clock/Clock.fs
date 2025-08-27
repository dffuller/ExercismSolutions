module Clock

type Clock = Clock of Minutes:int

let private mih = 60
let private hid = 24
let private mid = mih * hid

let private modulo x y = (x % y + y) % y

let create hours minutes = Clock(modulo (hours * mih + minutes) mid)

let add minutesToAdd (Clock minutes) = create 0 (minutes + minutesToAdd)

let subtract minutesToAdd (Clock minutes) = create 0 (minutes - minutesToAdd)

let display (Clock minutes) = $"%02i{minutes / 60}:%02i{minutes % mih}"
