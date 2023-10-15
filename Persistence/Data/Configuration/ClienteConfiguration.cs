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
    
    
        }
    }
}