using Kumbajah.Domain.Entities;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using KumbajahTabacaria.Response;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KumbajahTabacaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserService OrderService { get; }

        public UserController(IUserService userService)
        {
            OrderService = userService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<CreateOrderResponse<User>>> Create([FromBody] UserDTO request)
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
