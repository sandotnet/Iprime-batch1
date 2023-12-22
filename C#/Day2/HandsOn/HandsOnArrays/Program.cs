namespace HandsOnArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //array syntax
            //datatype []var_name=new datatype[size];
            int[] marks = new int[6];
            //assign value to array
            marks[0] = 89;
            marks[1] = 78;
            marks[2] = 67;
            marks[3] = 90;
            marks[4] = 66;
            marks[5] = 78;
            int total = 0;
            //marks[6] = 88; //runtime error
            Console.WriteLine("English marks: " + 
                marks[3]); //access value from array using index
            Console.WriteLine("Marks in All Subjects");
            for(int i=0; i<6; i++)
            {
                Console.WriteLine(marks[i]);
                total = total + marks[i];
            }
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine();
            //fetch array values uisng foreach
            foreach(int k in marks)
            {
                Console.WriteLine(k);
            }
        }
    }
}
