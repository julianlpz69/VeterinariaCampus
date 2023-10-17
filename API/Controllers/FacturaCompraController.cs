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
    public class FacturaCompraController : BaseApiController
    {
        private IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public FacturaCompraController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this.unitofwork = unitOfWork;
            this.mapper = Mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<FacturaCompraDto>>> Get([FromQuery]Params FacturaCompraParams)
        {
        var FacturaCompra = await unitofwork.FacturaCompras.GetAllAsync(FacturaCompraParams.PageIndex,FacturaCompraParams.PageSize, FacturaCompraParams.Search,"FechaFacturaCompra");
        var listaFacturaCompras= mapper.Map<List<FacturaCompraDto>>(FacturaCompra.registros);
        return new Pager<FacturaCompraDto>(listaFacturaCompras, FacturaCompra.totalRegistros,FacturaCompraParams.PageIndex,FacturaCompraParams.PageSize,FacturaCompraParams.Search);
        }

        [HttpGet("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<FacturaCompraDto>> Get(int id)
        {
            var FacturaCompra = await unitofwork.FacturaCompras.GetByIdAsync(id);
            return mapper.Map<FacturaCompraDto>(FacturaCompra);
        }


          [HttpPost]
          [MapToApiVersion("1.1")]
          [ProducesResponseType(StatusCodes.Status201Created)]
          [ProducesResponseType(StatusCodes.Status400BadRequest)]
          public async Task<ActionResult<FacturaCompra>> Post([FromBody]FacturaCompraDto FacturaCompraDto)
          {
              var FacturaCompra = mapper.Map<FacturaCompra>(FacturaCompraDto);
              unitofwork.FacturaCompras.Add(FacturaCompra);
              await unitofwork.SaveAsync();

              if (FacturaCompra == null){
                  return BadRequest();
              }
                

              FacturaCompraDto.Id = FacturaCompra.Id;
              return CreatedAtAction(nameof(Post), new {id = FacturaCompraDto.Id}, FacturaCompraDto); 
           }



        [HttpPut("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<FacturaCompraDto>> Put(int id, [FromBody]FacturaCompraDto FacturaCompraDto){
            if(FacturaCompraDto == null)
                return NotFound();

            var FacturaCompra = this.mapper.Map<FacturaCompra>(FacturaCompraDto);
            unitofwork.FacturaCompras.Update(FacturaCompra);
            await unitofwork.SaveAsync();
            return FacturaCompraDto;
        }


        [HttpDelete("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete (int id){
            var FacturaCompra = await unitofwork.FacturaCompras.GetByIdAsync(id);
            if(FacturaCompra == null)
                return NotFound();
            
            unitofwork.FacturaCompras.Remove(FacturaCompra);
            await unitofwork.SaveAsync();
            return NoContent();    }
    }
}