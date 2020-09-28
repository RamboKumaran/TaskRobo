using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using static TaskRobo.DataAccess.Common.Enum;

namespace TaskRobo.DataAccess
{
    public class TaskRoboDbInitializer : DropCreateDatabaseAlways<TaskRoboDbContext>
    {
        protected override void Seed(TaskRoboDbContext context)
        {
            IList<AppUser> appUsers = new List<AppUser>
            {
                new AppUser {Email = "admin@taskrobo.com", Password = "admin"},
                new AppUser {Email = "ram@taskrobo.com", Password = "ram"},
                new AppUser {Email = "srini@taskrobo.com", Password = "srini"},
                new AppUser {Email = "prasanna@taskrobo.com", Password = "prasanna"},
                new AppUser {Email = "saravanan@taskrobo.com", Password = "saravanan"}
            };

            context.AppUser.AddRange(appUsers);
            context.SaveChanges();

            IList<Category> categories = new List<Category>()
            {
                new Category()
                { 
                    CategoryTitle = "Development", 
                    UserId = appUsers.First(x=>x.Email == "ram@taskrobo.com").Id 
                },
                new Category() 
                { 
                    CategoryTitle = "Unit Testing", 
                    UserId = appUsers.First(x=>x.Email == "ram@taskrobo.com").Id 
                },
                new Category() 
                { 
                    CategoryTitle = "Manager", 
                    UserId = appUsers.First(x=>x.Email == "prasanna@taskrobo.com").Id 
                },
                new Category() 
                { 
                    CategoryTitle = "Testing", 
                    UserId = appUsers.First(x=>x.Email == "saravanan@taskrobo.com").Id 
                },
                new Category() 
                { 
                    CategoryTitle = "Development", 
                    UserId = appUsers.First(x=>x.Email == "srini@taskrobo.com").Id 
                },
            };

            context.Category.AddRange(categories);
            context.SaveChanges();

            IList<UserTask> userTasks = new List<UserTask>()
            {
                new UserTask()
                {
                    TaskTitle = "Feature 1 Task Robo Development",
                    TaskContent = "Task Robo  - Create the feature details, develop and test it",
                    TaskStatus = TaskStatus.InProgress.ToString(),
                    Category = categories.First(x=>x.CategoryTitle == "Development" && x.UserId == appUsers.First(y=>y.Email == "ram@taskrobo.com").Id),
                    User =  appUsers.FirstOrDefault(),
                },

                new UserTask()
                {
                    TaskTitle = "Feature 1 Task Robo Unit Testing",
                    TaskContent = "Task Robo  - Create the feature details, Unit Testing",
                    TaskStatus = "ToDo",
                    Category = categories.First(x=>x.CategoryTitle == "Unit Testing" && x.UserId == appUsers.First(y=>y.Email == "ram@taskrobo.com").Id),
                    User =  appUsers.FirstOrDefault(),
                },

                new UserTask()
                {
                    TaskTitle = "Feature 2 Task Robo Development",
                    TaskContent = "Task Robo  - Create the feature details, develop and test it",
                    TaskStatus = "Open",
                    Category = categories.First(x=>x.CategoryTitle == "Development" && x.UserId == appUsers.First(y=>y.Email == "srini@taskrobo.com").Id),
                    User =  appUsers.FirstOrDefault(),
                },

                new UserTask()
                {
                    TaskTitle = "Task Robo - Project Manageent",
                    TaskContent = "Task Robo - Project requirement and resource planning",
                    TaskStatus = "Open",
                    Category = categories.First(x=>x.CategoryTitle == "Manager" && x.UserId == appUsers.First(y=>y.Email == "prasanna@taskrobo.com").Id),
                    User =  appUsers.FirstOrDefault(),
                },
            };

            context.UserTask.AddRange(userTasks);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}