using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class MedicamentoCompraConfiguration : IEntityTypeConfiguration<MedicamentoCompra>
    {
        public void Configure(EntityTypeBuilder<MedicamentoCompra> builder){
    
            builder.ToTable("medicamento_compra");

          
            builder.HasOne(p => p.FacturaCompra)
                .WithMany(p => p.MedicamentosCompras)
                .HasForeignKey(p => p.IdFacturaCompraFK);

            builder.HasOne(p => p.Medicamento)
                .WithMany(p => p.MedicamentoCompras)
                .HasForeignKey(p => p.IdMedicamentoFK);
        }
    }
}