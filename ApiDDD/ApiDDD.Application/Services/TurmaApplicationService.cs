using ApiDDD.Application.Contracts;
using ApiDDD.Application.Models.Professor;
using ApiDDD.Application.Models.Turma;
using ApiDDD.Domain.Contracts.Services;
using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Application.Services
{
    public class TurmaApplicationService : ITurmaApplicationServices
    {
        private readonly ITurmaDomainService turmaDomainService;

        public TurmaApplicationService(ITurmaDomainService turmaDomainService)
        {
            this.turmaDomainService = turmaDomainService;
        }

        public void Alterar(TurmaEdicaoModel model)
        {
            var turma = turmaDomainService.ObterPorId(model.Id);
            turma.Nome = model.Nome;
            turma.Periodo = model.Periodo;
            turma.DataInicio = DateTime.Parse(model.DataInicio);
            turma.DataTermino = DateTime.Parse(model.DataTermino);
            turma.IdProfessor = Guid.Parse(model.IdProfessor);


            turmaDomainService.Alterar(turma);
        }

        public void Excluir(Guid id)
        {
            var Turma = turmaDomainService.ObterPorId(id);
            turmaDomainService.Excluir(Turma);
        }

        public void Inserir(TurmaCadastroModel model)
        {
            var Turma = new Turma
            {
                Id = Guid.NewGuid(),
                Nome = model.Nome,
                DataInicio = DateTime.Parse(model.DataInicio),
                DataTermino = DateTime.Parse(model.DataTermino),
                IdProfessor = Guid.Parse(model.IdProfessor),
            };

            turmaDomainService.Inserir(Turma);
        }

        public TurmaConsultaModel ObterPorId(Guid id)
        {
            var turma = turmaDomainService.ObterPorId(id);
            return new TurmaConsultaModel
            {
                Id = id,
                Nome = turma.Nome,
                Periodo = turma.Periodo,
                DataInicio = turma.DataInicio,
                DataTermino = turma.DataTermino,
                Professor = new ProfessorConsultaModel
                {
                    Id = turma.Professor.Id,
                    Nome = turma.Professor.Nome,
                    Cpf = turma.Professor.Cpf,
                }
            };
        }

        public List<TurmaConsultaModel> ObterTodos()
        {
            var model   = new List<TurmaConsultaModel>();
            foreach(var turma in turmaDomainService.ObterTodos())
            {
                model.Add(
                    new TurmaConsultaModel
                    {
                        Id = turma.Id,
                        Nome = turma.Nome,
                        Periodo = turma.Periodo,
                        DataInicio = turma.DataInicio,
                        DataTermino = turma.DataTermino,
                        Professor = new ProfessorConsultaModel
                        {
                            Id = turma.Professor.Id,
                            Nome = turma.Professor.Nome,
                            Cpf = turma.Professor.Cpf,
                        }
                    }
                    );
            }
            return model;
        }
    }
}
