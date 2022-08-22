using ApiDDD.Application.Models.Aluno;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Application.Models.Usuario

{
    public class UsuarioConsultaModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DataCriacao { get; set; }
       
    }
}
