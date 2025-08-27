module InterestIsInteresting

let interestRate (balance: decimal): single =
  match balance with
  | x when x < 0.0m -> single(3.213)
  | x when x < 1000.0m -> single(0.5)
  | x when x < 5000.0m -> single(1.621)
  | _ -> single(2.475)

let interest (balance: decimal): decimal =
  balance * decimal( decimal(interestRate balance) / 100.0m)

let annualBalanceUpdate(balance: decimal): decimal =
  balance + interest balance

let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
  let amount = int(2.0m * (balance) * decimal(taxFreePercentage) / 100.0m)
  if amount < 0 then
    0
  else
    amount
