using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalAndIterativeStatemts
{
    internal class Demo4
    {
        static void Main()
        {
            string name = "Arya";
            int count = 1;
            while (count <= 10)
            {
                Console.WriteLine("Hello " + name);
                count++;
                if (count == 10)
                    break; //loop is terminated
            }
            Console.WriteLine("Thank U");
            Console.WriteLine();
            count = 1;
            name = "Jemes";
            do
            {
                Console.WriteLine("Hello " + name);
                count++;
            } while (count <= 10);

            Console.WriteLine();
            name = "Adithya";
            for(int c=1;c<=100;c++)
            {
                Console.WriteLine("Hello " + name);
                if (c == 10)
                    break;
            }

        }
    }
}
