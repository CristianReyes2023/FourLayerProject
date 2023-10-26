using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class DireccionConfiguration : IEntityTypeConfiguration<Direccion>
{
    public void Configure(EntityTypeBuilder<Direccion> builder)
    {
        builder.ToTable("direccion");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x=>x.TipoVia).IsRequired().HasMaxLength(15);
        builder.Property(x=>x.Numero).HasColumnType("int");
        builder.Property(x=>x.Letra).IsRequired().HasMaxLength(3);
        builder.Property(x=>x.SufijoCardinal).IsRequired().HasMaxLength(3);
        builder.Property(x=>x.NumeroViaSecundaria).HasColumnType("int");
        builder.Property(x=>x.LetraViaSecundaria).IsRequired().HasMaxLength(3);
        builder.HasOne(x=>x.Persona).WithMany(x=>x.Direcciones).HasForeignKey(x=>x.IdPersonaFk);

    }
}
