using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class RazaConfiguration : IEntityTypeConfiguration<Raza>
    {
        public void Configure(EntityTypeBuilder<Raza> builder){
    
            builder.ToTable("raza");
    
            builder.Property(e => e.NombreRaza)
                .HasMaxLength(50);


            builder.HasOne(p => p.Especie)
                .WithMany(p => p.Razas)
                .HasForeignKey(p => p.IdEspecieFK);

            builder.HasData(
                new Raza { Id = 1, NombreRaza = "Labrador Retriever", IdEspecieFK = 1 },
                new Raza { Id = 2, NombreRaza = "Persa", IdEspecieFK = 2 },
                new Raza { Id = 3, NombreRaza = "Periquito Australiano", IdEspecieFK = 3 },
                new Raza { Id = 4, NombreRaza = "Cobaya", IdEspecieFK = 4 },
                new Raza { Id = 5, NombreRaza = "Gecko Leopardo", IdEspecieFK = 5 },
                new Raza { Id = 6, NombreRaza = "Golden Retriver", IdEspecieFK = 1 },
                new Raza { Id = 7, NombreRaza = "Siamés", IdEspecieFK = 2 },
                new Raza { Id = 8, NombreRaza = "Canario", IdEspecieFK = 3 },
                new Raza { Id = 9, NombreRaza = "Hámster", IdEspecieFK = 4 },
                new Raza { Id = 10, NombreRaza = "Rana Dardo Venenoso", IdEspecieFK = 5 }
            );
        }
    }
}