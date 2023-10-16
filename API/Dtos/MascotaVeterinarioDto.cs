using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class MascotaVeterinarioDto
    {
        public int Id {get; set;}
        public string NombreMascota {get; set;}
        public ICollection<CitaVeterinarioDto> Citas {get; set;}
    }
}