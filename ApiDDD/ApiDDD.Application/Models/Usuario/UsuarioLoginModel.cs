using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ApiDDD.Application.Models.Usuario
{
    public class UsuarioLoginModel
    {
    

        [MaxLength(50, ErrorMessage = "Informe no minimo {1} caracteres")]
        [MinLength(3, ErrorMessage = "Informe no minimo {1} caracteres")]
        [Required(ErrorMessage = "Informe o Email do usuario")]
        public string Email { get; set; }

        [MaxLength(50, ErrorMessage = "Informe no minimo {1} caracteres")]
        [MinLength(6, ErrorMessage = "Informe no minimo {1} caracteres")]

        [Required(ErrorMessage = "Informe o Senha do usuario")]
        public string Senha { get; set; }

        
    }
}
