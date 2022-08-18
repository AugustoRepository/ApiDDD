using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiDDD.Infra.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DataContext dataContext;

        public BaseRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Alterar(T entity)
        {
            dataContext.Entry(entity).State = EntityState.Modified;
            dataContext.SaveChanges();
        }

        public void Excluir(T entity)
        {
            dataContext.Entry(entity).State = EntityState.Deleted;
            dataContext.SaveChanges();
        }

        public void Inserir(T entity)
        {
            dataContext.Entry(entity).State = EntityState.Added;
            dataContext.SaveChanges();
        }

        public T ObterPorId(Guid id)
        {
            return dataContext.Set<T>().Find();
        }

        public List<T> ObterTodos()
        {
            return dataContext.Set<T>().ToList();
        }
    }
}
