using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo9
    {
        static void Main()
        {
           List<Student> students =new List<Student>()
                { new Student(1, "Hari"),
                new Student(2, "Ravi"),
                new Student(3, "Narender"),
                new Student(4, "Sandeep") };
            //Retrun first occurence 
            Student s=students.First();
            s=students.Where(s=>s.Name.Length>4).First();
            Console.WriteLine(s.Name);
            //Retrun last occurence 
            s = students.Last();
            s = students.Where(s => s.Name.Length > 4).Last();
            Console.WriteLine(s.Name);
            s = students.Where(s => s.Name.Length > 14).FirstOrDefault(); //return null when expression return no records
            if (s == null)
                Console.WriteLine("No Students");
            s = students.Where(s => s.Name.Length > 14).LastOrDefault(); //return null when expression return no records
            //Single use only when expression return one record
            //It throws exception when expression return more than one record or no records
            s = students.Single(s => s.Id == 3);
            //SingleOrDefault use only when expression return one record
            //It returns default when expression retrun no records
            //It throws exception when expression return more than one record 
            s = students.SingleOrDefault(s => s.Id == 12);
            if (s != null)
                Console.WriteLine(s.Name);
            else
                Console.WriteLine("Invalid Id");
            s = students.SingleOrDefault(s => s.Name == "Naren" && s.Id == 5);

            List<Student> list1 = students.Where(s => s.Name.Length > 4).ToList(); //convert IEnumarable data to List Type
            Student[] students1 = students.Where(s => s.Name.Length > 4).ToArray(); //convert IEnumable data to Array
            Student s1 = students.Where(s => s.Name.Length > 4).ElementAt(0); //return 1st index record
            s1 = students.Where(s => s.Name.Length > 4).ElementAt(1); //return 2nd record

        }
    }
}
