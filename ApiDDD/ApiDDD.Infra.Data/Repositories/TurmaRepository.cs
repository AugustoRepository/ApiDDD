using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Entities;
using ApiDDD.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiDDD.Infra.Data.Repositories
{
    public class TurmaRepository : BaseRepository<Turma>, ITurmaRepository
    {
        private readonly DataContext dataContext;
        public TurmaRepository(DataContext dataContext) : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public override List<Turma> ObterTodos()
        {
            return dataContext.Turma
                .Include(t => t.Professor)
                .ToList();
        }

        public override Turma ObterPorId(Guid id)
        {
            return dataContext.Turma
                .Include(t => t.Professor)
                .FirstOrDefault(t => t.Id == id);
        }

    }
}
