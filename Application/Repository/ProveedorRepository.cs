using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
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
    }
}