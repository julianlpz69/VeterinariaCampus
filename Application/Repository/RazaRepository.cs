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
    public class RazaRepository : GenericRepository<Raza>, IRaza
    {
        private readonly VeterinariaDBContext _context;

        public RazaRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }



        public async Task<IEnumerable<object>> MascotasXRaza()
        {
            var mascotasAtendidas = await _context.Razas
                .Select(raza => new
                {
                    RazaNombre = raza.NombreRaza,
                    CantidadMascotas = raza.Mascotas.Count
                })
                .ToListAsync();

            return mascotasAtendidas;
        }
    }
}