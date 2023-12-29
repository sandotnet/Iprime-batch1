using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace HandsOnGenericCollection
{
    class Student
    {
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Demo3
    {
        static void Main()
        {
            List<string> list = new List<string>() { "Rose", "Lilly", "Jasmine", "Tulips" };
            List<bool> list2 = new List<bool>() { true, false, false, true, false };
            List<Student> students = new List<Student>()
            {
                new Student(32323,"Manoj"),
                new Student(90988,"Ann"),
                new Student(32345,"Hani"),
                new Student(12376,"Nedhi"),
                new Student(65434,"Priya"),
            };
            students.Add(new Student(58900, "Varun"));
            Student s = students[4];
            foreach(var k in students)
            {
                Console.WriteLine($"ID:{k.Id} Name:{k.Name}");
            }
           

        }
    }
}
