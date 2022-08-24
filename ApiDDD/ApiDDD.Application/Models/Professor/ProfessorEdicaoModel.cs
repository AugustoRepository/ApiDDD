using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDDD.Application.Models.Professor
{
    public class ProfessorEdicaoModel
    {
        [Required(ErrorMessage ="infomre o id do professore")]
        public Guid Id { get; set; }

        [MinLength(6, ErrorMessage ="informe no minimo {1} caracteres")]
        [MaxLength(150, ErrorMessage ="informe no maximo {1} caracteres")]
        [Required(ErrorMessage = "infomre o id do professore")]
        public string Nome { get; set; }
    }
}
