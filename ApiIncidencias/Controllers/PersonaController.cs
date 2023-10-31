using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiIncidencias.Dtos;
using Aplicacion.UnitOfWork;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using iText.Svg.Renderers.Impl;
using Microsoft.AspNetCore.Mvc;

namespace ApiIncidencias.Controllers
{
    public class PersonaController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PersonaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PersonaDto>>> Get()
        {
            var results = await _unitOfWork.Personas.GetAllAsync();
            return _mapper.Map<List<PersonaDto>>(results);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PersonaDto>> Get(string id)
        {
            var result = await _unitOfWork.Personas.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return _mapper.Map<PersonaDto>(result);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PersonaDto>> Post(PersonaDto resultDto)
        {
            var result = _mapper.Map<Persona>(resultDto);
            _unitOfWork.Personas.Add(result);
            await _unitOfWork.SaveAsync();
            if (result == null)
            {
                return BadRequest();
            }
            resultDto.Id = result.Id;
            return CreatedAtAction(nameof(Post), new { id = resultDto.Id }, resultDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PersonaDto>> Put(string id, [FromBody] PersonaDto PersonaDto)
        {
            var result = await _unitOfWork.Personas.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            if (PersonaDto.Id == null)
            {
                PersonaDto.Id = id;
            }
            if (PersonaDto.Id != id)
            {
                return BadRequest();
            }
            // Update the properties of the existing entity with values from PersonaDto
            _mapper.Map(PersonaDto, result);
            // The context is already tracking result, so no need to attach it
            await _unitOfWork.SaveAsync();
            // Return the updated entity
            return _mapper.Map<PersonaDto>(result);
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _unitOfWork.Personas.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            _unitOfWork.Personas.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }

    }
}