using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Class3
    {
        static void Main()
        {
            //convert one type to another type
            //using Convert class we can convert one type another type
            double d = 12.34;
            //convert any value to int use ToInt32()
            int k = Convert.ToInt32(d); //convert double to int
            k=Convert.ToInt32("234"); //convet string to int
            object o = 23;
            k = Convert.ToInt32(o); //convert object to int
            double dd = Convert.ToDouble("3456");
            o = 34.56;
            dd= Convert.ToDouble(o);
            string s = "s";
            char ch = Convert.ToChar(s);
            double ddd = 34.55665;
            s = Convert.ToString(ddd); //convert double to string 
        }
    }
}
