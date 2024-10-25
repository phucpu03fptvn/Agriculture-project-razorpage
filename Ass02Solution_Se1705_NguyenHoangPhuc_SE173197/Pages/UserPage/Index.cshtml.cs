using Agriculture_Services.DTOs;
using Agriculture_Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages.UserPage
{
    public class IndexModel : PageModel
    {
        private readonly IAgricultureProductService _agricultureProductService;

        public IndexModel(IAgricultureProductService agricultureProductService)
        {
            _agricultureProductService = agricultureProductService;
        }

        public IList<AgricultureProductDTO> AgricultureProduct { get; set; } = default!;

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
