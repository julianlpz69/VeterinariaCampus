using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class VeterinarioDto
    {
        public int Id {get; set;}
        public string NombreVeterinario {get; set;}
        public string CorreoVeterinario {get; set;}
        public string TelefonoVeterinario {get; set;}
        public string CedulaVeterinario {get; set;}
        public string EspecialidadVeterinario {get; set;}
    }
}