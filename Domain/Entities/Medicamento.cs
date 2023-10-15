using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Medicamento : BaseEntity
    {
        public string NombreMedicamento {get; set;}
        public double PrecioMedicamento {get; set;}
        public int StockMedicamento {get; set;}
        public int IdProveedorFK {get; set;}
        public Proveedor Proveedor {get; set;}
        public int IdMarcaFK {get; set;}
        public Marca Marca {get; set;}
        public ICollection<MedicamentoCompra> MedicamentoCompras {get; set;}
        public ICollection<MedicamentoVenta> MedicamentoVentas {get; set;}
        public ICollection<MedicamentoServicio> MedicamentoServicios {get; set;}
    }
}