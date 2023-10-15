using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class EspecieRepository : GenericRepository<Especie>, IEspecie
    {
         private readonly VeterinariaDBContext _context;

        public EspecieRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }
    }
}