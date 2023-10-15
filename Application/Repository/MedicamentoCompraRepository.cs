using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class MedicamentoCompraRepository : GenericRepository<MedicamentoCompra> , IMedicamentoCompra
    {
        private readonly VeterinariaDBContext _context;

        public MedicamentoCompraRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }
    }
}