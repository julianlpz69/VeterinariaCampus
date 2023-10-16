using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class MascotaVacunaDto
    {
        public int Id {get; set;}
        public string NombreMascota {get; set;}
        public ICollection<CitaVacunaDto> Citas {get; set;}
    }
}
