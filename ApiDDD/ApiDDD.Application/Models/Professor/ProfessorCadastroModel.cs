using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ApiDDD.Application.Models.Professor
{
    public class ProfessorCadastroModel
    {
        [MaxLength(150, ErrorMessage = "Informe no minimo {1} caracteres")]
        [MinLength(6,ErrorMessage ="Informe no minimo {1} caracteres")]
        [Required(ErrorMessage = "Informe o nome do professor")]
        public string Nome { get; set; }

        [MaxLength(150, ErrorMessage = "Informe no minimo {1} caracteres")]
        [MinLength(6, ErrorMessage = "Informe no minimo {1} caracteres")]
        [Required(ErrorMessage = "Informe o Cpf do professor")]
        public string Cpf { get; set; }

    }
}
