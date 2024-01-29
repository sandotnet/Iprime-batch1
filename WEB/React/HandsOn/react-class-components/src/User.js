import React, { Component } from "react";
class User extends Component {
  constructor() {
    super();
    this.state = {
      name: "guest",
      email: "guest@gmail.com",
    };
  }
  //handler
  chageUser = () => {
    this.setState({
      name: "Chandra",
      email: "chandra@gmail.com",
    });
  };
  render() {
    return (
      <div>
        <h1>Welcome {this.state.name}</h1>
        <h3>Login with email:{this.state.email}</h3>
        <button onClick={this.chageUser}>Click</button>
      </div>
    );
  }
}
export default User;
