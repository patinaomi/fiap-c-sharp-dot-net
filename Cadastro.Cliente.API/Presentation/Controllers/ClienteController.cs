using Cadastro.Cliente.API.Domain.Entity;
using Cadastro.Cliente.API.Domain.Interface;
using Cadastro.Cliente.API.Infraestructure.Data.AppData;
using Cadastro.Cliente.API.Infraestructure.Data.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Cliente.API.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class ClienteController : Controller
{
    private readonly IClienteRepository _clienteRepository;
    
    public ClienteController(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        var clientes = _clienteRepository.ObterTodos();
        return Ok(clientes);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var cliente = _clienteRepository.ObterPorId(id);
        return Ok(cliente);
    }
    
    [HttpPost]
    public IActionResult Post([FromBody] ClienteEntity entity)
    {
        var cliente = _clienteRepository.SalvarDados(entity);

        return Ok(cliente);
    }
    
    [HttpPut]
    public IActionResult Put(int id, [FromBody] ClienteEntity entity)
    {
        try
        {
            var cliente = _clienteRepository.EditarDados(entity);

            if (cliente is null)
            {
                return NoContent();
            }
            return Ok(cliente);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        try
        {
            var cliente = _clienteRepository.DeletarDados(id);

            if (cliente is null)
            {
                return NoContent();
            }
            return Ok(cliente);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}