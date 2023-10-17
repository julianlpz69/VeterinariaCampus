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
    public class FacturaVentaController : BaseApiController
    {
          private IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public FacturaVentaController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this.unitofwork = unitOfWork;
            this.mapper = Mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<FacturaVentaDto>>> Get([FromQuery]Params FacturaVentaParams)
        {
        var FacturaVenta = await unitofwork.FacturaVentas.GetAllAsync(FacturaVentaParams.PageIndex,FacturaVentaParams.PageSize, FacturaVentaParams.Search,"FechaFacturaVenta");
        var listaFacturaVentas= mapper.Map<List<FacturaVentaDto>>(FacturaVenta.registros);
        return new Pager<FacturaVentaDto>(listaFacturaVentas, FacturaVenta.totalRegistros,FacturaVentaParams.PageIndex,FacturaVentaParams.PageSize,FacturaVentaParams.Search);
        }

        [HttpGet("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<FacturaVentaDto>> Get(int id)
        {
            var FacturaVenta = await unitofwork.FacturaVentas.GetByIdAsync(id);
            return mapper.Map<FacturaVentaDto>(FacturaVenta);
        }


          [HttpPost]
          [MapToApiVersion("1.1")]
          [ProducesResponseType(StatusCodes.Status201Created)]
          [ProducesResponseType(StatusCodes.Status400BadRequest)]
          public async Task<ActionResult<FacturaVenta>> Post([FromBody]FacturaVentaDto FacturaVentaDto)
          {
              var FacturaVenta = mapper.Map<FacturaVenta>(FacturaVentaDto);
              unitofwork.FacturaVentas.Add(FacturaVenta);
              await unitofwork.SaveAsync();

              if (FacturaVenta == null){
                  return BadRequest();
              }
                

              FacturaVentaDto.Id = FacturaVenta.Id;
              return CreatedAtAction(nameof(Post), new {id = FacturaVentaDto.Id}, FacturaVentaDto); 
           }



        [HttpPut("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<FacturaVentaDto>> Put(int id, [FromBody]FacturaVentaDto FacturaVentaDto){
            if(FacturaVentaDto == null)
                return NotFound();

            var FacturaVenta = this.mapper.Map<FacturaVenta>(FacturaVentaDto);
            unitofwork.FacturaVentas.Update(FacturaVenta);
            await unitofwork.SaveAsync();
            return FacturaVentaDto;
        }


        [HttpDelete("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete (int id){
            var FacturaVenta = await unitofwork.FacturaVentas.GetByIdAsync(id);
            if(FacturaVenta == null)
                return NotFound();
            
            unitofwork.FacturaVentas.Remove(FacturaVenta);
            await unitofwork.SaveAsync();
            return NoContent();    }
    }
    
}