using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TexnofestAPI.Application.Features.Commands.Users;
using TexnofestAPI.Application.Features.Queries.Users.GetAllUser;

namespace TexnofestAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserCommandHandler _userCommandHandler;
        private readonly GetAllQueryHandler _getAllQueryHandler;
        public UsersController(UserCommandHandler userCommandHandler,GetAllQueryHandler getAllQueryHandler)
        {
            _userCommandHandler = userCommandHandler;
            _getAllQueryHandler = getAllQueryHandler;   
        }


        [HttpPost("{userCode}/{productName}")]
        public async Task<IActionResult> AddProduct([FromRoute]string userCode,[FromRoute]string productName)
        {
         return Ok(await _userCommandHandler.GetPython(userCode,productName));

        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_getAllQueryHandler.GetAll());
        }
             
    }
}
