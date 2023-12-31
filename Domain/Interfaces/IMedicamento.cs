using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IMedicamento : IGenericRepository<Medicamento>
    {
        Task<IEnumerable<Medicamento>> MedicamentosGenfar();
        Task<IEnumerable<Medicamento>> MedicamentosCaros();
        Task<IEnumerable<Medicamento>> MedicamentoMovimientos();
    }
}