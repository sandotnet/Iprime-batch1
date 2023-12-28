using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    internal class Demo6
    {
        static void Main()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter a,b values");
                    byte a = byte.Parse(Console.ReadLine());
                    byte b = byte.Parse(Console.ReadLine());
                    int c = a / b;
                    Console.WriteLine(c);
                }
                catch(DivideByZeroException ex)
                {
                    throw ex;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
