using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIUsingModels.Models;
namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student>()
        {
            new Student{Id=3234,Name="Harsha",Age=10,Std="4"},
             new Student{Id=7898,Name="Hani",Age=10,Std="4"}
        };
        //defind action methods or end points
        //Add new Student
        //[HttpPost("AddStudent")]
        [HttpPost,Route("AddStudent")]
        public Student Add(Student student) //pass the student details through the request body
        {
            students.Add(student);
            return student;
        }
        [HttpGet,Route("GetAll")]
        public List<Student> GetStudents()
        {
            return students;
        }
        [HttpGet,Route("GetStudentById/{id}")]
        public Student GetStudent(int id)
        {
            foreach(var item in students)
            {
                if(item.Id==id) return item;
            }
            return null;
        }
        [HttpGet, Route("GetStudentByName/{name}")]
        public Student GetStudent(string name)
        {
            foreach (var item in students)
            {
                if (item.Name == name) return item;
            }
            return null;
        }
        [HttpDelete,Route("DeleteStudent/{id}")]
        public string Delete(int id)
        {
            try
            {
                Student student = null;
                foreach (var item in students)
                {
                    if (item.Id == id)
                    {
                        student = item;
                        break;
                    }
                }
                //Removoe Student
                if (student != null)
                {
                    students.Remove(student);
                    return "Student Deleted";
                }
                else
                {
                    return "Invalid Student Id";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpGet,Route("GetStudentByNameAndAge/{name}/{age}")]
        public Student GetStudent(string name,int age)
        {
            foreach (var item in students)
            {
                if (item.Name == name && item.Age==age) return item;
            }
            return null;
        }
    }
}
