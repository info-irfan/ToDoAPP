using Microsoft.EntityFrameworkCore;
using ToDo.Model.Model;

namespace ToDo.DataAccess.Repository
{
    public class ToDoDBContext: DbContext
    {
       public ToDoDBContext(DbContextOptions<ToDoDBContext>options):base(options)
        {

        }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<TaskReminder> TaskReminder { get; set; }
    }
}
