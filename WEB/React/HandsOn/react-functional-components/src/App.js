import logo from "./logo.svg";
import "./App.css";
import Greet from "./Greet";
import Message from "./Message";
import Garage from "./Car";
import Shop from "./Product";
import Classroom from "./ClassRoom";
function App() {
  return (
    <div className="App">
      {/* <Greet name="Sachin" age="45" city="Mumbai" />
      <Greet name="Virat" age="35" city="Delhi" />
      <Greet name="Rohith" age="36" city="Banglore" />
      <Message name="Nidhi" />
      <Message name="Akash" />
      <Message name="Saranya" />
      <Greet name="Virat" age="35" city="Delhi">
        <h1>Virat is a Indian Cricketer!!</h1>
      </Greet> */}
      {/* <Garage />
      <Garage brand="Hundai" color="Red" /> */}
      {/* <Shop /> */}
      <Classroom />
    </div>
  );
}

export default App;
