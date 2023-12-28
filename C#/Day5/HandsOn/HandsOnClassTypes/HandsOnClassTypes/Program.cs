using System;

namespace HandsOnClassTypes
{
    //1. static class create using static keyword
    //2. in static class define only static members
    //3. static classes are not instantiated(not able to create object)
    //4. static classes are not inherited
    //5. static class members are access by class name runtime time
    //6. ex: Console,Math,Directory etc.
    static class Convertor
    {
        //difine only static members
        public static int a;
        public static double RTD(double rupees)
        {
            return rupees / 78.5;
        }
        public static double DTR(double dollers)
        {
            return dollers * 78.5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:C}",Convertor.RTD(100000));
            Console.WriteLine(Convertor.DTR(1000));
        }
    }
}
