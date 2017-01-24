using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyCodeCamp.Controllers
{
    public class CampsController : Controller
    {
        [HttpGet("api/camps")]
        public IActionResult Get()
        {
            return Ok(new {Name = "Roberto", FavoriteColor = "Red"});
        }
    }
}
