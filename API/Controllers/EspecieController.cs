using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class EspecieController : BaseApiController
    {

        private IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public EspecieController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this.unitofwork = unitOfWork;
            this.mapper = Mapper;
        }

        

        [HttpGet("especie-mascota")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<object>>> GetEspecialidad()
        {
            var Especies = await unitofwork.Especies.ObtenerMascotasPorEspecie();
            return Ok(Especies);
            
        }
    }
}