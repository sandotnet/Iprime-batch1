using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance_1
{
    //Method over riding is a concept of re-defining or extending base functions in derived class
    //base functions are declared using virtual keyword
    //whild override base functions in derived class use override
    class Staff
    {
        public int staffId;
        public string staffName;

        public Staff(int staffId, string staffName)
        {
            this.staffId = staffId;
            this.staffName = staffName;
        }
        public virtual void Display()
        {
            Console.WriteLine($"ID:{staffId} Name:{staffName}");
        }
    }
    class Princple : Staff
    {
        public string level;

        public Princple(int staffId, string staffName, string level)
            : base(staffId, staffName)
        {
            this.level = level;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Level: " + level);
        }


    }
    internal class Demo7
    {
        static void Main()
        {
            Staff obj = null;
            Console.WriteLine("1.Teacher");
            Console.WriteLine("2.Pricple");
            Console.WriteLine("Enter U r choice");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    obj = new Staff(32434, "Rinku");
                    obj.Display();
                    break;
                    case 2:
                    obj = new Princple(30333, "Ajay", "Vice-Principle");
                    obj.Display(); break;   
            }
        }
    }
}
