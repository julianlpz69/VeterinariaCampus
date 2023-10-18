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
                

            builder.HasData(
               new Proveedor { Id = 1, NombreProveedor = "Droguería La Economía", DireccionProveedor = "Carrera 10 #25-30, Bogotá", TelefonoProveedor = "123-456-7890" },
                new Proveedor { Id = 2, NombreProveedor = "Droguería San Martín", DireccionProveedor = "Calle 15 #45-12, Medellín", TelefonoProveedor = "234-567-8901" },
                new Proveedor { Id = 3, NombreProveedor = "Farmacia El Rosario", DireccionProveedor = "Avenida 5 #8-40, Cali", TelefonoProveedor = "345-678-9012" },
                new Proveedor { Id = 4, NombreProveedor = "Droguería La Salud", DireccionProveedor = "Carrera 20 #33-55, Barranquilla", TelefonoProveedor = "456-789-0123" },
                new Proveedor { Id = 5, NombreProveedor = "Farmacia Los Alamos", DireccionProveedor = "Calle 30 #17-22, Cartagena", TelefonoProveedor = "567-890-1234" },
                new Proveedor { Id = 6, NombreProveedor = "Droguería El Carmen", DireccionProveedor = "Carrera 8 #12-30, Bucaramanga", TelefonoProveedor = "678-901-2345" },
                new Proveedor { Id = 7, NombreProveedor = "Farmacia La Esperanza", DireccionProveedor = "Avenida 15 #40-18, Cúcuta", TelefonoProveedor = "789-012-3456" },
                new Proveedor { Id = 8, NombreProveedor = "Droguería San José", DireccionProveedor = "Calle 25 #10-50, Pereira", TelefonoProveedor = "890-123-4567" },
                new Proveedor { Id = 9, NombreProveedor = "Farmacia Santa Marta", DireccionProveedor = "Carrera 12 #22-15, Santa Marta", TelefonoProveedor = "901-234-5678" },
                new Proveedor { Id = 10, NombreProveedor = "Droguería El Parque", DireccionProveedor = "Avenida 3 #5-10, Manizales", TelefonoProveedor = "012-345-6789" }
            );
        }
    }
}