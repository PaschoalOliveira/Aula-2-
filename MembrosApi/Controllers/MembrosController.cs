using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MembrosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MembrosController : ControllerBase
    {
        private static readonly string[] Membros = new[]
        {
            "Elayne", "Paloma", "Alexandre", "Alisson", "Italo", "Lucas", "Paschoal"
        };

        private readonly ILogger<MembrosController> _logger;

        public MembrosController(ILogger<MembrosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult  Get()
        {
             return Ok(Membros);
        }
    }
}
