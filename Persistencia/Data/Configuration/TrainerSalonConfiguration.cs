using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class TrainerSalonConfiguration : IEntityTypeConfiguration<TrainerSalon>
{
    public void Configure(EntityTypeBuilder<TrainerSalon> builder)
    {
        builder.ToTable("trainersalon");

        builder.HasKey(x => new { x.IdPersonaFk, x.IdSalonFk });

        builder.HasOne(x => x.Personas).WithMany(x => x.TrainerSalones).HasForeignKey(x => x.IdPersonaFk);
        builder.HasOne(x => x.Salones).WithMany(x => x.TrainerSalones).HasForeignKey(x => x.IdSalonFk);
    }
}
