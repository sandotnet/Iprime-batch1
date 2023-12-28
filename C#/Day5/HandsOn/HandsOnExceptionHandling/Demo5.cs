using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    internal class Demo5
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a,b values");
                byte a = byte.Parse(Console.ReadLine());
                byte b = byte.Parse(Console.ReadLine());
                if (b == 0)
                {
                    throw new DivideByZeroException("b value should not be zero");
                    //throw new DivideByZeroException();
                }
                else
                {
                    int c = a / b;
                    Console.WriteLine(c);
                }

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
