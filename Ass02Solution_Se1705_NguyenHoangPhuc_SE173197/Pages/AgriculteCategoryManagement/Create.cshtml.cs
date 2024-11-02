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

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.AgriculteCategoryManagement
{
    public class CreateModel : PageModel
    {
        private readonly IAgricultureCategoryService _context;

        public CreateModel(IAgricultureCategoryService context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AgricultureCategory AgricultureCategory { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context == null || AgricultureCategory == null)
            {
                return Page();
            }

            _context.AddAgricultureCategory(AgricultureCategory);

            return RedirectToPage("./Index");
        }
    }
}
