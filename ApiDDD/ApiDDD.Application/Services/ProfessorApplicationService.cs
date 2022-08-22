using ApiDDD.Application.Contracts;
using ApiDDD.Application.Models.Professor;
using ApiDDD.Domain.Contracts.Services;
using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Application.Services
{
    public class ProfessorApplicationService : IProfessorApplicationServices
    {
        private readonly IProfessorDomainService professorDomainService;

        public ProfessorApplicationService(IProfessorDomainService professorDomainService)
        {
            this.professorDomainService = professorDomainService;
        }

        public void Alterar(ProfessorEdicaoModel model)
        {
            var professor = professorDomainService.ObterPorId(model.Id);
            professor.Nome = model.Nome;
            

            professorDomainService.Alterar(professor);
        }

        public void Excluir(Guid id)
        {
            var professor = professorDomainService.ObterPorId(id);
            professorDomainService.Excluir(professor);
        }

        public void Inserir(ProfessorCadastroModel model)
        {
            var Professor = new Professor
            {
                Id = Guid.NewGuid(),
                Nome = model.Nome,
                Cpf = model.Cpf
            };

            professorDomainService.Inserir(Professor);
        }

        public ProfessorConsultaModel ObterPorId(Guid id)
        {
            var professor = professorDomainService.ObterPorId(id);
            return new ProfessorConsultaModel
            {
                Id = id,
                Nome = professor.Nome,
                Cpf = professor.Cpf
            };
        }

        public List<ProfessorConsultaModel> ObterTodos()
        {
            var model   = new List<ProfessorConsultaModel>();
            foreach(var professor in professorDomainService.ObterTodos())
            {
                model.Add(
                    new ProfessorConsultaModel
                    {
                        Id = professor.Id,
                        Nome = professor.Nome,
                        Cpf = professor.Cpf                        
                    }
                    );
            }
            return model;
        }
    }
}
