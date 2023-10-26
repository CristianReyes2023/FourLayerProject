using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiIncidencias.Dtos;
public class SalonDto
{
    public string Id { get; set; }
    public string NombreSalon { get; set; }
    public int Capacidad { get; set; }
}
