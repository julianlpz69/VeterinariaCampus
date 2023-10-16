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
    public class ClienteRepository : GenericRepository<Cliente>, ICliente
    {
         private readonly VeterinariaDBContext _context;

        public ClienteRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Cliente>> ClientePet()
        {
            var Clientes =await _context.Clientes
                .Include(u => u.Mascotas)
                .ToListAsync();

            return Clientes;
        }
    }
}