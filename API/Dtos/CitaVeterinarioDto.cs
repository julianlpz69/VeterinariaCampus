using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class CitaVeterinarioDto
    {
        public string MotivoCita {get; set;}
        public VeterinarioCitaDto Veterinario {get; set;}
    }
}