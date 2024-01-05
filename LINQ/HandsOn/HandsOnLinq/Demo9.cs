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
            s = students.Where(s => s.Name.Length > 14).FirstOrDefault();
            if (s == null)
                Console.WriteLine("No Students");
            s = students.Where(s => s.Name.Length > 14).LastOrDefault();
            //Single use only when expression return one record
            //It throws exception when expression return more than one record or no records
            s = students.Single(s => s.Id == 3);
            //Single use only when expression return one record
            //It returns default when expression retrun no records
            //It throws exception when expression return more than one record 
            s = students.SingleOrDefault(s => s.Id == 12);
            if (s != null)
                Console.WriteLine(s.Name);
            else
                Console.WriteLine("Invalid Id");
            s = students.SingleOrDefault(s => s.Name == "Naren" && s.Id == 5);

        }
    }
}
