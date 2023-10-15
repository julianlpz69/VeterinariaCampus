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
    
        }
    }
}