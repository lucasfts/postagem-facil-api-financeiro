using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PostagemFacil.Financeiro.API.Data;

namespace PostagemFacil.Financeiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParametrosController : ControllerBase
    {
        private readonly FinanceiroContext _financeiroContext;

        public ParametrosController(FinanceiroContext financeiroContext) => _financeiroContext = financeiroContext;

        [HttpGet("pesos-limite")]
        public async Task<IActionResult> ObterPesosLimite() => Ok(await _financeiroContext.PesosLimite.ToListAsync());

        [HttpGet("tipos-caixa")]
        public async Task<IActionResult> ObterTiposCaixa() => Ok(await _financeiroContext.TiposCaixa.ToListAsync());

        [HttpGet("transportadoras")]
        public async Task<IActionResult> ObterTransportadoras() => Ok(await _financeiroContext.Transportadoras.ToListAsync());
    }
}
