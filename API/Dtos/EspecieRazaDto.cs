using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class EspecieRazaDto
    {
        public int Id {get; set;}
        public string NombreEspecie {get; set;}
        public ICollection<RazaMascotaDto> Razas {get; set;}
    }
}