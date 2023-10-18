using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class FacturaVentaConfiguration : IEntityTypeConfiguration<FacturaVenta>
    {
        public void Configure(EntityTypeBuilder<FacturaVenta> builder){
    
            builder.ToTable("factura_venta");
    
            builder.HasOne(p => p.Cliente)
                .WithMany(p => p.FacturasVentas)
                .HasForeignKey(p => p.IdClienteFK);


            builder.HasData(
                new FacturaVenta { Id = 1, FechaVenta = new DateTime(2023, 5, 10), PrecioTotal = 20000, IdClienteFK = 1 },
                new FacturaVenta { Id = 2, FechaVenta = new DateTime(2023, 5, 15), PrecioTotal = 18000, IdClienteFK = 2 },
                new FacturaVenta { Id = 3, FechaVenta = new DateTime(2023, 5, 20), PrecioTotal = 22000, IdClienteFK = 3 },
                new FacturaVenta { Id = 4, FechaVenta = new DateTime(2023, 5, 25), PrecioTotal = 25000, IdClienteFK = 4 },
                new FacturaVenta { Id = 5, FechaVenta = new DateTime(2023, 5, 30), PrecioTotal = 21000, IdClienteFK = 5 },
                new FacturaVenta { Id = 6, FechaVenta = new DateTime(2023, 6, 5), PrecioTotal = 24000, IdClienteFK = 6 },
                new FacturaVenta { Id = 7, FechaVenta = new DateTime(2023, 6, 10), PrecioTotal = 19000, IdClienteFK = 7 },
                new FacturaVenta { Id = 8, FechaVenta = new DateTime(2023, 6, 15), PrecioTotal = 23000, IdClienteFK = 8 },
                new FacturaVenta { Id = 9, FechaVenta = new DateTime(2023, 6, 20), PrecioTotal = 26000, IdClienteFK = 9 },
                new FacturaVenta { Id = 10, FechaVenta = new DateTime(2023, 6, 25), PrecioTotal = 27000, IdClienteFK = 10 },
                new FacturaVenta { Id = 11, FechaVenta = new DateTime(2023, 5, 10), PrecioTotal = 20000, IdClienteFK = 1 },
                new FacturaVenta { Id = 12, FechaVenta = new DateTime(2023, 5, 15), PrecioTotal = 18000, IdClienteFK = 2 },
                new FacturaVenta { Id = 13, FechaVenta = new DateTime(2023, 5, 20), PrecioTotal = 22000, IdClienteFK = 3 },
                new FacturaVenta { Id = 14, FechaVenta = new DateTime(2023, 5, 25), PrecioTotal = 25000, IdClienteFK = 4 },
                new FacturaVenta { Id = 15, FechaVenta = new DateTime(2023, 5, 30), PrecioTotal = 21000, IdClienteFK = 5 },
                new FacturaVenta { Id = 16, FechaVenta = new DateTime(2023, 6, 5), PrecioTotal = 24000, IdClienteFK = 6 },
                new FacturaVenta { Id = 17, FechaVenta = new DateTime(2023, 6, 10), PrecioTotal = 19000, IdClienteFK = 7 },
                new FacturaVenta { Id = 18, FechaVenta = new DateTime(2023, 6, 15), PrecioTotal = 23000, IdClienteFK = 8 },
                new FacturaVenta { Id = 19, FechaVenta = new DateTime(2023, 6, 20), PrecioTotal = 26000, IdClienteFK = 9 },
                new FacturaVenta { Id = 20, FechaVenta = new DateTime(2023, 6, 25), PrecioTotal = 27000, IdClienteFK = 10 }
            );
    
        }
    }
}