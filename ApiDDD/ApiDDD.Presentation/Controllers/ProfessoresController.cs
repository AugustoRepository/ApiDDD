using ApiDDD.Application.Contracts;
using ApiDDD.Application.Models.Professor;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiDDD.Presentation.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {
        private readonly IProfessorApplicationServices professorApplicationServices;

        public ProfessoresController(IProfessorApplicationServices professorApplicationServices)
        {
            this.professorApplicationServices = professorApplicationServices;        
        }

        [HttpPost]
        public IActionResult Post(ProfessorCadastroModel model)
        {
            try
            {
                professorApplicationServices.Inserir(model);
                return Ok("Professor inserido com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(ProfessorEdicaoModel model)
        {
            try
            {
                professorApplicationServices.Alterar(model);
                return Ok("Professor Alterado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                professorApplicationServices.Excluir(id);
                return Ok("Professor excluido com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll(ProfessorEdicaoModel model)
        {
            try
            {
                return Ok(professorApplicationServices.ObterTodos());
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
                return Ok(professorApplicationServices.ObterPorId(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
