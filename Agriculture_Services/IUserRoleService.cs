﻿using Agriculture_BussinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture_Services
{
    public interface IUserRoleService
    {
        bool AddUserRole(UserRole userRole);
        UserRole GetUserRole(int id);
        List<UserRole> GetAllUserRoles();
        bool UpdateUserRole(UserRole userRole);
        bool DeleteUserRole(int id);
    }
}
