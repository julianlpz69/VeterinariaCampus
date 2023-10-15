using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class MedicamentoConfiguration : IEntityTypeConfiguration<Medicamento>
    {
        public void Configure(EntityTypeBuilder<Medicamento> builder){
    
            builder.ToTable("medicamento");

            builder.Property(e => e.NombreMedicamento)
                .HasMaxLength(50);
    
            builder.HasOne(p => p.Marca)
                .WithMany(p => p.Medicamentos)
                .HasForeignKey(p => p.IdMarcaFK);

            builder.HasOne(p => p.Proveedor)
                .WithMany(p => p.Medicamentos)
                .HasForeignKey(p => p.IdProveedorFK);


    
        }
    }
}