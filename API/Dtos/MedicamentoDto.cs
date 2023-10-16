using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class MedicamentoDto
    {
        public int Id {get; set;}
        public string NombreMedicamento {get; set;}
        public double PrecioMedicamento {get; set;}
        public int StockMedicamento {get; set;}
        public int IdProveedorFK {get; set;}
        public int IdMarcaFK {get; set;}
        public MarcaDto Marca {get; set;}
    }
}