import React from "react";
class Studnet extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      rollno: 3409834,
      name: "Usama",
      std: 4,
      section: "A",
    };
  }
  changeState = () => {
    this.setState({
      section: "B",
    });
  };
  render() {
    return (
      <div>
        <h1>I am {this.state.name}</h1>
        <h3>
          I am studing in {this.state.std} class in section {this.state.section}
        </h3>
        <h4>My RollNo {this.state.rollno}</h4>
        <button type="button" onClick={this.changeState}>
          ClickMe
        </button>
      </div>
    );
  }
}
export default Studnet;
