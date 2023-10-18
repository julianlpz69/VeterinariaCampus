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

            builder.HasData(
                new MedicamentoServicio { Id = 1, Cantidad = 4, Precio = 20000, IdFacturaServicioFK = 1, IdMedicamentoFK = 1 },
                new MedicamentoServicio { Id = 2, Cantidad = 3, Precio = 18000, IdFacturaServicioFK = 2, IdMedicamentoFK = 2 },
                new MedicamentoServicio { Id = 3, Cantidad = 5, Precio = 22000, IdFacturaServicioFK = 3, IdMedicamentoFK = 1 },
                new MedicamentoServicio { Id = 4, Cantidad = 2, Precio = 21000, IdFacturaServicioFK = 4, IdMedicamentoFK = 3 },
                new MedicamentoServicio { Id = 5, Cantidad = 6, Precio = 24000, IdFacturaServicioFK = 5, IdMedicamentoFK = 2 },
                new MedicamentoServicio { Id = 6, Cantidad = 3, Precio = 19000, IdFacturaServicioFK = 6, IdMedicamentoFK = 1 },
                new MedicamentoServicio { Id = 7, Cantidad = 5, Precio = 21000, IdFacturaServicioFK = 7, IdMedicamentoFK = 3 },
                new MedicamentoServicio { Id = 8, Cantidad = 4, Precio = 22000, IdFacturaServicioFK = 8, IdMedicamentoFK = 2 },
                new MedicamentoServicio { Id = 9, Cantidad = 3, Precio = 19000, IdFacturaServicioFK = 9, IdMedicamentoFK = 1 },
                new MedicamentoServicio { Id = 10, Cantidad = 6, Precio = 23000, IdFacturaServicioFK = 10, IdMedicamentoFK = 3 },
                new MedicamentoServicio { Id = 11, Cantidad = 4, Precio = 20000, IdFacturaServicioFK = 1, IdMedicamentoFK = 3 },
                new MedicamentoServicio { Id = 12, Cantidad = 3, Precio = 18000, IdFacturaServicioFK = 2, IdMedicamentoFK = 1 },
                new MedicamentoServicio { Id = 13, Cantidad = 5, Precio = 22000, IdFacturaServicioFK = 3, IdMedicamentoFK = 3 },
                new MedicamentoServicio { Id = 14, Cantidad = 2, Precio = 21000, IdFacturaServicioFK = 4, IdMedicamentoFK = 2 },
                new MedicamentoServicio { Id = 15, Cantidad = 6, Precio = 24000, IdFacturaServicioFK = 5, IdMedicamentoFK = 1 },
                new MedicamentoServicio { Id = 16, Cantidad = 3, Precio = 19000, IdFacturaServicioFK = 6, IdMedicamentoFK = 3 },
                new MedicamentoServicio { Id = 17, Cantidad = 5, Precio = 21000, IdFacturaServicioFK = 7, IdMedicamentoFK = 1 },
                new MedicamentoServicio { Id = 18, Cantidad = 4, Precio = 22000, IdFacturaServicioFK = 8, IdMedicamentoFK = 1 },
                new MedicamentoServicio { Id = 19, Cantidad = 3, Precio = 19000, IdFacturaServicioFK = 9, IdMedicamentoFK = 3 },
                new MedicamentoServicio { Id = 20, Cantidad = 6, Precio = 23000, IdFacturaServicioFK = 10, IdMedicamentoFK = 2 }

            );
    
        }
    }
}