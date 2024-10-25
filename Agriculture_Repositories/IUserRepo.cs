using Agriculture_BussinessObjects.Models;
using Agriculture_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture_Repositories
{
    public interface IUserRepo
    {
        User GetUser(string email);
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int id);
        List<UserDTO> GetAllUsers();
        User GetUser(int id);
        UserDTO GetUserWithRole(int id);
    }
}
