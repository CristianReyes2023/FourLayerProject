using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiIncidencias.Dtos;
public class MatriculaDto
{
    public int Id { get; set; }
    public string IdPersonaFk { get; set; }
    public int IdSalonFk { get; set; }
}
