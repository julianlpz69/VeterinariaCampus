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
    public class ProveedorRepository : GenericRepository<Proveedor>, IProveedor
    {
         private readonly VeterinariaDBContext _context;

        public ProveedorRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }


          public async Task<IEnumerable<Proveedor>> MedicamentoProveedor(string NombreMedicamento)
        {
            var mascotasAtendidas = await _context.Proveedors
                .Where(m => m.Medicamentos.Any(c => c.NombreMedicamento == NombreMedicamento ))
                .Include(c => c.Medicamentos)
                .ToListAsync();

            return mascotasAtendidas;
        }
    }
}