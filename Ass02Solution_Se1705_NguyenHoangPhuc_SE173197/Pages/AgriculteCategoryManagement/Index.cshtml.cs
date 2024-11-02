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

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.AgriculteCategoryManagement
{
    public class IndexModel : PageModel
    {
        private readonly IAgricultureCategoryService _context;

        public IndexModel(IAgricultureCategoryService context)
        {
            _context = context;
        }

        public IList<AgricultureCategory> AgricultureCategory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context != null)
            {
                AgricultureCategory =  _context.GetAllAgricultureCategories();
            }
        }
    }
}
