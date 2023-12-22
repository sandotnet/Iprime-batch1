using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo2
    {
        static void Main()
        {
            //Array class members
            int []n = { 12, 23, 34, 45, 36, 21 }; //dynamic array
            Console.WriteLine("Size: " + n.Length); //returns size of the array
            Console.WriteLine("Dimension: " + n.Rank); //Rank returns dimenstion of the array
            //sort array elements
            Array.Sort(n);
            foreach (int i in n) Console.WriteLine(i);
            Console.WriteLine();
            //reverse array elements
            Array.Reverse(n);
            foreach (int i in n) Console.WriteLine(i);
            if (Array.BinarySearch(n, 134)>=0) //BinarySearch() search a value with in the array(condition: array value should be in sorted order)
            {
                Console.WriteLine("Value exist");
            }
            else
                Console.WriteLine("Value Not exist");


        }
    }
}
