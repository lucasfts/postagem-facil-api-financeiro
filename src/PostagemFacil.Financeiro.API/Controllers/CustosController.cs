using Microsoft.AspNetCore.Mvc;
using PostagemFacil.Financeiro.API.Business;

namespace PostagemFacil.Financeiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustosController : ControllerBase
    {
        private readonly ICustosService _custosService;

        public CustosController(ICustosService custosService)
        {
            _custosService = custosService;
        }

        [HttpGet("transportadora/{tipoCaixaId}/peso/{pesoId}")]
        public IActionResult ObterCustoPostal(int tipoCaixaId, int pesoId)
        {
            return Ok(_custosService.CalcularCustoPostal(tipoCaixaId, pesoId));
        }
    }
}
