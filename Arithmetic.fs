
module Arithmetic


let add (a: float) (b: float) =
    a + b


let subtract (a: float) (b: float) =
    a - b


let multiply (a: float) (b: float) =
    a * b


let divide (a: float) (b: float) =
    if b = 0.0 then
        Error "Нөлге бөлуге болмайды!"
    else
        Ok (a / b)
