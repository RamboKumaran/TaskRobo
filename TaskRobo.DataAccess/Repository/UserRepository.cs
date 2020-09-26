using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace TaskRobo.DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly TaskRoboDbContext _taskRoboDbContext;

        public UserRepository()
        {
            _taskRoboDbContext = new TaskRoboDbContext();
        }

        public async Task<IEnumerable<AppUser>> GetUsersAsync()
        {
            return await _taskRoboDbContext.AppUser.ToListAsync();
        }
    }
}