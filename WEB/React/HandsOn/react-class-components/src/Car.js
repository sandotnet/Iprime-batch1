import React, { Component } from "react";

class Car extends Component {
  render() {
    return (
      <div>
        <h2 style={{ color: this.props.color }}>
          I am a Car!!! with {this.props.color} Color
        </h2>
      </div>
    );
  }
}
class Garage extends Component {
  render() {
    return (
      <>
        <Car color="Red"></Car>
        <Car color="Green"></Car>
      </>
    );
  }
}
export default Garage;
