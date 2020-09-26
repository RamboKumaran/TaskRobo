using System.Collections.Generic;
using System.Data.Entity;

namespace TaskRobo.DataAccess
{
    public class TaskRoboDbInitializer : DropCreateDatabaseAlways<TaskRoboDbContext>
    {
        protected override void Seed(TaskRoboDbContext context)
        {
            IList<AppUser> appUsers = new List<AppUser>
            {
                new AppUser {Email = "admin@taskrobo.com", Password = "admin"},
                new AppUser {Email = "ram@taskrobo.com", Password = "ram"}
            };

            context.AppUser.AddRange(appUsers);

            base.Seed(context);
        }
    }
}