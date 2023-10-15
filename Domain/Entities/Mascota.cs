using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Mascota : BaseEntity
    {
        public string NombreMascota {get; set;}
        public DateOnly FechaNacimiento {get; set;}
        public int IdRazaFK {get; set;}
        public Raza Raza {get; set;}
        public int IdClienteFK {get; set;}
        public Cliente Cliente {get; set;}
        public ICollection<Cita> Citas {get; set;}
    }
}