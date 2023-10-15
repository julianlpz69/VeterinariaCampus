using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class CitaConfiguration : IEntityTypeConfiguration<Cita>
    {
        public void Configure(EntityTypeBuilder<Cita> builder){
    
            builder.ToTable("cita");
    
            builder.Property(e => e.MotivoCita)
                .HasMaxLength(255);

            
            builder.HasOne(p => p.Cliente)
                .WithMany(p => p.Citas)
                .HasForeignKey(p => p.IdClienteFK);

            builder.HasOne(p => p.Mascota)
                .WithMany(p => p.Citas)
                .HasForeignKey(p => p.IdMascotaFK);

            builder.HasOne(p => p.Veterinario)
                .WithMany(p => p.Citas)
                .HasForeignKey(p => p.IdVeterinarioFK);



    
        }
    }
}