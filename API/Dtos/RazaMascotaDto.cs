using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class RazaMascotaDto
    {
        public int Id {get; set;}       
        public string NombreRaza {get; set;}
   
        public ICollection<MascotaPetDto> Mascotas {get; set;}
    }
}