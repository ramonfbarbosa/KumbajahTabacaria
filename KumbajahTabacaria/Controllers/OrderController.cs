using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Pagination;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using KumbajahTabacaria.Infra.Pagination;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KumbajahTabacaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private IOrderService OrderService { get; }

        public OrderController(IOrderService orderService)
        {
            OrderService = orderService;
        }

        [HttpGet("/{id}")]
        public ActionResult<List<Order>> GetById(int id)
        {
            return Ok(OrderService.GetById(id));
        }

        [HttpGet("orders")]
        public ActionResult<List<OrderDTO>> GetAll()
        {
            return Ok(OrderService.GetAll());
        }

        [HttpPost("orderspaged")]
        public ActionResult<PaginationResponse<UserDTO>> PagedOrders([FromBody] ListCriteria criteria)
        {
            var userList = OrderService.PagedOrders(criteria);
            return Ok(userList);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync([FromBody] OrderDTO request)
        {
            var result = await OrderService.CreateAsync(request);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Errors);
        }
    }
}
