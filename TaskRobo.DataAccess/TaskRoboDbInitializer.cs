using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
                new AppUser {Email = "prasanna@taskrobo.com", Password = "prasanna"}
            };

            context.AppUser.AddRange(appUsers);
            context.SaveChanges();

            IList<Category> categories = new List<Category>()
            {
                new Category() { CategoryTitle = "All Categories", UserId = appUsers.First(x=>x.Email == "ram@taskrobo.com").Id },
                new Category() { CategoryTitle = "Development", UserId = appUsers.First(x=>x.Email == "ram@taskrobo.com").Id },
                new Category() { CategoryTitle = "Testing", UserId = appUsers.First(x=>x.Email == "ram@taskrobo.com").Id },
                new Category() { CategoryTitle = "Manage", UserId = appUsers.First(x=>x.Email == "ram@taskrobo.com").Id },

                new Category() { CategoryTitle = "All Categories", UserId = appUsers.First(x=>x.Email == "ram@taskrobo.com").Id },
                new Category() { CategoryTitle = "Testing", UserId = appUsers.First(x=>x.Email == "prasanna@taskrobo.com").Id },
            };

            context.Category.AddRange(categories);
            context.SaveChanges();

            IList<UserTask> userTasks = new List<UserTask>()
            {
                new UserTask()
                {
                    Category = categories.First(x=>x.CategoryTitle == "All Categories" && x.UserId == appUsers.First(y=>y.Email == "ram@taskrobo.com").Id),
                    User =  appUsers.FirstOrDefault(),
                    TaskStatus = "Open",
                    TaskContent = "Employee - Create the feature details, develop and test it",
                    TaskTitle = "Feature creation of Employee",
                },

                new UserTask()
                {
                    Category = categories.First(x=>x.CategoryTitle == "Development" && x.UserId == appUsers.First(y=>y.Email == "ram@taskrobo.com").Id),
                    User =  appUsers.FirstOrDefault(),
                    TaskStatus = "Open",
                    TaskContent = "Feature creation - Development",
                    TaskTitle = "Feature creation - Development",
                },

                new UserTask()
                {
                    Category = categories.First(x=>x.CategoryTitle == "Testing" && x.UserId == appUsers.First(y=>y.Email == "prasanna@taskrobo.com").Id),
                    User =  appUsers.FirstOrDefault(),
                    TaskStatus = "Open",
                    TaskContent = "Feature creation - Testing",
                    TaskTitle = "Feature creation - Testing",
                },
            };

            context.UserTask.AddRange(userTasks);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}