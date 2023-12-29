using System;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a variable with var keyword can accept any type of data while initilize data
            // var variable we can use only in local scope
            var a = 10;
            var b = "David";
            var c = 'c';
            ArrayList obj = new ArrayList();
            //Add Items
            obj.Add(12);
            obj.Add("David");
            obj.Add('a');
            obj.Add(true);
            obj.Insert(2, 12.34);
            Console.WriteLine("Size: " + obj.Count);
            //access a value
            char ch = (char)obj[3]; //arraylist returns data in object form so it required unboxing every time to assign the data to particular varible type
            int m = (int)obj[0];
            //remove a value
            obj.Remove("David");
            Console.WriteLine("Size: " + obj.Count);
            //retrun all items
            foreach (object k in obj)
                Console.WriteLine(k);
            Console.WriteLine();
            foreach (var k in obj)
                Console.WriteLine(k);

        }
    }
}
