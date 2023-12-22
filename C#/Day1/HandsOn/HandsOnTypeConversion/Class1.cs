using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Class1
    {
        static void Main()
        {
            //convert values from reference type to value type
            string s = "233";
            //Parse() used to convert string to any value type
            int k=int.Parse(s); //convet string to int
            byte b = byte.Parse(s);
            short ss=short.Parse(s);
            double d=double.Parse(s);
            float f=float.Parse(s);
            decimal dd=decimal.Parse(s);
            //int m=int.Parse("ASD"); //format exception

            //convert values from value type to string type
            int k1 = 34;
            string s1 = k1.ToString(); //convet any value to string
            double d1 = 34.56;
            s1 = s1.ToString();
        }
    }
}
