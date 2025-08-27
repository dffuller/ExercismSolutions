module Grains

open System

let bigintpower (b: uint64) (e: int) : uint64 =
  if e < 0 then
    failwith "Exponent cannot be negative for uint64 power"
  elif e = 0 then
    1UL
  else
    let mutable result = 1UL
    for _ in 1 .. e do
      result <- result * b
    result

let square (n: int): Result<uint64,string> =
  if n < 1 || n > 64 then 
    Error "square must be between 1 and 64"
  else 
    Ok(bigintpower 2UL (n-1))

let total: Result<uint64,string> = 
  if 1<0 then
    Error "bad logic"
  else
    Ok((bigintpower 2UL 64) - 1UL)
