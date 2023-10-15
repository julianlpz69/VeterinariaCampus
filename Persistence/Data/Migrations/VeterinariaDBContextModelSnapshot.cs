﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(VeterinariaDBContext))]
    partial class VeterinariaDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdClienteFK")
                        .HasColumnType("int");

                    b.Property<int>("IdMascotaFK")
                        .HasColumnType("int");

                    b.Property<int>("IdVeterinarioFK")
                        .HasColumnType("int");

                    b.Property<string>("MotivoCita")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFK");

                    b.HasIndex("IdMascotaFK");

                    b.HasIndex("IdVeterinarioFK");

                    b.ToTable("cita", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CedulaCliente")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("CorreoCliente")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NombreCliente")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("TelefonoCliente")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Especie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreEspecie")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("especie", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.FacturaCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCompra")
                        .HasColumnType("date");

                    b.Property<int>("IdProveedorFK")
                        .HasColumnType("int");

                    b.Property<double>("PrecioTotal")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdProveedorFK");

                    b.ToTable("factura_compra", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.FacturaServicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaServicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCitaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoServicioFK")
                        .HasColumnType("int");

                    b.Property<double>("PrecioTotal")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdCitaFk");

                    b.HasIndex("IdTipoServicioFK");

                    b.ToTable("factura_servicio", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.FacturaVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdClienteFK")
                        .HasColumnType("int");

                    b.Property<double>("PrecioTotal")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFK");

                    b.ToTable("factura_venta", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreMarca")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("marca", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<int>("IdClienteFK")
                        .HasColumnType("int");

                    b.Property<int>("IdRazaFK")
                        .HasColumnType("int");

                    b.Property<string>("NombreMascota")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFK");

                    b.HasIndex("IdRazaFK");

                    b.ToTable("mascota", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Medicamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdMarcaFK")
                        .HasColumnType("int");

                    b.Property<int>("IdProveedorFK")
                        .HasColumnType("int");

                    b.Property<string>("NombreMedicamento")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<double>("PrecioMedicamento")
                        .HasColumnType("double");

                    b.Property<int>("StockMedicamento")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMarcaFK");

                    b.HasIndex("IdProveedorFK");

                    b.ToTable("medicamento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.MedicamentoCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdFacturaCompraFK")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicamentoFK")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdFacturaCompraFK");

                    b.HasIndex("IdMedicamentoFK");

                    b.ToTable("medicamento_compra", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.MedicamentoServicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdFacturaServicioFK")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicamentoFK")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdFacturaServicioFK");

                    b.HasIndex("IdMedicamentoFK");

                    b.ToTable("medicamento_servicio", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.MedicamentoVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdFacturaVentaFK")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicamentoFK")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdFacturaVentaFK");

                    b.HasIndex("IdMedicamentoFK");

                    b.ToTable("MedicamentoVenta", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DireccionProveedor")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NombreProveedor")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TelefonoProveedor")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("proveedor", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Raza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdEspecieFK")
                        .HasColumnType("int");

                    b.Property<string>("NombreRaza")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdEspecieFK");

                    b.ToTable("raza", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdUsuarioFK")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuarioFK");

                    b.ToTable("refresh_token", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreRol")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("rolName");

                    b.HasKey("Id");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoServicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreServicio")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<double>("PrecioServicio")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("tipo_servicio", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaveUser")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("password");

                    b.Property<string>("EmailUser")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("email");

                    b.Property<string>("NombreUser")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.UsuarioRol", b =>
                {
                    b.Property<int>("IdUsuarioFK")
                        .HasColumnType("int");

                    b.Property<int>("IdRolFK")
                        .HasColumnType("int");

                    b.HasKey("IdUsuarioFK", "IdRolFK");

                    b.HasIndex("IdRolFK");

                    b.ToTable("userRol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Veterinario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CedulaVeterinario")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("CorreoVeterinario")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EspecialidadVeterinario")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("NombreVeterinario")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("TelefonoVeterinario")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("veterinario", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cita", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "Cliente")
                        .WithMany("Citas")
                        .HasForeignKey("IdClienteFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Mascota", "Mascota")
                        .WithMany("Citas")
                        .HasForeignKey("IdMascotaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Veterinario", "Veterinario")
                        .WithMany("Citas")
                        .HasForeignKey("IdVeterinarioFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Mascota");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("Domain.Entities.FacturaCompra", b =>
                {
                    b.HasOne("Domain.Entities.Proveedor", "Proveedor")
                        .WithMany("FacturaCompras")
                        .HasForeignKey("IdProveedorFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Domain.Entities.FacturaServicio", b =>
                {
                    b.HasOne("Domain.Entities.Cita", "Cita")
                        .WithMany("FacturasServicios")
                        .HasForeignKey("IdCitaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TipoServicio", "TipoServicio")
                        .WithMany("FacturaServicios")
                        .HasForeignKey("IdTipoServicioFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cita");

                    b.Navigation("TipoServicio");
                });

            modelBuilder.Entity("Domain.Entities.FacturaVenta", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "Cliente")
                        .WithMany("FacturasVentas")
                        .HasForeignKey("IdClienteFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Domain.Entities.Mascota", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "Cliente")
                        .WithMany("Mascotas")
                        .HasForeignKey("IdClienteFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Raza", "Raza")
                        .WithMany("Mascotas")
                        .HasForeignKey("IdRazaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Raza");
                });

            modelBuilder.Entity("Domain.Entities.Medicamento", b =>
                {
                    b.HasOne("Domain.Entities.Marca", "Marca")
                        .WithMany("Medicamentos")
                        .HasForeignKey("IdMarcaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Proveedor", "Proveedor")
                        .WithMany("Medicamentos")
                        .HasForeignKey("IdProveedorFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Domain.Entities.MedicamentoCompra", b =>
                {
                    b.HasOne("Domain.Entities.FacturaCompra", "FacturaCompra")
                        .WithMany("MedicamentosCompras")
                        .HasForeignKey("IdFacturaCompraFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Medicamento", "Medicamento")
                        .WithMany("MedicamentoCompras")
                        .HasForeignKey("IdMedicamentoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FacturaCompra");

                    b.Navigation("Medicamento");
                });

            modelBuilder.Entity("Domain.Entities.MedicamentoServicio", b =>
                {
                    b.HasOne("Domain.Entities.FacturaServicio", "FacturaServicio")
                        .WithMany("MedicamentoServicios")
                        .HasForeignKey("IdFacturaServicioFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Medicamento", "Medicamento")
                        .WithMany("MedicamentoServicios")
                        .HasForeignKey("IdMedicamentoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FacturaServicio");

                    b.Navigation("Medicamento");
                });

            modelBuilder.Entity("Domain.Entities.MedicamentoVenta", b =>
                {
                    b.HasOne("Domain.Entities.FacturaVenta", "FacturaVenta")
                        .WithMany("MedicamentoVentas")
                        .HasForeignKey("IdFacturaVentaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Medicamento", "Medicamento")
                        .WithMany("MedicamentoVentas")
                        .HasForeignKey("IdMedicamentoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FacturaVenta");

                    b.Navigation("Medicamento");
                });

            modelBuilder.Entity("Domain.Entities.Raza", b =>
                {
                    b.HasOne("Domain.Entities.Especie", "Especie")
                        .WithMany("Razas")
                        .HasForeignKey("IdEspecieFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especie");
                });

            modelBuilder.Entity("Domain.Entities.RefreshToken", b =>
                {
                    b.HasOne("Domain.Entities.Usuario", "Usuario")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("IdUsuarioFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.UsuarioRol", b =>
                {
                    b.HasOne("Domain.Entities.Rol", "Rol")
                        .WithMany("UsuariosRols")
                        .HasForeignKey("IdRolFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Usuario", "Usuario")
                        .WithMany("UsuarioRols")
                        .HasForeignKey("IdUsuarioFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.Cita", b =>
                {
                    b.Navigation("FacturasServicios");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Citas");

                    b.Navigation("FacturasVentas");

                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("Domain.Entities.Especie", b =>
                {
                    b.Navigation("Razas");
                });

            modelBuilder.Entity("Domain.Entities.FacturaCompra", b =>
                {
                    b.Navigation("MedicamentosCompras");
                });

            modelBuilder.Entity("Domain.Entities.FacturaServicio", b =>
                {
                    b.Navigation("MedicamentoServicios");
                });

            modelBuilder.Entity("Domain.Entities.FacturaVenta", b =>
                {
                    b.Navigation("MedicamentoVentas");
                });

            modelBuilder.Entity("Domain.Entities.Marca", b =>
                {
                    b.Navigation("Medicamentos");
                });

            modelBuilder.Entity("Domain.Entities.Mascota", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("Domain.Entities.Medicamento", b =>
                {
                    b.Navigation("MedicamentoCompras");

                    b.Navigation("MedicamentoServicios");

                    b.Navigation("MedicamentoVentas");
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.Navigation("FacturaCompras");

                    b.Navigation("Medicamentos");
                });

            modelBuilder.Entity("Domain.Entities.Raza", b =>
                {
                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Navigation("UsuariosRols");
                });

            modelBuilder.Entity("Domain.Entities.TipoServicio", b =>
                {
                    b.Navigation("FacturaServicios");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Navigation("RefreshTokens");

                    b.Navigation("UsuarioRols");
                });

            modelBuilder.Entity("Domain.Entities.Veterinario", b =>
                {
                    b.Navigation("Citas");
                });
#pragma warning restore 612, 618
        }
    }
}