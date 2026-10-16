using Microsoft.AspNetCore.Mvc;
using TodoManager08.Services;

namespace TodoManager08.Controllers;

public class TodosController(ITodoService todoService) : Controller
{
    [HttpGet("todos")]
    public async Task<IActionResult> Index()
    {
        var todos = await todoService.GetIncompleteAsync();
        return View(todos);
    }
}
