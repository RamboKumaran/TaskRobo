using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskRobo.DataAccess.Repository
{
    public interface ITaskRepository
    {
        IEnumerable<UserTask> GetTasks();

        UserTask GetTask(int id);

        void AddTask(UserTask userTask);

        void UpdateTask(UserTask userTask);

        void DeleteTask(int id);
    }
}