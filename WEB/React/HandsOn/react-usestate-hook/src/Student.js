import React, { useState } from "react";

export default function Student() {
  const [student, setStudent] = useState({
    id: 34023,
    name: "Reshma",
    std: 3,
    section: "A",
  });
  const updateStudent = () => {
    setStudent((previouseState) => ({
      ...previouseState,
      std: 4,
      section: "B",
    }));
  };

  return (
    <div>
      <table border={1} className="table table-striped">
        <thead>
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Class</th>
            <th>Section</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>{student.id}</td>
            <td>{student.name}</td>
            <td>{student.std}</td>
            <td>{student.section}</td>
            <td>
              <button onClick={updateStudent}>Updated</button>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  );
}
