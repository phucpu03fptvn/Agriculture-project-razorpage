using Agriculture_BussinessObjects.Models;
using Agriculture_Daos;
using Agriculture_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture_Repositories
{
    public class UserRepo : IUserRepo
    {
        public bool AddUser(User user)
        {
            bool isSuccess = false;
            try
            {
                user.CreateAt = DateTime.Now;
                user.UpdateAt = DateTime.Now;
                UserDAO.Instance.AddUser(user);
                isSuccess = true;
            }
            catch (Exception)
            {

                throw;
            }
            return isSuccess;
        }

        public bool DeleteUser(int id) => UserDAO.Instance.DeleteUser(id);

        public List<UserDTO> GetAllUsers() => UserDAO.Instance.GetAllUsers();

        public User GetUser(string email) => UserDAO.Instance.GetUser(email);

        public User GetUser(int id) => UserDAO.Instance.GetUser(id);

        public UserDTO GetUserWithRole(int id) => UserDAO.Instance.GetUserWithRole(id);

        public bool UpdateUser(User user)
        {
            bool isSuccess = false;
            try
            {
                user.UpdateAt = DateTime.Now;
                UserDAO.Instance.UpdateUser(user);
                isSuccess = true;
            }
            catch (Exception)
            {

                throw;
            }
            return isSuccess;
        }
    }
}
