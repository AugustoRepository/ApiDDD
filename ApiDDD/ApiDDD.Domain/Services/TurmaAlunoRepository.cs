using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Contracts.Services;
using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Services
{
    public class TurmaAlunoRepository : BaseDomainService<TurmaAluno>, ITurmaAlunoDomainService
    {
        private readonly ITurmaAlunoRepository turmaAlunoRepository;
        public TurmaAlunoRepository(ITurmaAlunoRepository turmaAlunoRepository) : base(turmaAlunoRepository)
        {
            this.turmaAlunoRepository = turmaAlunoRepository;
        }
    }
}
