using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository
{
    public class MascotaRepository : GenericRepository<Mascota> , IMascota
    {
         private readonly VeterinariaDBContext _context;

        public MascotaRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Mascota>> MascotaFelino()
        {
            var MascotaFelino =await _context.Mascotas
                .Where(v => v.Raza.Especie.NombreEspecie == "Felino" )
                .Include(u => u.Raza)
                .Include(u => u.Raza.Especie)
                .ToListAsync();

            return MascotaFelino;
        }


        public async Task<IEnumerable<Mascota>> MascotasVacunacion()
        {
            DateTime fecha1 = new DateTime(2023, 1, 1);
            DateTime fecha2 = new DateTime(2023, 3, 31);

        var mascotasAtendidas = await _context.Mascotas
            .Where(m => m.Citas.Any(c => c.MotivoCita == "Vacunacion" && 
                                         c.FechaCita >= fecha1 && 
                                         c.FechaCita <= fecha2))
            .Include(c => c.Citas)
            .ToListAsync();

        return mascotasAtendidas;
        }



        public async Task<IEnumerable<Mascota>> MascotasAtentidas(string NombreVeterinario)
        {
       

        var mascotasAtendidas = await _context.Mascotas
            .Where(m => m.Citas.Any(c => c.Veterinario.NombreVeterinario == NombreVeterinario ))
            .Include(c => c.Citas)
                .ThenInclude(c => c.Veterinario)
            .ToListAsync();

        return mascotasAtendidas;
        }


        public async Task<IEnumerable<Mascota>> MascotasRetriever()
        {
       

        var mascotasAtendidas = await _context.Mascotas
            .Where(m => m.Raza.NombreRaza == "Golden Retriver")
            .Include(c => c.Raza)
            .Include(c => c.Cliente)
            .ToListAsync();

        return mascotasAtendidas;
        }


        

      
        

        






    }
}