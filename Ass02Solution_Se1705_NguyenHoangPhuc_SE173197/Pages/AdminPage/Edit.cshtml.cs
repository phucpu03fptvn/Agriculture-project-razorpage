using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Agriculture_BussinessObjects.Models;
using Agriculture_Daos.Data;
using Agriculture_Services;

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.AdminPage
{
    public class EditModel : PageModel
    {
        private readonly IUserService userService;
        private readonly IUserRoleService userRoleService;

        public EditModel()
        {
            userService = new UserService();
            userRoleService = new UserRoleService();
        }

        [BindProperty]
        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null || userService == null)
            {
                return NotFound();
            }

            var user =  userService.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            User = user;
           ViewData["RoleId"] = new SelectList(userRoleService.GetAllUserRoles(), "RoleId", "RoleName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                userService.UpdateUser(User);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(User.UserId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool UserExists(int id)
        {
            bool isSuccess = false;
            try
            {
                var userExist = userService.GetUser(id);
                if (userExist != null)
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
