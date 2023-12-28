using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    internal class Demo1
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a,b values");
                byte a=byte.Parse(Console.ReadLine());
                byte b=byte.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
                Console.WriteLine("Thank U");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("b value should not be zero");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Enter only numbers");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("enter values between 1 to 255");
            }
        }
    }
}
