using Agriculture_BussinessObjects.Models;
using Agriculture_Services;
using Agriculture_Services.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages
{
    public class DetailsProductModel : PageModel
    {
        private readonly IAgricultureProductService _agricultureProductService;
        private readonly IAgricultureCategoryService _agricultureCategoryService;

        public DetailsProductModel(IAgricultureProductService agricultureProductService, IAgricultureCategoryService agricultureCategoryService)
        {
            _agricultureProductService = agricultureProductService;
            _agricultureCategoryService = agricultureCategoryService;
        }

        public AgricultureProduct Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            ViewData["CategoryId"] = new SelectList(_agricultureCategoryService.GetAllAgricultureCategories(), "CategoryId", "CategoryName");
            Product =  _agricultureProductService.GetAgricultureProduct(id);

            if (Product == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
