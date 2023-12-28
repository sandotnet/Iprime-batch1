using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    interface IA
    {
        void M1();
    }
    interface IB:IA
    {
        void M2();
    }
    class C : IB
    {
        public void M1()
        {
            
        }

        public void M2()
        {
           
        }
    }
    internal class Demo3
    {
    }
}
