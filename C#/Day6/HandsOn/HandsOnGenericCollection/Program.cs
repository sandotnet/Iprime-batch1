namespace HandsOnGenericCollection
{
    //generic class
    class Sample<T>
    {
        //generic variables
        public T a;
        public T b;
        public void Details(T i,T j)
        {
            a = i;
            b=j;
            Console.WriteLine($"a={0} and b={1}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample<int> ob = new Sample<int>();
            ob.a = 10;
            ob.b = 20;
            ob.Details(3, 4);
            Sample<char> ob1 = new Sample<char>();
            ob1.a = 'a';
            ob1.b='i';
            ob.Details('r','t');
            Sample<string> ob2=new Sample<string>();
            ob2.Details("Rahul", "Dravid");
        }
    }
}
