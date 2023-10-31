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
    public class MatriculaController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MatriculaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MatriculaDto>>> Get()
        {
            var results = await _unitOfWork.Matriculas.GetAllAsync();
            return _mapper.Map<List<MatriculaDto>>(results);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MatriculaDto>> Get(int id)
        {
            var result = await _unitOfWork.Matriculas.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return _mapper.Map<MatriculaDto>(result);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MatriculaDto>> Post(MatriculaDto resultDto)
        {
            var result = _mapper.Map<Matricula>(resultDto);
            _unitOfWork.Matriculas.Add(result);
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
        public async Task<ActionResult<MatriculaDto>> Put(int id, [FromBody] MatriculaDto MatriculaDto)
        {
            var result = await _unitOfWork.Matriculas.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            if (MatriculaDto.Id == 0)
            {
                MatriculaDto.Id = id;
            }
            if (MatriculaDto.Id != id)
            {
                return BadRequest();
            }
            // Update the properties of the existing entity with values from MatriculaDto
            _mapper.Map(MatriculaDto, result);
            // The context is already tracking result, so no need to attach it
            await _unitOfWork.SaveAsync();
            // Return the updated entity
            return _mapper.Map<MatriculaDto>(result);
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.Matriculas.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            _unitOfWork.Matriculas.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }

    }
}