using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cita : BaseEntity
    {
        public string MotivoCita {get; set;}
        public DateTime FechaCita {get; set;}
        public int IdVeterinarioFK {get; set;}
        public Veterinario Veterinario {get; set;}
        public int IdClienteFK {get; set;}
        public Cliente Cliente {get; set;}
        public int IdMascotaFK {get; set;}
        public Mascota Mascota {get; set;}
        public ICollection<FacturaServicio> FacturasServicios {get; set;}
    }
}