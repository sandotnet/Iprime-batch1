import React from "react";

export default function Cricket() {
  //   const Shot = () => {
  //     alert("Great Shot!!");
  //   };
  const Shot = (a) => {
    alert("Great Shot!! " + a);
  };
  return (
    <div>
      {/* <button onClick={Shot}>Take the Shot!</button> */}
      <button onClick={() => Shot("Virat")}>Take the Shot!</button>
      <br></br>
      <button onClick={() => Shot("Rohith")}>Take the Shot!</button>
    </div>
  );
}
