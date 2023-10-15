using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class MedicamentoVentaConfiguration : IEntityTypeConfiguration<MedicamentoVenta>
    {
        public void Configure(EntityTypeBuilder<MedicamentoVenta> builder){
    
            builder.ToTable("MedicamentoVenta");
    
          
            builder.HasOne(p => p.FacturaVenta)
                .WithMany(p => p.MedicamentoVentas)
                .HasForeignKey(p => p.IdFacturaVentaFK);

            builder.HasOne(p => p.Medicamento)
                .WithMany(p => p.MedicamentoVentas)
                .HasForeignKey(p => p.IdMedicamentoFK);
        }
    }
}