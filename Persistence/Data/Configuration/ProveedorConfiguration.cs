using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder){
    
            builder.ToTable("proveedor");
    
            builder.Property(e => e.NombreProveedor)
                .HasMaxLength(50);

            builder.Property(e => e.TelefonoProveedor)
                .HasMaxLength(50);

            builder.Property(e => e.DireccionProveedor)
                .HasMaxLength(100);
    
        }
    }
}