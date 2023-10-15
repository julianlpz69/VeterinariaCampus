using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class TipoServicioRepository : GenericRepository<TipoServicio>, ITipoServicio
    {
        private readonly VeterinariaDBContext _context;

        public TipoServicioRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }
    }
}