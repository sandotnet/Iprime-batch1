import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import App from "./App";
import reportWebVitals from "./reportWebVitals";

const root = ReactDOM.createRoot(document.getElementById("root"));
const myElement = (
  <div>
    <table>
      <tr>
        <th>Name</th>
      </tr>
      <tr>
        <td>Faris</td>
      </tr>
      <tr>
        <td>Chandra</td>
      </tr>
      <tr>
        <td>Anil</td>
      </tr>
    </table>
  </div>
);
root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);
// root.render(<React.StrictMode><App /></React.StrictMode>);
//ReactDOM.render(<App />, document.getElementById("root"));
// ReactDOM.render(<p>Hello</p>, document.getElementById("root"));

// ReactDOM.render(myElement, document.getElementById("root"));
// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
