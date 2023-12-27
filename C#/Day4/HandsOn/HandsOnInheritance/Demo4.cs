using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    //Multi level Inheritance
    public class AA
    {
        public void M() { }
    }
    public class BB : AA
    {
        public void M1()
        {

        }
    }
    public class CC:BB
    {
        public void M2()
        {

        }
    }

    internal class Demo4
    {
        static void Main()
        {
            AA ob = new AA();
            ob.M(); //access only aa members
            BB ob1 = new BB(); //access both aa and bb class members
            ob1.M();
            ob1.M1();
            CC ob2= new CC(); //acess aa,bb and cc class members
            ob2.M();
            ob2.M1();
            ob2.M2();

        }
    }
}
