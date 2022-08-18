using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Contracts.Services
{
    public interface IUsuarioDomainService : IBaseDomainService<Usuario>
    {
        Usuario Authenticate(string email, string senha);
    }
}
