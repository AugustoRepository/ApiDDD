using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ApiDDD.Application.Models.Turma
{
    public class TurmaCadastroModel
    {
        [MaxLength(150, ErrorMessage = "Informe no minimo {1} caracteres")]
        [MinLength(6,ErrorMessage ="Informe no minimo {1} caracteres")]
        [Required(ErrorMessage ="Informe o nome do aluno")]
        public string Nome { get; set; }

        [MaxLength(50, ErrorMessage = "Informe no minimo {1} caracteres")]
        [MinLength(3, ErrorMessage = "Informe no minimo {1} caracteres")]
        [Required(ErrorMessage = "Informe o matricula do aluno")]
        public string C { get; set; }

       
        [Required(ErrorMessage = "Informe o Email do aluno")]
        public string DataInicio { get; set; }

        [Required(ErrorMessage = "Informe o data de nascimento do aluno")]
        public string DataTermino { get; set; }
        [Required(ErrorMessage ="infome o Id do professor")]
        public string IdProfessor { get; set; }
    }
}
