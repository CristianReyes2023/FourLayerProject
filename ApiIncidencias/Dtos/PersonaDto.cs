using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiIncidencias.Dtos;
public class PersonaDto
{
    public string Id { get; set; }
    public string NombrePersona { get; set; }
    public string ApellidoPersona { get; set; }
    public int IdGeneroFk { get; set; }
    public int IdCiudadFk { get; set; }
    public int IdTipoPerFk { get; set; }
}
