using ApiDDD.Application.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Application.Contracts
{
    public interface IUsuarioApplicationServices
    {
        void Inserir(UsuarioCadastroModel model);
        UsuarioConsultaModel  Autenticar(UsuarioLoginModel model);
    }
}
