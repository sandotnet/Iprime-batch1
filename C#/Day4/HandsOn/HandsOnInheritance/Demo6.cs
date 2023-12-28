using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    //method hiding
    class Staff
    {
        public int staffId;
        public string staffName;

        public Staff(int staffId, string staffName)
        {
            this.staffId = staffId;
            this.staffName = staffName;
        }
        public void Display()
        {
            Console.WriteLine($"ID:{staffId} Name:{staffName}");
        }
    }
    class Princple:Staff
    {
        public string level;
        new public int staffId;
        public Princple(int staffId, string staffName,string level)
            :base(staffId,staffName)
        {
            this.level = level;
        }

         new public void Display() //new keyword is requred when to defind base functiona in derived class
        {
            base.Display(); //invokes staff display function
            Console.WriteLine($"Level:{level}");
        }
    }
    internal class Demo6
    {
        static void Main()
        {
            Princple obj = new Princple(32443, "Ajay", "Vice Pricple");
            obj.Display(); //invoke Pricple display fn
            Staff ob1 = new Staff(4320943, "Jenny");
            ob1.Display(); //invoke Staff display fn
            Staff ob2 = new Princple(324342,"Jon","Vice Principle"); //object of base class and instance of derived class can access only base class members
            ob2.Display(); //invokes only staff class Display
        }
    }
}
