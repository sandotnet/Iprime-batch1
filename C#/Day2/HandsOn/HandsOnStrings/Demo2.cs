using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    internal class Demo2
    {
        static void Main()
        {
            StringBuilder obj= new StringBuilder(); //it is mutable
            obj.AppendLine("Good Morning");
            Console.WriteLine(obj);
            obj.Replace("Morning", "Evening");
            Console.WriteLine(obj);
            string s = "Good Morning";
            Console.WriteLine(s);
            s.Replace("Morning", "Evening");
            Console.WriteLine(s);
        }
    }
}
