using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Raza : BaseEntity
    {
        public string NombreRaza {get; set;}
        public int IdEspecieFK {get; set;}
        public Especie Especie {get; set;}
        public ICollection<Mascota> Mascotas {get; set;}
    }
}