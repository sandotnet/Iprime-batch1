import React, { useState } from "react";
const items = [
  { id: 1, name: "Hani" },
  { id: 2, name: "Fana" },
  { id: 3, name: "Keerthi" },
  { id: 4, name: "Mahi" },
];
export default function Student() {
  const [students, setStudents] = useState(items);
  const [attendece, setAttendence] = useState([
    {
      id: 1,
      class: "1",
      attDate: new Date().toLocaleDateString(),
      status: "A",
    },
  ]);
  const setAtt = (id, status) => {
    setAttendence((prevs) => [
      ...prevs,
      {
        id: id,
        class: "1",
        attDate: new Date().toLocaleDateString(),
        status: status,
      },
    ]);
    console.log(attendece);
  };
  const updateAttendence = () => {
    for (let atte of attendece) {
      //invoke api endpoint
    }
  };
  return (
    <div>
      <table border={1}>
        <thead>
          <th>Id</th>
          <th>Name</th>
          <th>Attendence</th>
        </thead>
        <tbody>
          {students.map((s) => (
            <tr key={s.id}>
              <td>{s.id}</td>
              <td>{s.name}</td>
              <td>
                <input
                  type="button"
                  value="Present"
                  onClick={(e) => setAtt(s.id, "P")}
                ></input>
              </td>
              <td>
                <input
                  type="button"
                  value="Absent"
                  onClick={(e) => setAtt(s.id, "A")}
                ></input>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
      <hr></hr>
      <table border={1}>
        <thead>
          <th>Id</th>
          <th>Class</th>
          <th>Date</th>
          <th>Attendence</th>
        </thead>
        <tbody>
          {attendece.map((s) => (
            <tr key={s.id}>
              <td>{s.id}</td>
              <td>{s.class}</td>
              <td>{s.attDate}</td>
              <td>{s.status}</td>
            </tr>
          ))}
        </tbody>
      </table>
      <button onClick={updateAttendence}>Update Attendence</button>
    </div>
  );
}
