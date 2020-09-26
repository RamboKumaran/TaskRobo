using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskRobo.Business.Model;

namespace TaskRobo.Business
{
  public   interface IUserDetails
  {
      Task<IEnumerable<AppUser>> GetUsersAsync();
  }
}
