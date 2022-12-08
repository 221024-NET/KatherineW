using Microsoft.EntityFrameworkCore;

namespace ToDoAPI.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext>)
            :base(options)
        {

        }

        public DbSet<ToDoItem> ToDo {get; set;}
    }
}