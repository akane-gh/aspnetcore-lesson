using Microsoft.AspNetCore.Mvc;
using TodoManager06.Models;

namespace TodoManager06.Controllers;

[Route("todos")]
public class TodosController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("new")]
    public IActionResult New()
    {
        return View();
    }

    [HttpPost("")]
    [ValidateAntiForgeryToken]
    public IActionResult Create(CreateTodoInputModel input)
    {
        if (!ModelState.IsValid)
        {
            return View("New", input);
        }

        return RedirectToAction(nameof(Index));
    }
}
