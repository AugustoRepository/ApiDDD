using ApiDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Infra.Data.Mappings
{
    public class TurmaMap : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.ToTable("TURMA");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .HasColumnName("IDTURMA")
                .IsRequired();

            builder.Property(t => t.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.Periodo)
                .HasColumnName("PERIODO")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.DataInicio)
               .HasColumnName("DATAINICIO")
               .HasColumnType("date")
               .IsRequired();

            builder.Property(t => t.DataTermino)
               .HasColumnName("DATATERMINO")
               .HasColumnType("date")
               .IsRequired();

            builder.Property(t => t.IdProfessor)
                .HasColumnName("IDPROFESSOR")
                .IsRequired();

            #region Relacionamentos
            builder.HasOne(t => t.Professor)
                .WithMany(p => p.Turmas)
                .HasForeignKey(t => t.IdProfessor);
            #endregion
        }
    }
}
