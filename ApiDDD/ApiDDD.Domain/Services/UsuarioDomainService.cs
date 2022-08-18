using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Contracts.Services;
using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Domain.Services
{
    public class UsuarioDomainService : BaseDomainService<Usuario>, IUsuarioDomainService
    {
        private readonly IUsuarioRepository usuarioRepository;
        public UsuarioDomainService(IUsuarioRepository UsuarioRepository) 
            : base(UsuarioRepository)
        {
            this.usuarioRepository = UsuarioRepository;
        }

        public Usuario Authenticate(string email, string senha)
        {
            var usuario = usuarioRepository.GetEmailAndSenha(email , senha);
        }

        public override void Inserir(Usuario obj)
        {
            #region validar dados repetidos no banco
            if (usuarioRepository.Get(obj.Email) != null)
            {
                throw new Exception("O Email informada ja encontra-se cadastrada");
            }

            #endregion

            usuarioRepository.Inserir(obj);
        }


    }
}
