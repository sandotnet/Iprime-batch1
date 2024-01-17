using HandsOnEFCodeFirst_Demo2.Entities;
using HandsOnEFCodeFirst_Demo2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEFCodeFirst_Demo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarksController : ControllerBase
    {
        private readonly MarksRepository _marksRepository;

        public MarksController(MarksRepository marksRepository)
        {
            _marksRepository = marksRepository;
        }
        [HttpPost,Route("AddMarks")]
        public IActionResult Add(Marks marks)
        {
            marks.MarksId= Guid.NewGuid();
            _marksRepository.Add(marks);
            return Ok(marks);
        }

    }
}
