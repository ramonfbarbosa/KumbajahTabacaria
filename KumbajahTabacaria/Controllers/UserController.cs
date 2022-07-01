using Kumbajah.Domain.Entities;
using Kumbajah.Services.DTO;
using Kumbajah.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KumbajahTabacaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserService UserService { get; }

        public UserController(IUserService userService)
        {
            UserService = userService;
        }

        [HttpGet("id")]
        public ActionResult<List<User>> GetById([FromBody] int id)
        {
            return Ok(UserService.GetById(id));
        }

        [HttpGet]
        [Route("users")]
        public ActionResult<List<User>> GetAll()
        {
            return Ok(UserService.GetAll());
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] UserDTO request)
        {
            var result = await UserService.CreateAsync(request);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Errors);
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] UserDTO request)
        {
            var result = await UserService.UpdateAsync(request);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Errors);
        }
    }
}
