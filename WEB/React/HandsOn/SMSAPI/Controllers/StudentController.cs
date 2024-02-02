using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSAPI.Entities;
using SMSAPI.Repositories;

namespace SMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentRepository _studentRepository;

        public StudentController(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        //Get actions
        [HttpGet,Route("GetStudents")]
        public IActionResult GetAll()
        {
            return Ok(_studentRepository.GetAll());
        }
        [HttpGet,Route("GetStudent/{id}")]
        public IActionResult GetAction(string id)
        {
            return Ok(_studentRepository.Get(id));
        }
        //Post actions
        [HttpPost,Route("AddStudent")]
        public IActionResult Add([FromBody]Student student)
        {
            _studentRepository.Add(student);
            return Ok(student);
        }
        //Put actions
        [HttpPut, Route("EditStudent")]
        public IActionResult Update([FromBody] Student student)
        {
            _studentRepository.Update(student);
            return Ok(student);
        }
        //Delete actions
        [HttpDelete,Route("DeleteStudent/{id}")]
        public IActionResult Delete(string id)
        {
            _studentRepository.Delete(id);
            return Ok("Student Deleted");
        }
    }
}
