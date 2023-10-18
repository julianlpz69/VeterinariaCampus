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

            builder.HasData(
                new MedicamentoVenta { Id = 1, Cantidad = 6, Precio = 30000, IdFacturaVentaFK = 1, IdMedicamentoFK = 1 },
                new MedicamentoVenta { Id = 2, Cantidad = 4, Precio = 28000, IdFacturaVentaFK = 1, IdMedicamentoFK = 2 },
                new MedicamentoVenta { Id = 3, Cantidad = 8, Precio = 32000, IdFacturaVentaFK = 2, IdMedicamentoFK = 3 },
                new MedicamentoVenta { Id = 4, Cantidad = 5, Precio = 31000, IdFacturaVentaFK = 2, IdMedicamentoFK = 4 },
                new MedicamentoVenta { Id = 5, Cantidad = 7, Precio = 29000, IdFacturaVentaFK = 3, IdMedicamentoFK = 5 },
                new MedicamentoVenta { Id = 6, Cantidad = 3, Precio = 27000, IdFacturaVentaFK = 3, IdMedicamentoFK = 6 },
                new MedicamentoVenta { Id = 7, Cantidad = 9, Precio = 26000, IdFacturaVentaFK = 4, IdMedicamentoFK = 7 },
                new MedicamentoVenta { Id = 8, Cantidad = 2, Precio = 24000, IdFacturaVentaFK = 4, IdMedicamentoFK = 8 },
                new MedicamentoVenta { Id = 9, Cantidad = 5, Precio = 22000, IdFacturaVentaFK = 5, IdMedicamentoFK = 9 },
                new MedicamentoVenta { Id = 10, Cantidad = 6, Precio = 20000, IdFacturaVentaFK = 5, IdMedicamentoFK = 10 },
                new MedicamentoVenta { Id = 11, Cantidad = 8, Precio = 18000, IdFacturaVentaFK = 6, IdMedicamentoFK = 1 },
                new MedicamentoVenta { Id = 12, Cantidad = 3, Precio = 160000, IdFacturaVentaFK = 6, IdMedicamentoFK = 2 },
                new MedicamentoVenta { Id = 13, Cantidad = 7, Precio = 14000, IdFacturaVentaFK = 7, IdMedicamentoFK = 3 },
                new MedicamentoVenta { Id = 14, Cantidad = 4, Precio = 12000, IdFacturaVentaFK = 7, IdMedicamentoFK = 4 },
                new MedicamentoVenta { Id = 15, Cantidad = 2, Precio = 10000, IdFacturaVentaFK = 8, IdMedicamentoFK = 5 },
                new MedicamentoVenta { Id = 16, Cantidad = 5, Precio = 80000, IdFacturaVentaFK = 8, IdMedicamentoFK = 6 },
                new MedicamentoVenta { Id = 17, Cantidad = 6, Precio = 60000, IdFacturaVentaFK = 9, IdMedicamentoFK = 7 },
                new MedicamentoVenta { Id = 18, Cantidad = 3, Precio = 40000, IdFacturaVentaFK = 9, IdMedicamentoFK = 8 },
                new MedicamentoVenta { Id = 19, Cantidad = 9, Precio = 20000, IdFacturaVentaFK = 10, IdMedicamentoFK = 9 },
                new MedicamentoVenta { Id = 20, Cantidad = 7, Precio = 10000, IdFacturaVentaFK = 10, IdMedicamentoFK = 10 }
            );
        }
    }
}