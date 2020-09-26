using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace TaskRobo.DataAccess.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskRoboDbContext _taskRoboDbContext;

        public TaskRepository()
        {
            _taskRoboDbContext = new TaskRoboDbContext();
        }

        public async Task<IEnumerable<UserTask>> GetTasksAsync()
        {
            return await _taskRoboDbContext.UserTask.ToListAsync();
        }

        public Task<UserTask> GetTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserTask> AddTask(UserTask userTask)
        {
            throw new NotImplementedException();
        }

        public Task<UserTask> UpdateTask(UserTask userTask)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTask(int id)
        {
            throw new NotImplementedException();
        }
    }
}