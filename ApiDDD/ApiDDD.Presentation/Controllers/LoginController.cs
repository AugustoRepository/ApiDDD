using ApiDDD.Application.Contracts;
using ApiDDD.Application.Models.Usuario;
using ApiDDD.Presentation.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiDDD.Presentation.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioApplicationServices usuarioApplicationServices;
        private readonly JwtAuthorization jwtAuthorization;

        public LoginController(IUsuarioApplicationServices usuarioApplicationServices, JwtAuthorization jwtAuthorization)
        {
            this.usuarioApplicationServices = usuarioApplicationServices;
            this.jwtAuthorization = jwtAuthorization;
        }

        [HttpPost]
        public IActionResult Post(UsuarioLoginModel model)
        {
            try
            {
                var usuario = usuarioApplicationServices.Autenticar(model);

                return Ok(new
                {
                    usuario,
                    token =jwtAuthorization.GenarateToken(usuario.Email)
                }); ;
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
