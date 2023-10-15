using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class MedicamentoServicioConfiguration : IEntityTypeConfiguration<MedicamentoServicio>
    {
        public void Configure(EntityTypeBuilder<MedicamentoServicio> builder){
    
            builder.ToTable("medicamento_servicio");
    

            builder.HasOne(p => p.FacturaServicio)
                .WithMany(p => p.MedicamentoServicios)
                .HasForeignKey(p => p.IdFacturaServicioFK);

            builder.HasOne(p => p.Medicamento)
                .WithMany(p => p.MedicamentoServicios)
                .HasForeignKey(p => p.IdMedicamentoFK);
    
        }
    }
}