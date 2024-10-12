using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Cliente.API.Controllers;

public class ClienteController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}