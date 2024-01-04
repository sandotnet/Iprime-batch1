using HandsOnAPIUsingModels.Models;
using HandsOnAPIUsingModels.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository teacherRepository;

        public TeacherController(ITeacherRepository teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }

        //public TeacherController()
        //{
        //    teacherRepository= new TeacherRepository(); 
        //}
        //end points
        [HttpGet,Route("GetAllTeachers")]
        public IActionResult GetAll() //return any type of data as a http response
        {
            try
            {
                List<Teacher> teachers=teacherRepository.GetAll();
                //statusCode use to send any json/respnse data with status code
                return StatusCode(200, teachers);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetTeacherById/{id}")]
        public IActionResult GetTeacher(int id)
        {
            try
            {
               
                Teacher teacher = teacherRepository.GetTeacher(id);
                if (teacher != null)
                    return StatusCode(200, teacher);
                else
                    return StatusCode(404, new JsonResult("Invalid Teacher Id")); //JsonResult send data in json format
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetTeachersBySubject/{subject}")]
        public IActionResult GetTeacherBySubject(string subject)
        {
            try
            {
                return StatusCode(200, teacherRepository.GetTeachersBySubject(subject));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpPost,Route("AddTeacher")]
        public IActionResult Add(Teacher teacher)
        {
            try
            {
                teacherRepository.Add(teacher);
                return StatusCode(200, teacher);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpPut,Route("UpdateTeaher")]
        public IActionResult Update(Teacher teacher)
        {
            try
            {
                teacherRepository.Update(teacher);
                return StatusCode(200, teacher);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }

        }
        [HttpDelete,Route("DeleteTeacher/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                teacherRepository.Delete(id);
                return StatusCode(200, "Teacher Deleted");
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

    }
}
