using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class MascotaController : BaseApiController
    {
        private IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public MascotaController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this.unitofwork = unitOfWork;
            this.mapper = Mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<MascotaDto>>> Get([FromQuery]Params MascotaParams)
        {
        var Mascota = await unitofwork.Mascotas.GetAllAsync(MascotaParams.PageIndex,MascotaParams.PageSize, MascotaParams.Search,"NombreMascota");
        var listaMascotas= mapper.Map<List<MascotaDto>>(Mascota.registros);
        return new Pager<MascotaDto>(listaMascotas, Mascota.totalRegistros,MascotaParams.PageIndex,MascotaParams.PageSize,MascotaParams.Search);
        }


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MascotaDto>> Get(int id)
        {
            var Mascota = await unitofwork.Mascotas.GetByIdAsync(id);
            return mapper.Map<MascotaDto>(Mascota);
        }


          [HttpPost]
          [ProducesResponseType(StatusCodes.Status201Created)]
          [ProducesResponseType(StatusCodes.Status400BadRequest)]
          public async Task<ActionResult<Mascota>> Post([FromBody]MascotaDto MascotaDto)
          {
              var Mascota = mapper.Map<Mascota>(MascotaDto);
              unitofwork.Mascotas.Add(Mascota);
              await unitofwork.SaveAsync();

              if (Mascota == null){
                  return BadRequest();
              }
              MascotaDto.Id = Mascota.Id;
              return CreatedAtAction(nameof(Post), new {id = MascotaDto.Id}, MascotaDto); 
           }



        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<MascotaDto>> Put(int id, [FromBody]MascotaDto MascotaDto){
            if(MascotaDto == null)
                return NotFound();

            var Mascota = this.mapper.Map<Mascota>(MascotaDto);
            unitofwork.Mascotas.Update(Mascota);
            await unitofwork.SaveAsync();
            return MascotaDto;
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete (int id){
            var Mascota = await unitofwork.Mascotas.GetByIdAsync(id);
            if(Mascota == null)
                return NotFound();
            
            unitofwork.Mascotas.Remove(Mascota);
            await unitofwork.SaveAsync();
            return NoContent();    }
    }
}