using Clinica.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.EntitiesConfiguration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Login)
                .HasMaxLength(15)
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder.Property(x => x.Senha)
                .HasMaxLength(20)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.HasData(
                new {Id = 1, Login = "admim", Senha = "admim"});
        }
    }
}
