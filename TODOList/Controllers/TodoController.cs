global using TODOList.Models;
global using TODOList.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;



    public class TodoController : Controller
    {
        List<Todo> TODOs = new List<Todo>
        {
            new Todo { Id = 1, Tarefa = "Estudar C#", Descricao = "Estudar mais" },
            new Todo { Id = 2, Tarefa = "Estudar ASP.NET", Descricao = "Aprender sobre MVC" },
            new Todo { Id = 3, Tarefa = "Praticar C#", Descricao = "Praticar com projetos pequenos" },
            new Todo { Id = 4, Tarefa = "Ler Documentação", Descricao = "Ler a documentação do .NET" },
            new Todo { Id = 5, Tarefa = "Assistir tutoriais", Descricao = "Ver vídeos sobre ASP.NET" },
        };

        // GET
        public IActionResult Index()
        {
            return View(TODOs); // Retorna a lista de TODOs para a view
        }
    }