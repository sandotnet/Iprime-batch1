using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    //Application Exception or User defind Excption
    class AgeException:Exception
    {
        int age;
        string message;
        public AgeException(int age)
        {
            message = $"{age} is not applicable for appliing exam and\n age should between 12 to 15";
        }
        public override string Message
        {
            get { return message;}
        }
        public string Msg
        {
            get { return message;}
        }
    }
    internal class Student
    {
        public void ApplyExam(int age)
        {
            try
            {
               if(age>=12 && age<=15)
                {
                    Console.WriteLine("Applied for Exam Successfully!!");
                }
               else
                    throw new AgeException(age);
            }
            catch(AgeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Msg);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Test_Student
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter Age");
                int age = int.Parse(Console.ReadLine());
                Student obj = new Student();
                obj.ApplyExam(age);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
