using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAndProperties_1
{
    internal class Student
    {
        private int id;
        private string name;
        private int[] marks = { 56, 67, 78, 89, 78, 89 };
        private int total;
        //create a property for id
        public int ID
        {
            get { return id; } //get value of private variable
            set { id = value; } //set value to private variable
        }
        public string NAME
        {
            get { return name; }
            set {  name = value; }
        }
        public int Marks //here Marks prop is used to compute data
        {
            get
            {
                total = 0;
                foreach (int k in marks)
                {
                    total += k;
                }
                return total;
            }
            
        }
        public string Grade
        {
            get
            {
                if (total >= 700)
                    return "A+";
                else if (total >= 600)
                    return "A";
                else if (total >= 500)
                    return "B";
                else
                    return "C";
            }
        }
    }
   class Test_Student
    {
        static void Main()
        {
            Student obj = new Student();
            obj.ID = 4433;
            obj.NAME = "Manoj";
            Console.WriteLine($"Id:{obj.ID} Name:{obj.NAME} Total Marks:{obj.Marks}  Grade:{obj.Grade}");
           
        }
    }
}
