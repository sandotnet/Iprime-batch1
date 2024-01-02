using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")] //Route specifies url patterns of a controller
    [ApiController] //attrite
    public class TeacherController : ControllerBase
    {
        //action method or endpoints
        [HttpGet("Greet")] //this method is invoked by get request
        //request  http://localhost:50660/api/Teacher/Greet
        public string Greet()
        {
            return "Good Morning Teachers"; //sent this message as a http response message
        }
        [HttpGet("GetAll")]
        //request: http://localhost:50660/api/Teacher/GetAll
        public string[] GetTeachers()
        {
            return new string[] { "Roopam","Sanu","Santhosh","Karthik"};
        }
        [HttpGet]
        public string Hello()
        {
            return "Hello World!!!";
        }
        [HttpGet("GetTeachersByStd/{std}")] //route with parameter
        // http://localhost:50660/api/Teacher/GetTeachersByStd/2
        public string[] GetTeacherByClass(string std)
        {
            return new string[] { "Roopam", "Sanu", "Santhosh", "Karthik","Ahila" };
        }
    }
}
