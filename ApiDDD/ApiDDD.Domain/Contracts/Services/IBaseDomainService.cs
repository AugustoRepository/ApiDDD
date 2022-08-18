using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Contracts.Services
{
    public interface IBaseDomainService<T> where T : class
    {
        void Inserir(T obj);
        void Alterar(T obj);
        void Excluir(T obj);

        List<T> ObterTodos();

        T ObterPorId(Guid id);
    }
}
