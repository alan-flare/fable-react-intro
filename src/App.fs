module App

open Feliz
open Fable.React
open Browser

ReactDom.render(
  Html.h1 "Hello, world",
  document.getElementById("root"))

(* React Functional Component

function Welcome(props) {
  return <h1>Hello, {props.name}</h1>;
}

*)



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
