using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class EspecieConfiguration : IEntityTypeConfiguration<Especie>
    {
        public void Configure(EntityTypeBuilder<Especie> builder){
    
            builder.ToTable("especie");
    
            builder.Property(e => e.NombreEspecie)
                .HasMaxLength(50);

    
        }
    }
}