using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class ProveedorMedicamentosDto
    {
        public int Id {get; set;}
        public string NombreProveedor {get; set;}
        public ICollection<MedicamentoSoloDto> Medicamentos {get; set;}
    }
}