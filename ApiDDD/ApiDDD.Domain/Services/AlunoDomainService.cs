using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Contracts.Services;
using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Services
{
    public class AlunoDomainService : BaseDomainService<Aluno>, IAlunoDomainService
    {
        private readonly IAlunoRepository alunoRepository;
        public AlunoDomainService(IAlunoRepository alunoRepository) 
            : base(alunoRepository)
        {
            this.alunoRepository = alunoRepository;
        }

        public override void Inserir(Aluno obj)
        {
            #region validar dados repetidos no banco
            if (alunoRepository.ObterPorMatricula(obj.Matricula) != null)
            {
                throw new Exception("A matricula informada ja encontra-se cadastrada");
            }
            if (alunoRepository.ObterPorEmail(obj.Email) != null)
            {
                throw new Exception("O Email informada ja encontra-se cadastrada");
            }
            #endregion

            alunoRepository.Inserir(obj);
        }
    }
}
