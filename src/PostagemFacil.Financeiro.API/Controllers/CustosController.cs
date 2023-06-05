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

        [HttpGet("transportadora/{transportadoraId}/tipo-caixa/{tipoCaixaId}/peso-limite/{pesoLimiteId}")]
        public async Task<IActionResult> ObterCustoPostal(int transportadoraId, int tipoCaixaId, int pesoLimiteId)
        {
            var custoPostal = await _custosService.CalcularCustoPostal(transportadoraId, tipoCaixaId, pesoLimiteId);
            return Ok(custoPostal);
        }
    }
}
