using ApiDDD.Domain.Entities;
using ApiDDD.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Aluno> Aluno {get; set;}
        public DbSet<Professor> Professor {get; set;}
        public DbSet<Turma> Turma { get; set;}
        public DbSet<TurmaAluno> TurmaAluno { get; set;}
        public DbSet<Usuario> Usuario { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());
            modelBuilder.ApplyConfiguration(new TurmaAlunoMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
