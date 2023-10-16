using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IVeterinario : IGenericRepository<Veterinario>
    {
        Task<IEnumerable<Veterinario>> VeterinariosCirujano();
    }
}