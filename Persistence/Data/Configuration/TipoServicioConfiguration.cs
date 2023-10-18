using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TipoServicioConfiguration : IEntityTypeConfiguration<TipoServicio>
    {
        public void Configure(EntityTypeBuilder<TipoServicio> builder){
    
            builder.ToTable("tipo_servicio");
    
            builder.Property(u => u.NombreServicio)
                .HasMaxLength(50);



            builder.HasData(
                new TipoServicio{Id = 1, NombreServicio = "Operacion"},
                new TipoServicio{Id = 2, NombreServicio = "Bañado"},
                new TipoServicio{Id = 3, NombreServicio = "Vacunacion"},
                new TipoServicio{Id = 4, NombreServicio = "Desparasitación"},
                new TipoServicio{Id = 5, NombreServicio = "Examen General"}
            );    
        }
    }
}