using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class SortedListDemo
    {
        static void Main()
        {
            SortedList obj = new SortedList();
            //add key-value pairs to hashtable
            obj.Add(56788, "Rohan");
            obj.Add(12345, "Jemes");
            obj.Add(34521, "Karan");
            obj.Add(90988, "Joy");
            //access a key-value
            string name = obj[34521].ToString(); //convert object to string
            //remove key-pair
            obj.Remove(90988);
            //access all key-value pairs
            foreach (int k in obj.Keys)
            {
                Console.WriteLine($"ID:{k} Name:{obj[k]}");
            }
        }
    }
}
