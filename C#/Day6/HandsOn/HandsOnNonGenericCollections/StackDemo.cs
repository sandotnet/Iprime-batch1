using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class StackDemo
    {
        static void Main()
        {
            Stack obj = new Stack();
            //Add items
            obj.Push("Delhi");
            obj.Push("Hyderabad");
            obj.Push("Mumbai");
            obj.Push("Chennai");
            //access item
            Console.WriteLine(obj.Peek());
            //fetch all
            foreach (var k in obj)
                Console.WriteLine(k);
            //remove item
            obj.Pop();
            Console.WriteLine();
            foreach (var k in obj)
                Console.WriteLine(k);

        }
    }
}
