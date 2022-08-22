using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDDD.Application.Models.Aluno
{
    public class AlunoConsultaModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
