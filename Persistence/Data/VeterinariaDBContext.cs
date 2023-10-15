using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data
{
    public class VeterinariaDBContext : DbContext
    {
        public VeterinariaDBContext(DbContextOptions<VeterinariaDBContext> options) : base(options)
        {
    
        }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<FacturaCompra> FacturaCompras { get; set; }
        public DbSet<FacturaServicio> FacturaServicios { get; set; }
        public DbSet<FacturaVenta> FacturaVentas { get; set; }
        public DbSet<Marca> Marcas { get; set; }
         public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<MedicamentoCompra> MedicamentoCompras { get; set; }
        public DbSet<MedicamentoServicio> MedicamentoServicios { get; set; }
        public DbSet<MedicamentoVenta> MedicamentoVentas { get; set; }
        public DbSet<Proveedor> Proveedors { get; set; }
         public DbSet<Raza> Razas { get; set; }
         public DbSet<RefreshToken> RefreshTokens { get; set; }
         public DbSet<Rol> Rols { get; set; }
        public DbSet<TipoServicio> TipoServicios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioRol> UsuarioRols { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }


    
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
    
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    
          
        }
    }
}