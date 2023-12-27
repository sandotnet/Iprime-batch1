using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAndProperties
{
    internal class Staff
    {
        private int id;
        public string name;
        public Staff(int id,string name) //constructor
        {
           this.id = id;
            this.name = name;
        }
        //copy constructor
        public Staff(Staff staff)
        {
            this.id = staff.id;
            this.name = staff.name;
        }
        public void Display()
        {
            Console.WriteLine($"ID:{id} Name:{name}");
        }
    }
    class Test_Staff
    {
        static void Main()
        {
            Staff s = new Staff(3434,"Rajan");
            s.Display();
            Staff s1 = new Staff(3456, "Shoban");
            s1.Display();
            Staff[] staffs = new Staff[3];
            staffs[0] = s1; //copy object s1 to staffs[0] it is shallow copy
            s1.name = "Shard";
            staffs[1] = new Staff(s); //copy s object data to staffs[1] and it is deep copy
            s.name = "Ranjan";
            staffs[2] = new Staff(3489, "Mary");
            foreach(Staff ss in staffs)
            {
                ss.Display();
            }
           
        }
    }
}
