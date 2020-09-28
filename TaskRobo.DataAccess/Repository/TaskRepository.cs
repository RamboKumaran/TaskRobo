using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskRobo.DataAccess.Repository
{
    public class TaskRepository : ITaskRepository, IDisposable
    {
        private TaskRoboDbContext db = new TaskRoboDbContext();
        public IEnumerable<UserTask> GetTasks()
        {
          var tasks =   db.UserTask.ToList();

          return tasks;
        }

        public UserTask GetTask(int id)
        {
           return db.UserTask.Find(id);
        }

        public void AddTask(UserTask userTask)
        {
            db.UserTask.Add(userTask);
            db.SaveChanges();
        }

        public void UpdateTask(UserTask userTask)
        {
            db.Entry(userTask).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteTask(int id)
        {
            UserTask userTask = db.UserTask.Find(id);
            db.UserTask.Remove(userTask);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}