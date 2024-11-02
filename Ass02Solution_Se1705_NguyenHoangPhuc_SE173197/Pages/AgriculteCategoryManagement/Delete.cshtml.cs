﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Agriculture_BussinessObjects.Models;
using Agriculture_Daos.Data;
using Agriculture_Services;

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.AgriculteCategoryManagement
{
    public class DeleteModel : PageModel
    {
        private readonly IAgricultureCategoryService _context;

        public DeleteModel(IAgricultureCategoryService context)
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

            var agriculturecategory =  _context.GetAgricultureCategory(id);

            if (agriculturecategory == null)
            {
                return NotFound();
            }
            else 
            {
                AgricultureCategory = agriculturecategory;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (id == null || _context == null)
            {
                return NotFound();
            }
            var agriculturecategory =  _context.GetAgricultureCategory(id);

            if (agriculturecategory != null)
            {
                _context.DeleteAgricultureCategory(id);
                
            }

            return RedirectToPage("./Index");
        }
    }
}