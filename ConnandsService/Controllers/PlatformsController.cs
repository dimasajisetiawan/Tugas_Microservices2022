using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnandsService.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConnandsService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {
            
        }

        [HttpPost]
        public ActionResult TestInboundConnection(Platform platform) {
            Console.WriteLine($"---> Inbound POST Command - {platform.Id} - {platform.Name}");
            return Ok("Inbound Test dari Command Services");

        }
    }
}