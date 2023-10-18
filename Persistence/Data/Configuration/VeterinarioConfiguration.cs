using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class VeterinarioConfiguration : IEntityTypeConfiguration<Veterinario>
    {
        public void Configure(EntityTypeBuilder<Veterinario> builder){
    
            builder.ToTable("veterinario");
    
             builder.Property(e => e.NombreVeterinario)
                .HasMaxLength(40);

            builder.Property(e => e.CedulaVeterinario)
                .HasMaxLength(40);
    
            builder.Property(e => e.CorreoVeterinario)
                .HasMaxLength(100);
    
            builder.Property(e => e.TelefonoVeterinario)
                .HasMaxLength(40);

            builder.Property(e => e.EspecialidadVeterinario)
                .HasMaxLength(40);

            builder.HasData(
                new Veterinario { Id = 1, NombreVeterinario = "Dr. Smith", CedulaVeterinario = "123456789", CorreoVeterinario = "dr.smith@example.com", TelefonoVeterinario = "123-456-7890", EspecialidadVeterinario = "Cirujano vascular" },
                new Veterinario { Id = 2, NombreVeterinario = "Dr. Johnson", CedulaVeterinario = "234567890", CorreoVeterinario = "dr.johnson@example.com", TelefonoVeterinario = "234-567-8901", EspecialidadVeterinario = "Dermatología" },
                new Veterinario { Id = 3, NombreVeterinario = "Dr. Brown", CedulaVeterinario = "345678901", CorreoVeterinario = "dr.brown@example.com", TelefonoVeterinario = "345-678-9012", EspecialidadVeterinario = "Oftalmología" },
                new Veterinario { Id = 4, NombreVeterinario = "Dr. Davis", CedulaVeterinario = "456789012", CorreoVeterinario = "dr.davis@example.com", TelefonoVeterinario = "456-789-0123", EspecialidadVeterinario = "Cardiología" },
                new Veterinario { Id = 5, NombreVeterinario = "Dr. Miller", CedulaVeterinario = "567890123", CorreoVeterinario = "dr.miller@example.com", TelefonoVeterinario = "567-890-1234", EspecialidadVeterinario = "Cirujano vascular" },
                new Veterinario { Id = 6, NombreVeterinario = "Dr. Wilson", CedulaVeterinario = "678901234", CorreoVeterinario = "dr.wilson@example.com", TelefonoVeterinario = "678-901-2345", EspecialidadVeterinario = "Endocrinología" },
                new Veterinario { Id = 7, NombreVeterinario = "Dr. Moore", CedulaVeterinario = "789012345", CorreoVeterinario = "dr.moore@example.com", TelefonoVeterinario = "789-012-3456", EspecialidadVeterinario = "Gastroenterología" },
                new Veterinario { Id = 8, NombreVeterinario = "Dr. Anderson", CedulaVeterinario = "890123456", CorreoVeterinario = "dr.anderson@example.com", TelefonoVeterinario = "890-123-4567", EspecialidadVeterinario = "Nefrología" },
                new Veterinario { Id = 9, NombreVeterinario = "Dr. Clark", CedulaVeterinario = "901234567", CorreoVeterinario = "dr.clark@example.com", TelefonoVeterinario = "901-234-5678", EspecialidadVeterinario = "Cirujano vascular" },
                new Veterinario { Id = 10, NombreVeterinario = "Dr. Turner", CedulaVeterinario = "012345678", CorreoVeterinario = "dr.turner@example.com", TelefonoVeterinario = "012-345-6789", EspecialidadVeterinario = "Inmunología" }
            );
           
        }
    }
}