using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string School { get; set; }
    }
    public interface ITeacherRepository
    {
        void AddTeacher(Teacher teacher);
        Teacher GetTeacher(int id);
        List<Teacher> GetTeachers();
        List<Teacher> GetTeachersBySchool(string school);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int id);

    }
    class TeacherRepository : ITeacherRepository
    {
        List<Teacher> teachers = new List<Teacher>();
        public void AddTeacher(Teacher teacher)
        {
            //add teacher to list
            teachers.Add(teacher);
        }

        public Teacher GetTeacher(int id)
        {
           foreach(var teacher in teachers)
            {
                if(teacher.Id == id) return teacher;
            }
            return null;
        }

        public List<Teacher> GetTeachers()
        {
            return teachers;
        }
        public List<Teacher> GetTeachersBySchool(string school)
        {
            List<Teacher> list = new List<Teacher>();
            foreach(var teacher in teachers)
            {
                if(teacher.School==school)
                {
                    list.Add(teacher);
                }
            }
            return list;
        }
        public void UpdateTeacher(Teacher teacher)
        {
            for(int i=0;i<teachers.Count;i++)
            {
                if (teachers[i].Id==teacher.Id)
                {
                    teachers[i].Email = teacher.Email;
                    teachers[i].Mobile = teacher.Mobile;
                }
                break;
            }
        }
        public void DeleteTeacher(int id)
        {
            foreach(Teacher teacher in teachers)
            {
                if(teacher.Id==id)
                {
                    teachers.Remove(teacher);
                }
                break;
            }
        }
    }
    class Test_Teacher
    {
        static void Main()
        {
            TeacherRepository teacherRepository = new TeacherRepository();
            do
            {
                Console.WriteLine("1.Add Teacher");
                Console.WriteLine("2.Get Teacher By Id");
                Console.WriteLine("3.Get Teachers by School");
                Console.WriteLine("4.Get All Teachers");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter Choice");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1: //Add new Teacher
                        {
                            Teacher teacher = new Teacher();
                            teacher.Id = new Random().Next(1000,9999);
                            Console.WriteLine("Enter Name");
                            teacher.Name = Console.ReadLine();
                            teacher.Email = teacher.Name + "@gmail.com";
                            Console.WriteLine("Enter Mobile");
                            teacher.Mobile = Console.ReadLine();
                            Console.WriteLine("Enter School");
                            teacher.School = Console.ReadLine();
                            teacherRepository.AddTeacher(teacher);

                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Id");
                            int id = int.Parse(Console.ReadLine());
                            Teacher teacher = teacherRepository.GetTeacher(id);
                            if (teacher != null)
                            {
                                Console.WriteLine($"Id:{teacher.Id} Name:{teacher.Name} Email:{teacher.Email} Phone:{teacher.Mobile} Scholl:{teacher.School}");
                            }
                            else
                                Console.WriteLine("Invlaid Id");

                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter School name");
                            string school = Console.ReadLine();
                            List<Teacher> teachers=teacherRepository.GetTeachersBySchool(school);
                            foreach(var teacher in teachers)
                            {
                                Console.WriteLine($"Id:{teacher.Id} Name:{teacher.Name} Email:{teacher.Email} Phone:{teacher.Mobile} Scholl:{teacher.School}");
                            }
                        }
                        break;
                    case 4:
                        {
                            List<Teacher> teachers = teacherRepository.GetTeachers();
                            foreach (var teacher in teachers)
                            {
                                Console.WriteLine($"Id:{teacher.Id} Name:{teacher.Name} Email:{teacher.Email} Phone:{teacher.Mobile} Scholl:{teacher.School}");
                            }
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}
