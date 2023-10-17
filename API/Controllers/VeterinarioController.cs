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
    public class VeterinarioController : BaseApiController
    {
      private IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public VeterinarioController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this.unitofwork = unitOfWork;
            this.mapper = Mapper;
        }
         
        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<VeterinarioDto>>> Get([FromQuery]Params VeterinarioParams)
        {
            var Veterinario = await unitofwork.Veterinarios.GetAllAsync(VeterinarioParams.PageIndex,VeterinarioParams.PageSize, VeterinarioParams.Search,"CedulaVeterinario");
            var listaVeterinariosDto= mapper.Map<List<VeterinarioDto>>(Veterinario.registros);
            return new Pager<VeterinarioDto>(listaVeterinariosDto, Veterinario.totalRegistros,VeterinarioParams.PageIndex,VeterinarioParams.PageSize,VeterinarioParams.Search);
        }

        [HttpGet("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<VeterinarioDto>> Get(int id)
        {
            var Veterinario = await unitofwork.Veterinarios.GetByIdAsync(id);
            return mapper.Map<VeterinarioDto>(Veterinario);
        }


          [HttpPost]
          [MapToApiVersion("1.1")]
          [Authorize(Roles = "Administrador")]
          [ProducesResponseType(StatusCodes.Status201Created)]
          [ProducesResponseType(StatusCodes.Status400BadRequest)]
          public async Task<ActionResult<Veterinario>> Post([FromBody]VeterinarioDto VeterinarioDto)
          {
              var Veterinario = mapper.Map<Veterinario>(VeterinarioDto);
              unitofwork.Veterinarios.Add(Veterinario);
              await unitofwork.SaveAsync();

              if (Veterinario == null){
                  return BadRequest();
              }
              VeterinarioDto.Id = Veterinario.Id;
              return CreatedAtAction(nameof(Post), new {id = VeterinarioDto.Id}, VeterinarioDto); 
           }



        [HttpPut("{id}")]
        [MapToApiVersion("1.1")]
        [Authorize(Roles = "Administrador")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<VeterinarioDto>> Put(int id, [FromBody]VeterinarioDto VeterinarioDto){
            if(VeterinarioDto == null)
                return NotFound();

            var Veterinario = this.mapper.Map<Veterinario>(VeterinarioDto);
            unitofwork.Veterinarios.Update(Veterinario);
            await unitofwork.SaveAsync();
            return VeterinarioDto;
        }


        [HttpDelete("{id}")]
        [MapToApiVersion("1.1")]
        [Authorize(Roles = "Administrador")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete (int id){
            var Veterinario = await unitofwork.Veterinarios.GetByIdAsync(id);
            if(Veterinario == null)
                return NotFound();
            
            unitofwork.Veterinarios.Remove(Veterinario);
            await unitofwork.SaveAsync();
            return NoContent();    }



        
        [HttpGet("Especialidad")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<VeterinarioDto>>> GetEspecialidad()
        {
            var Veterinario = await unitofwork.Veterinarios.VeterinariosCirujano();
            return mapper.Map<List<VeterinarioDto>>(Veterinario);
            
        }
    }
}