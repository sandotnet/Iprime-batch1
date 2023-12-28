using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    class Student
    {
        //Automatic properties
        public int Id { get; set; }
        public string Name { get; set;}
        public int Age { get; set; }

    }
    interface IStudentRepository
    {
        Student GetById(int id);
        void Update(Student student);
        void DeleteById(int id);
        Student[] GetStudents();
        void AddStudent(Student student);
    }
    class StudentRepository : IStudentRepository
    {
        public Student[] students = new Student[3];
        int idx = 0;

        public void AddStudent(Student student)
        {
            students[idx]= student;
        }

        public void DeleteById(int id)
        {
           // write implementation here 
        }

        public Student GetById(int id)
        {
           return students[id];
        }

        public Student[] GetStudents()
        {
            return students;
        }

        public void Update(Student student)
        {
            //write implementation here
        }
    }
    internal class Demo2
    {
        static void Main()
        {
            //write menu driven code to test StudentRepository functions
        }
    }
}
