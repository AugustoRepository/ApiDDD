using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Contracts.Repositories
{
    public interface IBaseRepository<T> where T : class 
    {
        void Inserir(T entity); 
        void Alterar(T entity); 
        void Excluir(T entity); 

        List<T> ObterTodos();

        T ObterPorId(Guid id);
    }   
}
