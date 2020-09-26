using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskRobo.Business.Model;
using TaskRobo.DataAccess.Repository;

namespace TaskRobo.Business
{
   public  class UserDetails : IUserDetails
   {
       private readonly IUserRepository _userRepository;
        public UserDetails()
        {
            _userRepository = new UserRepository();
        }
        public async Task<IEnumerable<AppUser>> GetUsersAsync()
        {
            var users = await _userRepository.GetUsersAsync();

            return users.Select(x => new AppUser()
            {
                Email = x.Email,
                Password = x.Password
            });
        }
    }
}
