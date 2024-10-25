using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Agriculture_BussinessObjects.Models;
using Agriculture_Daos.Data;
using Agriculture_Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Agriculture_DTOs;

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.AdminPage
{
    public class IndexModel : PageModel
    {
        private readonly IUserService userService;
        private readonly IUserRoleService roleService;

        public IndexModel()
        {
            userService = new UserService();
            roleService = new UserRoleService();
        }

        public IList<UserDTO> User { get;set; } = default!;

        public Task OnGetAsync()
        {
            ViewData["RoleId"] = new SelectList(roleService.GetAllUserRoles(), "RoleId", "RoleName");
            if (userService != null)
            {
                User = userService.GetAllUsers();
            }
            return Task.CompletedTask;
        }
    }
}
