using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class RolRepository : GenericRepository<Rol>, IRol
    {
        private readonly VeterinariaDBContext _context;

        public RolRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }
    }
}