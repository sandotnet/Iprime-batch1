using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    //classes
    //stucts
    //enums
    //interfaces
    //delegate
    internal class Student
    {
        //class-members like variables,methods,construnctors,properties,distructors and indexers
        //class-variable(default is private)
         public int id;
        public string name;
        public byte age;
         public char gender;
         public void Display() //method
        {
            Console.WriteLine($"Id:{id} Name:{name} " +
                $"Age:{age} Gender:{gender}");
        }
    }
}
