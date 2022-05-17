module Button

open Feliz

[<ReactComponent>]
let MyButton(label: string) =
  Html.button [
    prop.text label
  ]