using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo1
    {
        static void Main()
        {
            string[] students = new string[5]{
                "Abiya",
                "Arya",
                "Adithya",
                "Faris",
                "Alfia"
            };
            Console.WriteLine("Enter Student Name");
            bool flag = false;
            string name = Console.ReadLine();
            //foreach (string s in students)
            //{
            //    if (s == name)
            //    {
            //        flag = true;
            //        break;
            //    }
            //}
            
            Array.Sort(students);
            if (Array.BinarySearch(students, name) > 0)
            {
                flag = true;
            }
            else
                flag = false;
            if (flag)
            {
                Console.WriteLine($"{name} is " +
                    $"Selected for the Test");
            }
            else
                Console.WriteLine($"{name} is Not " +
                    $"Selected for the Test\nhard luck!!");

        }
    }
}