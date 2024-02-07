using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSAPI.Entities;
using SMSAPI.Repositories;

namespace SMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorController : ControllerBase
    {
        private readonly TutorRepository _tutorRepository;

        public TutorController(TutorRepository tutorRepository)
        {
            _tutorRepository = tutorRepository;
        }
        //Get actions
        [HttpGet, Route("GetTutors")]
        [Authorize(Roles ="Admin")]
        public IActionResult GetAll()
        {
            return Ok(_tutorRepository.GetAll());
        }
        [HttpGet, Route("GetTutor/{id}")]
        [Authorize(Roles = "Admin,Tutor")]
        public IActionResult GetAction(string id)
        {
            return Ok(_tutorRepository.Get(id));
        }
        //Post actions
        [HttpPost, Route("AddTutor")]
        [Authorize(Roles = "Admin")]
        public IActionResult Add([FromBody] Tutor tutor)
        {
            _tutorRepository.Add(tutor);
            return Ok(tutor);
        }
        //Put actions
        [HttpPut, Route("EditTutor")]
        [Authorize(Roles = "Tutor")]
        public IActionResult Update([FromBody] Tutor tutor)
        {
            _tutorRepository.Update(tutor);
            return Ok(tutor);
        }
        //Delete actions
        [HttpDelete, Route("DeleteTutor/{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(string id)
        {
            _tutorRepository.Delete(id);
            return Ok("Tutor Deleted");
        }
    }
}
