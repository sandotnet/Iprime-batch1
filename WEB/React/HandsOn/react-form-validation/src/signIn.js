import logo from "./logo.svg";
import "./App.css";
import React, { useState } from "react";

function SignIn() {
  const [firstName, setFirstName] = useState(""); // useState to store First Name
  const [lastName, setLastName] = useState(""); // useState to store Last Name
  const [mobile, setMobile] = useState(""); // useState to store Mobile Number
  const [age, setAge] = useState(""); // useState to store Age
  const [email, setEmail] = useState(""); // useState to store Email address of the user
  const [password, setPassword] = useState(""); // useState to store Password

  return (
    <div className="main">
      <form>
        {/* Input Field to insert First Name */}
        <input
          placeholder="First Name"
          onChange={(e) => setFirstName(e.target.value)}
        />
        {/* Input Field to insert Last Name */}
        <input
          placeholder="Last Name"
          onChange={(e) => setLastName(e.target.value)}
        />
        {/*Input Field to insert Mobile Number */}
        <input
          placeholder="Mobile Number"
          onChange={(e) => setMobile(e.target.value)}
        />
        {/*Input Field to insert Age */}
        <input placeholder="Age" onChange={(e) => setAge(e.target.value)} />
        {/*Input Field to insert Email Address of the user */}
        <input placeholder="Email" onChange={(e) => setEmail(e.target.value)} />
        {/*Input Field to insert Password */}
        <input
          placeholder="Password"
          onChange={(e) => setPassword(e.target.value)}
        />
        <br></br>
        <button type="submit">Submit</button>
      </form>
    </div>
  );
}

export default SignIn;
