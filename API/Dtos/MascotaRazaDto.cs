using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class MascotaRazaDto
    {
        public int Id {get; set;}
        public string NombreMascota {get; set;}
        public ClienteonlyDto Cliente {get; set;}
        public RazaDto Raza { get; set; }
    }
}