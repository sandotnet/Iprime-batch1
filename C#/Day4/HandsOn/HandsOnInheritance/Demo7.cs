using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance_1
{
    //Method over riding is a concept of re-defining or extending any base functions in derived class
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
        public virtual void Display() //virtal function
        {
            Console.WriteLine($"ID:{staffId} Name:{staffName}");
        }
        public void Show()
        {

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
        public void Details()
        {

        }


    }
    internal class Demo7
    {
        static void Main()
        {
            Staff obj = new Staff(430943, "Ajay");
            obj.Display(); //invoke Staff Display()
            Princple obj1 = new Princple(4324324, "Anny", "Vice-Prinici");
            obj1.Details();
            obj1.Display(); //invoke Principle Display()
            Staff obj2 = new Princple(3420834, "Renu", "Vice-Princi"); //access all staff functions and overide methods of child class
            obj2.Display(); //invoke Principle Display()

            Staff ob = null;
            Console.WriteLine("1.Teacher");
            Console.WriteLine("2.Pricple");
            Console.WriteLine("Enter U r choice");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    ob = new Staff(32434, "Rinku");
                    ob.Display();
                    break;
                case 2:
                    ob = new Princple(30333, "Ajay", "Vice-Principle");
                    ob.Display(); break;   //can invoke override methods of derived class
            }
        }
    }
}
