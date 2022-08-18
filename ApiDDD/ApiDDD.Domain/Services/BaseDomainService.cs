using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Services
{
    public class BaseDomainService<T> : IBaseDomainService<T> where T : class
    {
        private readonly IBaseRepository<T> baseRepository;

        public BaseDomainService(IBaseRepository<T> baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public virtual void Alterar(T obj)
        {
            baseRepository.Alterar(obj);
        }

        public virtual void Excluir(T obj)
        {
            baseRepository.Excluir(obj);
        }

        public virtual void Inserir(T obj)
        {
            baseRepository.Inserir(obj);
        }

        public virtual T ObterPorId(Guid id)
        {
           return baseRepository.ObterPorId(id);
        }

        public List<T> ObterTodos()
        {
            return baseRepository.ObterTodos();
        }
    }
}
