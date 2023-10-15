using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Veterinario : BaseEntity
    {
        public string NombreVeterinario {get; set;}
        public string CorreoVeterinario {get; set;}
        public string TelefonoVeterinario {get; set;}
        public string CedulaVeterinario {get; set;}
        public string EspecialidadVeterinario {get; set;}
        public ICollection<Cita> Citas {get; set;}
    }
}