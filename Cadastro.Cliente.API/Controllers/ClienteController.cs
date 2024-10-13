using Cadastro.Cliente.API.Domain.Entity;
using Cadastro.Cliente.API.Infraestructure.Data.AppData;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Cliente.API.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class ClienteController : Controller
{
    private readonly ApplicationContext _context;
    
    public ClienteController(ApplicationContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        var clientes = _context.Cliente.ToList();
        return Ok(clientes);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var cliente = _context.Cliente.FirstOrDefault(x => x.Id == id);
        return Ok(cliente);
    }
    
    [HttpPost]
    public IActionResult Post([FromBody] ClienteEntity entity)
    {
        _context.Cliente.Add(entity);
        _context.SaveChanges();

        return Ok(entity);
    }
    
    [HttpPut]
    public IActionResult Put(int id, [FromBody] ClienteEntity entity)
    {
        var cliente = _context.Cliente.FirstOrDefault(x => x.Id == entity.Id);
        
        if(cliente is not null)
        {
            cliente.Email = entity.Email;
            cliente.Idade = entity.Idade;
            cliente.Nome = entity.Nome;
            
            _context.Cliente.Update(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }
        return BadRequest("Cliente não encontrado");
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var cliente = _context.Cliente.FirstOrDefault(x => x.Id == id);
        
        if(cliente is not null)
        {
            _context.Cliente.Remove(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }
        return BadRequest("Cliente não encontrado");
    }
}