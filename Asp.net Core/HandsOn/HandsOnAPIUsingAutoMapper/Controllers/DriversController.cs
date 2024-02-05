using AutoMapper;
using HandsOnAPIUsingAutoMapper.DTOs;
using HandsOnAPIUsingAutoMapper.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingAutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private static List<Driver> drivers = new List<Driver>();
        private readonly IMapper _mapper;

        public DriversController(IMapper mapper)
        {
            this._mapper = mapper;
        }

        ////[HttpGet]
        ////public IActionResult GetDrivers()
        ////{
        ////    var items = drivers.Where(x => x.Status == 1).ToList();
        ////    return Ok(items);
        ////}
        [HttpGet]
        public IActionResult GetDrivers()
        {
            var items = drivers.Where(x => x.Status == 1).ToList();
            var driverList = _mapper.Map<List<DriverDto>>(items); //convets List of Entties to list of dtos
            return Ok(driverList);
        }
        ////[HttpPost]
        ////public IActionResult CreateDriver(Driver data)
        ////{
        ////    if (ModelState.IsValid)
        ////    {
        ////        drivers.Add(data);

        ////        return CreatedAtAction("GetDriver", new { data.Id }, data);
        ////    }

        ////    return new JsonResult("Something went wrong") { StatusCode = 500 };
        ////}
        //[HttpPost]
        //public IActionResult CreateDriver(DriverDto data)
        //{
        //    var _driver = new Driver()
        //    {
        //        Id = Guid.NewGuid(),
        //        Status = 1,
        //        DateAdded = DateTime.Now,
        //        DateUpdated = DateTime.Now,
        //        DriverNumber = data.DriverNumber,
        //        FirstName = data.FirstName,
        //        LastName = data.LastName,
        //        WorldChampionships = data.WorldChampionships
        //    };
        //    if (ModelState.IsValid)
        //    {
        //        drivers.Add(_driver);

        //        return CreatedAtAction("GetDriver", new { _driver.Id }, data);
        //    }

        //    return new JsonResult("Something went wrong") { StatusCode = 500 };
        //}
        [HttpPost]
        public IActionResult CreateDriver(DriverDto data)
        {
            var _driver = _mapper.Map<Driver>(data); //convert dto to entity
            _driver.Status = 1;
            _driver.DateUpdated = DateTime.Now;
            _driver.DateAdded = DateTime.Now;

            if (ModelState.IsValid)
            {
                drivers.Add(_driver);

                return CreatedAtAction("GetDriver", new { _driver.Id }, data);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }
        //[HttpGet("{id}")]
        //public IActionResult GetDriver(Guid id)
        //{
        //    var item = drivers.FirstOrDefault(x => x.Id == id);

        //    if (item == null)
        //        return NotFound();

        //    return Ok(item);
        //}
        [HttpGet("{id}")]
        public IActionResult GetDriver(Guid id)
        {
            var item = drivers.FirstOrDefault(x => x.Id == id);

            if (item == null)
                return NotFound();
            var dtoDriver = new DriverDto()
            {
                FirstName = item.FirstName,
                LastName = item.LastName,
                DriverNumber = item.DriverNumber,
                WorldChampionships = item.WorldChampionships
            };

            return Ok(dtoDriver);
        }

        //[HttpPut("{id}")]
        //public IActionResult UpdateDriver(Guid id, Driver item)
        //{
        //    if (id != item.Id)
        //        return BadRequest();

        //    var existItem = drivers.FirstOrDefault(x => x.Id == id);

        //    if (existItem == null)
        //        return NotFound();

        //    existItem.FirstName = item.FirstName;
        //    existItem.LastName = item.LastName;
        //    existItem.DriverNumber = item.DriverNumber;
        //    existItem.WorldChampionships = item.WorldChampionships;


        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteDriver(Guid id)
        //{
        //    var existItem = drivers.FirstOrDefault(x => x.Id == id);

        //    if (existItem == null)
        //        return NotFound();

        //    existItem.Status = 0;

        //    return Ok(existItem);
        //}
    }
}
