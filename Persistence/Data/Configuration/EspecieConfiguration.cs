using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class EspecieConfiguration : IEntityTypeConfiguration<Especie>
    {
        public void Configure(EntityTypeBuilder<Especie> builder){
    
            builder.ToTable("especie");
    
            builder.Property(e => e.NombreEspecie)
                .HasMaxLength(50);

            builder.HasData(
                new Especie { Id = 1, NombreEspecie = "Canino" },
                new Especie { Id = 2, NombreEspecie = "Felino" },
                new Especie { Id = 3, NombreEspecie = "Ave" },
                new Especie { Id = 4, NombreEspecie = "Roedores" },
                new Especie { Id = 5, NombreEspecie = "Exotico" }
            );
        }
    }
}