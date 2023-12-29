using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    class KeyValue<K,V>
    {
        public K Id { get; set; }
        public V Name { get; set; }
    }
    internal class Demo1
    {
        static void Main()
        {
            KeyValue<int, string> ob = new KeyValue<int, string>();
            ob.Id = 3044;
            ob.Name = "San";
            KeyValue<double, char> ob1 = new KeyValue<double, char>();
            ob1.Id = 434.55;
            ob1.Name = 'a';
        }
    }
}
