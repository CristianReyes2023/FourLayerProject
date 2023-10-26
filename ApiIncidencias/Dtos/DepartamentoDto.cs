using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiIncidencias.Dtos;
public class DepartamentoDto
{
    public string Id { get; set; }
    public string NombreDepartamento { get; set; }
    public string IdPaisFk { get; set; }
}
