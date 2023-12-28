using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    public interface IShape
    {
        void Area();
    }
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void Area()
        {
            Console.WriteLine("Area of Circle: "+Math.PI*radius*radius);
        }
        public void GetShape()
        {
            Console.WriteLine("Its a Circle");
        }
    }
    class Square : IShape
    {
        private double lenght;

        public Square(double lenght)
        {
            this.lenght = lenght;
        }

        public void Area()
        {
            Console.WriteLine("Square Area: "+lenght*lenght);
        }
        public void GetShape()
        {
            Console.WriteLine("Its a Square");
        }
    }
    internal class Demo1
    {
        static void Main()
        {
            Circle c = new Circle(12); //access All circle class members
            c.Area();
            c.GetShape();
            Square s = new Square(3);
            s.Area();
            s.GetShape();
            IShape circle = new Circle(3); //access only interface members with in circle class
            circle.Area();
            IShape square=new Square(3);
            square.Area();

        }
    }
}
