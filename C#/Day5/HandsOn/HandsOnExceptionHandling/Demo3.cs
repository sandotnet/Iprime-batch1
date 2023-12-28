using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    internal class Demo3
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a,b values");
                byte a = byte.Parse(Console.ReadLine());
                byte b = byte.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
                Console.WriteLine("Thank U");
            }
            catch (Exception ex) //handle all exceptions
            {
                Console.WriteLine(ex.Message); //returns buildin message
                Console.WriteLine(ex.TargetSite); //returns method name
                Console.WriteLine(ex.Source); //returns project name
                Console.WriteLine(ex.StackTrace); //return complete info about error
            }
        }
    }
}
