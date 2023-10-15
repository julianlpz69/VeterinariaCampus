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
    
        }
    }
}