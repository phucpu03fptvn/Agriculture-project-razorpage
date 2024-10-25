using Agriculture_BussinessObjects.Models;
using Agriculture_Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Principal;

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages
{
    public class LoginModel : PageModel
    {
        private IUserService userService;

        public LoginModel()
        {
            userService = new UserService();
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            string email = Request.Form["txtEmail"];
            string passWord = Request.Form["txtPassword"];

            User user = userService.GetUser(email);
            if (user != null && user.Password.Equals(passWord) && user.RoleId == 3)
            {
                Response.Redirect("/AgricultureProductPage/Index");
            } else if(user != null && user.Password.Equals(passWord) && user.RoleId == 1)
            {
                Response.Redirect("/AdminPage/Index");
            } else if(user != null && user.Password.Equals(passWord) && user.RoleId ==2)
            {
                Response.Redirect("/UserPage/Index");
            }




        }
    }
}
