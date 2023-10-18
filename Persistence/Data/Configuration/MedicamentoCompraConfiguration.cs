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

            
            builder.HasData(
                new MedicamentoCompra { Id = 1, Cantidad = 5, Precio = 20000, IdFacturaCompraFK = 1, IdMedicamentoFK = 1 },
                new MedicamentoCompra { Id = 2, Cantidad = 3, Precio = 15000, IdFacturaCompraFK = 2, IdMedicamentoFK = 2 },
                new MedicamentoCompra { Id = 3, Cantidad = 7, Precio = 22000, IdFacturaCompraFK = 3, IdMedicamentoFK = 1 },
                new MedicamentoCompra { Id = 4, Cantidad = 2, Precio = 18000, IdFacturaCompraFK = 4, IdMedicamentoFK = 3 },
                new MedicamentoCompra { Id = 5, Cantidad = 4, Precio = 19000, IdFacturaCompraFK = 5, IdMedicamentoFK = 2 },
                new MedicamentoCompra { Id = 6, Cantidad = 6, Precio = 21000, IdFacturaCompraFK = 6, IdMedicamentoFK = 1 },
                new MedicamentoCompra { Id = 7, Cantidad = 8, Precio = 23000, IdFacturaCompraFK = 7, IdMedicamentoFK = 3 },
                new MedicamentoCompra { Id = 8, Cantidad = 1, Precio = 17000, IdFacturaCompraFK = 8, IdMedicamentoFK = 2 },
                new MedicamentoCompra { Id = 9, Cantidad = 9, Precio = 24000, IdFacturaCompraFK = 9, IdMedicamentoFK = 1 },
                new MedicamentoCompra { Id = 10, Cantidad = 3, Precio = 16000, IdFacturaCompraFK = 10, IdMedicamentoFK = 3 },
                new MedicamentoCompra { Id = 11, Cantidad = 5, Precio = 20000, IdFacturaCompraFK = 1, IdMedicamentoFK = 3 },
                new MedicamentoCompra { Id = 12, Cantidad = 3, Precio = 15000, IdFacturaCompraFK = 2, IdMedicamentoFK = 1 },
                new MedicamentoCompra { Id = 13, Cantidad = 7, Precio = 22000, IdFacturaCompraFK = 3, IdMedicamentoFK = 2 },
                new MedicamentoCompra { Id = 14, Cantidad = 2, Precio = 18000, IdFacturaCompraFK = 4, IdMedicamentoFK = 2 },
                new MedicamentoCompra { Id = 15, Cantidad = 4, Precio = 19000, IdFacturaCompraFK = 5, IdMedicamentoFK = 1 },
                new MedicamentoCompra { Id = 16, Cantidad = 6, Precio = 21000, IdFacturaCompraFK = 6, IdMedicamentoFK = 3 },
                new MedicamentoCompra { Id = 17, Cantidad = 8, Precio = 23000, IdFacturaCompraFK = 7, IdMedicamentoFK = 2 },
                new MedicamentoCompra { Id = 18, Cantidad = 1, Precio = 17000, IdFacturaCompraFK = 8, IdMedicamentoFK = 1 },
                new MedicamentoCompra { Id = 19, Cantidad = 9, Precio = 24000, IdFacturaCompraFK = 9, IdMedicamentoFK = 3 },
                new MedicamentoCompra { Id = 120, Cantidad = 3, Precio = 16000, IdFacturaCompraFK = 10, IdMedicamentoFK = 1 }
            );
        }
    }
}