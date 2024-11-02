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

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.AgricultureProductPage
{
    public class DetailsModel : PageModel
    {
        private readonly IAgricultureProductService _agricultureProductService;
        private readonly IAgricultureCategoryService _agricultureCategoryService;

        public DetailsModel(IAgricultureProductService agricultureProductService, IAgricultureCategoryService agricultureCategoryService)
        {
            _agricultureProductService = agricultureProductService;
            _agricultureCategoryService = agricultureCategoryService;
        }

      public AgricultureProduct AgricultureProduct { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _agricultureProductService == null)
                if (id == null || _agricultureProductService == null)
                {
                    return NotFound();
                }

            var agricultureproduct = _agricultureProductService.GetAgricultureProduct(id);
            if (agricultureproduct == null)
            {
                return NotFound();
            }
            AgricultureProduct = agricultureproduct;
            ViewData["CategoryId"] = new SelectList(_agricultureCategoryService.GetAllAgricultureCategories(), "CategoryId", "CategoryName");
            return Page();
        }
    }
}
