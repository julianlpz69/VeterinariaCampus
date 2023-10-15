using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveAsync();
        IRol Roles { get; }
        IUsuario Usuarios { get; }
        ICita Citas { get; }
        ICliente Clientes{ get; }
        IEspecie Especies{ get; }
        IFacturaCompra FacturaCompras{ get; }
        IFacturaServicio FacturaServicios{ get; }
        IFacturaVenta FacturaVentas{ get; }
        IMarca Marcas{ get; }
        IMascota Mascotas{ get; }
        IMedicamento Medicamentos{ get; }
        IMedicamentoCompra MedicamentoCompras{ get; }
        IMedicamentoServicio MedicamentoServicios{ get; }
        IMedicamentoVenta MedicamentoVentas{ get; }
        IProveedor Proveedores{ get; }
        IRaza Razas{ get; }
        ITipoServicio TipoServicios{ get; }
         IVeterinario Veterinarios{ get; }
    }
}