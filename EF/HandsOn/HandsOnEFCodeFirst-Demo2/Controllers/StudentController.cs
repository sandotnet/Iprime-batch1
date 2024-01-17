using HandsOnEFCodeFirst_Demo2.Entities;
using HandsOnEFCodeFirst_Demo2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEFCodeFirst_Demo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private StudentRepository studentRepository;

        public StudentController(StudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        //Endpoints
        [HttpGet,Route("GetStudents")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(studentRepository.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetStudent/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(studentRepository.Get(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost,Route("AddStudent")]
        public IActionResult Add(Student student)
        {
            try
            {
                studentRepository.Add(student);
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut, Route("EditStudent")]
        public IActionResult Edit(Student student)
        {
            try
            {
                studentRepository.Update(student);
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("DeleteStudent/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                studentRepository.Delete(id);
                return Ok("Student Deleted");
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetMarks/{id}")]
        public IActionResult GetMarks(int id)
        {
            return Ok(studentRepository.GetMarks(id));
        }
    }
}
