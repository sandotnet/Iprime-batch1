namespace HandsOnDependencyInjection
{
    class Student
    {
        public int Id;
        public string Name;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    class Register
    {
        Student student;
        //public Register()
        //{
        //    student = new Student(1,"David");
        //}
        public Register(Student student) //here student object is created with out its values/dependencies
        {
            this.student = student;
        }
        public void Details()
        {
            Console.WriteLine($"Id:{student.Id} Name:{student.Name}");
        }
    }
    class School
    {
        public readonly Register register;
        public School(Register register)
        {
            this.register = register;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Register register = new Register(new Student(23, "David"));
            register.Details();
        }
    }
}
