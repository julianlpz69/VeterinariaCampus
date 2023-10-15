using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
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
    }
}