using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskRobo.DataAccess.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<AppUser>> GetUsersAsync();

        Task<bool> AuthenticatedAsync(string email, string password);
    }
}