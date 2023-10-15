using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FacturaVenta : BaseEntity
    {
        public double PrecioTotal {get; set;}
        public DateTime FechaVenta {get; set;}
        public int IdClienteFK {get; set;}
        public Cliente Cliente {get; set;}
        public ICollection<MedicamentoVenta> MedicamentoVentas {get; set;}
    }
}