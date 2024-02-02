import { React, useState, useEffect } from "react";
import axios from "axios";
const GetStudents = () => {
  const [students, getStudents] = useState([]);
  useEffect(() => {
    axios
      .get("http://localhost:5066/api/Student/GetStudents")
      .then((response) => {
        console.log(response.data); //response.data return json data send by API
        getStudents(response.data); //add response data to students state
      })
      .catch((error) => {
        console.log(error);
      });
  },[]);
  return (
    <div className="container">
      <table className="table table-striped">
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Class</th>
            <th>Section</th>
          </tr>
        </thead>
        <tbody>
          {students.map((student) => {
            return (
              <tr key={student.id}>
                <td>{student.id}</td>
                <td>{student.name}</td>
                <td>{student.std}</td>
                <td>{student.section}</td>
              </tr>
            );
          })}
        </tbody>
      </table>
    </div>
  );
};
export default GetStudents;
