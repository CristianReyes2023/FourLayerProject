using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;
public class Pais : BaseEntityString
{
    public string NombrePais { get; set; }
    public ICollection<Departamento> Departamentos { get; set; }
}
