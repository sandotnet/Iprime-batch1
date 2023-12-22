using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Class2
    {
        static void Main()
        {
            //object is a reference data type which access any type of data in the form of object
            object obj = null;
            obj = "James";
            obj = 'A';
            obj = 34;
            obj = 45.56;
            obj = true;
            //convert value type to object(boxing)
            int k = 34;
            double d = 34.45;
            decimal dd = 45.6788m;
            //implicit conversion
            object o1 = k;
            object o2 = d;
            object o3 = dd;
            //convert object to value datatype is unboxing
            object o4 = 34;
            int n = (int)o4;
            o4 = 34.56;
            double d1 = (double)o4;
            Console.WriteLine(n);
            Console.WriteLine(d1);
        }
    }
}
