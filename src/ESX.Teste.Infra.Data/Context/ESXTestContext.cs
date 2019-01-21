using ESX.Teste.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using ESX.Teste.Infra.Data.Mappings;

namespace ESX.Teste.Infra.Data.Context
{
    public class ESXTestContext : DbContext
    {
        public ESXTestContext(DbContextOptions<ESXTestContext> options) : base(options)
        {
        }

        public DbSet<Patrimonio> Patrimonios { get; set; }
        public DbSet<Marca> Marcas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MarcaMap());
            modelBuilder.ApplyConfiguration(new PatrimonioMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }
    }
}
