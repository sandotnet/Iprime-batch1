import { React, useState } from "react";
const MyForm = () => {
  let [uname, setName] = useState("");
  return (
    <div className="container">
      <form>
        <table className="table">
          <tr>
            <td>Enter Name</td>
            <td>
              <input
                type="text"
                value={uname}
                onChange={(e) => setName(e.target.value)} //e.target.value returns textbox value
              />
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <button>Greet</button>
            </td>
          </tr>
          <tr>
            <td colSpan={2}>
              <span className="text-primary">Good Morning {uname}</span>
            </td>
          </tr>
        </table>
      </form>
    </div>
  );
};
export default MyForm;
