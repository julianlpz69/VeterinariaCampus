using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FacturaServicio : BaseEntity
    {
        public double PrecioTotal {get; set;}
        public DateTime FechaServicio {get; set;}
        public int IdTipoServicioFK {get; set;}
        public TipoServicio TipoServicio {get; set;}
        public int IdCitaFk {get; set;}
        public Cita Cita {get; set;}
        public ICollection<MedicamentoServicio> MedicamentoServicios {get; set;}
    }
}