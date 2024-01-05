using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo8
    {
        static void Main()
        {
            Student[] students =
                { new Student(1, "Hari"),
                new Student(2, "Ravi"),
                new Student(3, "Narender"),
                new Student(4, "Sandeep") };
            Enroll[] enrollments = { new Enroll(1, ".NET"),
                new Enroll(2, "SAP"),
                new Enroll(3, "SAP"),
                new Enroll(4, "SAP") };
            //Fetch Students with Enrollment course
            var result = from s in students
                         join e in enrollments
                         on s.Id equals e.Id
                         select new StudentEnroll(s.Id, s.Name, e.CourseName);
            result = students.Join(enrollments, s => s.Id, e => e.Id,
                (s, e) => new StudentEnroll(s.Id, s.Name, e.CourseName));
            foreach (var item in result)
            {
                Console.WriteLine($"Id:{item.Id} Name:{item.Name} Course:{item.CourseName}");
            }
            Console.Clear();
            ////Grouping data using Course
            ////var group = from s in students
            ////            join e in enrollments
            ////            on s.Id equals e.Id
            ////            group new StudentEnroll(s.Id, s.Name, e.CourseName)
            ////            by e.CourseName;
            //var group = from s in students
            //            join e in enrollments
            //            on s.Id equals e.Id
            //            select new StudentEnroll(s.Id, s.Name, e.CourseName) into temp
            //            group temp by temp.CourseName;
            var group = students.Join(enrollments, s => s.Id, e => e.Id,
                (s, e) => new StudentEnroll(s.Id, s.Name, e.CourseName))
                .GroupBy(e => e.CourseName);
            foreach (var l in group)
            {
                Console.WriteLine("Students Join in " + l.Key);
                foreach (var item in l)
                {
                    Console.WriteLine($"Id:{item.Id} Name:{item.Name} Course:{item.CourseName}");
                }
            }
        }
    }
}
