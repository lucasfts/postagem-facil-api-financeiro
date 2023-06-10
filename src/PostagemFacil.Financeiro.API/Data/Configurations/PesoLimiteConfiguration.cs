using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostagemFacil.Financeiro.API.Data.Models;

namespace PostagemFacil.Financeiro.API.Data.Configurations
{
    public class PesoLimiteConfiguration : IEntityTypeConfiguration<PesoLimite>
    {
        public void Configure(EntityTypeBuilder<PesoLimite> builder)
        {
            builder.HasData(
                new PesoLimite() { Id = 1, Descricao = "Até 3kg", CustoPostal = 0.5M },
                new PesoLimite() { Id = 2, Descricao = "Entre 3kg e 5kg", CustoPostal = 1M },
                new PesoLimite() { Id = 3, Descricao = "Entre 5kg e 10kg", CustoPostal = 2M }
            );
        }
    }
}
