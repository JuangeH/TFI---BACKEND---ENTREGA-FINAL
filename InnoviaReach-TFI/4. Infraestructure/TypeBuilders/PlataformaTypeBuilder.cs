﻿using Core.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Infraestructure.TypeBuilders
{
    public class PlataformaTypeBuilder : IEntityTypeConfiguration<PlataformaModel>
    {
        public void Configure(EntityTypeBuilder<PlataformaModel> builder)
        {
            builder.HasKey(x => x.Plataforma_ID);

            builder.Property(x => x.PlatformRawgID)
                .HasColumnType("integer")
                .IsRequired();

            builder.Property(x => x.Nombre)
                .HasColumnType("text")
                .IsRequired();

            builder.Property(x => x.Slug)
                .HasColumnType("text")
                .IsRequired();

            builder.ToTable("Plataforma");
        }
    }
}
