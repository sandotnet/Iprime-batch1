using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class QueueDemo
    {
        static void Main()
        {
            Queue obj = new Queue();
            //add items
            obj.Enqueue(12);
            obj.Enqueue(34);
            obj.Enqueue(56);
            obj.Enqueue(67);
            obj.Enqueue(78);
            //return first item
            Console.WriteLine(obj.Peek());
            //remove item
            obj.Dequeue(); //remove first item
            foreach (var k in obj)
                Console.WriteLine(k);


        }
    }
}
