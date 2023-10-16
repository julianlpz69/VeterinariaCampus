using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class MascotaEspecieDto
    {
        public int Id {get; set;}
        public string NombreMascota {get; set;}
        public DateOnly FechaNacimiento {get; set;}
        public EspecieDto Especies {get; set;}
    }
}