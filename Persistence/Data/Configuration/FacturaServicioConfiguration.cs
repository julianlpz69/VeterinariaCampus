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

            builder.HasData(
                new FacturaServicio { Id = 1, FechaServicio = new DateTime(2023, 10, 29), IdCitaFk = 1, PrecioTotal = 200000, IdTipoServicioFK = 3 },
                new FacturaServicio { Id = 2, FechaServicio = new DateTime(2023, 11, 5), IdCitaFk = 2, PrecioTotal = 180000, IdTipoServicioFK = 2 },
                new FacturaServicio { Id = 3, FechaServicio = new DateTime(2023, 11, 12), IdCitaFk = 3, PrecioTotal = 220000, IdTipoServicioFK = 1 },
                new FacturaServicio { Id = 4, FechaServicio = new DateTime(2023, 11, 19), IdCitaFk = 4, PrecioTotal = 250000, IdTipoServicioFK = 3 },
                new FacturaServicio { Id = 5, FechaServicio = new DateTime(2023, 11, 26), IdCitaFk = 5, PrecioTotal = 210000, IdTipoServicioFK = 5 },
                new FacturaServicio { Id = 6, FechaServicio = new DateTime(2023, 12, 3), IdCitaFk = 6, PrecioTotal = 240000, IdTipoServicioFK = 4 },
                new FacturaServicio { Id = 7, FechaServicio = new DateTime(2023, 12, 10), IdCitaFk = 7, PrecioTotal = 190000, IdTipoServicioFK = 3 },
                new FacturaServicio { Id = 8, FechaServicio = new DateTime(2023, 12, 17), IdCitaFk = 8, PrecioTotal = 230000, IdTipoServicioFK = 4 },
                new FacturaServicio { Id = 9, FechaServicio = new DateTime(2023, 12, 24), IdCitaFk = 9, PrecioTotal = 260000, IdTipoServicioFK = 2 },
                new FacturaServicio { Id = 10, FechaServicio = new DateTime(2023, 12, 31), IdCitaFk = 10, PrecioTotal = 270000, IdTipoServicioFK = 3 }
            );
    
        }
    }
}