using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo4
    {
        static void Main()
        {
            string[,] logins = new string[5, 2]
            {
                {"Hani","12345" },
                 {"Abay","12345" },
                  {"Harini","12345" },
                   {"Arya","12345" },
                    {"Faris","12345" }

            };
            Console.WriteLine("Enter Username");
            string uname = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pwd=Console.ReadLine();
            bool flag = false;
            for(int i = 0;i<5;i++)
            {
                if (logins[i,0]==uname && logins[i,1]==pwd)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                Console.WriteLine("Valid Student Credentials");
            else
                Console.WriteLine("Invalid Student Credentials");

        }
    }
}
