using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskRobo.DataAccess.Repository
{
    public interface ITaskRepository
    {
        Task<IEnumerable<UserTask>> GetTasksAsync();

        Task<UserTask> GetTaskAsync(int id);

        Task<UserTask> AddTask(UserTask userTask);

        Task<UserTask> UpdateTask(UserTask userTask);

        Task<bool> DeleteTask(int id);
    }
}