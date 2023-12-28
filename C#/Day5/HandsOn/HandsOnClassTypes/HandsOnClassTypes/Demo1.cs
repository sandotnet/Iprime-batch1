using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    //sealed class(can not be inherited)
    //sealed classes are instantiated
    class A //base class
    {
        public void M() { }
    }
    sealed class B:A //B is child class
    {
        public void M1() { }
    }
    class C
    {

    }
    class Demo1
    {
        static void Main()
        {
            B obj = new B(); //Sealed class B can create object
            obj.M();
            obj.M1();
        }
    }
}
