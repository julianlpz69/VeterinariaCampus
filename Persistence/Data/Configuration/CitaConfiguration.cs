using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    
    public class CitaConfiguration : IEntityTypeConfiguration<Cita>
    {
        public void Configure(EntityTypeBuilder<Cita> builder){
    
            builder.ToTable("cita");
    
            builder.Property(e => e.MotivoCita)
                .HasMaxLength(255);

            
            builder.HasOne(p => p.Cliente)
                .WithMany(p => p.Citas)
                .HasForeignKey(p => p.IdClienteFK);

            builder.HasOne(p => p.Mascota)
                .WithMany(p => p.Citas)
                .HasForeignKey(p => p.IdMascotaFK);

            builder.HasOne(p => p.Veterinario)
                .WithMany(p => p.Citas)
                .HasForeignKey(p => p.IdVeterinarioFK);

            Random random = new Random();
            builder.HasData(
                   new Cita 
    { 
        Id = 1, 
        MotivoCita = "Consulta de rutina", 
        FechaCita = new DateTime(2023, 10, 20, random.Next(8, 18), random.Next(0, 59), random.Next(0, 59)),
        IdVeterinarioFK = 1,
        IdClienteFK = 1,
        IdMascotaFK = 1
    }, 
    new Cita 
    { 
        Id = 2, 
        MotivoCita = "Vacunación", 
        FechaCita = new DateTime(2023, 3, 21, random.Next(8, 18), random.Next(0, 59), random.Next(0, 59)),
        IdVeterinarioFK = 2,
        IdClienteFK = 2,
        IdMascotaFK = 2
    },
    new Cita 
    { 
        Id = 3, 
        MotivoCita = "Control de peso", 
        FechaCita = new DateTime(2023, 10, 22, random.Next(8, 18), random.Next(0, 59), random.Next(0, 59)),
        IdVeterinarioFK = 3,
        IdClienteFK = 3,
        IdMascotaFK = 3
    },
    new Cita 
    { 
        Id = 4, 
        MotivoCita = "Dolor abdominal", 
        FechaCita = new DateTime(2023, 10, 23, random.Next(8, 18), random.Next(0, 59), random.Next(0, 59)),
        IdVeterinarioFK = 4,
        IdClienteFK = 4,
        IdMascotaFK = 4
    },
    new Cita 
    { 
        Id = 5, 
        MotivoCita = "Vacunación", 
        FechaCita = new DateTime(2023, 2, 24, random.Next(8, 18), random.Next(0, 59), random.Next(0, 59)),
        IdVeterinarioFK = 5,
        IdClienteFK = 5,
        IdMascotaFK = 5
    },
    new Cita 
    { 
        Id = 6, 
        MotivoCita = "Control de diabetes", 
        FechaCita = new DateTime(2023, 10, 25, random.Next(8, 18), random.Next(0, 59), random.Next(0, 59)),
        IdVeterinarioFK = 6,
        IdClienteFK = 6,
        IdMascotaFK = 6
    },
    new Cita 
    { 
        Id = 7, 
        MotivoCita = "Vacunación", 
        FechaCita = new DateTime(2023, 1, 26, random.Next(8, 18), random.Next(0, 59), random.Next(0, 59)),
        IdVeterinarioFK = 7,
        IdClienteFK = 7,
        IdMascotaFK = 7
    },
    new Cita 
    { 
        Id = 8, 
        MotivoCita = "Extracción dental", 
        FechaCita = new DateTime(2023, 10, 27, random.Next(8, 18), random.Next(0, 59), random.Next(0, 59)),
        IdVeterinarioFK = 8,
        IdClienteFK = 8,
        IdMascotaFK = 8
    },
    new Cita 
    { 
        Id = 9, 
        MotivoCita = "Cirugía de esterilización", 
        FechaCita = new DateTime(2023, 10, 28, random.Next(8, 18), random.Next(0, 59), random.Next(0, 59)),
        IdVeterinarioFK = 9,
        IdClienteFK = 9,
        IdMascotaFK = 9
    },
    new Cita 
    { 
        Id = 10, 
        MotivoCita = "Consulta de rutina", 
        FechaCita = new DateTime(2023, 10, 29, random.Next(8, 18), random.Next(0, 59), random.Next(0, 59)),
        IdVeterinarioFK = 10,
        IdClienteFK = 10,
        IdMascotaFK = 10
    }
            );

    
        }
    }
}