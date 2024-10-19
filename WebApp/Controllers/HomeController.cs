using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        return View();
    }

    [Route("/pagina/anonima")]
    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Listar()
    {
        var listaAula = new List<AulaModel>
        {
            new AulaModel { Nome = "nome 1", Turma = "turma 1" },
            new AulaModel { Nome = "nome 2", Turma = "turma 2" },
            new AulaModel { Nome = "nome 3", Turma = "turma 3" }
        };
        return View(listaAula);
    }

    
    public IActionResult Aula()
    {
        var aula = new AulaModel()
        {
            Nome = ".NET",
            Turma = "SPR"
        };
        
        return View(aula);
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Cadastrar(AulaModel model)
    {
        if (ModelState.IsValid)
        {
        //Salvar dados no banco
        return RedirectToAction("Listar");
        }
            
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}