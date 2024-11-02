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

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.AgriculteCategoryManagement
{
    public class EditModel : PageModel
    {
        private readonly IAgricultureCategoryService _context;

        public EditModel(IAgricultureCategoryService context)
        {
            _context = context;
        }

        [BindProperty]
        public AgricultureCategory AgricultureCategory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null || _context == null)
            {
                return NotFound();
            }

            var agriculturecategory =   _context.GetAgricultureCategory(id);
            if (agriculturecategory == null)
            {
                return NotFound();
            }
            AgricultureCategory = agriculturecategory;
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
                _context.UpdateAgricultureCategory(AgricultureCategory);
            }
            catch (DbUpdateConcurrencyException)
            {
                
                    throw;
            
            }

            return RedirectToPage("./Index");
        }

        private bool AgricultureCategoryExists(int id)
        {
            bool isSuccess = false;
            try
            {
                var userExist = _context.GetAgricultureCategory(id);
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
