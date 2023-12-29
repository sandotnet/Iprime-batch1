using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    internal interface IShape<T> //Generic inteface
    {
        T area();
    }
    class Circle:IShape<int>
    {
        public int area() {
            return 23;
        }
    }
    class Trainagle : IShape<double>
    {
        public double area()
        {
            return 23.34;
        }
    }
}
