using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    //abstract class can defind abstract and not abstract methods/normal method
    //abstract method is having only declration not defination
    //abstract class is incomplete class, so we cannot crate object of abstract classes
    //absttract class are inherited
    //when abstract class inherit with any child class, the child class shold impleted all the abstract methods of base class
    //while implement abstract methods in child class use override keyword
    abstract class Shape
    {
        public abstract void Area(); //abstract method having diff implementations in each class
        public void Type() //not abstract method, it is have same implementation for all the classes
        {
            Console.WriteLine("It is a 2D type object");
        }
    }
    class Circle:Shape
    {
        double r;

        public Circle(double r)
        {
            this.r = r;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Cicle " + Math.PI * r * r);
        }
    }
    class Recangle:Shape
    {
        int l;
        int w;

        public Recangle(int l, int w)
        {
            this.l = l;
            this.w = w;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Rectangle " + (l * w));
        }
    }
    class Demo2
    {
        static void Main()
        {
            Shape circle = new Circle(12.23);
            circle.Area();
            Shape rectangle = new Recangle(3, 4);
            rectangle.Area();
            Shape[] shapes = new Shape[2];
            shapes[0] = new Circle(12.3);
            shapes[1] = new Recangle(34, 45);
            foreach (var item in shapes)
                item.Area();
        }
    }
}
