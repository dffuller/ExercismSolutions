module ValentinesDay

// TODO: please define the 'Approval' discriminated union type
type Approval =
  | Yes
  | No
  | Maybe

// TODO: please define the 'Cuisine' discriminated union type
type Cuisine =
  | Korean
  | Turkish

// TODO: please define the 'Genre' discriminated union type
type Genre =
  | Crime
  | Horror
  | Romance
  | Thriller

// TODO: please define the 'Activity' discriminated union type
type Activity =
  | BoardGame
  | Chill
  | Movie of Genre
  | Restaurant of Cuisine
  | Walk of int

let rateActivity (activity: Activity): Approval =
  match activity with
  | Movie(g) when g = Romance -> Yes
  | Restaurant(c) -> if (c=Korean) then Yes else Maybe
  | Walk(d) -> if (d < 3) then Yes elif d < 5 then Maybe else No
  | _ -> Approval.No

