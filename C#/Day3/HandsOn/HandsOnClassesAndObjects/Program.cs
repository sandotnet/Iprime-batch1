namespace HandsOnClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //create object of a student
            Student obj=new Student();
            obj.id = 43203;
            obj.name = "Anna";
            obj.gender = 'F';
            obj.age = 10;
            obj.Display();
            Console.WriteLine();
            Student s1= new Student();
            s1.id = 89098;
            s1.name = "Harish";
            s1.age = 11;
            s1.gender = 'M';
            s1.Display();
            Console.WriteLine();
            Student s2 = new Student();
            s2.Display(); //return default values of class variables
            Student s3 = new Student() //object initializer
            {
                id = 342093,
                name = "Chandra",
                age = 11,
                gender = 'M'
            };
            s3.Display();
            //Student s4 = null; //s4 object instance is null
            //s4.id = 432309;
            //s4.name = "Hani";
            //s4.Display();
            //array of studetns
            Student[] students = new Student[3];
            students[0]=new Student()
            {
                id = 342093,
                name = "Chandra",
                age = 11,
                gender = 'M'
            };
            students[1]=new Student()
            {
                id = 342056,
                name = "Hani",
                age = 11,
                gender = 'F'
            };
            students[2] = new Student()
            {
                id = 342786,
                name = "Mary",
                age = 11,
                gender = 'F'
            };
            Console.WriteLine();
            students[0].Display();
            Console.WriteLine();
            foreach (Student s in students)
            {
                s.Display();
            }
            Console.WriteLine();
            for(int i=0;i<3;i++)
            {
                students[i].Display();
            }

        }
    }

}
