using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles
{
    public class MappingProfiles : Profile
    {
         public MappingProfiles()
         {
            CreateMap<Cliente,ClienteDto>().ReverseMap();
             CreateMap<Cliente,ClientePetDto>().ReverseMap();
             CreateMap<Cliente,ClienteonlyDto>().ReverseMap();
            
            CreateMap<Cita,CitaDto>().ReverseMap();
            CreateMap<Cita,CitaVacunaDto>().ReverseMap();
            CreateMap<Cita,CitaVeterinarioDto>().ReverseMap();

            CreateMap<Veterinario,VeterinarioDto>().ReverseMap();
            CreateMap<Veterinario,VeterinarioCitaDto>().ReverseMap();

            CreateMap<Medicamento,MedicamentoDto>().ReverseMap();
            CreateMap<Medicamento,MedicamentoSoloDto>().ReverseMap();
            CreateMap<Medicamento,MedicamentoMovDto>().ReverseMap();

            CreateMap<MedicamentoCompra,MediCompraDto>().ReverseMap();
             
            
            CreateMap<MedicamentoVenta,MediCompraDto>().ReverseMap();

            CreateMap<MedicamentoServicio,MediCompraDto>().ReverseMap();
            CreateMap<MedicamentoVenta,MediVentaDto>().ReverseMap();
            
            CreateMap<MedicamentoServicio,MediServicioDto>().ReverseMap();
            

            CreateMap<Marca,MarcaDto>().ReverseMap();

            CreateMap<Mascota,MascotaDto>().ReverseMap();
            CreateMap<Mascota,MascotaVacunaDto>().ReverseMap();
            CreateMap<Mascota,MascotaVeterinarioDto>().ReverseMap();
            CreateMap<Mascota,MascotaRazaDto>().ReverseMap();
            
             

            CreateMap<Mascota,MascotaPetDto>().ReverseMap();
            CreateMap<Mascota,MascotaEspecieDto>()
            .ForMember(d => d.Especie, l => l.MapFrom(src => src.Raza.Especie.NombreEspecie));

            CreateMap<Raza,RazaDto>().ReverseMap();
            CreateMap<Raza,RazaMascotaDto>().ReverseMap();

            CreateMap<Especie,EspecieDto>().ReverseMap();
            CreateMap<Especie,EspecieRazaDto>().ReverseMap();

            CreateMap<Proveedor,ProveedorDto>().ReverseMap();
            CreateMap<Proveedor,ProveedorMedicamentosDto>().ReverseMap();

            CreateMap<FacturaCompra,FacturaCompraDto>().ReverseMap();
            CreateMap<FacturaVenta,FacturaVentaDto>().ReverseMap();
            CreateMap<FacturaServicio,FacturaServicioDto>().ReverseMap();
         }
    }
}