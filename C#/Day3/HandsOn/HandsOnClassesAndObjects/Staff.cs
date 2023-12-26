using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Staff
    {
        //instance variables(acccess by class object)
        public int staffId;
        public string staffName;
        //static variable(access by class name and change at runtime)
        public static string school;
        public static string branch;
        //const variables(access by classname and can't be chage at runtime)
        public const string city="Hyderabad";
        public string Display()
        {
            return $"Id:{staffId} Name:{staffName} School:{school} Branch:{branch} City:{city}";
        }
        static void Main()
        {
            //access static data
            Staff.school = "DPS";
            Staff.branch = "JublisHills";
            Staff s1 = new Staff() { staffId = 43832, staffName = "Jessy" };
            Staff s3 = new Staff() { staffId = 43878, staffName = "Mani" };
            Staff s2 = new Staff() { staffId = 43823, staffName = "Sujen" };
            Console.WriteLine(s1.Display());
            Console.WriteLine(s2.Display());
            Console.WriteLine(s3.Display());
            Staff.branch = "HitechCity";
            Staff s4 = new Staff() { staffId = 43845, staffName = "Jeetan" };
            Staff s5 = new Staff() { staffId = 43812, staffName = "Hani" };
            Console.WriteLine(s4.Display());
            Console.WriteLine(s5.Display());



        }
    }
}
