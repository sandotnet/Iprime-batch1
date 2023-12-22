namespace HandsOnTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conversion in between value types
            byte b = 34;
            //implicit conversion
            int k = b;
            double d = b;
            short s = b;
            s = 345;
            k = s;
            d = s;
            k = 4567;
            d = k;
            long l = 456;

            //explicit conversion(casting)
            int m = 345;
            //convert m value to short and byte
            short ss = (short)m; //convert int to short
            byte bb = (byte)m; //convet into byte
            long ll = 324093;
            m = (int)ll; //converting long to int
            double dd = 34.45;
            m = (int)dd; //converting doule to int
            ll = (long)dd; //converting double to long
            Console.WriteLine(m); //34
            decimal dc = 34.5675m;
            //convert decimal value to int,byte,short,long,double and float

        }
    }
}
