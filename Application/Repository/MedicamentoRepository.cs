using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository
{
    public class MedicamentoRepository : GenericRepository<Medicamento>, IMedicamento
    {
        private readonly VeterinariaDBContext _context;

        public MedicamentoRepository(VeterinariaDBContext context):base(context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Medicamento>> MedicamentosGenfar()
        {
            var MedicamentosGenfar =await _context.Medicamentos
                .Where(v => v.Marca.NombreMarca == "Genfar")
                .Include(u => u.Marca)
                .ToListAsync();

            return MedicamentosGenfar;
        }




        public async Task<IEnumerable<Medicamento>> MedicamentosCaros()
        {
            var MedicamentosGenfar =await _context.Medicamentos
                .Where(v => v.PrecioMedicamento > 50000)
                .ToListAsync();

            return MedicamentosGenfar;
        }



        public async Task<IEnumerable<Medicamento>> MedicamentoMovimientos()
        {
            var Movimientos =await _context.Medicamentos
                .Include(u => u.MedicamentoCompras)
                .Include(u => u.MedicamentoVentas)
                .Include(u => u.MedicamentoServicios)
                .ToListAsync();

            return Movimientos;
        }
    }
}