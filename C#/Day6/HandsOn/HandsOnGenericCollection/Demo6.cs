using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace HandsOnGenericCollection
{
    internal class Demo6
    {
        static void Main()
        {
            Queue<int> obj = new Queue<int>();
            obj.Enqueue(1);
            obj.Enqueue(2);
            obj.Enqueue(3);
            obj.Enqueue(4);
            obj.Enqueue(5);
            foreach (var k in obj)
                Console.WriteLine(k);
            Console.WriteLine();
            Console.WriteLine("picked no: " + obj.Peek()); //get 1st item
            Console.WriteLine("removed no: " + obj.Dequeue()); //remove 1st item

            Console.WriteLine();

            foreach (var k in obj)
                Console.WriteLine(k);
        }
    }
}
