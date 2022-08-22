using ApiDDD.Application.Contracts;
using ApiDDD.Application.Models.Aluno;
using ApiDDD.Application.Models.Usuario;
using ApiDDD.Domain.Contracts.Services;
using ApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Application.Services
{
    public class UsuarioApplicationService : IUsuarioApplicationServices
    {
        private readonly IUsuarioDomainService usuarioDomainService;

        public UsuarioApplicationService(IUsuarioDomainService usuarioDomainService)
        {
            this.usuarioDomainService = usuarioDomainService;
        }

        public UsuarioConsultaModel Autenticar(UsuarioLoginModel model)
        {
            var usuario = usuarioDomainService.Authenticate(model.Email, model.Senha);
            return new UsuarioConsultaModel
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Email = usuario.Email,
                DataCriacao = usuario.DataCriacao.ToString("dd/MM/yyyy HH:mm")
            };
        }

        public void Inserir(UsuarioCadastroModel model)
        {
            var usuario = new Usuario
            {
                Id = Guid.NewGuid(),
                Nome = model.Nome,
                Email = model.Email,
                Senha = model.Senha,
                DataCriacao = DateTime.Now
            };
            usuarioDomainService.Inserir(usuario);
        }
    }
}
