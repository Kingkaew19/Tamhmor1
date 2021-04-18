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

        

        [HttpGet("GetDoctor")]
        public IActionResult GetDoctor(int Did)
        {
            var result = doctorService.getdoctor(Did);
            return new OkObjectResult(result);
        }

        [HttpGet("DepartmentDoctor")]
        public IActionResult DepartmentDoctor()
        {
            var result = doctorService.departmentdoctor();
            return new OkObjectResult(result);
        }

        

    }
}
