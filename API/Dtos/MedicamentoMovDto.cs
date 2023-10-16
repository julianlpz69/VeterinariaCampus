using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class MedicamentoMovDto
    {
        public int Id {get; set;}
        public string NombreMedicamento {get; set;}
        public ICollection<MediCompraDto> MedicamentoCompras {get; set;}
        public ICollection<MediCompraDto> MedicamentoVentas {get; set;}
        public ICollection<MediCompraDto> MedicamentoServicios {get; set;}

    }
}