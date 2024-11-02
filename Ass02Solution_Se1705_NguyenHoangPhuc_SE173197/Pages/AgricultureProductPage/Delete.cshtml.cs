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

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.AgricultureProductPage
{
    public class DeleteModel : PageModel
    {
        private readonly IAgricultureProductService agricultureProductService;

        public DeleteModel()
        {
            agricultureProductService = new AgricultureProductService();
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (id == null || agricultureProductService == null)
            {
                return NotFound();
            }
            var agricultureproduct = agricultureProductService.GetAgricultureProduct(id);

            if (agricultureproduct != null)
            {
                agricultureProductService.DeleteAgricultureProduct(agricultureproduct.ProductId);
            }

            return RedirectToPage("./Index");
        }
    }
}
