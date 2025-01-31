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
    public class ForoTypeBuilder : IEntityTypeConfiguration<ForoModel>
    {
        public void Configure(EntityTypeBuilder<ForoModel> builder)
        {
            builder.HasKey(x => x.Foro_ID);

            builder.Property(x => x.Descripcion)
                .HasColumnType("text")
                .IsRequired();

            builder.Property(x => x.Titulo)
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder.Property(x => x.FechaCreado)
                .HasColumnType("timestamp with time zone")
                .IsRequired();

            builder.Property(x => x.Activo)
                .HasColumnType("boolean")
                .IsRequired();

            builder.HasOne(x => x.usuario)
                .WithMany(y => y.foroModels)
                .HasForeignKey(z => z.User_ID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.videojuego)
                .WithMany(y => y.foroModels)
                .HasForeignKey(z => z.Videojuego_ID);

            builder.ToTable("Foro");
        }
    }
}
