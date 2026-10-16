using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TodoManager09.Controllers;

[Authorize]
public class TodosController : Controller
{
    [HttpGet("todos")]
    public IActionResult Index()
    {
        return View();
    }
}
