namespace TodoManager05.Models;

public class TodoListItemViewModel
{
    public int Id { get; init; }

    public required string Title { get; init; }

    public bool IsCompleted { get; init; }
}
