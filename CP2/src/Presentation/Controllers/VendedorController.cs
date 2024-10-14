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
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorApplicationService _applicationService;

        public VendedorController(IVendedorApplicationService applicationService)
        {
            _applicationService = applicationService;
        }


        [HttpGet]
        [SwaggerOperation(Summary = "Lista todos os vendedores", Description = "Este endpoint retorna uma lista completa de todos os vendedores cadastrados.")]
        [Produces<IEnumerable<VendedorEntity>>]
        public IActionResult Get()
        {
            try
            {
                var vendedores = _applicationService.ObterTodosVendedores();
                if (vendedores is null)
                    return NoContent();
                    
                return Ok(vendedores);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Obtém um vendedor específico", Description = "Este endpoint retorna os detalhes de um vendedor específico com base no ID fornecido.")]
        [SwaggerResponse(200, "Vendedor encontrado com sucesso", typeof(VendedorEntity))]
        [SwaggerResponse(204, "vendedor não encontrado")]
        [SwaggerResponse(404, "Falha para obter o vendedor")]
        [Produces(typeof(VendedorEntity))]
        public IActionResult GetPorId(int id)
        {
            try
            {
                var vendedor = _applicationService.ObterVendedorPorId(id);
                if (vendedor is null)
                    return NoContent();
                return Ok(vendedor);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [SwaggerOperation(Summary = "Cadastra um novo vendedor", Description = "Este endpoint cria um novo vendedor com base nas informações fornecidas.")]
        [SwaggerResponse(200, "Vendedor criado com sucesso")]
        [SwaggerResponse(404, "Falha para inserir o vendedor")]
        [Produces(typeof(VendedorEntity))]
        public IActionResult Post([FromBody] VendedorDto entity)
        {
            try
            {
                var vendedor = _applicationService.SalvarDadosVendedor(entity);
                return Ok(vendedor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Atualiza um vendedor existente", Description = "Este endpoint atualiza as informações de um vendedor com base no ID fornecido.")]
        [SwaggerResponse(200, "Vendedor atualizado com sucesso")]
        [SwaggerResponse(404, "Falha para atualizar o vendedor")]
        [Produces(typeof(VendedorEntity))]
        public IActionResult Put(int id, [FromBody] VendedorDto entity)
        {
            try
            {
                var vendedor = _applicationService.EditarDadosVendedor(id, entity);
                return Ok(vendedor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Remove um vendedor existente", Description = "Este endpoint remove as informações de um vendedor com base no ID fornecido.")]
        [SwaggerResponse(200, "Vendedor removido com sucesso")]
        [SwaggerResponse(404, "Falha para excluir o vendedor")]
        [Produces(typeof(VendedorEntity))]

        public IActionResult Delete(int id)
        {
            try
            {
                var vendedor = _applicationService.DeletarDadosVendedor(id);
                return Ok(vendedor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
