using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ApiDDD.Application.Models.Turma
{
    public class TurmaEdicaoModel
    {
        [Required(ErrorMessage ="informe o id da turma")]
        public Guid Id { get; set; }

        [MaxLength(150, ErrorMessage = "Informe no Maximo {1} caracteres")]
        [MinLength(6, ErrorMessage = "Informe no minimo {1} caracteres")]
        [Required(ErrorMessage = "Informe o nome do turma")]
        public string Nome { get; set; }

        [MaxLength(50, ErrorMessage = "Informe no Maximo {1} caracteres")]
        [MinLength(3, ErrorMessage = "Informe no minimo {1} caracteres")]
        [Required(ErrorMessage = "Informe o nome do perido")]
        public string Periodo { get; set; }

       
        [Required(ErrorMessage = "Informe o data de inicio")]
        public string DataInicio { get; set; }

        [Required(ErrorMessage = "Informe o data de termino")]
        public string DataTermino { get; set; }

        [Required(ErrorMessage = "Informe o Id  do professor")]
        public string IdProfessor { get; set; }
    }
}
