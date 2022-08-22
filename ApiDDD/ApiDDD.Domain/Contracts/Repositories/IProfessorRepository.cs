using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Contracts.Repositories
{
    public interface IProfessorRepository : IBaseRepository<Professor>
    {
        Professor ObeterPorCpf(string cpf);
    }
}
