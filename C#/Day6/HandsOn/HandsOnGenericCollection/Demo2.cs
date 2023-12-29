using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace HandsOnGenericCollection
{
    internal class Demo2
    {
        static void Main()
        {
            List<int> list=new List<int>();
            //add value
            list.Add(10);
            list.Add(20);
            list.Add(34);
            list.Add(89);
            list.Add(45);
            //access a value
            int k = list[2]; //34
            Console.WriteLine("Count"+list.Count);
            list.Remove(10);
            list.Sort(); //sort list elements
            list.Reverse();
            foreach(var i in list)
                Console.WriteLine(i);

        }
    }
}
