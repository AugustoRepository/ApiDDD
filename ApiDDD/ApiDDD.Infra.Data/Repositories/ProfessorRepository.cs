using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Entities;
using ApiDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Infra.Data.Repositories
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        private readonly DataContext dataContext;
        public ProfessorRepository(DataContext dataContext) : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public Professor ObeterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}
