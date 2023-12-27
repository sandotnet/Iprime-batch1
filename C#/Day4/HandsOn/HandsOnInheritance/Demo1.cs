using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class X
    {
        private int a;
        public int b;
        protected int c;
        internal int d;
    }
    class Y:X
    {
        public void M()
        {
            //a is private so we can't access
            b = 30;
            c = 90; //c is protected and access in inherited class
            d = 78;
        }
    }
    internal class Demo1
    {
        static void Main()
        {
            Y obj = new Y();
            //private and protected data not accessable using object refernce
            obj.b = 90;
            obj.d = 8;
        }
    }
}
