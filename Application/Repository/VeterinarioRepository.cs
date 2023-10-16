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
    public class VeterinarioRepository : GenericRepository<Veterinario>, IVeterinario
    {
        private readonly VeterinariaDBContext _context;

        public VeterinarioRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Veterinario>> VeterinariosCirujano()
        {
            var veterinariosCirujanoVascular =await _context.Veterinarios
                .Where(v => v.EspecialidadVeterinario == "Cirujano vascular")
                .ToListAsync();

            return veterinariosCirujanoVascular;
        }
    }
}