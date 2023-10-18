using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder){
    
            builder.ToTable("cliente");
    
            builder.Property(e => e.NombreCliente)
                .HasMaxLength(40);

            builder.Property(e => e.CedulaCliente)
                .HasMaxLength(40);
    
            builder.Property(e => e.CorreoCliente)
                .HasMaxLength(100);
    
            builder.Property(e => e.TelefonoCliente)
                .HasMaxLength(40);
    
            builder.HasData(
                new Cliente { Id = 1, NombreCliente = "Juan Pérez", CorreoCliente = "juan.perez@example.com", TelefonoCliente = "123-456-7890", CedulaCliente = "123456789" },
                new Cliente { Id = 2, NombreCliente = "María Rodríguez", CorreoCliente = "maria.rodriguez@example.com", TelefonoCliente = "234-567-8901", CedulaCliente = "234567890" },
                new Cliente { Id = 3, NombreCliente = "Carlos Gómez", CorreoCliente = "carlos.gomez@example.com", TelefonoCliente = "345-678-9012", CedulaCliente = "345678901" },
                new Cliente { Id = 4, NombreCliente = "Laura Martínez", CorreoCliente = "laura.martinez@example.com", TelefonoCliente = "456-789-0123", CedulaCliente = "456789012" },
                new Cliente { Id = 5, NombreCliente = "Andrés López", CorreoCliente = "andres.lopez@example.com", TelefonoCliente = "567-890-1234", CedulaCliente = "567890123" },
                new Cliente { Id = 6, NombreCliente = "Ana Ramírez", CorreoCliente = "ana.ramirez@example.com", TelefonoCliente = "678-901-2345", CedulaCliente = "678901234" },
                new Cliente { Id = 7, NombreCliente = "Javier Herrera", CorreoCliente = "javier.herrera@example.com", TelefonoCliente = "789-012-3456", CedulaCliente = "789012345" },
                new Cliente { Id = 8, NombreCliente = "Isabel Castro", CorreoCliente = "isabel.castro@example.com", TelefonoCliente = "890-123-4567", CedulaCliente = "890123456" },
                new Cliente { Id = 9, NombreCliente = "Sergio Vargas", CorreoCliente = "sergio.vargas@example.com", TelefonoCliente = "901-234-5678", CedulaCliente = "901234567" },
                new Cliente { Id = 10, NombreCliente = "Natalia López", CorreoCliente = "natalia.lopez@example.com", TelefonoCliente = "012-345-6789", CedulaCliente = "012345678" }
            );
        }
    }
}