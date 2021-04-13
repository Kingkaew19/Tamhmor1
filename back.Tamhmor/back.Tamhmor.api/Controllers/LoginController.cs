using back.Tamhmor.api.Models;
using back.Tamhmor.api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Tamhmor.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {

        private readonly ILoginService loginService;
        public LoginController(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        [HttpPost("AddUsers")]
        public IActionResult AddUsers([FromBody] UsersModel usersModel)
        {
            try
            {

                var data = loginService.addUsers(usersModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
