using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class MarcaRepository : GenericRepository<Marca>, IMarca
    {
         private readonly VeterinariaDBContext _context;

        public MarcaRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }
    }
}