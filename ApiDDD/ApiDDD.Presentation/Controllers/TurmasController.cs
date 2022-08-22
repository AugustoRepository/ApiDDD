using ApiDDD.Application.Contracts;
using ApiDDD.Application.Models.Turma;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiDDD.Presentation.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TurmasController : ControllerBase
    {
        private readonly ITurmaApplicationServices turmaApplicationServices;
        public TurmasController(ITurmaApplicationServices turmaApplicationServices)
        {
            this.turmaApplicationServices = turmaApplicationServices;
        }

        [HttpPost]
        public IActionResult Post(TurmaCadastroModel model)
        {
            try
            {
                turmaApplicationServices.Inserir(model);
                return Ok("Turma cadastrada com sucesso.");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }
        [HttpPut]
        public IActionResult Put(TurmaEdicaoModel model)
        {
            try
            {
                turmaApplicationServices.Alterar(model);
                return Ok("Turma Alterada com sucesso.");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                turmaApplicationServices.Excluir(id);
                return Ok("Turma Excluida com sucesso.");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {

                return Ok(turmaApplicationServices.ObterTodos());
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {                
                return Ok(turmaApplicationServices.ObterPorId(id));
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }
    }
}
