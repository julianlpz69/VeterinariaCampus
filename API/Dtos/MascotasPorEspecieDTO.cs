using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class MascotasPorEspecieDTO
    {
        public int Id {get; set;}
        public string NombreEspecie { get; set; }
        public List<MascotaPetDto> Mascotas { get; set; }
    }
}