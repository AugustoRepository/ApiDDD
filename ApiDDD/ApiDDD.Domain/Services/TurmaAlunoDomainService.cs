using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Contracts.Services;
using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Services
{
    public class TurmaAlunoDomainService : BaseDomainService<TurmaAluno>, ITurmaAlunoDomainService
    {
        private readonly ITurmaAlunoRepository turmaAlunoRepository;
        public TurmaAlunoDomainService(ITurmaAlunoRepository turmaAlunoRepository) : base(turmaAlunoRepository)
        {
            this.turmaAlunoRepository = turmaAlunoRepository;
        }
    }
}
