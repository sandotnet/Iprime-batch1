using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
   
    internal class Demo5
    {
        static void Main()
        {
            DateTime orderdate;
            orderdate = DateTime.Now; //current date
            Console.WriteLine(orderdate);
            Console.WriteLine(DateTime.Now.ToLongDateString()); //return date in long format
            Console.WriteLine(DateTime.Now.ToShortDateString()); //return date in small format
            orderdate = DateTime.Parse("2/23/2000"); //string value should be in mm/dd/yy format
            Console.WriteLine(orderdate);
            orderdate = new DateTime(2000, 2, 23);
            Console.WriteLine(orderdate);
            var obj = new { Id = 1, Name = "Rana" }; //anonymous object
            Console.WriteLine(obj.Id+ ", " + obj.Name); 
        }
    }
}
