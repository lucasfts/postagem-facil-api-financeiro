using Microsoft.EntityFrameworkCore;
using PostagemFacil.Financeiro.API.Data.Models;

namespace PostagemFacil.Financeiro.API.Data
{
    public class FinanceiroContext : DbContext
    {
        public FinanceiroContext(DbContextOptions<FinanceiroContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Transportadora> Transportadoras { get; set; }
        public DbSet<TipoCaixa> TiposCaixa { get; set; }
        public DbSet<PesoLimite> PesosLimite { get; set; }
    }
}
