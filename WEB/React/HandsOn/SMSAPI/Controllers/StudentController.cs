using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles ="Admin")]
        public IActionResult GetAll()
        {
            return Ok(_studentRepository.GetAll());
        }
        [HttpGet,Route("GetStudent/{id}")]
        [Authorize(Roles = "Admin,Student")]
        public IActionResult GetAction(string id)
        {
            return Ok(_studentRepository.Get(id));
        }
        //Post actions
        [HttpPost,Route("AddStudent")]
        [Authorize(Roles = "Admin")]
        public IActionResult Add([FromBody]Student student)
        {
            _studentRepository.Add(student);
            return Ok(student);
        }
        //Put actions
        [HttpPut, Route("EditStudent")]
        [Authorize(Roles = "Student")]
        public IActionResult Update([FromBody] Student student)
        {
            _studentRepository.Update(student);
            return Ok(student);
        }
        //Delete actions
        [HttpDelete,Route("DeleteStudent/{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(string id)
        {
            _studentRepository.Delete(id);
            return Ok("Student Deleted");
        }
    }
}
