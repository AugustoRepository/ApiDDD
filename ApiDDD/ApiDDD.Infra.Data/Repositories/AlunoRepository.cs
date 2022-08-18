using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Entities;
using ApiDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiDDD.Infra.Data.Repositories
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        private readonly DataContext dataContext;

        public AlunoRepository(DataContext dataContext) :base(dataContext)
        {

        }
        public Aluno ObterPorEmail(string email)
        {
            return dataContext.Aluno.FirstOrDefault(a => a.Email.Equals(email));
        }

        public Aluno ObterPorMatricula(string matricula)
        {
            return dataContext.Aluno.FirstOrDefault(a => a.Matricula.Equals(matricula));
        }
    }
}
