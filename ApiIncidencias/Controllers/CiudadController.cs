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
    public class CiudadController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CiudadController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<CiudadDto>>> Get()
        {
            var results = await _unitOfWork.Ciudades.GetAllAsync();
            return _mapper.Map<List<CiudadDto>>(results);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CiudadDto>> Get(int id)
        {
            var result = await _unitOfWork.Ciudades.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return _mapper.Map<CiudadDto>(result);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CiudadDto>> Post(CiudadDto resultDto)
        {
            var result = _mapper.Map<Ciudad>(resultDto);
            _unitOfWork.Ciudades.Add(result);
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
        public async Task<ActionResult<CiudadDto>> Put(int id, [FromBody] CiudadDto CiudadDto)
        {
            var result = await _unitOfWork.Ciudades.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            if (CiudadDto.Id == 0)
            {
                CiudadDto.Id = id;
            }
            if (CiudadDto.Id != id)
            {
                return BadRequest();
            }
            // Update the properties of the existing entity with values from CiudadDto
            _mapper.Map(CiudadDto, result);
            // The context is already tracking result, so no need to attach it
            await _unitOfWork.SaveAsync();
            // Return the updated entity
            return _mapper.Map<CiudadDto>(result);
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.Ciudades.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            _unitOfWork.Ciudades.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }

    }
}