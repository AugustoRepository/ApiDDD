using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Entities;
using ApiDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiDDD.Infra.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly DataContext dataContext;

        public UsuarioRepository(DataContext dataContext) : base(dataContext)
        {
            this.dataContext = dataContext;
        }
        public Usuario Get(string email)
        {
            return dataContext.Usuario.FirstOrDefault(u => u.Email.Equals(email));
        }

        public Usuario GetEmailAndSenha(string email, string senha)
        {
            return dataContext.Usuario.FirstOrDefault(u => u.Email.Equals(email) && u.Senha.Equals(senha));
        }
    }
}
