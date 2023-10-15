using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{

    private readonly VeterinariaDBContext _context; 
    private ICita _citas;
    private ICliente _clientes;
    private IEspecie _especies;
    private IFacturaCompra _facturaCompras;
    private IFacturaServicio _facturaServicios;
    private IFacturaVenta _facturaVentas;
    private IMarca _marcas;
    private IMascota _mascotas;
    private IMedicamento _medicamentos;
    private IMedicamentoCompra _medicamentoCompras;
    private IMedicamentoServicio _medicamentoServicios;
    private IMedicamentoVenta _medicamentoVentas;
    private IProveedor _proveedores;
    private IRaza _razas;
    private ITipoServicio _tipoServicios;
    private IVeterinario _veterinarios;
	private IRol _roles;
    private IUsuario _usuario;
    public UnitOfWork(VeterinariaDBContext context){
        _context = context;
    }

   
    
    public ICita Citas
    {
        get{
            if (_citas == null)
            {
                _citas = new CitaRepository(_context);
            }
            return _citas;
        }
    }


    public ICliente Clientes
    {
        get{
            if (_clientes == null)
            {
                _clientes = new ClienteRepository(_context);
            }
            return _clientes;
        }
    }



    public IEspecie Especies
    {
        get{
            if (_especies == null)
            {
                _especies = new EspecieRepository(_context);
            }
            return _especies;
        }
    }



    public IFacturaCompra FacturaCompras
    {
        get{
            if (_facturaCompras == null)
            {
                _facturaCompras = new FacturaCompraRepository(_context);
            }
            return _facturaCompras;
        }
    }



    public IFacturaServicio FacturaServicios
    {
        get{
            if (_facturaServicios == null)
            {
                _facturaServicios = new FacturaServicioRepository(_context);
            }
            return _facturaServicios;
        }
    }



    public IFacturaVenta FacturaVentas
    {
        get{
            if (_facturaVentas == null)
            {
                _facturaVentas = new FacturaVentaRepository(_context);
            }
            return _facturaVentas;
        }
    }



    public IMarca Marcas
    {
        get{
            if (_marcas == null)
            {
                _marcas = new MarcaRepository(_context);
            }
            return _marcas;
        }
    }



    public IMascota Mascotas
    {
        get{
            if (_mascotas == null)
            {
                _mascotas = new MascotaRepository(_context);
            }
            return _mascotas;
        }
    }



    public IMedicamento Medicamentos
    {
        get{
            if (_medicamentos == null)
            {
                _medicamentos = new MedicamentoRepository(_context);
            }
            return _medicamentos;
        }
    }



    public IMedicamentoCompra MedicamentoCompras
    {
        get{
            if (_medicamentoCompras == null)
            {
                _medicamentoCompras = new MedicamentoCompraRepository(_context);
            }
            return _medicamentoCompras;
        }
    }



    public IMedicamentoServicio MedicamentoServicios
    {
        get{
            if (_medicamentoServicios == null)
            {
                _medicamentoServicios = new MedicamentoServicioRepository(_context);
            }
            return _medicamentoServicios;
        }
    }



    public IMedicamentoVenta MedicamentoVentas
    {
        get{
            if (_medicamentoVentas == null)
            {
                _medicamentoVentas = new MedicamentoVentaRepository(_context);
            }
            return _medicamentoVentas;
        }
    }
    


    public IProveedor Proveedores
    {
        get{
            if (_proveedores == null)
            {
                _proveedores = new ProveedorRepository(_context);
            }
            return _proveedores;
        }
    }



    public IRaza Razas
    {
        get{
            if (_razas == null)
            {
                _razas = new RazaRepository(_context);
            }
            return _razas;
        }
    }


    
    public IRol Roles
    {
        get
        {
            if (_roles == null)
            {
                _roles = new RolRepository(_context);
            }
            return _roles;
        }
    }



    public ITipoServicio TipoServicios
    {
        get{
            if (_tipoServicios == null)
            {
                _tipoServicios = new TipoServicioRepository(_context);
            }
            return _tipoServicios;
        }
    }



    public IUsuario Usuarios
    {
        get
        {
            if (_usuario == null)
            {
                _usuario = new UsuarioRepository(_context);
            }
            return _usuario;
        }
    }



    public IVeterinario Veterinarios
    {
        get{
            if (_veterinarios == null)
            {
                _veterinarios = new VeterinarioRepository(_context);
            }
            return _veterinarios;
        }
    }



    public void Dispose()
    {
        _context.Dispose();
    }



    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
