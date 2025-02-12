using ClickUp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ClickUp_API.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }
        public DbSet<TodoItem> TodoItems => Set<TodoItem>();
    }
}
