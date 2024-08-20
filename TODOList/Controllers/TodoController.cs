using Microsoft.AspNetCore.Mvc;

namespace TODOList.Controllers;

public class TodoController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}