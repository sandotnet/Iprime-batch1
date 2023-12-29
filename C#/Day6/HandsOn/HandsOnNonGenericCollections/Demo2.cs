using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Product:IComparable
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public override string ToString()
        {
            return $"ID:{Pid} Name:{Pname} Price:{Price} Stock:{Stock}";
        }
       
        public int CompareTo(object obj) // write logic here to sort object data
        {
            return Price.CompareTo(((Product)obj).Price); //sorting objects using price
        }
    }
    class Demo2
    {
        static void Main()
        {
            Product p1 = new Product() { Pid = 2, Pname = "bottle", Price = 200, Stock = 10 };
            Product p2 = new Product() { Pid = 3, Pname = "biscuit", Price = 20, Stock = 10 };
            Product p3 = new Product() { Pid = 4, Pname = "choclate", Price = 20, Stock = 10 };
            Product p4 = new Product() { Pid = 5, Pname = "chips", Price = 20, Stock = 10 };
            ArrayList list = new ArrayList();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            list.Add(new Product() { Pid = 1, Pname = "Cup", Price = 100, Stock = 10 });
            Product p = list[2] as Product; //convert object to Product type
            list.Sort();
            foreach (Product ob in list)
                Console.WriteLine(ob);
        }
    }
}
