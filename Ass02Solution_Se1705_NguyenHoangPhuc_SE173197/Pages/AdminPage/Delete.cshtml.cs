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
using Agriculture_DTOs;

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.AdminPage
{
    public class DeleteModel : PageModel
    {
        private readonly IUserService userService;

        public DeleteModel()
        {
            userService = new UserService();
        }

        [BindProperty]
      public UserDTO User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null || userService == null)
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

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (id == null ||userService == null)
            {
                return NotFound();
            }
            var user = userService.GetUser(id);

            if (user != null)
            {
                userService.DeleteUser(id);
            }

            return RedirectToPage("./Index");
        }
    }
}
