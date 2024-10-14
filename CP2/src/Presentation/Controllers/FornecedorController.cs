using CP2.API.Application.Interfaces;
using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Swashbuckle.AspNetCore.Annotations;

namespace CP2.API.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorApplicationService _applicationService;

        public FornecedorController(IFornecedorApplicationService applicationService)
        {
            _applicationService = applicationService;
        }


        [HttpGet]
        [SwaggerOperation(Summary = "Lista todos os fornecedores", Description = "Este endpoint retorna uma lista completa de todos os fornecedores cadastrados.")]
        [Produces<IEnumerable<FornecedorEntity>>]
        public IActionResult Get()
        {
            try
            {
                var fornecedores = _applicationService.ObterTodosFornecedores();
                if (fornecedores is null)
                    return NoContent();
                return Ok(fornecedores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Obtém um fornecedor específico", Description = "Este endpoint retorna os detalhes de um fornecedor específico com base no ID fornecido.")]
        [SwaggerResponse(200, "Fornecedor encontrado com sucesso", typeof(FornecedorEntity))]
        [SwaggerResponse(204, "Fornecedor não encontrado")]
        [SwaggerResponse(404, "Falha para obter o fornecedor")]
        [Produces(typeof(FornecedorEntity))]
        public IActionResult GetPorId(int id)
        {
            try
            {
                var fornecedor = _applicationService.ObterFornecedorPorId(id);
                if (fornecedor is null)
                    return NoContent();
                return Ok(fornecedor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [SwaggerOperation(Summary = "Cadastra um novo fornecedor", Description = "Este endpoint cria um novo fornecedor com base nas informações fornecidas.")]
        [SwaggerResponse(200, "Fornecedor criado com sucesso")]
        [SwaggerResponse(404, "Falha para inserir o fornecedor")]
        [Produces(typeof(FornecedorEntity))]

        public IActionResult Post([FromBody] FornecedorDto entity)
        {
            try
            {
                var fornecedor = _applicationService.SalvarDadosFornecedor(entity);
                return Ok(fornecedor);
            }
            catch(Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    status = HttpStatusCode.BadRequest,
                });
            }
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Atualiza um fornecedor existente", Description = "Este endpoint atualiza as informações de um fornecedor com base no ID fornecido.")]
        [SwaggerResponse(200, "Fornecedor atualizado com sucesso")]
        [SwaggerResponse(404, "Falha para atualizar o fornecedor")]
        [Produces(typeof(FornecedorEntity))]

        public IActionResult Put(int id, [FromBody] FornecedorDto entity)
        {
            try
            {
                var fornecedor = _applicationService.EditarDadosFornecedor(id, entity);
                return Ok(fornecedor);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    status = HttpStatusCode.BadRequest,
                });
            }
        }


        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Remove um fornecedor existente", Description = "Este endpoint remove as informações de um fornecedor com base no ID fornecido.")]
        [SwaggerResponse(200, "Fornecedor removido com sucesso")]
        [SwaggerResponse(404, "Falha para excluir o fornecedor")]
        [Produces(typeof(FornecedorEntity))]
        public IActionResult Delete(int id)
        {
            try
            {
                var fornecedor = _applicationService.DeletarDadosFornecedor(id);
                return Ok(fornecedor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
