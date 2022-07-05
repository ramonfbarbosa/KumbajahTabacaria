using Kumbajah.Infra.Pagination;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using Kumbajah.Services.Services;
using KumbajahTabacaria.Infra.Pagination;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KumbajahTabacaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IProductService ProductService { get; }

        public ProductController(ProductService productService)
        {
            ProductService = productService;
        }

        [HttpGet("/{id}")]
        public ActionResult<List<ProductDTO>> GetById(int id)
        {
            return Ok(ProductService.GetById(id));
        }

        [HttpGet("products")]
        public ActionResult<List<ProductDTO>> GetAll()
        {
            return Ok(ProductService.GetAll());
        }

        [HttpPost("productspaged")]
        public ActionResult<PaginationResponse<ProductDTO>> PagedOrders([FromBody] ListCriteria criteria)
        {
            var userList = ProductService.PagedProducts(criteria);
            return Ok(userList);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync([FromBody] ProductDTO request)
        {
            var result = await ProductService.CreateAsync(request);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Errors);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateAsync([FromBody] ProductDTO request)
        {
            var result = await ProductService.UpdateAsync(request);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Errors);
        }

        [HttpPost("delete/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var isProduct = await ProductService.DeleteAsync(id);
            if (isProduct != null)
            {
                return StatusCode(StatusCodes.Status200OK, "Produto removido!");
            }
            return BadRequest(StatusCodes.Status400BadRequest);
        }
    }
}
