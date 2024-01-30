import React from "react";

export default function Demo2() {
  let countries = ["india", "china", "japan", "usa"];
  const listitems = countries.map((country) => <li>{country}</li>);
  return (
    <div>
      <h2>Country List</h2>
      <ul>
        {countries.map((item) => (
          <li>{item}</li>
        ))}
      </ul>
      <hr />
      <ol>{listitems}</ol>
    </div>
  );
}
