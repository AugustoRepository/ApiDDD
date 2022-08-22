using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Contracts.Services;
using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Services
{
    public class TurmaDomainService : BaseDomainService<Turma>, ITurmaDomainService
    {
        private readonly ITurmaRepository turmaRepository;
        public TurmaDomainService(ITurmaRepository turmaRepository) : base(turmaRepository)
        {
            this.turmaRepository = turmaRepository;
        }
    }
}
