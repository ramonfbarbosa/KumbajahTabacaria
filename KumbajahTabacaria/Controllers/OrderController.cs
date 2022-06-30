using Kumbajah.Domain.Entities;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using KumbajahTabacaria.Response;
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

        [HttpGet("orders")]
        public ActionResult<List<OrderDTO>> GetAll()
        {
            return Ok(OrderService.GetAll());
        }

        [HttpPost("create")]
        public async Task<ActionResult<CreateOrderResponse<Order>>> CreateOrder([FromBody] OrderDTO request)
        {
            var result = await OrderService.Create(request);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Errors);
        }
    }
}
