namespace PostagemFacil.Financeiro.API.Business
{
    public interface ICustosService
    {
        decimal CalcularCustoPostal(int tipoCaixaId, int pesoId);
    }

    public class CustosService : ICustosService
    {
        public decimal CalcularCustoPostal(int tipoCaixaId, int pesoId)
        {
            return 1M * 5M;
        }
    }
}
