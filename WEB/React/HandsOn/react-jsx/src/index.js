import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
import Greet from "./Greet";
import MyComponent from "./MyComponent";
import MyComponent1 from "./MyComponent1";
import Ex1 from "./ex1";
import Ex4 from "./ex4";
import Ex from "./ex";
const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <React.StrictMode>
    {/* <App /> */}
    {/* <MyComponent1 /> */}
    {/* <Ex4 /> */}
    <Ex />
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
