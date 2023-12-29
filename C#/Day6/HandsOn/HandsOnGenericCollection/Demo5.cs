using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace HandsOnGenericCollection
{
    internal class Demo5
    {
        static void Main()
        {
            Stack<string> stack = new Stack<string>();
            //add items to stack
            stack.Push("Rose");
            stack.Push("Lilly");
            stack.Push("Jasmine");
            stack.Push("Tulips");
           
            
            foreach (var item in stack)
                Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine("picked item: " + stack.Peek()); //top item picked
            Console.WriteLine("removed item: "+stack.Pop()); //top item removed
            Console.WriteLine();
            foreach (var item in stack)
                Console.WriteLine(item);
            //clear all items
            stack.Clear();
        }
    }
}
