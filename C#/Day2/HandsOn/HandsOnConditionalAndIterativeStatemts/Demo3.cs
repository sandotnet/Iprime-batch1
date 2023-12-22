using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalAndIterativeStatemts
{
    internal class Demo3
    {
        static void Main()
        {
            string grade = "C";
            switch(grade)
            {
                case "A++":
                    Console.WriteLine("Prize Money 10,000");
                    break;
                case "A+":
                    {
                        Console.WriteLine("Prize Money 5,000");
                        break;
                    }
                case "A":
                    Console.WriteLine("Prize Money 3,000");
                    break;
                case "B+":
                case "B":
                    Console.WriteLine("Prize Money 1,000");
                    break;
                default:
                    Console.WriteLine("Better luck next time!!");
                    break;
                   
            }
        }
    }
}
