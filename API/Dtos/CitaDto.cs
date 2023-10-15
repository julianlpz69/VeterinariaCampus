using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class CitaDto
    {
        public int Id {get; set;}
         public string MotivoCita {get; set;}
        public DateTime FechaCita {get; set;}
        public int IdVeterinarioFK {get; set;}
        public int IdClienteFK {get; set;}
        public int IdMascotaFK {get; set;}
       
    }
}