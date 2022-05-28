using Kumbajah.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using KumbajahTabacaria.ViewModels.User;

namespace KumbajahTabacaria.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        [HttpPost]
        [Route("/api/v1/users/create")]
        public async Task<IActionResult> Create([FromBody] CreateUserViewModel userViewModel)
        {
            try
            {
                return Ok();
            }
            catch(DomainException e)
            {
                return BadRequest(e.Message);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
            
        }
    }
}
