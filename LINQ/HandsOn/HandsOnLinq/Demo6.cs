using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    class Enroll
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public Enroll(int id, string name)
        {
            this.Id = id;
            this.CourseName = name;
        }
    }
    class StudentEnroll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }
        public StudentEnroll(int id, string name,
                           string cname)
        {
            this.Id = id;
            this.Name = name;
            this.CourseName = cname;
        }
    }



    internal class Demo6
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
                new Enroll(4, "Java") ,
             new Enroll(1, "Java") ,};
            //return join data in the form of anonmous object
            //var result = from s in students
            //             join e in enrollments
            //             on s.Id equals e.Id
            //             select new { id = s.Id, name = s.Name, couse = e.CourseName };
            //Fetch Students with Enrollment course using join
            //return join data in the StudentEnroll object form
             var result = from s in students
                         join e in enrollments
                         on s.Id equals e.Id
                         select new StudentEnroll(s.Id, s.Name, e.CourseName);
            foreach(var item in result)
            {
                Console.WriteLine($"Id:{item.Id} Name:{item.Name} Course:{item.CourseName}");
            }
            //Console.Clear();
            //Grouping data using Course
            //var group = from s in students
            //            join e in enrollments
            //            on s.Id equals e.Id
            //            group new StudentEnroll(s.Id, s.Name, e.CourseName)
            //            by e.CourseName;
            //var group = from s in students
            //            join e in enrollments
            //            on s.Id equals e.Id
            //            select new StudentEnroll(s.Id, s.Name, e.CourseName) into temp
            //            group temp by temp.CourseName;

            //foreach (var l in group)
            //{
            //    Console.WriteLine("Students Join in " + l.Key);
            //    foreach (var item in l)
            //    {
            //        Console.WriteLine($"Id:{item.Id} Name:{item.Name} Course:{item.CourseName}");
            //    }
            //}



        }
    }
}
