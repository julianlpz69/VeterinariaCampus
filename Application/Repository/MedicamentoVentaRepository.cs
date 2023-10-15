using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class MedicamentoVentaRepository : GenericRepository<MedicamentoVenta> , IMedicamentoVenta
    {
         private readonly VeterinariaDBContext _context;

        public MedicamentoVentaRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }
    }
}