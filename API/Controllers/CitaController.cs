using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    [Authorize]
    public class CitaController : BaseApiController
    {
        
        private IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public CitaController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this.unitofwork = unitOfWork;
            this.mapper = Mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<CitaDto>>> Get([FromQuery]Params CitaParams)
        {
        var Cita = await unitofwork.Citas.GetAllAsync(CitaParams.PageIndex,CitaParams.PageSize, CitaParams.Search,"FechaCita");
        var listaCitas= mapper.Map<List<CitaDto>>(Cita.registros);
        return new Pager<CitaDto>(listaCitas, Cita.totalRegistros,CitaParams.PageIndex,CitaParams.PageSize,CitaParams.Search);
        }

        [HttpGet("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CitaDto>> Get(int id)
        {
            var Cita = await unitofwork.Citas.GetByIdAsync(id);
            return mapper.Map<CitaDto>(Cita);
        }


          [HttpPost]
          [MapToApiVersion("1.1")]
          [ProducesResponseType(StatusCodes.Status201Created)]
          [ProducesResponseType(StatusCodes.Status400BadRequest)]
          public async Task<ActionResult<Cita>> Post([FromBody]CitaDto CitaDto)
          {
              var Cita = mapper.Map<Cita>(CitaDto);
              unitofwork.Citas.Add(Cita);
              await unitofwork.SaveAsync();

              if (Cita == null){
                  return BadRequest();
              }
              CitaDto.Id = Cita.Id;
              return CreatedAtAction(nameof(Post), new {id = CitaDto.Id}, CitaDto); 
           }



        [HttpPut("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<CitaDto>> Put(int id, [FromBody]CitaDto CitaDto){
            if(CitaDto == null)
                return NotFound();

            var Cita = this.mapper.Map<Cita>(CitaDto);
            unitofwork.Citas.Update(Cita);
            await unitofwork.SaveAsync();
            return CitaDto;
        }


        [HttpDelete("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete (int id){
            var Cita = await unitofwork.Citas.GetByIdAsync(id);
            if(Cita == null)
                return NotFound();
            
            unitofwork.Citas.Remove(Cita);
            await unitofwork.SaveAsync();
            return NoContent();    }
    }
}