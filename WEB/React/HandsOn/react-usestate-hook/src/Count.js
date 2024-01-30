import React, { useState } from "react";

export default function Count() {
  const [count, setCount] = useState(0);
  const increment = () => {
    setCount(count + 1);
  };
  return (
    <div>
      Count:{count}
      <br></br>
      <button type="button" onClick={increment}>
        Click Me
      </button>
    </div>
  );
}
