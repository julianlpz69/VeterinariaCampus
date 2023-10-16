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
    public class ProveedorController : BaseApiController
    {
        

        private IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public ProveedorController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this.unitofwork = unitOfWork;
            this.mapper = Mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<ProveedorDto>>> Get([FromQuery]Params ProveedorParams)
        {
        var Proveedor = await unitofwork.Proveedores.GetAllAsync(ProveedorParams.PageIndex,ProveedorParams.PageSize, ProveedorParams.Search,"FechaProveedor");
        var listaProveedors= mapper.Map<List<ProveedorDto>>(Proveedor.registros);
        return new Pager<ProveedorDto>(listaProveedors, Proveedor.totalRegistros,ProveedorParams.PageIndex,ProveedorParams.PageSize,ProveedorParams.Search);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProveedorDto>> Get(int id)
        {
            var Proveedor = await unitofwork.Proveedores.GetByIdAsync(id);
            return mapper.Map<ProveedorDto>(Proveedor);
        }


          [HttpPost]
          [ProducesResponseType(StatusCodes.Status201Created)]
          [ProducesResponseType(StatusCodes.Status400BadRequest)]
          public async Task<ActionResult<Proveedor>> Post([FromBody]ProveedorDto ProveedorDto)
          {
              var Proveedor = mapper.Map<Proveedor>(ProveedorDto);
              unitofwork.Proveedores.Add(Proveedor);
              await unitofwork.SaveAsync();

              if (Proveedor == null){
                  return BadRequest();
              }
              ProveedorDto.Id = Proveedor.Id;
              return CreatedAtAction(nameof(Post), new {id = ProveedorDto.Id}, ProveedorDto); 
           }



        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<ProveedorDto>> Put(int id, [FromBody]ProveedorDto ProveedorDto){
            if(ProveedorDto == null)
                return NotFound();

            var Proveedor = this.mapper.Map<Proveedor>(ProveedorDto);
            unitofwork.Proveedores.Update(Proveedor);
            await unitofwork.SaveAsync();
            return ProveedorDto;
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete (int id){
            var Proveedor = await unitofwork.Proveedores.GetByIdAsync(id);
            if(Proveedor == null)
                return NotFound();
            
            unitofwork.Proveedores.Remove(Proveedor);
            await unitofwork.SaveAsync();
            return NoContent();    }




        [HttpGet("Medicamento")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<ProveedorMedicamentosDto>>> GetVeterinario(string nombre)
        {
            var Mascota = await unitofwork.Proveedores.MedicamentoProveedor(nombre);
            return mapper.Map<List<ProveedorMedicamentosDto>>(Mascota);
            
        }
    }
}