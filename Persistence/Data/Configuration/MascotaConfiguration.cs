using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class MascotaConfiguration : IEntityTypeConfiguration<Mascota>
    {
        public void Configure(EntityTypeBuilder<Mascota> builder){
    
            builder.ToTable("mascota");

            builder.HasOne(p => p.Cliente)
                .WithMany(p => p.Mascotas)
                .HasForeignKey(p => p.IdClienteFK);
    

            builder.HasOne(p => p.Raza)
                .WithMany(p => p.Mascotas)
                .HasForeignKey(p => p.IdRazaFK);


            builder.HasData(
                    new Mascota { Id = 1, NombreMascota = "Luna", FechaNacimiento = new DateOnly(2018, 5, 10), IdRazaFK = 6, IdClienteFK = 1 },
                    new Mascota { Id = 2, NombreMascota = "Max", FechaNacimiento = new DateOnly(2019, 2, 15), IdRazaFK = 2, IdClienteFK = 2 },
                    new Mascota { Id = 3, NombreMascota = "Bella", FechaNacimiento = new DateOnly(2017, 8, 20), IdRazaFK = 3, IdClienteFK = 3 },
                    new Mascota { Id = 4, NombreMascota = "Rocky", FechaNacimiento = new DateOnly(2016, 11, 5), IdRazaFK = 1, IdClienteFK = 4 },
                    new Mascota { Id = 5, NombreMascota = "Daisy", FechaNacimiento = new DateOnly(2018, 7, 30), IdRazaFK = 2, IdClienteFK = 5 },
                    new Mascota { Id = 6, NombreMascota = "Charlie", FechaNacimiento = new DateOnly(2019, 1, 12), IdRazaFK = 3, IdClienteFK = 6 },
                    new Mascota { Id = 7, NombreMascota = "Lucky", FechaNacimiento = new DateOnly(2017, 3, 25), IdRazaFK = 6, IdClienteFK = 7 },
                    new Mascota { Id = 8, NombreMascota = "Milo", FechaNacimiento = new DateOnly(2016, 6, 18), IdRazaFK = 7, IdClienteFK = 8 },
                    new Mascota { Id = 9, NombreMascota = "Sophie", FechaNacimiento = new DateOnly(2015, 10, 8), IdRazaFK = 4, IdClienteFK = 9 },
                    new Mascota { Id = 10, NombreMascota = "Teddy", FechaNacimiento = new DateOnly(2018, 4, 3), IdRazaFK = 5, IdClienteFK = 10 }
            );
    
        }
    }
}