using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiIncidencias.Dtos;

namespace ApiIncidencias.Controllers;
public class PaisxDepDto
{
    public int Id { get; set; }
    public string NombrePais { get; set; }
    public List<DepartamentoDto> departamentos { get; set; }
}
