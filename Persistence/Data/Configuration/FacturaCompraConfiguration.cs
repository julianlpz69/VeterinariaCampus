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
    
          
    
        }
    }
}