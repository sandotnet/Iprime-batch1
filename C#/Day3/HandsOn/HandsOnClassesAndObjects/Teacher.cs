using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Teacher
    {
        public int Id;
        public string Name;
        public string Subject;
        public string[] stds;
    }
    class TeacherRepository
    {
        public Teacher[] teachers = new Teacher[5];
        public int idx = 0;
        public void AddTeacher(Teacher teacher) //Adding new teacher details
        {
            //add teacher details to array
            if (idx <= teachers.Length)
            {
                teachers[idx] = teacher;
                idx++;
            }
            else
            {
                Console.WriteLine("Staff is Full!!!");
            }
        }
        public Teacher GetTeacher(int id) //get teacher details with id
        {
            foreach(Teacher teacher in teachers)
            {
                if ((teacher != null))
                {
                    if (teacher.Id == id)
                    {
                        return teacher;
                    }
                    else
                        return null;
                }

            }
            return null; //when teacher not exist with given id
        }
        public Teacher[] GetTeachers() //Get All Teachers
        {
            return teachers;
        }
        public Teacher[] GetTeacherBySubject(string subject) //Get Teachers by Subject
        {
            Teacher[] subject_teachers = new Teacher[teachers.Length];
            int idx = 0;
            foreach(Teacher teacher in teachers)
            {
                if (teacher != null)
                {
                    if (teacher.Subject == subject)
                    {
                        subject_teachers[idx] = teacher;
                        idx++;
                    }
                }
            }
            return subject_teachers;
        }
    }
    class Teacher_Main
    {
        static void Main()
        {
            TeacherRepository teacherRepository = new TeacherRepository();
            do
            {
                Console.WriteLine("1.Add Teacher");
                Console.WriteLine("2.Get Teacher By Id");
                Console.WriteLine("3.Get Teachers By Subject");
                Console.WriteLine("4.Get All Teachers");
                Console.WriteLine("Enter U r Choice");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1: //add new Teacher
                        {
                            Teacher teacher = new Teacher();
                            Console.WriteLine("Enter Name");
                            teacher.Name = Console.ReadLine();
                            Console.WriteLine("Enter Subject");
                            teacher.Subject = Console.ReadLine();
                            teacher.Id = new Random().Next(); //Random class return random value
                            teacher.stds = new string[] { "1", "2", "3" };
                            teacherRepository.AddTeacher(teacher);

                        }
                        break;
                    case 2: // Get Teacher By Id
                        {
                            Console.WriteLine("Enter Id");
                            int id = int.Parse(Console.ReadLine());
                            Teacher teacher=teacherRepository.GetTeacher(id);
                            if (teacher != null)
                            {
                                Console.WriteLine($"Id:{teacher.Id} Name:{teacher.Name} Subject:{teacher.Subject}");
                                Console.WriteLine("Classes handled");
                                foreach (string s in teacher.stds) Console.Write(s + " ");
                            }
                            else
                                Console.WriteLine("Invalid Id");
                        }
                        break;
                    case 3: //Get Teachers by Subject
                        {
                            Console.WriteLine("Enter Subject");
                            string subject = Console.ReadLine();
                            Teacher[]teachers=teacherRepository.GetTeacherBySubject(subject);
                            foreach(Teacher teacher in teachers)
                            {
                                if (teacher != null)
                                {
                                    Console.WriteLine($"Id:{teacher.Id} Name:{teacher.Name} Subject:{teacher.Subject}");
                                    Console.WriteLine("Classes handled");
                                    foreach (string s in teacher.stds) Console.Write(s + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 4: //Get Teachers
                        {
                            Teacher[] teachers = teacherRepository.GetTeachers();
                            foreach (Teacher teacher in teachers)
                            {
                                if (teacher != null)
                                {
                                    Console.WriteLine($"Id:{teacher.Id} Name:{teacher.Name} Subject:{teacher.Subject}");
                                    Console.WriteLine("Classes handled");
                                    foreach (string s in teacher.stds) Console.Write(s + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                }
            } while (true);
        }
    }
}
