using ApiDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Infra.Data.Mappings
{
    public class ProfessorMap : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("PROFESSOR");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("IDPROFESSOR")
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.Cpf)
                .HasColumnName("CPF")
                .HasMaxLength(15)
                .IsRequired();
        }
    }
}
