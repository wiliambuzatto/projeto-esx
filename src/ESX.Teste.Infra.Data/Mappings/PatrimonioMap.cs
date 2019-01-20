using ESX.Teste.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ESX.Teste.Infra.Data.Mappings
{
    public class PatrimonioMap : IEntityTypeConfiguration<Patrimonio>
    {
        public void Configure(EntityTypeBuilder<Patrimonio> builder)
        {
            builder.Property(c => c.Id)
                 .HasColumnName("Id");

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.MarcaId)
               .IsRequired();

            builder.Property(c => c.Descricao)
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(f => f.NumeroTombo).ValueGeneratedOnAdd();
        }
    }
}
