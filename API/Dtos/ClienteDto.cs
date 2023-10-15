using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class ClienteDto
    {
        public int Id {get; set;}
         public string NombreCliente {get; set;}
        public string CorreoCliente {get; set;}
        public string TelefonoCliente {get; set;}
        public string CedulaCliente {get; set;}
        public ICollection<MascotaDto> Mascotas {get; set;}
        
    }
}