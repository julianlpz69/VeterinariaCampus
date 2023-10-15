using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class FacturaServicioConfiguration : IEntityTypeConfiguration<FacturaServicio>
    {
        public void Configure(EntityTypeBuilder<FacturaServicio> builder){
    
            builder.ToTable("factura_servicio");
    
            builder.HasOne(p => p.Cita)
                .WithMany(p => p.FacturasServicios)
                .HasForeignKey(p => p.IdCitaFk);

            builder.HasOne(p => p.TipoServicio)
                .WithMany(p => p.FacturaServicios)
                .HasForeignKey(p => p.IdTipoServicioFK);
    
        }
    }
}