using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public string NombreCliente {get; set;}
        public string CorreoCliente {get; set;}
        public string TelefonoCliente {get; set;}
        public string CedulaCliente {get; set;}
        public ICollection<Mascota> Mascotas {get; set;}
        public ICollection<FacturaVenta> FacturasVentas {get; set;}
        public ICollection<Cita> Citas {get; set;}
    }
}