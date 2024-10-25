using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Agriculture_BussinessObjects.Models;
using Agriculture_Daos.Data;
using Agriculture_Services;

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.AdminPage
{
    public class CreateModel : PageModel
    {
        private readonly IUserService userService;
        private readonly IUserRoleService userRoleService;

        public CreateModel()
        {
            userService = new UserService();
            userRoleService = new UserRoleService();
        }

        public IActionResult OnGet()
        {
        ViewData["RoleId"] = new SelectList(userRoleService.GetAllUserRoles(), "RoleId", "RoleName");
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || userService == null || User == null)
            {
                return Page();
            }

            userService.AddUser(User);

            return RedirectToPage("./Index");
        }
    }
}
