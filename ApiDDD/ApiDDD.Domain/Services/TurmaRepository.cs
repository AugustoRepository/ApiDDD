using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Contracts.Services;
using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Services
{
    public class TurmaRepository : BaseDomainService<Turma>, ITurmaDomainService
    {
        private readonly ITurmaRepository turmaRepository;
        public TurmaRepository(ITurmaRepository turmaRepository) : base(turmaRepository)
        {
            this.turmaRepository = turmaRepository;
        }
    }
}
