import { React, useState, useEffect } from "react";
const Timer = () => {
  //state
  const [count, setCount] = useState(0);
  useEffect(() => {
    setCount((count) => count + 1);
  }, []); //adding empty brackets calls useEffect only once.
  return <div>I have rendered {count} times!!</div>;
};
export default Timer;
