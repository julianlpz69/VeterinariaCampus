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
    public class FacturaServicioController : BaseApiController
    {
        private IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public FacturaServicioController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this.unitofwork = unitOfWork;
            this.mapper = Mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<FacturaServicioDto>>> Get([FromQuery]Params FacturaServicioParams)
        {
        var FacturaServicio = await unitofwork.FacturaServicios.GetAllAsync(FacturaServicioParams.PageIndex,FacturaServicioParams.PageSize, FacturaServicioParams.Search,"FechaFacturaServicio");
        var listaFacturaServicios= mapper.Map<List<FacturaServicioDto>>(FacturaServicio.registros);
        return new Pager<FacturaServicioDto>(listaFacturaServicios, FacturaServicio.totalRegistros,FacturaServicioParams.PageIndex,FacturaServicioParams.PageSize,FacturaServicioParams.Search);
        }

        [HttpGet("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<FacturaServicioDto>> Get(int id)
        {
            var FacturaServicio = await unitofwork.FacturaServicios.GetByIdAsync(id);
            return mapper.Map<FacturaServicioDto>(FacturaServicio);
        }


          [HttpPost]
          [MapToApiVersion("1.1")]
          [ProducesResponseType(StatusCodes.Status201Created)]
          [ProducesResponseType(StatusCodes.Status400BadRequest)]
          public async Task<ActionResult<FacturaServicio>> Post([FromBody]FacturaServicioDto FacturaServicioDto)
          {
              var FacturaServicio = mapper.Map<FacturaServicio>(FacturaServicioDto);
              unitofwork.FacturaServicios.Add(FacturaServicio);
              await unitofwork.SaveAsync();

              if (FacturaServicio == null){
                  return BadRequest();
              }
                

              FacturaServicioDto.Id = FacturaServicio.Id;
              return CreatedAtAction(nameof(Post), new {id = FacturaServicioDto.Id}, FacturaServicioDto); 
           }



        [HttpPut("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<FacturaServicioDto>> Put(int id, [FromBody]FacturaServicioDto FacturaServicioDto){
            if(FacturaServicioDto == null)
                return NotFound();

            var FacturaServicio = this.mapper.Map<FacturaServicio>(FacturaServicioDto);
            unitofwork.FacturaServicios.Update(FacturaServicio);
            await unitofwork.SaveAsync();
            return FacturaServicioDto;
        }


        [HttpDelete("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete (int id){
            var FacturaServicio = await unitofwork.FacturaServicios.GetByIdAsync(id);
            if(FacturaServicio == null)
                return NotFound();
            
            unitofwork.FacturaServicios.Remove(FacturaServicio);
            await unitofwork.SaveAsync();
            return NoContent();    }
    }
}