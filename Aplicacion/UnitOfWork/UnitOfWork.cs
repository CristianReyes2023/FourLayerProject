using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{

    private CiudadRepository _ciudades { get; set; }
    private DepartamentoRepository _departamentos { get; set; }
    private DireccionRepository _direcciones { get; set; }
    private GeneroRepository _generos { get; set; }
    private MatriculaRepository _matriculas { get; set; }
    private PaisRepository _paises { get; set; }
    private PersonaRepository _personas { get; set; }
    private SalonRepository _salones { get; set; }
    private TipoPersonaRepository _tipopersonas { get; set; }
    private readonly ApiIncidenciasContext _context;

    public UnitOfWork(ApiIncidenciasContext context)
    {
        _context = context;
    }
    public ICiudadRepository Ciudades
    {
        get
        {
            if (_ciudades == null)
            {
                _ciudades = new CiudadRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _ciudades;
        }
    }
    public IDepartamentoRepository Departamentos
    {
        get
        {
            if (_departamentos == null)
            {
                _departamentos = new DepartamentoRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _departamentos;
        }
    }
    public IDireccionRepository Direcciones
    {
        get
        {
            if (_direcciones == null)
            {
                _direcciones = new DireccionRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _direcciones;
        }
    }
    public IGeneroRepository Generos
    {
        get
        {
            if (_generos == null)
            {
                _generos = new GeneroRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _generos;
        }
    }
    public IMatriculaRepository Matriculas
    {
        get
        {
            if (_matriculas == null)
            {
                _matriculas = new MatriculaRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _matriculas;
        }
    }
    public IPaisRepository Paises
    {
        get
        {
            if (_paises == null)
            {
                _paises = new PaisRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _paises;
        }
    }
    public IPersonaRepository Personas
    {
        get
        {
            if (_personas == null)
            {
                _personas = new PersonaRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _personas;
        }
    }
    public ISalonRepository Salones
    {
        get
        {
            if (_salones == null)
            {
                _salones = new SalonRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _salones;
        }
    }
    public ITipoPersonaRepository TipoPersonas
    {
        get
        {
            if (_tipopersonas == null)
            {
                _tipopersonas = new TipoPersonaRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _tipopersonas;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }
}
