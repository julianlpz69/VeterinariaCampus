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
    public class EspecieRepository : GenericRepository<Especie>, IEspecie
    {
         private readonly VeterinariaDBContext _context;

        public EspecieRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }


        public async Task<IEnumerable<object>> ObtenerMascotasPorEspecie()
        {
            var resultado = await _context.Especies
                .Include(e => e.Razas)
                .ThenInclude(r => r.Mascotas)
                .SelectMany(especie => especie.Razas.SelectMany(raza => raza.Mascotas),
                            (especie, mascota) => 
                            new { EspecieId = especie.Id, 
                            NombreEspecie = especie.NombreEspecie, 
                            NombreMascota = mascota.NombreMascota, 
                            MascotaId = mascota.Id, 
                            FechaNacimiento = mascota.FechaNacimiento})
                .GroupBy(x => x.NombreEspecie)
                .Select(g => new
                {
                    Id = g.First().EspecieId,
                    NombreEspecie = g.Key,
                    Mascotas = g.Select(x => new
                    {
                        IdMascota = x.MascotaId,
                        NombreMascota = x.NombreMascota,
                        FechaNacimiento = x.FechaNacimiento
                    }).ToList()
                })
                .ToListAsync();

            return resultado;
        }


        

    
    }
}