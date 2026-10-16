namespace TodoManager05.Models;

public class TodosIndexViewModel
{
    public required string PageTitle { get; init; }

    public required IReadOnlyList<TodoListItemViewModel> Todos { get; init; }
}
