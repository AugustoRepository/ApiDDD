using ApiDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Infra.Data.Mappings
{
    public class TurmaAlunoMap : IEntityTypeConfiguration<TurmaAluno>
    {
        public void Configure(EntityTypeBuilder<TurmaAluno> builder)
        {
            builder.ToTable("TURMAALUNO");

            builder.HasKey(ta => new
            {
                ta.IdTurma,
                ta.IdAluno
            });

            builder.Property(ta => ta.IdTurma)
                .HasColumnName("IDTURMA")
                .IsRequired();

            builder.Property(ta => ta.IdAluno)
                .HasColumnName("IDALUNO")
                .IsRequired();

            #region Relacionamentos
            builder.HasOne(ta => ta.Turma)
                .WithMany(a => a.Alunos)
                .HasForeignKey(ta => ta.IdTurma);

            builder.HasOne(ta => ta.Aluno)
                .WithMany(a => a.Turmas)
                .HasForeignKey(ta => ta.IdAluno);
            #endregion
        }
    }
}
