using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class FacturaServicioDto
    {
        public int Id {get; set;}
        public double PrecioTotal {get; set;}
        public DateTime FechaServicio {get; set;}
        public int IdTipoServicioFK {get; set;}
        public int IdCitaFk {get; set;}
        public ICollection<MediServicioDto> MedicamentoServicios {get; set;}
    }
}