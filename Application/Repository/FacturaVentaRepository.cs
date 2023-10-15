using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class FacturaVentaRepository : GenericRepository<FacturaVenta> , IFacturaVenta
    {
        private readonly VeterinariaDBContext _context;

        public FacturaVentaRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }
    }
}