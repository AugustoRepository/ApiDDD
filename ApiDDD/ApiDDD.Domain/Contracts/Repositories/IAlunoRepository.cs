using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Contracts.Repositories
{
    public interface IAlunoRepository : IBaseRepository<Aluno>
    {
        Aluno ObterPorMatricula(string matricula);
        Aluno ObterPorEmail(string email);
    }
}
