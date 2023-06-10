using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostagemFacil.Financeiro.API.Data.Models;

namespace PostagemFacil.Financeiro.API.Data.Configurations
{
    public class TipoCaixaConfiguration : IEntityTypeConfiguration<TipoCaixa>
    {
        public void Configure(EntityTypeBuilder<TipoCaixa> builder)
        {
            builder.HasData(
                new TipoCaixa() { Id = 1, Descricao = "20cm x 20cm x 20cm", CustoPostal = 1.5M },
                new TipoCaixa() { Id = 2, Descricao = "40cm x 40cm x 40cm", CustoPostal = 2M },
                new TipoCaixa() { Id = 3, Descricao = "60cm x 60cm x 60cm", CustoPostal = 2.5M }            );
        }
    }
}
