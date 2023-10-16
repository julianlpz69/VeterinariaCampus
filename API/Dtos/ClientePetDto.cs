using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class ClientePetDto
    {
        public int Id {get; set;}
        public string NombreCliente {get; set;}
        public string CedulaCliente {get; set;}
        public ICollection<MascotaPetDto> Mascotas {get; set;}
    }
}