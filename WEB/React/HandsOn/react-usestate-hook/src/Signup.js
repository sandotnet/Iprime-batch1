import React, { useState } from "react";

function Signup() {
  //   const [name, setName] = useState("Faris");
  //   const [email, setEmail] = useState("faris@gmail.com");
  //   const [address, setAddress] = useState("Chennai");
  const [{ name, email, address }, setUser] = useState({
    name: "Faris",
    email: "faris@gmail.com",
    address: "chennai",
  });
  //   const updateUser = () => {
  //     setUser({
  //       name: "Hani",
  //       email: "hani@gmail.com",
  //       address: address,
  //     });
  //   };
  const updateUser = () => {
    setUser((previouseState) => ({
      ...previouseState,
      name: "Hani",
      email: "hani@gmail.com",
    }));
  };
  return (
    <div>
      <h1>Name:{name}</h1>
      <h1>Email:{email}</h1>
      <h1>Address:{address}</h1>
      <button type="button" onClick={updateUser}>
        Update
      </button>
    </div>
  );
}
export default Signup;
