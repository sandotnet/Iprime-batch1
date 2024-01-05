using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{

    internal class Demo3
    {
        static void Main()
        {
            List<Flower> FlowerList = new List<Flower>();
            FlowerList.Add(new Flower("dahlia", 5));
            FlowerList.Add(new Flower("lotus", 20));
            FlowerList.Add(new Flower("lily", 5));
            FlowerList.Add(new Flower("daffodil", 6));
            FlowerList.Add(new Flower("hibiscus", 5));
            //Fetch flowers whos name starts with d
            var result = from f in FlowerList
                         where f.Name.StartsWith("d")
                         select f;
            foreach (var item in result)
            {
                Console.WriteLine($"Name:{item.Name} Petals{item.Petals}");

            }
            //Fetch flowers whos petals are equal to 5
            result = from f1 in FlowerList
                     where f1.Petals == 5
                     select f1;
            //Fetch flowers whos name starts with d and with 5 petals
            result = from f2 in FlowerList
                     where f2.Petals == 5 && f2.Name.StartsWith("d")
                     select f2;
            //Fetch flower with name lily
            result = from f3 in FlowerList
                     where f3.Name == "lily"
                     select f3;
            //Fetch all flowers in an asending order of Name
            result = from f in FlowerList
                     orderby f.Name ascending
                     select f;
            //Fetch all flowers in an desending order of Petals
            result = from f in FlowerList
                     orderby f.Petals descending
                     select f;
           
            Console.Clear();

            //Filter flowers by group by
            var lquery = from Flower flower in FlowerList
                         orderby flower.Petals
                         group flower by flower.Petals;
            foreach (var f in lquery)
            {
                Console.WriteLine("flowers with " + f.Key + " petals: ");
                foreach (var nm in f)
                    Console.WriteLine(" " + nm.Name);
            }
        }

    }
}