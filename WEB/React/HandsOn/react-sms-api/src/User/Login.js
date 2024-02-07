import { useState } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";
const Login = (e) => {
  const navigate = useNavigate();
  const [user, setUser] = useState({ email: "", password: "" });
  const [err, setErr] = useState("");
  const Validate = (e) => {
    e.preventDefault();
    axios
      .post("http://localhost:5066/api/User/Login", user)
      .then((response) => {
        console.log(response.data);
        let validUser = response.data;
        if (validUser != null) {
          //set username in sessionstorage
          sessionStorage.setItem("uid", validUser.userId);
          sessionStorage.setItem("token", validUser.token);
          if (validUser.role === "Admin") {
            navigate("/admin-dashboard");
          } else if (validUser.role === "Student") {
            navigate("/student-dashboard");
          } else if (validUser.role === "Tutor") {
            navigate("/teacher-dashboard");
          }
        } else {
          setErr("Invalid User Credentials");
        }
      })
      .catch((err) => console.log(err));
  };
  return (
    <div className="container">
      <form onSubmit={Validate}>
        <table className="table table-bordered">
          <tr>
            <td>UserName</td>
            <td>
              <input
                type="text"
                value={user.email}
                onChange={(e) =>
                  setUser((prevstate) => ({
                    ...prevstate,
                    email: e.target.value,
                  }))
                }
              />
            </td>
          </tr>
          <tr>
            <td>Password</td>
            <td>
              <input
                type="password"
                value={user.password}
                onChange={(e) =>
                  setUser((prevstate) => ({
                    ...prevstate,
                    password: e.target.value,
                  }))
                }
              />
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <button type="submit">Login</button>
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <span className="text-warning">{err}</span>
            </td>
          </tr>
        </table>
      </form>
    </div>
  );
};
export default Login;
