using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ApiDDD.Application.Models.Aluno
{
    public class AlunoCadastroModel
    {
        [MaxLength(150, ErrorMessage = "Informe no minimo {1} caracteres")]
        [MinLength(6,ErrorMessage ="Informe no minimo {1} caracteres")]
        [Required(ErrorMessage ="Informe o nome do aluno")]
        public string Nome { get; set; }

        [MaxLength(150, ErrorMessage = "Informe no minimo {1} caracteres")]
        [MinLength(6, ErrorMessage = "Informe no minimo {1} caracteres")]
        [Required(ErrorMessage = "Informe o matricula do aluno")]
        public string Matricula { get; set; }

        [EmailAddress(ErrorMessage = "Infome um endereco de email valido")]
        [Required(ErrorMessage = "Informe o Email do aluno")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o data de nascimento do aluno")]
        public string DataNascimento { get; set; }
    }
}
