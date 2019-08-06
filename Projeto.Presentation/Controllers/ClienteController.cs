using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.ViewModels;

namespace Projeto.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        //atributo
        private readonly IClienteAppService appService;

        //construtor para injeção de dependência
        public ClienteController(IClienteAppService appService)
        {
            this.appService = appService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClienteCadastroViewModel model)
        {
            if (!ModelState.IsValid) //se não passaram nas regras de validação
            {
                return BadRequest(); //Status de erro 400
            }

            try
            {
                appService.Cadastrar(model);
                return Ok($"Cliente '{model.Nome}', cadastrado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] ClienteEdicaoViewModel model)
        {
            if (!ModelState.IsValid) //se não passaram nas regras de validação
            {
                return BadRequest(); //Status de erro 400
            }

            try
            {
                appService.Atualizar(model);
                return Ok($"Cliente '{model.Nome}', atualizado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                appService.Excluir(id);
                return Ok($"Cliente excluído com sucesso.");
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
                return Ok(appService.ConsultarTodos());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(appService.ConsultarPorId(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}