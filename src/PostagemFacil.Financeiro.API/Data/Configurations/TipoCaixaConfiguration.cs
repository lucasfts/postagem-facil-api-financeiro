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
                new TipoCaixa() { Id = 1, Descricao = "30cm x 30cm x 30cm", CustoPostal = 1.5M },
                new TipoCaixa() { Id = 2, Descricao = "60cm x 60cm x 60cm", CustoPostal = 2M },
                new TipoCaixa() { Id = 3, Descricao = "90cm x 90cm x 90cm", CustoPostal = 2.5M },
                new TipoCaixa() { Id = 4, Descricao = "120cm x 120cm x 120cm", CustoPostal = 3M }
            );
        }
    }
}
