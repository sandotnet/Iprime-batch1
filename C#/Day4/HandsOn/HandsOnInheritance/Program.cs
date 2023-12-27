namespace HandsOnInheritance
{
    class A
    {
        //variables
        public int a;
        public int b;   
    }
    class B : A
    {
        public int c;
        public void F()
        {
            a = 10;
            b = 20;
            c = 30;
        }
        public void Display()
        {
            Console.WriteLine($"A={a} B={b} C={c}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.F();
            obj.Display();
            B ob1=new B ();
            ob1.a = 67;
            ob1.b = 90;
            ob1.c = 89;
            ob1.Display();
        }
    }
}
