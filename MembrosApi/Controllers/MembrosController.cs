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
        private static readonly List<String> Membros = new List<String>
        {

            "Elayne", "Paloma", "Alexandre", "Álisson", "Italo", "Lucas", "Paschoal"
        };

        private static readonly List<String> MembroLR = new List<String>
        {
            "Frodo", "Sam", "Gandalf", "Pinpin", "Smeagle", "Aragorn", "Bilbo"

        };

        private String addMembros (string name) 
        {
            if(name!=null)
            {
                Membros.Add(name);
            }
    
            return name;
        }

        [HttpGet]
        public IActionResult  Get()
        {
            return Ok(Membros);
        }

        [HttpGet("{​​name}​​")]
        public IActionResult pesquisarPorNome(string name)
        {​​
            var nome = from membro in Membros
            where membro.Equals(name)
            select membro;

            return Ok(nome);
        }​​

        [HttpGet]
        [Route("ordenar")]
        public IActionResult Ordenar()
        {​​
            IEnumerable<string> sortAscendingQuery =
            from membro in Membros
            orderby membro
            select membro;

            return Ok(sortAscendingQuery);
        }​​

        [HttpPost]
        public IActionResult Post([FromBody] String name)
        {
            addMembros(name);
            return Ok("Nome adicionado com Sucesso!");
        }

    }
}
