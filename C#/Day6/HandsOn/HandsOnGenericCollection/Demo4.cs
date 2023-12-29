using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace HandsOnGenericCollection
{
    internal class Demo4
    {
        static void Main()
        {
            //Dictionary<int, string> obj = new Dictionary<int, string>();
            SortedDictionary<int,string> obj= new SortedDictionary<int,string>();
            obj.Add(40943, "Faris");
            obj.Add(78000, "Manoj");
            obj.Add(23134, "Ann");
            obj.Add(89765, "George");
            string name = obj[89765];
            Console.WriteLine(name);
           // obj.Remove(23134);//remove key-value pair
            foreach(var key in obj.Keys)
            {
                Console.WriteLine($"Id:{key} Name:{obj[key]}");
            }
            Teacher t1 = new Teacher() { Id = 343, Name = "George", Email = "geroge@gmail.com", Mobile = "909090909", School = "DPS" };
            Teacher t2 = new Teacher() { Id = 897, Name = "Manoj", Email = "manoj@gmail.com", Mobile = "909090989", School = "DPS" };
            Teacher t3 = new Teacher() { Id = 786, Name = "Faris", Email = "faris@gmail.com", Mobile = "909090989", School = "KPH" };
            Dictionary<int, Teacher> ob1 = new Dictionary<int, Teacher>();
            ob1.Add(t1.Id, t1);
            ob1.Add(t2.Id, t2);
            ob1.Add(t3.Id, t3);
            Teacher t = ob1[t1.Id];
            Console.WriteLine($"Name: {t.Name} Email: {t.Email}");

                


                

        }
    }
}
