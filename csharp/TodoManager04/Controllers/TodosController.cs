using Microsoft.AspNetCore.Mvc;

namespace TodoManager04.Controllers;

[Route("todos")]
public class TodosController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("{id:int}")]
    public IActionResult Details(int id)
    {
        return View(model: id);
    }

    [HttpGet("new")]
    public IActionResult New()
    {
        return View();
    }

    [HttpPost("")]
    public IActionResult Create()
    {
        return RedirectToAction(nameof(Index));
    }
}
