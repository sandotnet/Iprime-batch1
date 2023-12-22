namespace HandsOnStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1. A string is a reference datatype
             2. strins are two types 1. Immutable strings(not dynamic in nature) 2.Mutible strings(dyamic in naturue)
             3. Immutable strings are defined using string datatype or class
             4. mutalbe strings are defined using StringBuilder class
             */
            string n = "Hey, Good Morning";
            string path = @"C:\Trainings\Dotnet\C#\\Material"; //verbatim strings
            string path1 = "C:\\Trainings\\Dotnet\\C#\\Material";
            Console.WriteLine(path);
            Console.WriteLine(path1);
        }
    }
}
