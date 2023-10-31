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
    public class DireccionController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DireccionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DireccionDto>>> Get()
        {
            var results = await _unitOfWork.Direcciones.GetAllAsync();
            return _mapper.Map<List<DireccionDto>>(results);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DireccionDto>> Get(int id)
        {
            var result = await _unitOfWork.Direcciones.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return _mapper.Map<DireccionDto>(result);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DireccionDto>> Post(DireccionDto resultDto)
        {
            var result = _mapper.Map<Direccion>(resultDto);
            _unitOfWork.Direcciones.Add(result);
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
        public async Task<ActionResult<DireccionDto>> Put(int id, [FromBody] DireccionDto DireccionDto)
        {
            var result = await _unitOfWork.Direcciones.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            if (DireccionDto.Id == 0)
            {
                DireccionDto.Id = id;
            }
            if (DireccionDto.Id != id)
            {
                return BadRequest();
            }
            // Update the properties of the existing entity with values from DireccionDto
            _mapper.Map(DireccionDto, result);
            // The context is already tracking result, so no need to attach it
            await _unitOfWork.SaveAsync();
            // Return the updated entity
            return _mapper.Map<DireccionDto>(result);
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.Direcciones.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            _unitOfWork.Direcciones.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }

    }
}