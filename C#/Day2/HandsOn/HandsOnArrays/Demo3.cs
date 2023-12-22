using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo3
    {
        static void Main()
        {
            //2-dimensional array
            //datatype [,] array_name=new datatype[row_size,col_size]
            int[,] _2darray = new int[3, 2]; //arrang array elements in 3 rows and 2 columns
            //assign value
            //1st row
            _2darray[0, 0] = 98;
            _2darray[0, 1] = 45;
            //2nd row
            _2darray[1, 0] = 56;
            _2darray[1, 1] = 44;
            //3rd row
            _2darray[2, 0] = 99;
            _2darray[2, 1] = 33;
            foreach (int i in _2darray)
                Console.WriteLine(i);
            Console.WriteLine("Dispaly values in matrix format");
            for(int i=0;i<3;i++) //here i refer row index
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(_2darray[i,j]+" "); //Write() prints value in same line
                }
                Console.WriteLine();
            }

        }
    }
}
