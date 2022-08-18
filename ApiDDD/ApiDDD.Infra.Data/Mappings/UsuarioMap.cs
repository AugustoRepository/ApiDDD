using ApiDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Infra.Data.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasColumnName("IDUSUARIO").IsRequired();

            builder.Property(u => u.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(u => u.Email)
                .HasColumnName("EMAIL")
               .HasMaxLength(150)
               .IsRequired();

            builder.Property(u => u.Senha)
               .HasColumnName("SENHA")
              .HasMaxLength(150)
              .IsRequired();

            builder.Property(u => u.DataCriacao)
               .HasColumnName("DATACRIACAO")
              .HasColumnType("date")
              .IsRequired();
        }
    }
}
