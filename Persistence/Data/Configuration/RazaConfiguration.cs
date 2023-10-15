using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class RazaConfiguration : IEntityTypeConfiguration<Raza>
    {
        public void Configure(EntityTypeBuilder<Raza> builder){
    
            builder.ToTable("raza");
    
            builder.Property(e => e.NombreRaza)
                .HasMaxLength(50);


            builder.HasOne(p => p.Especie)
                .WithMany(p => p.Razas)
                .HasForeignKey(p => p.IdEspecieFK);
        }
    }
}