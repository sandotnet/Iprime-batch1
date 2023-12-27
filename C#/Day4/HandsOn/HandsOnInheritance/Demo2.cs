using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class I
    {
        public I()
        {
            Console.WriteLine("I Object is Initiated");
        }
    }
    class J:I
    {
        public J()
        {
            Console.WriteLine("J Object is Initiated");
        }
    }

    internal class Demo2
    {
        static void Main()
        {
            J obj=new J();
        }
    }
}
