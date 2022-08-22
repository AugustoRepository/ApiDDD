using ApiDDD.Application.Contracts;
using ApiDDD.Application.Models.Aluno;
using ApiDDD.Domain.Contracts.Services;
using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Application.Services
{
    public class AlunoApplicationService : IAlunoApplicationServices
    {
        private readonly IAlunoDomainService alunoDomainService;

        public AlunoApplicationService(IAlunoDomainService alunoDomainService)
        {
            this.alunoDomainService = alunoDomainService;
        }

        public void Alterar(AlunoEdicaoModel model)
        {
            var aluno = alunoDomainService.ObterPorId(model.Id);
            aluno.Nome = model.Nome;
            aluno.DataNascimento = DateTime.Parse(model.DataNascimento);

            alunoDomainService.Alterar(aluno);
        }

        public void Excluir(Guid id)
        {
            var aluno = alunoDomainService.ObterPorId(id);
            alunoDomainService.Excluir(aluno);
        }

        public void Inserir(AlunoCadastroModel model)
        {
            var aluno = new Aluno
            {
                Id = Guid.NewGuid(),
                Nome = model.Nome,
                Email = model.Email,
                Matricula = model.Matricula,
                DataNascimento = DateTime.Parse(model.DataNascimento)
            };

            alunoDomainService.Inserir(aluno);
        }

        public AlunoConsultaModel ObterPorId(Guid id)
        {
            var aluno = alunoDomainService.ObterPorId(id);
            return new AlunoConsultaModel
            {
                Id = id,
                Nome = aluno.Nome,
                Email= aluno.Email,
                Matricula= aluno.Matricula,
                DataNascimento = aluno.DataNascimento
            };
        }

        public List<AlunoConsultaModel> ObterTodos()
        {
            var model   = new List<AlunoConsultaModel>();
            foreach(var aluno in alunoDomainService.ObterTodos())
            {
                model.Add(
                    new AlunoConsultaModel
                    {
                        Id = aluno.Id,
                        Nome = aluno.Nome,
                        Email = aluno.Email,
                        Matricula = aluno.Matricula,
                        DataNascimento = aluno.DataNascimento
                    }
                    );
            }
            return model;
        }
    }
}
