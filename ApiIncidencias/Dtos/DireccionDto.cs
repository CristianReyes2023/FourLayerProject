using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiIncidencias.Dtos;
public class DireccionDto
{
    public int Id { get; set; }
    public string TipoVia { get; set; }
    public int Numero { get; set; }
    public string Letra { get; set; }
    public string SufijoCardinal { get; set; }
    public int NumeroViaSecundaria { get; set; }
    public string LetraViaSecundaria { get; set; }
    public string IdPersonaFk { get; set; }
}
