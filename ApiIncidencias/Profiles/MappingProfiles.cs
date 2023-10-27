using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiIncidencias.Controllers;
using ApiIncidencias.Dtos;
using AutoMapper;
using Dominio.Entities;

namespace ApiIncidencias.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Ciudad,CiudadDto>().ReverseMap();
        CreateMap<Departamento,DepartamentoDto>().ReverseMap();
        CreateMap<Direccion,DireccionDto>().ReverseMap();
        CreateMap<Genero,GeneroDto>().ReverseMap();
        CreateMap<Matricula,MatriculaDto>().ReverseMap();
        CreateMap<Pais,PaisDto>().ReverseMap();
        CreateMap<Persona,PersonaDto>().ReverseMap();
        CreateMap<Salon,SalonDto>().ReverseMap();
        CreateMap<TipoPersona,TipoPersonaDto>().ReverseMap();
        CreateMap<Pais,PaisxDepDto>().ReverseMap();
    }
}
