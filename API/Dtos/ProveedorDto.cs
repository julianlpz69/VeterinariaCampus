using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProveedorDto
    {
        public int Id {get; set;}
        public string NombreProveedor {get; set;}
        public string DireccionProveedor {get; set;}
        public string TelefonoProveedor {get; set;}
    }
}