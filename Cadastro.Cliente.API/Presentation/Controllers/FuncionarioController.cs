using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Cliente.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FuncionarioController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Funcionário");
    }
}