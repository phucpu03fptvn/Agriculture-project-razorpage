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

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.AgricultureProductPage
{
    public class CreateModel : PageModel
    {
        private readonly IAgricultureProductService _agricultureProductService;
        private readonly IAgricultureCategoryService _agricultureCategoryService;

        public CreateModel(IAgricultureProductService agricultureProductService)
        {
            _agricultureProductService = agricultureProductService;
            _agricultureCategoryService = new AgricultureCategoryService();
        }

        public IActionResult OnGet()
        {
        ViewData["CategoryId"] = new SelectList(_agricultureCategoryService.GetAllAgricultureCategories(), "CategoryId", "CategoryName");
            return Page();
        }

        [BindProperty]
        public AgricultureProduct AgricultureProduct { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _agricultureProductService.AddAgricultureProduct == null || AgricultureProduct == null)
            {
                return Page();
            }

            _agricultureProductService.AddAgricultureProduct(AgricultureProduct);

            return RedirectToPage("./Index");
        }
    }
}
