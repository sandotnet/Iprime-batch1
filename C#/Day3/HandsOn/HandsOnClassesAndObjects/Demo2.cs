using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Demo2
    {
        public string Greet(string name)
        {
            return "Hello " + name;
        }
      
        public double Sqaure(double a)
        {
            double r = a * a;
            return r;
        }
        public  bool IsEven(int no)
        {
            return no % 2 == 0 ? true : false;
        }
        public int Add(int a, int b=10) //passing default value to parameter
        {
            return a + b;
        }
        static void Main()
        {
            Demo2 demo = new Demo2();
            string result=demo.Greet("Virat");
            Console.WriteLine(result);
            Console.WriteLine(demo.Greet("Sachin"));
            Console.WriteLine(demo.Sqaure(25));
            Console.WriteLine(demo.IsEven(23) ? "Even" : "Odd");
            Console.WriteLine(demo.Add(23, 34));
            Console.WriteLine(demo.Add(21));
            Console.WriteLine(demo.Add(b: 34, a: 12)); //named parameter syntax
        }
    }
}
