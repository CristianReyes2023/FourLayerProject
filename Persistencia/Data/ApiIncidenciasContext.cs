using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data;
public class ApiIncidenciasContext : DbContext
{
    public ApiIncidenciasContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Ciudad> Ciudades { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Salon> Salones { get; set; }
    public DbSet<Matricula> Matriculas { get; set; }
    public DbSet<TipoPersona> TipoPersonas { get; set; }
    public DbSet<TrainerSalon> TrainerSalones { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Rol> Rols { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
