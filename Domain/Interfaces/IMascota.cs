using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IMascota : IGenericRepository<Mascota>
    {
        Task<IEnumerable<Mascota>> MascotaFelino();
        Task<IEnumerable<Mascota>> MascotasVacunacion();
        Task<IEnumerable<Mascota>> MascotasAtentidas(string NombreVeterinario);
        Task<IEnumerable<Mascota>> MascotasRetriever();
       
    }
}