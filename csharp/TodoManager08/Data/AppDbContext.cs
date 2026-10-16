using Microsoft.EntityFrameworkCore;
using TodoManager08.Models;

namespace TodoManager08.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Todo> Todos => Set<Todo>();
}
