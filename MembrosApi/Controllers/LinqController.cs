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
    public class LinqController : ControllerBase
    {
        private static readonly List<int> idades = new List<int>()
        {
           18, 20, 30, 40, 14, 03, 07, 12, 5, 16
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(idades);
        }

        [HttpGet]
        [Route("maiorDeIdade")]
        public String maiorDeIdade()
        {
            var maiorDeIdade = from idade in idades where idade >= 18 select idade;
            var qntMaiorDeIdade = maiorDeIdade.Count();

            return String.Format("Existe {0} pessoas maiores de idade", qntMaiorDeIdade);
        }

        [HttpGet]
        [Route("menorDeIdade")]
        public String menorDeIdade()
        {
            var maiorDeIdade = from idade in idades where idade < 18 select idade;
            var qntMaiorDeIdade = maiorDeIdade.Count();

            return String.Format("Existe {0} pessoas menores de idade", qntMaiorDeIdade);
        }

        [HttpGet]
        [Route("qntAdolescente")]
        public String qntAdolescente()
        {
            int qntAdolescente = idades.Count(idade => idade >= 12 && idade <= 18);
            return String.Format("Existe {0} adolescentes", qntAdolescente);
        }

        [HttpGet]
        [Route("qntCriancas")]
        public String qntCriancas()
        {
            var qntCriancas = idades.Count(idade => idade < 12);
            return String.Format("Existe {0} crianças", qntCriancas);
        }

        [HttpGet]
        [Route("somaIdade")]
        public String somaDasIdades()
        {
            var somaDasIdades = idades.Sum();
            return string.Format("Soma das idades: {0}", somaDasIdades);
        }

        [HttpGet]
        [Route("ordenaIdade")]
        public IEnumerable<int> ordenacaoDasIdades()
        {
            IEnumerable<int> sort = from idade in idades orderby idade select idade;
            return sort;
        }

        [HttpDelete("{idade}​​")]
        [Route("apagarIdade")]
        public string deletarIdade([FromBody] int idade)
        {
            if (isValid(idade) && exist(idade))
            {
                idades.Remove(idade);
                return "Excluido =)";
            }

            return "Não é possivel excluir";
        }

        public bool exist(int idade)
        {
            var idadeEscolhida = idades.Any(cli => cli == idade);
            
            if (idadeEscolhida) return true;
            return false;
        }

        public bool isValid(int idade)
        {
            if (idade.GetType() == typeof(int)) return true;
            return false;
        }


    }
}
