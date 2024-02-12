using Microsoft.EntityFrameworkCore;
using ToDoMigrations.Db.Entities;

namespace ToDoMigrations.Db
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDoEntity> ToDoEntities { get; set; }
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {
            
        }


    }
}
