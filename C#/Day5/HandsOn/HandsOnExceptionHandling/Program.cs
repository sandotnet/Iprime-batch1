namespace HandsOnExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
           try
            {
                int[] numbers = { 12, 23, 34, 45, 4, 5, 56, 45 };
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index exceeds its Size"); //exception message
                Console.WriteLine(ex.Message); //built it exception message
            }
        }
    }
}
