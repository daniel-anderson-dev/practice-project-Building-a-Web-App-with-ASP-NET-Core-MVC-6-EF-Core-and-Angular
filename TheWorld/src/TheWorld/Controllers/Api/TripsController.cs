using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorld.Models;

namespace TheWorld.Controllers.Api
{
    public class TripsController: Controller
    {
        [HttpGet("api/trips")]
        public IActionResult Get()
        {
            // Demonstrates the idea of returning an "Action Result"
            //  in case you don't always return raw json data.
            if (true) return BadRequest("NOOO");
            return Ok(new Trip() { Name = "My Trip" });
        }
    }
}
