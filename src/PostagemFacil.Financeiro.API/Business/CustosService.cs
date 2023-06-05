using PostagemFacil.Financeiro.API.Data;

namespace PostagemFacil.Financeiro.API.Business
{
    public interface ICustosService
    {
        Task<decimal> CalcularCustoPostal(int transportadoraId, int tipoCaixaId, int pesoLimiteId);
    }

    public class CustosService : ICustosService
    {
        private readonly FinanceiroContext _financeiroContext;

        public CustosService(FinanceiroContext financeiroContext)
        {
            _financeiroContext = financeiroContext;
        }

        public async Task<decimal> CalcularCustoPostal(int transportadoraId, int tipoCaixaId, int pesoLimiteId)
        {
            var transportadora = await _financeiroContext.Transportadoras.FindAsync(transportadoraId);
            var tipoCaixa = await _financeiroContext.TiposCaixa.FindAsync(tipoCaixaId);
            var pesosLimite = await _financeiroContext.PesosLimite.FindAsync(pesoLimiteId);

            return transportadora.FatorPostal * (tipoCaixa.CustoPostal + pesosLimite.CustoPostal);
        }
    }
}
