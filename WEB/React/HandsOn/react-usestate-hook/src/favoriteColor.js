import React, { useState } from "react";

export default function FavoriteColor() {
  //define state
  const [color, setColor] = useState("Green");
  const chageColor = () => {
    setColor("Red");
  };
  return (
    <div>
      <h2>My FavoriteColor is {color}</h2>
      <button type="button" onClick={chageColor}>
        Change Color
      </button>
      <button type="button" onClick={() => setColor("Orange")}>
        Orange
      </button>
      <button type="button" onClick={() => setColor("Green")}>
        Green
      </button>
    </div>
  );
}
