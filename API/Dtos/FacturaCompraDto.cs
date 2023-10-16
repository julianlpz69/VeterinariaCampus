using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class FacturaCompraDto
    {
        public int Id {get; set;}
        public double PrecioTotal {get; set;}
        public DateOnly FechaCompra {get; set;}
        public int IdProveedorFK {get; set;}
        public ICollection<MediCompraDto> MedicamentosCompras {get; set;}
    }
}