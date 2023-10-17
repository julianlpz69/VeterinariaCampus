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
    public class MedicamentoController : BaseApiController
    {
        private IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public MedicamentoController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this.unitofwork = unitOfWork;
            this.mapper = Mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<MedicamentoDto>>> Get([FromQuery]Params MedicamentoParams)
        {
            var Medicamento = await unitofwork.Medicamentos.GetAllAsync(MedicamentoParams.PageIndex,MedicamentoParams.PageSize, MedicamentoParams.Search,"CedulaMedicamento");
            var listaMedicamentosDto= mapper.Map<List<MedicamentoDto>>(Medicamento.registros);
            return new Pager<MedicamentoDto>(listaMedicamentosDto, Medicamento.totalRegistros,MedicamentoParams.PageIndex,MedicamentoParams.PageSize,MedicamentoParams.Search);
        }

        [HttpGet("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MedicamentoDto>> Get(int id)
        {
            var Medicamento = await unitofwork.Medicamentos.GetByIdAsync(id);
            return mapper.Map<MedicamentoDto>(Medicamento);
        }


          [HttpPost]
          [MapToApiVersion("1.1")]
          [ProducesResponseType(StatusCodes.Status201Created)]
          [ProducesResponseType(StatusCodes.Status400BadRequest)]
          public async Task<ActionResult<Medicamento>> Post([FromBody]MedicamentoDto MedicamentoDto)
          {
              var Medicamento = mapper.Map<Medicamento>(MedicamentoDto);
              unitofwork.Medicamentos.Add(Medicamento);
              await unitofwork.SaveAsync();

              if (Medicamento == null){
                  return BadRequest();
              }
              MedicamentoDto.Id = Medicamento.Id;
              return CreatedAtAction(nameof(Post), new {id = MedicamentoDto.Id}, MedicamentoDto); 
           }



        [HttpPut("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<MedicamentoDto>> Put(int id, [FromBody]MedicamentoDto MedicamentoDto){
            if(MedicamentoDto == null)
                return NotFound();

            var Medicamento = this.mapper.Map<Medicamento>(MedicamentoDto);
            unitofwork.Medicamentos.Update(Medicamento);
            await unitofwork.SaveAsync();
            return MedicamentoDto;
        }


        [HttpDelete("{id}")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete (int id){
            var Medicamento = await unitofwork.Medicamentos.GetByIdAsync(id);
            if(Medicamento == null)
                return NotFound();
            
            unitofwork.Medicamentos.Remove(Medicamento);
            await unitofwork.SaveAsync();
            return NoContent();    }


        [HttpGet("Genfar")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MedicamentoDto>>> GetGenfar()
        {
            var Medicamento = await unitofwork.Medicamentos.MedicamentosGenfar();
            return mapper.Map<List<MedicamentoDto>>(Medicamento);
            
        }




        [HttpGet("Caro")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MedicamentoSoloDto>>> GetCaro()
        {
            var Medicamento = await unitofwork.Medicamentos.MedicamentosCaros();
            return mapper.Map<List<MedicamentoSoloDto>>(Medicamento);
            
        }


        [HttpGet("movimientos")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MedicamentoMovDto>>> GetMovimientos()
        {
            var Medicamento = await unitofwork.Medicamentos.MedicamentoMovimientos();
            return mapper.Map<List<MedicamentoMovDto>>(Medicamento);
            
        }
    }
}