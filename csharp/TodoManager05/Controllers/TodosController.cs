using Microsoft.AspNetCore.Mvc;
using TodoManager05.Models;

namespace TodoManager05.Controllers;

public class TodosController : Controller
{
    public IActionResult Index()
    {
        var model = new TodosIndexViewModel
        {
            PageTitle = "TODO 一覧",
            Todos =
            [
                new() { Id = 1, Title = "Razor を読む", IsCompleted = true },
                new() { Id = 2, Title = "詳細画面を作る", IsCompleted = false },
            ],
        };

        return View(model);
    }

    public IActionResult Details(int id)
    {
        var model = new TodoListItemViewModel
        {
            Id = id,
            Title = "詳細画面を作る",
            IsCompleted = false,
        };

        return View(model);
    }
}
