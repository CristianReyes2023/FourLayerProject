using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.ToTable("departamento");

        builder.HasKey(x => x.Id);
        builder.Property(x=>x.Id);

        builder.Property(x=>x.NombreDepartamento).IsRequired().HasMaxLength(50);

        builder.HasOne(x => x.Pais).WithMany(x=>x.Departamentos).HasForeignKey(x=>x.IdPaisFk);
        
    }
}
