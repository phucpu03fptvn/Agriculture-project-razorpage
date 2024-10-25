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
    public class DetailsModel : PageModel
    {
        private readonly IUserService userService;
        private readonly IUserRoleService userRoleService;

        public DetailsModel()
        {
            userService = new UserService();
            userRoleService = new UserRoleService();
        }

      public UserDTO User { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int id)
        {
            ViewData["RoleId"] = new SelectList(userRoleService.GetAllUserRoles(), "RoleId", "RoleName");
            if (id == null ||userService == null)
            {
                return NotFound();
            }

            var user = userService.GetUserWithRole(id);
            if (user == null)
            {
                return NotFound();
            }
            else 
            {
                User = user;
            }
            return Page();
        }
    }
}
