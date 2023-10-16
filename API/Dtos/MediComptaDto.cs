using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class MediCompraDto
    {
      public int Cantidad {get; set;}
        public double Precio {get; set;}  
        public int IdMedicamentoFK {get; set;}
    }
}