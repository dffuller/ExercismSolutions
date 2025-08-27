module Allergies

open System

type Allergen =
  | Eggs = 1
  | Peanuts = 2
  | Shellfish = 4
  | Strawberries = 8
  | Tomatoes = 16
  | Chocolate = 32
  | Pollen = 64
  | Cats = 128

let allergicTo (codedAllergies : int) (allergen : Allergen) : bool =
  let allergies = codedAllergies % (2 * int allergen)
  allergies >= int allergen

let list codedAllergies =
  System.Enum.GetValues(typeof<Allergen>) :?> Allergen[]
    |> List.ofArray 
    |> List.filter (allergicTo codedAllergies)
