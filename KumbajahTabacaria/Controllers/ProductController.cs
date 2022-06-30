using Kumbajah.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace KumbajahTabacaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private ProductService ProductService { get; }

        public ProductController(ProductService productService)
        {
            ProductService = productService;
        }
    }
}
