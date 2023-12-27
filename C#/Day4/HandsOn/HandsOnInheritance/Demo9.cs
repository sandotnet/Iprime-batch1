using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    //In c# every class inherits with Object class
    class Test { }
    class Sample
    {
        private string name;
        public Sample(string name)
        {
            this.name = name;
        }
        public override string ToString() //redefine Tostring() method of Object class
        {
            return "Hello " + name;
        }
    }
    internal class Demo9
    {
        static void Main()
        {
            Test t = new Test();
            Console.WriteLine(t.ToString());
            Sample s = new Sample("Ajay");
            Console.WriteLine(s.ToString());
        }
    }
}
