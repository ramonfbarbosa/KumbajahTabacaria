using Kumbajah.Domain.Entities;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Services;
using KumbajahTabacaria.Response;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KumbajahTabacaria.Controllers
{
    [ApiController]
    public class ProductController : Controller
    {
        private ProductService ProductService { get; }

        public ProductController(ProductService productService)
        {
            ProductService = productService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var productId = ProductService.GetById(id).Result;
            return Ok(new Response<ProductDTO>(productId));
        }
    }
}
