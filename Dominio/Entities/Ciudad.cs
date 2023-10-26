using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;
public class Ciudad : BaseEntityString
{
    public string NombreCiudad { get; set; }
    public string IdDepartamentoFk { get; set; }
    public Departamento Departamento { get; set; }
    public ICollection<Persona> Personas { get; set; }
}
