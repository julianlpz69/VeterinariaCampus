using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class FacturaVentaDto
    {
        public int Id {get; set;}
        public double PrecioTotal {get; set;}
        public DateTime FechaVenta {get; set;}
        public int IdClienteFK {get; set;}
        public ICollection<MediVentaDto> MedicamentoVentas {get; set;}
    }
}