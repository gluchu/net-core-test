using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("Test")]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
           return Ok("asdss");
        }
    }
}
