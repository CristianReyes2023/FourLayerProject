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

namespace ApiIncidencias.Controllers;
[ApiVersion("1.0")]//Aplicacion de las anotaciones de version antes del inicio de la declaracion de clase
[ApiVersion("1.1")]

public class DepartamentoController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DepartamentoController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<DepartamentoDto>>> Get()
    {
        var results = await _unitOfWork.Departamentos.GetAllAsync();
        return _mapper.Map<List<DepartamentoDto>>(results);
    }
    // [HttpGet]
    // [MapToApiVersion("1.0")]//Permite especificar a que version pertenece el endpoint
    // [ProducesResponseType(StatusCodes.Status200OK)]
    // [ProducesResponseType(StatusCodes.Status400BadRequest)]
    // public async Task<ActionResult<IEnumerable<DepartamentoDto>>> Get()
    // {
    //     var results = await _unitOfWork.Departamentoes.GetAllAsync();
    //     return _mapper.Map<List<DepartamentoDto>>(results);
    // }
    // [HttpGet]
    // [MapToApiVersion("1.1")]//Permite especificar a que version pertenece el endpoint
    // [ProducesResponseType(StatusCodes.Status200OK)]
    // [ProducesResponseType(StatusCodes.Status400BadRequest)]
    // public async Task<ActionResult<IEnumerable<DepartamentoDto>>> Get()
    // {
    //     var results = await _unitOfWork.Departamentos.GetAllAsync();
    //     return _mapper.Map<List<DepartamentoDto>>(results);
    // }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<DepartamentoDto>> Get(int id)
    {
        var result = await _unitOfWork.Departamentos.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        return _mapper.Map<DepartamentoDto>(result);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<DepartamentoDto>> Post(DepartamentoDto resultDto)
    {
        var result = _mapper.Map<Departamento>(resultDto);
        _unitOfWork.Departamentos.Add(result);
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
    public async Task<ActionResult<DepartamentoDto>> Put(int id, [FromBody] DepartamentoDto DepartamentoDto)
    {
        var result = await _unitOfWork.Departamentos.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        if (DepartamentoDto.Id == 0)
        {
            DepartamentoDto.Id = id;
        }
        if (DepartamentoDto.Id != id)
        {
            return BadRequest();
        }
        // Update the properties of the existing entity with values from DepartamentoDto
        _mapper.Map(DepartamentoDto, result);
        // The context is already tracking result, so no need to attach it
        await _unitOfWork.SaveAsync();
        // Return the updated entity
        return _mapper.Map<DepartamentoDto>(result);
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.Departamentos.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        _unitOfWork.Departamentos.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }

}
