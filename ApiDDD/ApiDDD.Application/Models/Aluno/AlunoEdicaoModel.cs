using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ApiDDD.Application.Models.Aluno
{
    public class AlunoEdicaoModel
    {
        [Required(ErrorMessage ="informe o id do aluno")]
        public Guid Id { get; set; }

        [MinLength(6, ErrorMessage ="infome no minimo{1} caracteres")]
        [MaxLength(150, ErrorMessage ="infome no minimo{1} caracteres")]
        [Required(ErrorMessage = "informe o Nome do aluno")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "informe o data nascimento do aluno")]
        public string DataNascimento { get; set; }

    }
}
