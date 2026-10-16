using Microsoft.EntityFrameworkCore;
using TodoManager08.Data;
using TodoManager08.Models;

namespace TodoManager08.Services;

public interface ITodoService
{
    Task<List<Todo>> GetIncompleteAsync();
}

public class TodoService(AppDbContext db, ILogger<TodoService> logger) : ITodoService
{
    public async Task<List<Todo>> GetIncompleteAsync()
    {
        logger.LogInformation("未完了の TODO を取得します");

        return await db.Todos
            .Where(todo => !todo.IsCompleted)
            .OrderByDescending(todo => todo.CreatedAt)
            .ToListAsync();
    }
}
