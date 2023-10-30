using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("user");

        builder.HasKey(x=>x.Id);
        builder.Property(x => x.Id);

        builder.Property(x=>x.Username).IsRequired().HasMaxLength(50);
        builder.Property(x=>x.Email).IsRequired().HasMaxLength(225);
        builder.Property(x=>x.Password).IsRequired().HasMaxLength(100);
        
    }
}
