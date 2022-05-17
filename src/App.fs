module App

  open Feliz
  open Fable.React
  open Browser
  open Fable.Core

  (* React Functional Component

  function Welcome(props) {
    return <h1>Hello, {props.name}</h1>;
  }

  *)

  [<ReactComponent>]
  let Welcome(props: {| name: string |}) =
    Html.h1 $"Hello, {props.name}"

  (* React Hooks - useState

  function CoinGenerator() {
    const [count, setCount] = useState(0);

    return (
      <div>
        <p>You have {count} coins 💰</p>
        <button onClick={() => setCount(count + 1)}>
          Generate 🚀
        </button>
      </div>
    );
  }

  *)

  [<ReactComponent>]
  let CoinGenerator() =
    let count, setCount = React.useState(0)

    Html.div [
      Html.p [
        prop.text $"You have {count} coins 💰"
      ]
      Html.button [
        prop.onClick (fun _ev -> count + 1 |> setCount)
        prop.text "Generate 🚀"
      ]
    ]













  // npm i -D babel-loader @babel/preset-react
  // create .babelrc
  // modify webpack config

  [<ReactComponent(import="About", from="./About.jsx")>]
  let About (title: string) = React.imported()

  ReactDom.render(
    About "hello",
    document.getElementById("root"))
