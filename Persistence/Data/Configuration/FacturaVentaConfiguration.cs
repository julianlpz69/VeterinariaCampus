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
    
        }
    }
}