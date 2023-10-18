using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder){
    
            builder.ToTable("marca");
    
            builder.Property(e => e.NombreMarca)
                .HasMaxLength(50);

            builder.HasData(
                new Marca{Id = 1, NombreMarca = "Serave"},
                new Marca{Id = 2, NombreMarca = "Pficer"},
                new Marca{Id = 3, NombreMarca = "DrogasMax"},
                new Marca{Id = 4, NombreMarca = "Salud Total"},
                new Marca{Id = 5, NombreMarca = "Genfar"}
            );
        

        }
    }
}