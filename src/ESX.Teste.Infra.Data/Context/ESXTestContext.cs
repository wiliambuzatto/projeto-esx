using System.IO;
using ESX.Teste.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using ESX.Teste.Infra.Data.Mappings;
using Microsoft.Extensions.Configuration;

namespace ESX.Teste.Infra.Data.Context
{
    public class ESXTestContext : DbContext
    {
        public DbSet<Patrimonio> Patrimonios { get; set; }
        public DbSet<Marca> Marcas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PatrimonioMap());
            modelBuilder.ApplyConfiguration(new PatrimonioMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
