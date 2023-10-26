using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Interfaces;
public interface IUnitOfWork 
{
    ICiudadRepository Ciudades {get;}
    IDepartamentoRepository Departamentos {get;}
    IDireccionRepository Direcciones {get;}
    IGeneroRepository Generos {get;}
    IMatriculaRepository Matriculas {get;}
    IPaisRepository Paises {get;}
    IPersonaRepository Personas {get;}
    ISalonRepository Salones {get;}
    ITipoPersonaRepository TipoPersonas {get;}

    Task<int> SaveAsync();

}
