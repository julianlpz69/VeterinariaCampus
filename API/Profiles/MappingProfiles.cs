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
            CreateMap<Mascota,MascotaDto>().ReverseMap();
            CreateMap<Cita,CitaDto>().ReverseMap();
            CreateMap<Veterinario,VeterinarioDto>().ReverseMap();
         }
    }
}