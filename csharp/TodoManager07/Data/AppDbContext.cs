using Microsoft.EntityFrameworkCore;
using TodoManager07.Models;

namespace TodoManager07.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Todo> Todos => Set<Todo>();
}
