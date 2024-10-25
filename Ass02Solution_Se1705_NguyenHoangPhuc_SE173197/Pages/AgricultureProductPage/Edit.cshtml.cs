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

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.AgricultureProductPage
{
    public class EditModel : PageModel
    {
        private readonly IAgricultureCategoryService _agricultureCategoryService;
        private readonly IAgricultureProductService _agricultureProductService;

        public EditModel()
        {
            _agricultureProductService = new AgricultureProductService();
            _agricultureCategoryService = new AgricultureCategoryService();
        }

        [BindProperty]
        public AgricultureProduct AgricultureProduct { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null || _agricultureProductService == null)
            {
                return NotFound();
            }

            var agricultureproduct = _agricultureProductService.GetAgricultureProduct(id)  ;
            if (agricultureproduct == null)
            {
                return NotFound();
            }
            AgricultureProduct = agricultureproduct;
           ViewData["CategoryId"] = new SelectList(_agricultureCategoryService.GetAllAgricultureCategories(), "CategoryId", "CategoryName");
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
                 _agricultureProductService.UpdateAgricultureProduct(AgricultureProduct);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgricultureProductExists(AgricultureProduct.ProductId))
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

        private bool AgricultureProductExists(int id)
        {
          bool result = false;
            try
            {
                var agricultureProduct = _agricultureProductService.GetAgricultureProduct(id);
                if (agricultureProduct != null) { return true; }
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
