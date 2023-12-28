using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    //Multilevel Inheritance
    interface IX
    {
        void M();
    }
    interface IY : IX
    {
        void M1();
    }
    interface IZ : IY
    {
        void M2();
    }
    internal class Demo4
    {
    }
}
