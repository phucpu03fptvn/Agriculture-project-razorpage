using Agriculture_BussinessObjects.Models;
using Agriculture_Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.UserPage
{
    public class DetailsModel : PageModel
    {
        private readonly IAgricultureProductService agricultureProductService;
        private readonly IAgricultureCategoryService agricultureCategoryService;

        public DetailsModel()
        {
            agricultureProductService = new AgricultureProductService();
            agricultureCategoryService = new AgricultureCategoryService();
        }

        public AgricultureProduct AgricultureProduct { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || agricultureProductService == null)
            {
                return NotFound();
            }

            var agricultureproduct = agricultureProductService.GetAgricultureProduct(id);
            if (agricultureproduct == null)
            {
                return NotFound();
            }
            else
            {
                AgricultureProduct = agricultureproduct;
            }
            return Page();
        }
    }

}
