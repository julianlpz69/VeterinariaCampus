using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TipoServicio : BaseEntity
    {
        public string NombreServicio {get; set;}
        public double PrecioServicio {get; set;}
        public ICollection<FacturaServicio> FacturaServicios {get; set;}
    }
}