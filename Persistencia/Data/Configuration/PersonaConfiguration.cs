using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("persona");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.NombrePersona).IsRequired().HasMaxLength(50);
        builder.Property(x => x.ApellidoPersona).IsRequired().HasMaxLength(50);

        builder.HasOne(x => x.Genero).WithMany(x=>x.Personas).HasForeignKey(x => x.IdGeneroFk);
        builder.HasOne(x => x.Ciudad).WithMany(x=>x.Personas).HasForeignKey(x => x.IdCiudadFk);
        builder.HasOne(x => x.TipoPersona).WithMany(x=>x.Personas).HasForeignKey(x => x.IdTipoPerFk);
        
    }
}
