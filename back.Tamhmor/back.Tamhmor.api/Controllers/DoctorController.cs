using back.Tamhmor.api.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Tamhmor.api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService doctorService;
        public DoctorController(IDoctorService doctorService)
        {
            this.doctorService = doctorService;
        }

        //[HttpPost("AddSJ")]
        //public IActionResult AddSJ([FromBody] SubjectModel subjectModel)
        //{
        //    try
        //    {

        //        var data = subjectService.addSubject(subjectModel);
        //        return Ok(data);
        //    }
        //    catch (Exception ex)
        //    {
        ////        throw ex;
        //    }
        //}

        //[HttpGet("GetDoctor")]
        //public IActionResult GetDoctor(int Did)
        //{
        //    var result = doctorService.getdoctor(Did);
        //    return new OkObjectResult(result);
        //}

        [HttpGet("DepartmentDoctor")]
        public IActionResult DepartmentDoctor()
        {
            var result = doctorService.departmentdoctor();
            return new OkObjectResult(result);
        }

        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<DoctorController>> getdoctor(int Did)
        //{
        //    try
        //    {
        //        var result = await doctorService.getdoctor(Did);

        //        if (result == null) return NotFound();

        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Error retrieving data from the database");
        //    }
        //}

        [HttpGet("GetDoctor")]
        public IActionResult GetDoctor(int Did)
        {
            //var result = doctorService.getdoctor(Did);
            //return new OkObjectResult(result);

            try
            {
                var result = doctorService.getdoctor(Did);
                if (result == null)
                {
                    return StatusCode(StatusCodes.Status204NoContent, result);
                }
                else
                {
                    return StatusCode(StatusCodes.Status200OK, result);
                }

            }
            
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<IDoctorService>>> GetDoctors()
        //{
        //    try
        //    {
        //        return (await doctorService.GetDoctors()).ToList();
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Error retrieving data from the database");
        //    }
        //}

        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<IDoctorService>> GetDoctor(int Did)
        //{
        //    try
        //    {
        //        var result = await doctorService.GetDoctor(Did);

        //        if (result == null) return NotFound();

        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Error retrieving data from the database");
        //    }
        //}
    }
}
