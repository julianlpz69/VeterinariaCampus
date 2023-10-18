using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class MedicamentoSoloDto
    {
        public int Id {get; set;}
        public string NombreMedicamento {get; set;}
        public double PrecioMedicamento {get; set;}
         public int StockMedicamento {get; set;}
      
    }
}