using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MedicamentoServicio : BaseEntity
    {
        public int Cantidad {get; set;}
        public double Precio {get; set;}
        public int IdFacturaServicioFK {get; set;}
        public FacturaServicio FacturaServicio {get; set;}
        public int IdMedicamentoFK {get; set;}
        public Medicamento Medicamento {get; set;}
    }
}