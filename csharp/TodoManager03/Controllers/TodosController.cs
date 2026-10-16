using Microsoft.AspNetCore.Mvc;

namespace TodoManager03.Controllers;

public class TodosController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
