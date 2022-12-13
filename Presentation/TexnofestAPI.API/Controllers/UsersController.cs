using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TexnofestAPI.Application.Features.Commands.AppUsers;
using TexnofestAPI.Persistence.Context;

namespace TexnofestAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly CreateAppUserHandler _createAppUserHandler;
        private readonly TexnofestAPIDbContext _context;
        public UsersController(CreateAppUserHandler createAppUserHandler, TexnofestAPIDbContext context)
        {
            _createAppUserHandler = createAppUserHandler;
            _context = context;
        }
    
        [HttpPost]
        public async Task<IActionResult> Create(CreateAppUserCommandRequest request)
        {
           await _createAppUserHandler.CreateAppUser(request);
           //await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
