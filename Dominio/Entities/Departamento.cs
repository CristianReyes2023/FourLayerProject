using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;
public class Departamento : BaseEntityString
{
    public string NombreDepartamento { get; set; }
    public string IdPaisFk { get; set; }
    public Pais Pais { get; set; }
    public ICollection<Ciudad> Ciudades { get; set; }

}
