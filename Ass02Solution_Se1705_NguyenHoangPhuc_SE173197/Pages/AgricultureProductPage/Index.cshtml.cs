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
using Agriculture_Services.DTOs;

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.AgricultureProductPage
{
    public class IndexModel : PageModel
    {
        private readonly IAgricultureProductService _agricultureProductService ;

        public IndexModel(IAgricultureProductService agricultureProductService)
        {
            _agricultureProductService = agricultureProductService;
        }

        public IList<AgricultureProductDTO> AgricultureProduct { get;set; } = default!;

        public Task OnGetAsync()
        {
            if (_agricultureProductService.GetAgricultureProducts() != null)
            {
                AgricultureProduct = _agricultureProductService.GetAgricultureProducts();
            }
            return Task.CompletedTask;
        }
    }
}
