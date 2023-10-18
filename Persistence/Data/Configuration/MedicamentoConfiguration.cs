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


            builder.HasData(
                new Medicamento
    {
        Id = 1,
        NombreMedicamento = "Paracetamol",
        PrecioMedicamento = 10050,  // Ejemplo de precio
        StockMedicamento = 100,
        IdProveedorFK = 1,
        IdMarcaFK = 1
    },
    new Medicamento
    {
        Id = 2,
        NombreMedicamento = "Ibuprofeno",
        PrecioMedicamento = 12.75,
        StockMedicamento = 80,
        IdProveedorFK = 2,
        IdMarcaFK = 1
    },
    new Medicamento
    {
        Id = 3,
        NombreMedicamento = "Amoxicilina",
        PrecioMedicamento = 15020,
        StockMedicamento = 90,
        IdProveedorFK = 3,
        IdMarcaFK = 2
    },
    new Medicamento
    {
        Id = 4,
        NombreMedicamento = "Omeprazol",
        PrecioMedicamento = 80090,
        StockMedicamento = 70,
        IdProveedorFK = 4,
        IdMarcaFK = 2
    },
    new Medicamento
    {
        Id = 5,
        NombreMedicamento = "Loratadina",
        PrecioMedicamento = 60075,
        StockMedicamento = 60,
        IdProveedorFK = 5,
        IdMarcaFK = 3
    },
    new Medicamento
    {
        Id = 6,
        NombreMedicamento = "Dexametasona",
        PrecioMedicamento = 18040,
        StockMedicamento = 50,
        IdProveedorFK = 6,
        IdMarcaFK = 3
    },
    new Medicamento
    {
        Id = 7,
        NombreMedicamento = "Ciprofloxacino",
        PrecioMedicamento = 14060,
        StockMedicamento = 40,
        IdProveedorFK = 7,
        IdMarcaFK = 4
    },
    new Medicamento
    {
        Id = 8,
        NombreMedicamento = "Aspirina",
        PrecioMedicamento = 50025,
        StockMedicamento = 30,
        IdProveedorFK = 8,
        IdMarcaFK = 4
    },
    new Medicamento
    {
        Id = 9,
        NombreMedicamento = "Ranitidina",
        PrecioMedicamento = 90080,
        StockMedicamento = 20,
        IdProveedorFK = 9,
        IdMarcaFK = 5
    },
    new Medicamento
    {
        Id = 10,
        NombreMedicamento = "Clotrimazol",
        PrecioMedicamento = 7030,
        StockMedicamento = 10,
        IdProveedorFK = 10,
        IdMarcaFK = 5
    }
            );
        }
    }
}