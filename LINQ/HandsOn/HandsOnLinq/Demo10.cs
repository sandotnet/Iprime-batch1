using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo10
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
                { new Student(1, "Hari"),
                new Student(2, "Ravi"),
                new Student(3, "Narender"),
                new Student(4, "Sandeep") };
            var result = students.Where(s => s.Name.Length > 4);
            List<Student> l1 = students.Where(s => s.Name.Length > 4).ToList();
            Student[] l2 = students.Where(s => s.Name.Length > 4).ToArray();
            int c = students.Where(s => s.Name.Length > 4).Count();
            int[] n = { 12, 23, 34, 4, 45, 56, 57 };
            int count=n.Where(i=>i%2==0).Count(); //couning even value
            int max = n.Where(i => i % 2 == 0).Max();
            int min = n.Where(i => i % 2 == 0).Min();
            int sum = n.Where(i => i % 2 == 0).Sum();
            double avg = n.Where(i => i % 2 == 0).Average();

        }
    }
}
