using ApiDDD.Application.Contracts;
using ApiDDD.Application.Models.Aluno;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiDDD.Presentation.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly IAlunoApplicationServices alunoApplicationServices;

        public AlunosController(IAlunoApplicationServices alunoApplicationServices)
        {
            this.alunoApplicationServices = alunoApplicationServices;
        }
        [HttpPost]
        public IActionResult Post(AlunoCadastroModel model)
        {
            try
            {
                alunoApplicationServices.Inserir(model);
                return Ok("Aluno cadastrado com sucesso");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(AlunoEdicaoModel model)
        {
            try
            {
                alunoApplicationServices.Alterar(model);
                return Ok("Aluno alterado com sucesso");
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
                alunoApplicationServices.Excluir(id);
                return Ok("Aluno deletado com sucesso");
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
                
                return Ok(alunoApplicationServices.ObterTodos());
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

                return Ok(alunoApplicationServices.ObterPorId(id));
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }
    }
}
