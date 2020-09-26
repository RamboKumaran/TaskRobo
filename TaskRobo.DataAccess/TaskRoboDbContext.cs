using System.Data.Entity;

namespace TaskRobo.DataAccess
{
    public class TaskRoboDbContext : DbContext
    {
        // Your context has been configured to use a 'TaskRoboDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TaskRobo.DataAccess.TaskRoboDb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TaskRoboDb' 
        // connection string in the application configuration file.
        public TaskRoboDbContext()
            : base("name=TaskRoboDb")
        {
            Database.SetInitializer(new TaskRoboDbInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<UserTask> UserTask { get; set; }
    }
}