using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCliente = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CorreoCliente = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoCliente = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CedulaCliente = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "especie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreEspecie = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_especie", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreMarca = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marca", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "proveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreProveedor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DireccionProveedor = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoProveedor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedor", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rolName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipo_servicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreServicio = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrecioServicio = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_servicio", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "veterinario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreVeterinario = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CorreoVeterinario = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoVeterinario = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CedulaVeterinario = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EspecialidadVeterinario = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veterinario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "factura_venta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PrecioTotal = table.Column<double>(type: "double", nullable: false),
                    FechaVenta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdClienteFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factura_venta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_factura_venta_cliente_IdClienteFK",
                        column: x => x.IdClienteFK,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "raza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreRaza = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEspecieFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_raza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_raza_especie_IdEspecieFK",
                        column: x => x.IdEspecieFK,
                        principalTable: "especie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "factura_compra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PrecioTotal = table.Column<double>(type: "double", nullable: false),
                    FechaCompra = table.Column<DateOnly>(type: "date", nullable: false),
                    IdProveedorFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factura_compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_factura_compra_proveedor_IdProveedorFK",
                        column: x => x.IdProveedorFK,
                        principalTable: "proveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreMedicamento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrecioMedicamento = table.Column<double>(type: "double", nullable: false),
                    StockMedicamento = table.Column<int>(type: "int", nullable: false),
                    IdProveedorFK = table.Column<int>(type: "int", nullable: false),
                    IdMarcaFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicamento_marca_IdMarcaFK",
                        column: x => x.IdMarcaFK,
                        principalTable: "marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicamento_proveedor_IdProveedorFK",
                        column: x => x.IdProveedorFK,
                        principalTable: "proveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "refresh_token",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuarioFK = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Expires = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refresh_token", x => x.Id);
                    table.ForeignKey(
                        name: "FK_refresh_token_user_IdUsuarioFK",
                        column: x => x.IdUsuarioFK,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "userRol",
                columns: table => new
                {
                    IdUsuarioFK = table.Column<int>(type: "int", nullable: false),
                    IdRolFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRol", x => new { x.IdUsuarioFK, x.IdRolFK });
                    table.ForeignKey(
                        name: "FK_userRol_rol_IdRolFK",
                        column: x => x.IdRolFK,
                        principalTable: "rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userRol_user_IdUsuarioFK",
                        column: x => x.IdUsuarioFK,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "mascota",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreMascota = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    IdRazaFK = table.Column<int>(type: "int", nullable: false),
                    IdClienteFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mascota", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mascota_cliente_IdClienteFK",
                        column: x => x.IdClienteFK,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_mascota_raza_IdRazaFK",
                        column: x => x.IdRazaFK,
                        principalTable: "raza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicamento_compra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<double>(type: "double", nullable: false),
                    IdFacturaCompraFK = table.Column<int>(type: "int", nullable: false),
                    IdMedicamentoFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicamento_compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicamento_compra_factura_compra_IdFacturaCompraFK",
                        column: x => x.IdFacturaCompraFK,
                        principalTable: "factura_compra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicamento_compra_medicamento_IdMedicamentoFK",
                        column: x => x.IdMedicamentoFK,
                        principalTable: "medicamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MedicamentoVenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<double>(type: "double", nullable: false),
                    IdFacturaVentaFK = table.Column<int>(type: "int", nullable: false),
                    IdMedicamentoFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentoVenta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicamentoVenta_factura_venta_IdFacturaVentaFK",
                        column: x => x.IdFacturaVentaFK,
                        principalTable: "factura_venta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicamentoVenta_medicamento_IdMedicamentoFK",
                        column: x => x.IdMedicamentoFK,
                        principalTable: "medicamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cita",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MotivoCita = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCita = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdVeterinarioFK = table.Column<int>(type: "int", nullable: false),
                    IdClienteFK = table.Column<int>(type: "int", nullable: false),
                    IdMascotaFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cita_cliente_IdClienteFK",
                        column: x => x.IdClienteFK,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cita_mascota_IdMascotaFK",
                        column: x => x.IdMascotaFK,
                        principalTable: "mascota",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cita_veterinario_IdVeterinarioFK",
                        column: x => x.IdVeterinarioFK,
                        principalTable: "veterinario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "factura_servicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PrecioTotal = table.Column<double>(type: "double", nullable: false),
                    FechaServicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdTipoServicioFK = table.Column<int>(type: "int", nullable: false),
                    IdCitaFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factura_servicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_factura_servicio_cita_IdCitaFk",
                        column: x => x.IdCitaFk,
                        principalTable: "cita",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_factura_servicio_tipo_servicio_IdTipoServicioFK",
                        column: x => x.IdTipoServicioFK,
                        principalTable: "tipo_servicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicamento_servicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<double>(type: "double", nullable: false),
                    IdFacturaServicioFK = table.Column<int>(type: "int", nullable: false),
                    IdMedicamentoFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicamento_servicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicamento_servicio_factura_servicio_IdFacturaServicioFK",
                        column: x => x.IdFacturaServicioFK,
                        principalTable: "factura_servicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicamento_servicio_medicamento_IdMedicamentoFK",
                        column: x => x.IdMedicamentoFK,
                        principalTable: "medicamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "cliente",
                columns: new[] { "Id", "CedulaCliente", "CorreoCliente", "NombreCliente", "TelefonoCliente" },
                values: new object[,]
                {
                    { 1, "123456789", "juan.perez@example.com", "Juan Pérez", "123-456-7890" },
                    { 2, "234567890", "maria.rodriguez@example.com", "María Rodríguez", "234-567-8901" },
                    { 3, "345678901", "carlos.gomez@example.com", "Carlos Gómez", "345-678-9012" },
                    { 4, "456789012", "laura.martinez@example.com", "Laura Martínez", "456-789-0123" },
                    { 5, "567890123", "andres.lopez@example.com", "Andrés López", "567-890-1234" },
                    { 6, "678901234", "ana.ramirez@example.com", "Ana Ramírez", "678-901-2345" },
                    { 7, "789012345", "javier.herrera@example.com", "Javier Herrera", "789-012-3456" },
                    { 8, "890123456", "isabel.castro@example.com", "Isabel Castro", "890-123-4567" },
                    { 9, "901234567", "sergio.vargas@example.com", "Sergio Vargas", "901-234-5678" },
                    { 10, "012345678", "natalia.lopez@example.com", "Natalia López", "012-345-6789" }
                });

            migrationBuilder.InsertData(
                table: "especie",
                columns: new[] { "Id", "NombreEspecie" },
                values: new object[,]
                {
                    { 1, "Canino" },
                    { 2, "Felino" },
                    { 3, "Ave" },
                    { 4, "Roedores" },
                    { 5, "Exotico" }
                });

            migrationBuilder.InsertData(
                table: "marca",
                columns: new[] { "Id", "NombreMarca" },
                values: new object[,]
                {
                    { 1, "Serave" },
                    { 2, "Pficer" },
                    { 3, "DrogasMax" },
                    { 4, "Salud Total" },
                    { 5, "Genfar" }
                });

            migrationBuilder.InsertData(
                table: "proveedor",
                columns: new[] { "Id", "DireccionProveedor", "NombreProveedor", "TelefonoProveedor" },
                values: new object[,]
                {
                    { 1, "Carrera 10 #25-30, Bogotá", "Droguería La Economía", "123-456-7890" },
                    { 2, "Calle 15 #45-12, Medellín", "Droguería San Martín", "234-567-8901" },
                    { 3, "Avenida 5 #8-40, Cali", "Farmacia El Rosario", "345-678-9012" },
                    { 4, "Carrera 20 #33-55, Barranquilla", "Droguería La Salud", "456-789-0123" },
                    { 5, "Calle 30 #17-22, Cartagena", "Farmacia Los Alamos", "567-890-1234" },
                    { 6, "Carrera 8 #12-30, Bucaramanga", "Droguería El Carmen", "678-901-2345" },
                    { 7, "Avenida 15 #40-18, Cúcuta", "Farmacia La Esperanza", "789-012-3456" },
                    { 8, "Calle 25 #10-50, Pereira", "Droguería San José", "890-123-4567" },
                    { 9, "Carrera 12 #22-15, Santa Marta", "Farmacia Santa Marta", "901-234-5678" },
                    { 10, "Avenida 3 #5-10, Manizales", "Droguería El Parque", "012-345-6789" }
                });

            migrationBuilder.InsertData(
                table: "rol",
                columns: new[] { "Id", "rolName" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Empleado" }
                });

            migrationBuilder.InsertData(
                table: "tipo_servicio",
                columns: new[] { "Id", "NombreServicio", "PrecioServicio" },
                values: new object[,]
                {
                    { 1, "Operacion", 0.0 },
                    { 2, "Bañado", 0.0 },
                    { 3, "Vacunacion", 0.0 },
                    { 4, "Desparasitación", 0.0 },
                    { 5, "Examen General", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "veterinario",
                columns: new[] { "Id", "CedulaVeterinario", "CorreoVeterinario", "EspecialidadVeterinario", "NombreVeterinario", "TelefonoVeterinario" },
                values: new object[,]
                {
                    { 1, "123456789", "dr.smith@example.com", "Cirujano vascular", "Dr. Smith", "123-456-7890" },
                    { 2, "234567890", "dr.johnson@example.com", "Dermatología", "Dr. Johnson", "234-567-8901" },
                    { 3, "345678901", "dr.brown@example.com", "Oftalmología", "Dr. Brown", "345-678-9012" },
                    { 4, "456789012", "dr.davis@example.com", "Cardiología", "Dr. Davis", "456-789-0123" },
                    { 5, "567890123", "dr.miller@example.com", "Cirujano vascular", "Dr. Miller", "567-890-1234" },
                    { 6, "678901234", "dr.wilson@example.com", "Endocrinología", "Dr. Wilson", "678-901-2345" },
                    { 7, "789012345", "dr.moore@example.com", "Gastroenterología", "Dr. Moore", "789-012-3456" },
                    { 8, "890123456", "dr.anderson@example.com", "Nefrología", "Dr. Anderson", "890-123-4567" },
                    { 9, "901234567", "dr.clark@example.com", "Cirujano vascular", "Dr. Clark", "901-234-5678" },
                    { 10, "012345678", "dr.turner@example.com", "Inmunología", "Dr. Turner", "012-345-6789" }
                });

            migrationBuilder.InsertData(
                table: "factura_compra",
                columns: new[] { "Id", "FechaCompra", "IdProveedorFK", "PrecioTotal" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 10, 29), 1, 200000.0 },
                    { 2, new DateOnly(2023, 10, 28), 2, 250000.0 },
                    { 3, new DateOnly(2023, 10, 27), 1, 180000.0 },
                    { 4, new DateOnly(2023, 10, 26), 3, 300000.0 },
                    { 5, new DateOnly(2023, 10, 25), 2, 220000.0 },
                    { 6, new DateOnly(2023, 10, 24), 3, 260000.0 },
                    { 7, new DateOnly(2023, 10, 23), 1, 190000.0 },
                    { 8, new DateOnly(2023, 10, 22), 5, 270000.0 },
                    { 9, new DateOnly(2023, 10, 21), 3, 230000.0 },
                    { 10, new DateOnly(2023, 10, 20), 4, 210000.0 }
                });

            migrationBuilder.InsertData(
                table: "factura_venta",
                columns: new[] { "Id", "FechaVenta", "IdClienteFK", "PrecioTotal" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 20000.0 },
                    { 2, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 18000.0 },
                    { 3, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 22000.0 },
                    { 4, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 25000.0 },
                    { 5, new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 21000.0 },
                    { 6, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 24000.0 },
                    { 7, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 19000.0 },
                    { 8, new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 23000.0 },
                    { 9, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 26000.0 },
                    { 10, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 27000.0 },
                    { 11, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 20000.0 },
                    { 12, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 18000.0 },
                    { 13, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 22000.0 },
                    { 14, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 25000.0 },
                    { 15, new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 21000.0 },
                    { 16, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 24000.0 },
                    { 17, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 19000.0 },
                    { 18, new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 23000.0 },
                    { 19, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 26000.0 },
                    { 20, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 27000.0 }
                });

            migrationBuilder.InsertData(
                table: "medicamento",
                columns: new[] { "Id", "IdMarcaFK", "IdProveedorFK", "NombreMedicamento", "PrecioMedicamento", "StockMedicamento" },
                values: new object[,]
                {
                    { 1, 1, 1, "Paracetamol", 10050.0, 100 },
                    { 2, 1, 2, "Ibuprofeno", 12.75, 80 },
                    { 3, 2, 3, "Amoxicilina", 15020.0, 90 },
                    { 4, 2, 4, "Omeprazol", 80090.0, 70 },
                    { 5, 3, 5, "Loratadina", 60075.0, 60 },
                    { 6, 3, 6, "Dexametasona", 18040.0, 50 },
                    { 7, 4, 7, "Ciprofloxacino", 14060.0, 40 },
                    { 8, 4, 8, "Aspirina", 50025.0, 30 },
                    { 9, 5, 9, "Ranitidina", 90080.0, 20 },
                    { 10, 5, 10, "Clotrimazol", 7030.0, 10 }
                });

            migrationBuilder.InsertData(
                table: "raza",
                columns: new[] { "Id", "IdEspecieFK", "NombreRaza" },
                values: new object[,]
                {
                    { 1, 1, "Labrador Retriever" },
                    { 2, 2, "Persa" },
                    { 3, 3, "Periquito Australiano" },
                    { 4, 4, "Cobaya" },
                    { 5, 5, "Gecko Leopardo" },
                    { 6, 1, "Golden Retriver" },
                    { 7, 2, "Siamés" },
                    { 8, 3, "Canario" },
                    { 9, 4, "Hámster" },
                    { 10, 5, "Rana Dardo Venenoso" }
                });

            migrationBuilder.InsertData(
                table: "MedicamentoVenta",
                columns: new[] { "Id", "Cantidad", "IdFacturaVentaFK", "IdMedicamentoFK", "Precio" },
                values: new object[,]
                {
                    { 1, 6, 1, 1, 30000.0 },
                    { 2, 4, 1, 2, 28000.0 },
                    { 3, 8, 2, 3, 32000.0 },
                    { 4, 5, 2, 4, 31000.0 },
                    { 5, 7, 3, 5, 29000.0 },
                    { 6, 3, 3, 6, 27000.0 },
                    { 7, 9, 4, 7, 26000.0 },
                    { 8, 2, 4, 8, 24000.0 },
                    { 9, 5, 5, 9, 22000.0 },
                    { 10, 6, 5, 10, 20000.0 },
                    { 11, 8, 6, 1, 18000.0 },
                    { 12, 3, 6, 2, 160000.0 },
                    { 13, 7, 7, 3, 14000.0 },
                    { 14, 4, 7, 4, 12000.0 },
                    { 15, 2, 8, 5, 10000.0 },
                    { 16, 5, 8, 6, 80000.0 },
                    { 17, 6, 9, 7, 60000.0 },
                    { 18, 3, 9, 8, 40000.0 },
                    { 19, 9, 10, 9, 20000.0 },
                    { 20, 7, 10, 10, 10000.0 }
                });

            migrationBuilder.InsertData(
                table: "mascota",
                columns: new[] { "Id", "FechaNacimiento", "IdClienteFK", "IdRazaFK", "NombreMascota" },
                values: new object[,]
                {
                    { 1, new DateOnly(2018, 5, 10), 1, 6, "Luna" },
                    { 2, new DateOnly(2019, 2, 15), 2, 2, "Max" },
                    { 3, new DateOnly(2017, 8, 20), 3, 3, "Bella" },
                    { 4, new DateOnly(2016, 11, 5), 4, 1, "Rocky" },
                    { 5, new DateOnly(2018, 7, 30), 5, 2, "Daisy" },
                    { 6, new DateOnly(2019, 1, 12), 6, 3, "Charlie" },
                    { 7, new DateOnly(2017, 3, 25), 7, 6, "Lucky" },
                    { 8, new DateOnly(2016, 6, 18), 8, 7, "Milo" },
                    { 9, new DateOnly(2015, 10, 8), 9, 4, "Sophie" },
                    { 10, new DateOnly(2018, 4, 3), 10, 5, "Teddy" }
                });

            migrationBuilder.InsertData(
                table: "medicamento_compra",
                columns: new[] { "Id", "Cantidad", "IdFacturaCompraFK", "IdMedicamentoFK", "Precio" },
                values: new object[,]
                {
                    { 1, 5, 1, 1, 20000.0 },
                    { 2, 3, 2, 2, 15000.0 },
                    { 3, 7, 3, 1, 22000.0 },
                    { 4, 2, 4, 3, 18000.0 },
                    { 5, 4, 5, 2, 19000.0 },
                    { 6, 6, 6, 1, 21000.0 },
                    { 7, 8, 7, 3, 23000.0 },
                    { 8, 1, 8, 2, 17000.0 },
                    { 9, 9, 9, 1, 24000.0 },
                    { 10, 3, 10, 3, 16000.0 },
                    { 11, 5, 1, 3, 20000.0 },
                    { 12, 3, 2, 1, 15000.0 },
                    { 13, 7, 3, 2, 22000.0 },
                    { 14, 2, 4, 2, 18000.0 },
                    { 15, 4, 5, 1, 19000.0 },
                    { 16, 6, 6, 3, 21000.0 },
                    { 17, 8, 7, 2, 23000.0 },
                    { 18, 1, 8, 1, 17000.0 },
                    { 19, 9, 9, 3, 24000.0 },
                    { 120, 3, 10, 1, 16000.0 }
                });

            migrationBuilder.InsertData(
                table: "cita",
                columns: new[] { "Id", "FechaCita", "IdClienteFK", "IdMascotaFK", "IdVeterinarioFK", "MotivoCita" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 20, 15, 12, 45, 0, DateTimeKind.Unspecified), 1, 1, 1, "Consulta de rutina" },
                    { 2, new DateTime(2023, 3, 21, 15, 13, 39, 0, DateTimeKind.Unspecified), 2, 2, 2, "Vacunación" },
                    { 3, new DateTime(2023, 10, 22, 10, 28, 33, 0, DateTimeKind.Unspecified), 3, 3, 3, "Control de peso" },
                    { 4, new DateTime(2023, 10, 23, 14, 55, 52, 0, DateTimeKind.Unspecified), 4, 4, 4, "Dolor abdominal" },
                    { 5, new DateTime(2023, 2, 24, 15, 25, 28, 0, DateTimeKind.Unspecified), 5, 5, 5, "Vacunación" },
                    { 6, new DateTime(2023, 10, 25, 17, 33, 11, 0, DateTimeKind.Unspecified), 6, 6, 6, "Control de diabetes" },
                    { 7, new DateTime(2023, 1, 26, 8, 49, 53, 0, DateTimeKind.Unspecified), 7, 7, 7, "Vacunación" },
                    { 8, new DateTime(2023, 10, 27, 15, 7, 49, 0, DateTimeKind.Unspecified), 8, 8, 8, "Extracción dental" },
                    { 9, new DateTime(2023, 10, 28, 13, 38, 51, 0, DateTimeKind.Unspecified), 9, 9, 9, "Cirugía de esterilización" },
                    { 10, new DateTime(2023, 10, 29, 11, 34, 10, 0, DateTimeKind.Unspecified), 10, 10, 10, "Consulta de rutina" }
                });

            migrationBuilder.InsertData(
                table: "factura_servicio",
                columns: new[] { "Id", "FechaServicio", "IdCitaFk", "IdTipoServicioFK", "PrecioTotal" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 200000.0 },
                    { 2, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 180000.0 },
                    { 3, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 220000.0 },
                    { 4, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, 250000.0 },
                    { 5, new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, 210000.0 },
                    { 6, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4, 240000.0 },
                    { 7, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3, 190000.0 },
                    { 8, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4, 230000.0 },
                    { 9, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, 260000.0 },
                    { 10, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 3, 270000.0 }
                });

            migrationBuilder.InsertData(
                table: "medicamento_servicio",
                columns: new[] { "Id", "Cantidad", "IdFacturaServicioFK", "IdMedicamentoFK", "Precio" },
                values: new object[,]
                {
                    { 1, 4, 1, 1, 20000.0 },
                    { 2, 3, 2, 2, 18000.0 },
                    { 3, 5, 3, 1, 22000.0 },
                    { 4, 2, 4, 3, 21000.0 },
                    { 5, 6, 5, 2, 24000.0 },
                    { 6, 3, 6, 1, 19000.0 },
                    { 7, 5, 7, 3, 21000.0 },
                    { 8, 4, 8, 2, 22000.0 },
                    { 9, 3, 9, 1, 19000.0 },
                    { 10, 6, 10, 3, 23000.0 },
                    { 11, 4, 1, 3, 20000.0 },
                    { 12, 3, 2, 1, 18000.0 },
                    { 13, 5, 3, 3, 22000.0 },
                    { 14, 2, 4, 2, 21000.0 },
                    { 15, 6, 5, 1, 24000.0 },
                    { 16, 3, 6, 3, 19000.0 },
                    { 17, 5, 7, 1, 21000.0 },
                    { 18, 4, 8, 1, 22000.0 },
                    { 19, 3, 9, 3, 19000.0 },
                    { 20, 6, 10, 2, 23000.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cita_IdClienteFK",
                table: "cita",
                column: "IdClienteFK");

            migrationBuilder.CreateIndex(
                name: "IX_cita_IdMascotaFK",
                table: "cita",
                column: "IdMascotaFK");

            migrationBuilder.CreateIndex(
                name: "IX_cita_IdVeterinarioFK",
                table: "cita",
                column: "IdVeterinarioFK");

            migrationBuilder.CreateIndex(
                name: "IX_factura_compra_IdProveedorFK",
                table: "factura_compra",
                column: "IdProveedorFK");

            migrationBuilder.CreateIndex(
                name: "IX_factura_servicio_IdCitaFk",
                table: "factura_servicio",
                column: "IdCitaFk");

            migrationBuilder.CreateIndex(
                name: "IX_factura_servicio_IdTipoServicioFK",
                table: "factura_servicio",
                column: "IdTipoServicioFK");

            migrationBuilder.CreateIndex(
                name: "IX_factura_venta_IdClienteFK",
                table: "factura_venta",
                column: "IdClienteFK");

            migrationBuilder.CreateIndex(
                name: "IX_mascota_IdClienteFK",
                table: "mascota",
                column: "IdClienteFK");

            migrationBuilder.CreateIndex(
                name: "IX_mascota_IdRazaFK",
                table: "mascota",
                column: "IdRazaFK");

            migrationBuilder.CreateIndex(
                name: "IX_medicamento_IdMarcaFK",
                table: "medicamento",
                column: "IdMarcaFK");

            migrationBuilder.CreateIndex(
                name: "IX_medicamento_IdProveedorFK",
                table: "medicamento",
                column: "IdProveedorFK");

            migrationBuilder.CreateIndex(
                name: "IX_medicamento_compra_IdFacturaCompraFK",
                table: "medicamento_compra",
                column: "IdFacturaCompraFK");

            migrationBuilder.CreateIndex(
                name: "IX_medicamento_compra_IdMedicamentoFK",
                table: "medicamento_compra",
                column: "IdMedicamentoFK");

            migrationBuilder.CreateIndex(
                name: "IX_medicamento_servicio_IdFacturaServicioFK",
                table: "medicamento_servicio",
                column: "IdFacturaServicioFK");

            migrationBuilder.CreateIndex(
                name: "IX_medicamento_servicio_IdMedicamentoFK",
                table: "medicamento_servicio",
                column: "IdMedicamentoFK");

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentoVenta_IdFacturaVentaFK",
                table: "MedicamentoVenta",
                column: "IdFacturaVentaFK");

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentoVenta_IdMedicamentoFK",
                table: "MedicamentoVenta",
                column: "IdMedicamentoFK");

            migrationBuilder.CreateIndex(
                name: "IX_raza_IdEspecieFK",
                table: "raza",
                column: "IdEspecieFK");

            migrationBuilder.CreateIndex(
                name: "IX_refresh_token_IdUsuarioFK",
                table: "refresh_token",
                column: "IdUsuarioFK");

            migrationBuilder.CreateIndex(
                name: "IX_userRol_IdRolFK",
                table: "userRol",
                column: "IdRolFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "medicamento_compra");

            migrationBuilder.DropTable(
                name: "medicamento_servicio");

            migrationBuilder.DropTable(
                name: "MedicamentoVenta");

            migrationBuilder.DropTable(
                name: "refresh_token");

            migrationBuilder.DropTable(
                name: "userRol");

            migrationBuilder.DropTable(
                name: "factura_compra");

            migrationBuilder.DropTable(
                name: "factura_servicio");

            migrationBuilder.DropTable(
                name: "factura_venta");

            migrationBuilder.DropTable(
                name: "medicamento");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "cita");

            migrationBuilder.DropTable(
                name: "tipo_servicio");

            migrationBuilder.DropTable(
                name: "marca");

            migrationBuilder.DropTable(
                name: "proveedor");

            migrationBuilder.DropTable(
                name: "mascota");

            migrationBuilder.DropTable(
                name: "veterinario");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "raza");

            migrationBuilder.DropTable(
                name: "especie");
        }
    }
}
