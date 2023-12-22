using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Student
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Student App");
            Console.WriteLine("Enter Name");
            string name=Console.ReadLine(); //reads a value from console
            Console.WriteLine("Hello " + name);
        }
    }
}
