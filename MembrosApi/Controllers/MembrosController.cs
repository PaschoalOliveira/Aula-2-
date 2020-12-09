using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MembrosApi.Controllers
{
    [Route("[controller]")]
    public class MembrosController : ControllerBase
    {
        private static readonly string[] Membros = new[]
        {
            "João", "Maria", "Lucas", "Luan", "Laís" 
        };

        [HttpGet]
        public string[] Get()
        {
            return Membros;
        }
    }
}
