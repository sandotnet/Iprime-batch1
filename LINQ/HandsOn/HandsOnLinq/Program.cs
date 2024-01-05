namespace HandsOnLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 12, 23, 34, 45, 56, 67, 78, 89, 87, 76, 65, 54, 43, 32, 21 };
            
            var result=from k in n
                       where k>50
                       select k;

            //fetch square of array no
            result = from k in n
                     select k * k;
            
            //fetch square value >1000
            result = from k in n
                     where k * k > 1000
                     select k * k;
          
            ////use variable in lin q
            result = from k in n
                     let i = k * k
                     where i > 1000
                     select i;
            
            result = from k in n
                     let i = k * k
                     where i > 1000 && i < 3000
                     select i;
            
            ////fetch values >50 in sorted order
            result = from k in n
                     where k > 50
                     orderby k //default ascending
                     select k;

            result = from k in n
                     where k > 50
                     orderby k descending
                     select k;
            foreach (var i in result)
                Console.WriteLine(i);


        }
    }
}