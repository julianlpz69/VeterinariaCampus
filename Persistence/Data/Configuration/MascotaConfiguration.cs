using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class MascotaConfiguration : IEntityTypeConfiguration<Mascota>
    {
        public void Configure(EntityTypeBuilder<Mascota> builder){
    
            builder.ToTable("mascota");

            builder.HasOne(p => p.Cliente)
                .WithMany(p => p.Mascotas)
                .HasForeignKey(p => p.IdClienteFK);
    

            builder.HasOne(p => p.Raza)
                .WithMany(p => p.Mascotas)
                .HasForeignKey(p => p.IdRazaFK);
    
        }
    }
}