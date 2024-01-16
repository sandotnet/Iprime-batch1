using HandsonAPIWithEFCodeFirst_Demo1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsonAPIWithEFCodeFirst_Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly MyContext _context;
        public StudentController()
        {
            _context = new MyContext();
        }
        //Endpoints
        [HttpPost,Route("AddStudent")]
        public IActionResult Add([FromBody]Student student)
        {
            try
            {
                _context.Students.Add(student); //adds students details to the student tabel
                _context.SaveChanges();
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                List<Student> students = _context.Students.ToList(); //retrun all students from table
                return StatusCode(200, students);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("Get/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                //Student student = _context.Students.Find(id); only for primary key column
                Student student = _context.Students.SingleOrDefault(s => s.Id == id); //for all non primary key column
                return StatusCode(200, student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut, Route("EditStudent")]
        public IActionResult Edit([FromBody] Student student)
        {
            try
            {
                _context.Students.Update(student); //update students details to the student tabel
                _context.SaveChanges();
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                Student student = _context.Students.Find(id);
                _context.Students.Remove(student); //removed students details from the student tabel
                _context.SaveChanges();
                return Ok(new JsonResult("Student Deleted",student));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
