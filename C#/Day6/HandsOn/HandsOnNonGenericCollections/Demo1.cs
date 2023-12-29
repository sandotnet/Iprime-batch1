using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Demo1
    {
        static void Main()
        {
            ArrayList list =
                new ArrayList() { "Rose", "Lilly", "Jasmine", "Tulips" }; //collection initializer
            ArrayList list1 = 
                new ArrayList() { 12, 23, 34, 45, 56, 67 };
            string f = "Jasmine";
            int flag = 0;
           
            foreach(string k in list)
            {
                if(k==f)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
                Console.WriteLine("Flower Exist");
            else
                Console.WriteLine("Not Exist");
            if(list.Contains(f))
                Console.WriteLine("Flower Exist");
            else
                Console.WriteLine("Not Exist");
            list.Sort();
            list.Reverse();
            foreach (string k in list)
            {
                Console.WriteLine(k);
            }

        }
    }
}
