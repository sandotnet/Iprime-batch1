namespace HandsOnConstructorsAndProperties
{
    class Student
    {
        public string firstName;
        public string lastName;
        public string school;
         static string city;
        //default constructor
        public Student()
        {
            school = "DPS";
         
        }
        //parameter constructor
        public Student(string fname,string lname,string s)
        {
            firstName=fname;
            lastName=lname;
            school = s;
           

        }
        public Student(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;
        }
        //static constuctor(not included any access specifier and paramters)
        // a class can have only 1 static constructor
        //static constructor is the first members to invoke in a class
        static Student()
        {
            //define only static variable
            city = "Kochi";
        }
        public void Display()
        {
            Console.WriteLine($"Name:{firstName} {lastName} School:{school} City:{city}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student s1=new Student();
            s1.firstName = "Rahul";
            s1.lastName = "Shetty";
            s1.Display();
            Student s2 = new Student();
            s2.firstName = "Viraj";
            s2.lastName = "Khanna";
            s2.Display();
            Student s3=new Student("Virat","Kohli","HPS");
            s3.Display();
            Student s4 = new Student("Hani", "Hani", "GPS");
            s4.Display();
            Student s5 = new Student("Hani", "Hani");
            s5.school = "GPS";
            s4.Display();
        }
    }
}
