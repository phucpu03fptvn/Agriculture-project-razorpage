using Agriculture_BussinessObjects.Models;
using Agriculture_Services;
using Agriculture_Services.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ass02Solution_Se1705_NguyenHoangPhuc_SE173197.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IAgricultureProductService _agricultureProductService;

        public IndexModel(IAgricultureProductService agricultureProductService)
        {
            _agricultureProductService = agricultureProductService;
        }
        public List<AgricultureProductDTO> AgricultureProduct { get; set; }

        public async Task OnGetAsync()
        {
            // Lấy danh sách sản phẩm từ cơ sở dữ liệu hoặc dịch vụ
            AgricultureProduct =  _agricultureProductService.GetAgricultureProducts();
        }
    }
}
