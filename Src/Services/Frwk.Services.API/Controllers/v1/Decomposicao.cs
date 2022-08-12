using Frwk.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioFrwk.Services.Controllers.v1
{
    [Route("api/v1/decomposicoes")]
    [ApiController]
    public class Decomposicao : ControllerBase
    {
        private readonly IDecomposicao _decomposicao;

        public Decomposicao(IDecomposicao decomposicao)
        {
            _decomposicao = decomposicao;
        }

        [HttpGet("numeros-divisores")]
        public IActionResult ListarNumerosDivisores(int numero)
        {
            var resultado = _decomposicao.ListarNumerosDivisores(numero);

            return Ok(resultado);
        }

        [HttpPost("numeros-primos")]
        public IActionResult ListarNumerosPrimos(List<int> numeros)
        {
            var resultado = _decomposicao.ListarNumerosPrimos(numeros);

            return Ok(resultado);
        }
    }
}
