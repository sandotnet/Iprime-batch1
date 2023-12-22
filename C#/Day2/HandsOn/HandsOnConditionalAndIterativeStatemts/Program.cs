namespace HandsOnConditionalAndIterativeStatemts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //simple-if
            Console.WriteLine("Enter Name");
            string ?name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int ?age = int.Parse(Console.ReadLine());
            if(age>=12)
            {
                Console.WriteLine($"{name} Allow to " +
                    $"write Exam");
            }
            else
            {
                Console.WriteLine($"{name} You are " +
                    $"under Age, Not allowed to write exam");
            }
            Console.WriteLine("Thank U!!");
        }
    }
}
