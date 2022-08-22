using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Entities;
using ApiDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Infra.Data.Repositories
{
    public class TurmaAlunoRepository : BaseRepository<TurmaAluno>, ITurmaAlunoRepository
    {
        private readonly DataContext dataContext;
        public TurmaAlunoRepository(DataContext dataContext) : base(dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
