using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Class4
    {
        static void Main()
        {
            Console.WriteLine("Enter Employee name");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Id");
            int employeeNumber=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Gender");
            char ch=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Designation");
            string designation=Console.ReadLine();
            Console.WriteLine("Enter Salary");
            double salary=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Employee Details");
            Console.WriteLine($"Name:{employeeName} Id:{employeeNumber} Gender:{ch} Designation:{designation} Salary:{salary}");
        }
    }
}
