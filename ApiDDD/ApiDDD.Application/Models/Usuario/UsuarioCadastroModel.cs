using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ApiDDD.Application.Models.Usuario
{
    public class UsuarioCadastroModel
    {
        [MaxLength(150, ErrorMessage = "Informe no minimo {1} caracteres")]
        [MinLength(6,ErrorMessage ="Informe no minimo {1} caracteres")]
        [Required(ErrorMessage ="Informe o nome do usuario")]
        public string Nome { get; set; }

        [MaxLength(50, ErrorMessage = "Informe no minimo {1} caracteres")]
        [MinLength(3, ErrorMessage = "Informe no minimo {1} caracteres")]
        [Required(ErrorMessage = "Informe o Email do usuario")]
        public string Email { get; set; }

        [MaxLength(50, ErrorMessage = "Informe no minimo {1} caracteres")]
        [MinLength(6, ErrorMessage = "Informe no minimo {1} caracteres")]
        [Required(ErrorMessage = "Informe o Senha do usuario")]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage ="Senhas nao conferem")]
        [Required(ErrorMessage = "Confirme a senha do usuario")]
        public string SenhaConfirmacao { get; set; }
       
    }
}
