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
    public class ClienteController : BaseApiController
    {

        private IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public ClienteController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this.unitofwork = unitOfWork;
            this.mapper = Mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<ClienteDto>>> Get([FromQuery]Params ClienteParams)
        {
        var Cliente = await unitofwork.Clientes.GetAllAsync(ClienteParams.PageIndex,ClienteParams.PageSize, ClienteParams.Search,"NombreCliente");
        var listaClientes= mapper.Map<List<ClienteDto>>(Cliente.registros);
        return new Pager<ClienteDto>(listaClientes, Cliente.totalRegistros,ClienteParams.PageIndex,ClienteParams.PageSize,ClienteParams.Search);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ClienteDto>> Get(int id)
        {
            var cliente = await unitofwork.Clientes.GetByIdAsync(id);
            return mapper.Map<ClienteDto>(cliente);
        }


          [HttpPost]
          [ProducesResponseType(StatusCodes.Status201Created)]
          [ProducesResponseType(StatusCodes.Status400BadRequest)]
          public async Task<ActionResult<Cliente>> Post([FromBody]ClienteDto clienteDto)
          {
              var cliente = mapper.Map<Cliente>(clienteDto);
              unitofwork.Clientes.Add(cliente);
              await unitofwork.SaveAsync();

              if (cliente == null){
                  return BadRequest();
              }
              clienteDto.Id = cliente.Id;
              return CreatedAtAction(nameof(Post), new {id = clienteDto.Id}, clienteDto); 
           }



        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<ClienteDto>> Put(int id, [FromBody]ClienteDto ClienteDto){
            if(ClienteDto == null)
                return NotFound();

            var Cliente = this.mapper.Map<Cliente>(ClienteDto);
            unitofwork.Clientes.Update(Cliente);
            await unitofwork.SaveAsync();
            return ClienteDto;
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete (int id){
            var Cliente = await unitofwork.Clientes.GetByIdAsync(id);
            if(Cliente == null)
                return NotFound();
            
            unitofwork.Clientes.Remove(Cliente);
            await unitofwork.SaveAsync();
            return NoContent();    }
    }
}