module TwoFer

let twoFer (input: string option) =
    defaultArg input "you"
    |> sprintf "One for %s, one for me."