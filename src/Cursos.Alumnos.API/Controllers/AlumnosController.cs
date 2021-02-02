using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cursos.Alumnos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlumnosController : ControllerBase
    {
      
        private readonly ILogger<AlumnosController> _logger;

        public AlumnosController(ILogger<AlumnosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var a = this.HttpContext;
            return Ok(new { msg = "oki doki servicio alumnos" });
        }
        [HttpGet("{id}")]
        //[Route("api/[controller]/{id}")]
        public IActionResult Get([FromRoute]int id)
        {
            return Ok(new { msg = $"oki doki servicio alumnos {id}" });
        }
    }
}
