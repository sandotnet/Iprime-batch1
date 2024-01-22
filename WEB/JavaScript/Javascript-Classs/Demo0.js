class Person {
  constructor() {
    //default constructor
    this.Pid = 1;
    this.Pname = "Ram";
    this.City = "Bangalore";
  }
}
let person = new Person();
console.log(person.Pid + " " + person.Pname + " " + person.City);
let person1 = new Person();
person1.Pid = 2;
person1.Pname = "Virat";
person1.City = "Delhi";
console.log(person1.Pid + " " + person1.Pname + " " + person1.City);
class Product {
  constructor() {
    this.Pid = 0;
    this.Pname = "";
    this.Price = 0;
    this.Stock = 0;
  }
  details() {
    //method
    console.log(
      `Id:${this.Pid} Name:${this.Pname} Price:${this.Price} Stock:${this.Stock}`
    );
  }
}
let product = new Product();
product.Pid = 1;
product.Pname = "Mouse";
product.Price = 400;
product.Stock = 10;
product.details();
