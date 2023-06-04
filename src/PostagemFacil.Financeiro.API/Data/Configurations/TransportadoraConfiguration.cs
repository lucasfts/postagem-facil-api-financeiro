using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostagemFacil.Financeiro.API.Data.Models;

namespace PostagemFacil.Financeiro.API.Data.Configurations
{
    public class TransportadoraConfiguration : IEntityTypeConfiguration<Transportadora>
    {
        public void Configure(EntityTypeBuilder<Transportadora> builder)
        {
            builder.HasData(
                new Transportadora() { Id = 1, Nome = "Correios", FatorPostal = 1M },
                new Transportadora() { Id = 2, Nome = "JadLog", FatorPostal = 0.95M },
                new Transportadora() { Id = 3, Nome = "DHL", FatorPostal = 1.7M },
                new Transportadora() { Id = 4, Nome = "UPS", FatorPostal = 2M },
                new Transportadora() { Id = 5, Nome = "Fedex", FatorPostal = 1.8M }
            );
        }
    }
}
