using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class MascotaRepository : GenericRepository<Mascota> , IMascota
    {
         private readonly VeterinariaDBContext _context;

        public MascotaRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }
    }
}