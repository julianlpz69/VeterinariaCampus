using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class FacturaCompraConfiguration : IEntityTypeConfiguration<FacturaCompra>
    {
        public void Configure(EntityTypeBuilder<FacturaCompra> builder){
    
            builder.ToTable("factura_compra");

            builder.HasOne(p => p.Proveedor)
                .WithMany(p => p.FacturaCompras)
                .HasForeignKey(p => p.IdProveedorFK);
        

            builder.HasData(
                new FacturaCompra { Id = 1, FechaCompra = new DateOnly(2023, 10, 29), IdProveedorFK = 1, PrecioTotal = 200000 },
                new FacturaCompra { Id = 2, FechaCompra = new DateOnly(2023, 10, 28), IdProveedorFK = 2, PrecioTotal = 250000 },
                new FacturaCompra { Id = 3, FechaCompra = new DateOnly(2023, 10, 27), IdProveedorFK = 1, PrecioTotal = 180000 },
                new FacturaCompra { Id = 4, FechaCompra = new DateOnly(2023, 10, 26), IdProveedorFK = 3, PrecioTotal = 300000 },
                new FacturaCompra { Id = 5, FechaCompra = new DateOnly(2023, 10, 25), IdProveedorFK = 2, PrecioTotal = 220000 },
                new FacturaCompra { Id = 6, FechaCompra = new DateOnly(2023, 10, 24), IdProveedorFK = 3, PrecioTotal = 260000 },
                new FacturaCompra { Id = 7, FechaCompra = new DateOnly(2023, 10, 23), IdProveedorFK = 1, PrecioTotal = 190000 },
                new FacturaCompra { Id = 8, FechaCompra = new DateOnly(2023, 10, 22), IdProveedorFK = 5, PrecioTotal = 270000 },
                new FacturaCompra { Id = 9, FechaCompra = new DateOnly(2023, 10, 21), IdProveedorFK = 3, PrecioTotal = 230000 },
                new FacturaCompra { Id = 10, FechaCompra = new DateOnly(2023, 10, 20), IdProveedorFK = 4, PrecioTotal = 210000 }
            );
        }
    }
}