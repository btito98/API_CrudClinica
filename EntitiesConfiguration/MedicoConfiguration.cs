using Clinica.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.EntitiesConfiguration
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("Medico");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(20)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(x => x.CRM)
                .HasMaxLength(5)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Especialidade)
                .HasMaxLength(20)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(x => x.CPF)
                .HasMaxLength(11)
                .HasColumnType("varchar(11)");
                
        }
    }
}
