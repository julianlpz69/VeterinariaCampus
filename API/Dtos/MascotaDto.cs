using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class MascotaDto
    {
        public int Id {get; set;}
        public string NombreMascota {get; set;}
        public DateOnly FechaNacimiento {get; set;}
        public int IdRazaFK {get; set;}
        public int IdClienteFK {get; set;}
    }
}