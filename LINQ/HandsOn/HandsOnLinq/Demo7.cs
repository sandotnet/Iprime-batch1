using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo7
    {
        static void Main()
        {
            string[] flowers = { "dahlia", "rose", "lotus", "lily", 
                "hibiscus", "daffodil" };
           // var result = from f1 in flowers where f1.StartsWith("d") select f1; //query syntax
            IEnumerable<string> f = flowers.Where(flower => flower.StartsWith("d"));
            foreach (string g in f)
            {
                Console.WriteLine(g);
            }
            //sort elements
            f = flowers.OrderBy(flower => flower);
            f=flowers.Where(flower => flower.StartsWith("d")).OrderByDescending(f=>f);


            //group the flowers by its length
            var result = flowers.GroupBy(e => e.Length);
            foreach (var item in result)
            {
                Console.WriteLine("Flowers with length " + item.Key);
                foreach (var k in item)
                { Console.WriteLine(k); }

            }


        }
    }
}
