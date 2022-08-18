using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Contracts.Services;
using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Services
{
    public class ProfessorDomainService : BaseDomainService<Professor>, IProfessorDomainService
    {
        private readonly IProfessorRepository professorRepository;
        public ProfessorDomainService(IProfessorRepository professorRepository) 
            : base(professorRepository)
        {
            this.professorRepository = professorRepository;
        }

        public override void Inserir(Professor obj)
        {
            #region validar dados repetidos no banco
            if (professorRepository.ObeterPorCpf(obj.Cpf) != null)
            {
                throw new Exception("O CPF informada ja encontra-se cadastrada");
            }

            #endregion

            professorRepository.Inserir(obj);
        }
    }
}
