using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class FacturaServicioRepository : GenericRepository<FacturaServicio>, IFacturaServicio
    {
        private readonly VeterinariaDBContext _context;

        public FacturaServicioRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }
    }
}