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
    public class SalonController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SalonController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<SalonDto>>> Get()
        {
            var results = await _unitOfWork.Salones.GetAllAsync();
            return _mapper.Map<List<SalonDto>>(results);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<SalonDto>> Get(int id)
        {
            var result = await _unitOfWork.Salones.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return _mapper.Map<SalonDto>(result);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<SalonDto>> Post(SalonDto resultDto)
        {
            var result = _mapper.Map<Salon>(resultDto);
            _unitOfWork.Salones.Add(result);
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
        public async Task<ActionResult<SalonDto>> Put(int id, [FromBody] SalonDto SalonDto)
        {
            var result = await _unitOfWork.Salones.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            if (SalonDto.Id == 0)
            {
                SalonDto.Id = id;
            }
            if (SalonDto.Id != id)
            {
                return BadRequest();
            }
            // Update the properties of the existing entity with values from SalonDto
            _mapper.Map(SalonDto, result);
            // The context is already tracking result, so no need to attach it
            await _unitOfWork.SaveAsync();
            // Return the updated entity
            return _mapper.Map<SalonDto>(result);
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.Salones.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            _unitOfWork.Salones.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }

    }
}