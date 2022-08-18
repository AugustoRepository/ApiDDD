using ApiDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Infra.Data.Mappings
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("ALUNO");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .HasColumnName("IDALUNO")
                .IsRequired();

            builder.Property(a => a.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(a => a.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(a => a.DataNascimento)
                .HasColumnName("DATANASCIMENTO")
                .HasColumnType("date")
                .IsRequired();
        }
    }
}
