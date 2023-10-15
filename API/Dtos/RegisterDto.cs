using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class RegisterDto
    {
    [Required]
    public string CorreoUsuario { get; set; }
    [Required]
    public string NombreUsuario { get; set; }
    [Required]
    public string ClaveUsuario { get; set; }
    }
}