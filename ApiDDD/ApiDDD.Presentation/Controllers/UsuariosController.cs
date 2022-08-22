using ApiDDD.Application.Contracts;
using ApiDDD.Application.Models.Usuario;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiDDD.Presentation.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioApplicationServices usuarioApplicationService;

        public UsuariosController(IUsuarioApplicationServices usuarioApplicationService)
        {
            this.usuarioApplicationService = usuarioApplicationService;
        }

        [HttpPost]
        public IActionResult Post(UsuarioCadastroModel model)
        {
            try
            {
                usuarioApplicationService.Inserir(model);
                return Ok("Usuario cadastrado com sucesso");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
